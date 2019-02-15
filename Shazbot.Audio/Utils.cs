using NAudio.CoreAudioApi;
using NAudio.Wave;
using System.Collections.Generic;
using System.Linq;

namespace Shazbot.Audio
{
    public static class Utils
    {
        public static IEnumerable<AudioDeviceInfo> GetInputDevices()
        {
            var fullNames = GetFullDeviceNames(DataFlow.Capture);
            return Enumerable.Range(0, WaveIn.DeviceCount).Select(id =>
                new AudioDeviceInfo(fullNames.FirstOrDefault(n => n.StartsWith(WaveIn.GetCapabilities(id).ProductName)), id));
        }

        public static IEnumerable<AudioDeviceInfo> GetOutputDevices()
        {
            var fullNames = GetFullDeviceNames(DataFlow.Render);
            return Enumerable.Range(0, WaveOut.DeviceCount).Select(id =>
                new AudioDeviceInfo(fullNames.FirstOrDefault(n => n.StartsWith(WaveOut.GetCapabilities(id).ProductName)), id));
        }

        private static IEnumerable<string> GetFullDeviceNames(DataFlow flow)
        {
            return new MMDeviceEnumerator()
                .EnumerateAudioEndPoints(flow, DeviceState.Active)
                .Select((device, id) => device.FriendlyName);
        }
    }
}
