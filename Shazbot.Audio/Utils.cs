using NAudio.Wave;
using System.Collections.Generic;
using System.Linq;

namespace Shazbot.Audio
{
    public static class Utils
    {
        public static IEnumerable<AudioDeviceInfo> GetInputDevices()
        {
            return Enumerable.Range(0, WaveIn.DeviceCount).Select(id =>
                {
                    WaveInCapabilities cap = WaveIn.GetCapabilities(id);
                    return new AudioDeviceInfo(cap.ProductName, id);
                });
        }

        public static IEnumerable<AudioDeviceInfo> GetOutputDevices()
        {
            return Enumerable.Range(0, WaveOut.DeviceCount).Select(id =>
            {
                WaveOutCapabilities cap = WaveOut.GetCapabilities(id);
                return new AudioDeviceInfo(cap.ProductName, id);
            });
        }
    }
}
