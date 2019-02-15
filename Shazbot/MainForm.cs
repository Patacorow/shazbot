using Newtonsoft.Json;
using Shazbot.Audio;
using Shazbot.Banks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Shazbot
{
    // TODO: Refactor & doc
    public partial class MainForm : Form
    {
        private const string BTN_START = "Start";
        private const string BTN_STOP = "Stop";

        private readonly ShazbotController _controller;
        private readonly AudioDeviceInfo[] _inputDevices;
        private readonly AudioDeviceInfo[] _outputDevices;

        private bool _repopulatingAdditionalOutputDevices;
        private bool _started;
        private PlayerForm _player;

        public MainForm(ShazbotController controller)
        {
            InitializeComponent();
            _controller = controller;

            _inputDevices = Utils.GetInputDevices().ToArray();
            _outputDevices = Utils.GetOutputDevices().ToArray();

            _repopulatingAdditionalOutputDevices = false;
            AddDevices();

            _started = false;
            btnStart.Text = BTN_START;
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
            checkUseAdditionalInputDevice.Checked = true;
            MakeEducatedChoice(comboPrimaryOutputDevice, "virtual cable", "headphones", "speakers");
            MakeEducatedChoice(comboAdditionalInputDevice, "microphone");
            checkUseAdditionalInputDevice.Checked = false;
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

        private void checkUseAdditionalInputDevice_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkUseAdditionalInputDevice.Checked;
            if (check)
            {
                _controller.AdditionalInputDevice = comboAdditionalInputDevice.SelectedItem as AudioDeviceInfo;
            }
            else
            {
                _controller.AdditionalInputDevice = null;
            }
            comboAdditionalInputDevice.Enabled = check;
        }

        private void comboAdditionalInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.AdditionalInputDevice = comboAdditionalInputDevice.SelectedItem as AudioDeviceInfo;
        }

        private void btnBrowseSoundbank_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog
            {
                Filter = SoundbankSerializer.FILTER,
                Title = "Select Soundbank"
            };

            if (diag.ShowDialog() == DialogResult.OK)
            {
                textBoxSoundbank.Text = diag.FileName;
            }
        }

        private void btnCreateSoundbank_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDiag = new FolderBrowserDialog
            {
                Description = "Select the root folder of your Soundbank.\nIt should contain sound files and sub-folders.",
            };

            if (fDiag.ShowDialog() != DialogResult.OK) return;
            string path = fDiag.SelectedPath;
            if (!Directory.Exists(path)) return;

            // Get name
            SoundbankNameDialog nDiag = new SoundbankNameDialog(Path.GetFileName(path))
            {
                Owner = this
            };
            if (nDiag.ShowDialog() != DialogResult.OK) return;

            // Get path to save in
            string fileName = Path.Combine(path, nDiag.SoundbankName.ToLower() + ".json");

            // Generate soundbank
            try
            {
                FolderEntry bank = SoundbankGenerator.CreateSoundbank(path, nDiag.SoundbankName);

                // Save it
                string json = SoundbankSerializer.Serialize(bank);
                File.WriteAllText(fileName, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot create Soundbank!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBoxSoundbank.Text = fileName;
            MessageBox.Show("Your Soundbank has been created and saved to:\n" + Path.Combine(path, fileName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start
            if (!_started)
            {
                if (!VerifyInput(out string[] errors, out FolderEntry soundbank))
                {
                    MessageBox.Show("Can't start, as there is one or more errors:\n" + string.Join(Environment.NewLine, errors),
                        "Can't Start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _started = true;
                _player = new PlayerForm(System.Windows.Input.Key.V, soundbank, Path.GetDirectoryName(textBoxSoundbank.Text));
                _player.FileSelected += _player_FileSelected;
                _player.Show();
                _controller.Start();
                audioPlayerTabs.Enabled = false;

                btnStart.Text = BTN_STOP;
            }
            else
            {
                _started = false;
                _controller.Stop();
                _player.Close();
                audioPlayerTabs.Enabled = true;

                btnStart.Text = BTN_START;
            }
        }

        private void _player_FileSelected(string file)
        {
            if (!_started) return;
            _controller.PlaySound(file);
        }

        private bool VerifyInput(out string[] errors, out FolderEntry soundbank)
        {
            bool success = true;
            soundbank = null;
            List<string> errorList = new List<string>();

            // For saving time...
            Action<string> addError = new Action<string>(error =>
            {
                success = false;
                errorList.Add(error);
            });

            if (!File.Exists(textBoxSoundbank.Text))
            {
                addError("The Soundbank file was not found.");
            }
            if (_controller.PrimaryOutputDevice == null)
            {
                addError("A primary output device was not set.");
            }

            // Deserialize soundbank
            if (success)
            {
                try
                {
                    soundbank = SoundbankSerializer.Deserialize(File.ReadAllText(textBoxSoundbank.Text));
                }
                catch (Exception ex)
                {
                    throw;
                    //addError("Cannot read soundbank file: " + ex.Message);
                }
            }


            errors = errorList.ToArray();
            return success;
        }
    }
}
