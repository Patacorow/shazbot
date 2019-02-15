using Shazbot.Audio;
using Shazbot.Banks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Shazbot
{
    // TODO: Refactor & doc
    public partial class MainForm : Form
    {
        private readonly ShazbotController _controller;
        private readonly AudioDeviceInfo[] _inputDevices;
        private readonly AudioDeviceInfo[] _outputDevices;

        private bool _repopulatingAdditionalOutputDevices;

        public MainForm(ShazbotController controller)
        {
            InitializeComponent();
            _controller = controller;

            _inputDevices = Utils.GetInputDevices().ToArray();
            _outputDevices = Utils.GetOutputDevices().ToArray();

            _repopulatingAdditionalOutputDevices = false;
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

            PopulateAdditionalOutputDevices();
            MakeEducatedChoice(comboPrimaryOutputDevice, "virtual cable", "headphones", "speakers");
            MakeEducatedChoice(comboAdditionalInputDevice, "microphone");
        }

        private void MakeEducatedChoice(ComboBox comboBox, params string[] keywords)
        {
            foreach (string keyword in keywords)
            {
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    string item = comboBox.Items[i].ToString().ToLower();
                    if (item.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) != -1)
                    {
                        comboBox.SelectedIndex = i;
                        return;
                    }
                }
            }

            comboBox.SelectedIndex = 0;
        }

        private void PopulateAdditionalOutputDevices()
        {
            listBoxAdditionalOutputDevices.BeginUpdate();
            listBoxAdditionalOutputDevices.Items.AddRange(_outputDevices);
            listBoxAdditionalOutputDevices.EndUpdate();
            listBoxAdditionalOutputDevices.Refresh();
        }

        private void RepopulateAdditionalOutputDevices(AudioDeviceInfo lastDevice, AudioDeviceInfo newDevice)
        {
            if (_repopulatingAdditionalOutputDevices) return;
            listBoxAdditionalOutputDevices.BeginUpdate();
            _repopulatingAdditionalOutputDevices = true;

            // Restore the last used primary device
            if (lastDevice != null && !listBoxAdditionalOutputDevices.Items.Contains(lastDevice))
            {
                listBoxAdditionalOutputDevices.Items.Insert(Math.Max(Array.IndexOf(_outputDevices, lastDevice), 0), lastDevice);
            }

            // Remove the new device so it may not be selected
            if (newDevice != null && listBoxAdditionalOutputDevices.Items.Contains(newDevice))
            {
                listBoxAdditionalOutputDevices.Items.Remove(newDevice);
            }


            listBoxAdditionalOutputDevices.EndUpdate();
            listBoxAdditionalOutputDevices.Refresh();
            _repopulatingAdditionalOutputDevices = false;
        }

        private void comboPrimaryOutputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the controller's primary output device
            AudioDeviceInfo lastDevice = _controller.PrimaryOutputDevice;
            AudioDeviceInfo newDevice = comboPrimaryOutputDevice.SelectedIndex != -1
                ? (AudioDeviceInfo)comboPrimaryOutputDevice.Items[comboPrimaryOutputDevice.SelectedIndex]
                : null;
            _controller.PrimaryOutputDevice = newDevice;

            // Remove that device from additional output devices
            _controller.AdditionalOutputDevices.Remove(newDevice);
            RepopulateAdditionalOutputDevices(lastDevice, newDevice);
        }

        private void listBoxAdditionalOutputDevices_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            AudioDeviceInfo item = listBoxAdditionalOutputDevices.Items[e.Index] as AudioDeviceInfo;

            // Add or remove the item from the controller
            if (e.NewValue == CheckState.Checked && !_controller.AdditionalOutputDevices.Contains(item))
            {
                _controller.AdditionalOutputDevices.Add(item);
            }
            else
            {
                _controller.AdditionalOutputDevices.Remove(item);
            }
        }
    }
}
