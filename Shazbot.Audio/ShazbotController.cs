using NAudio.Wave;
using System.Collections.Generic;

namespace Shazbot.Audio
{
    public class ShazbotController
    {
        private const int SAMPLING_RATE = 44100;
        private const float DEFAULT_VOLUME = 1.0f;

        public AudioDeviceInfo AdditionalInputDevice;
        public AudioDeviceInfo PrimaryOutputDevice;
        public IList<AudioDeviceInfo> AdditionalOutputDevices;
        public float Volume;

        private WaveInEvent _cachedInputDevice;
        private WaveOut _cachedOutputDevice;
        private IList<WaveOut> _cachedAdditionalOutputDevices;
        private BufferedWaveProvider _cachedInputProvider;
        private bool _isPlaying;

        public ShazbotController()
        {
            AdditionalOutputDevices = new List<AudioDeviceInfo>();
            Volume = DEFAULT_VOLUME;
            _cachedAdditionalOutputDevices = new List<WaveOut>();

            _isPlaying = false;
        }

        public void Start()
        {
            if (AdditionalInputDevice != null)
            {
                var waveIn = new WaveInEvent
                {
                    BufferMilliseconds = 25,
                    DeviceNumber = AdditionalInputDevice.Id,
                    WaveFormat = new WaveFormat(SAMPLING_RATE, 1)
                };

                var waveProvider = new BufferedWaveProvider(waveIn.WaveFormat);
                _cachedInputProvider = waveProvider;
                HookInputDevice();

                waveIn.DataAvailable += WaveIn_DataAvailable;
                waveIn.StartRecording();

                _cachedInputDevice = waveIn;
            }
        }

        public void Stop()
        {
            if (_cachedInputDevice != null)
            {
                _cachedInputDevice.StopRecording();
                _cachedInputDevice.DataAvailable -= WaveIn_DataAvailable;
                _cachedInputProvider.ClearBuffer();

                _cachedInputDevice = null;
                _cachedInputProvider = null;
            }

            UnhookOutputDevices();
        }

        public void PlaySound(string filePath)
        {
            UnhookOutputDevices();
            _isPlaying = true;

            _cachedOutputDevice = HookFilePlayback(PrimaryOutputDevice.Id, filePath);
            _cachedOutputDevice.PlaybackStopped += _cachedOutputDevice_PlaybackStopped;
            foreach (AudioDeviceInfo info in AdditionalOutputDevices)
            {
                _cachedAdditionalOutputDevices.Add(HookFilePlayback(info.Id, filePath));
            }
        }

        public void StopPlayback()
        {
            UnhookOutputDevices();
            _isPlaying = false;
            if (_cachedInputDevice != null) HookInputDevice();
        }

        private void _cachedOutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            _cachedOutputDevice.PlaybackStopped -= _cachedOutputDevice_PlaybackStopped;
            StopPlayback();
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (_isPlaying || _cachedInputProvider == null) return;

            // Pipe original input to output
            _cachedInputProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        private void HookInputDevice()
        {
            _cachedOutputDevice = HookOutputDevice(PrimaryOutputDevice.Id, _cachedInputProvider);
        }

        private WaveOut HookOutputDevice(int deviceId, IWaveProvider provider)
        {
            var waveOut = new WaveOut { DeviceNumber = deviceId, DesiredLatency = 100 };
            waveOut.Init(provider);
            waveOut.Play();
            return waveOut;
        }

        private WaveOut HookFilePlayback(int deviceId, string filePath)
        {
            WaveStream reader = new AudioFileReader(filePath) { Volume = Volume };
            return HookOutputDevice(deviceId, reader);
        }

        private void UnhookOutputDevices()
        {
            UnhookOutputDevice(_cachedOutputDevice);
            _cachedOutputDevice = null;
            foreach (WaveOut waveOut in _cachedAdditionalOutputDevices)
            {
                UnhookOutputDevice(waveOut);
            }
            _cachedAdditionalOutputDevices.Clear();
        }

        private void UnhookOutputDevice(WaveOut device)
        {
            if (device == null) return;

            if (device.PlaybackState == PlaybackState.Playing)
            {
                device.Stop();
            }
            device.Dispose();
        }
    }
}
