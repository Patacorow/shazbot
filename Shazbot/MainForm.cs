using Shazbot.Audio;
using Shazbot.Banks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Input;

namespace Shazbot
{
    public partial class MainForm : Form
    {
        private readonly ShazbotController _controller;
        private readonly IEnumerable<AudioDeviceInfo> _inputDevices;
        private readonly IEnumerable<AudioDeviceInfo> _outputDevices;

        public MainForm(ShazbotController controller)
        {
            InitializeComponent();
            _controller = controller;

            _inputDevices = Utils.GetInputDevices();
            _outputDevices = Utils.GetOutputDevices();

            AddDevices();

            var p = new PlayerForm(Key.V, new FolderEntry
            {
                Name = "VGS",
                Path = "C:\\code",
                Entries = new Dictionary<Key, Entry>()
                {
                    {Key.F, new FolderEntry
                    {
                        Name = "VGS",
                        Path = "subFolder",
                        Entries = new Dictionary<Key, Entry>()
                        {
                            {Key.A, new FileEntry {Name="Test2", File="shazbot2.wav" } }
                        }
                    } },
                    {Key.A, new FileEntry {Name="Test", File="shazbot.wav" } }
                }
            });
            p.FileSelected += str => MessageBox.Show(str);
            p.Show();

        }

        private void AddDevices()
        {
            foreach (AudioDeviceInfo info in _outputDevices)
            {
                comboPrimaryOutputDevice.Items.Add(info);
            }

            foreach (AudioDeviceInfo info in _inputDevices)
            {
                comboAdditionalInputDevice.Items.Add(info);
            }

            MakeEducatedChoice(comboPrimaryOutputDevice, "virtual cable", "headphones", "speakers");
            MakeEducatedChoice(comboAdditionalInputDevice, "microphone");
        }

        private void MakeEducatedChoice(ComboBox comboBox, params string[] keywords)
        {
            foreach (string keyword in keywords)
            {
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    var item = comboBox.Items[i].ToString().ToLower();
                    if (item.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        comboBox.SelectedIndex = i;
                        return;
                    }
                }
            }

            comboBox.SelectedIndex = 0;
        }
    }
}
