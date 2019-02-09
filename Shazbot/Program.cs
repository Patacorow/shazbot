using Shazbot.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shazbot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var a = Utils.GetInputDevices();
            var b = Utils.GetOutputDevices();

            var controller = new ShazbotController();
            controller.PrimaryOutputDevice = b.FirstOrDefault(d => d.Name.Contains("Dell"));
            controller.AdditionalInputDevice = a.FirstOrDefault(d => d.Name.Contains("PnP"));

            controller.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            controller.Stop();
        }
    }
}
