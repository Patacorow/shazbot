namespace Shazbot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.audioPlayerTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTab3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPrimaryOutputDevice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAdditionalOutputDevices = new System.Windows.Forms.CheckedListBox();
            this.checkUseAdditionalInputDevice = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAdditionalInputDevice = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.labelVolumeText = new System.Windows.Forms.Label();
            this.barVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelPlayback = new System.Windows.Forms.Label();
            this.panelTab1 = new System.Windows.Forms.Panel();
            this.btnRebuildSoundbank = new System.Windows.Forms.Button();
            this.btnCreateSoundbank = new System.Windows.Forms.Button();
            this.btnBrowseSoundbank = new System.Windows.Forms.Button();
            this.textBoxSoundbank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelTab2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.comboPlayerScreen = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboPlayerLocation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboPlayerKey = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.audioPlayerTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelTab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barVolume)).BeginInit();
            this.panelTab1.SuspendLayout();
            this.panelTab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // audioPlayerTabs
            // 
            this.audioPlayerTabs.Controls.Add(this.tabPage1);
            this.audioPlayerTabs.Controls.Add(this.tabPage3);
            this.audioPlayerTabs.Controls.Add(this.tabPage2);
            this.audioPlayerTabs.Location = new System.Drawing.Point(0, 0);
            this.audioPlayerTabs.Name = "audioPlayerTabs";
            this.audioPlayerTabs.SelectedIndex = 0;
            this.audioPlayerTabs.Size = new System.Drawing.Size(535, 286);
            this.audioPlayerTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelTab1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sounds";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelTab2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(527, 260);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Player";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelTab3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(527, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input/Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelTab3
            // 
            this.panelTab3.Controls.Add(this.label1);
            this.panelTab3.Controls.Add(this.label2);
            this.panelTab3.Controls.Add(this.comboPrimaryOutputDevice);
            this.panelTab3.Controls.Add(this.label3);
            this.panelTab3.Controls.Add(this.label4);
            this.panelTab3.Controls.Add(this.listBoxAdditionalOutputDevices);
            this.panelTab3.Controls.Add(this.checkUseAdditionalInputDevice);
            this.panelTab3.Controls.Add(this.label5);
            this.panelTab3.Controls.Add(this.comboAdditionalInputDevice);
            this.panelTab3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTab3.Location = new System.Drawing.Point(3, 3);
            this.panelTab3.Name = "panelTab3";
            this.panelTab3.Size = new System.Drawing.Size(521, 254);
            this.panelTab3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Primary output device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "This is where sounds, as well as input from the additional input device, will be " +
    "played to.";
            // 
            // comboPrimaryOutputDevice
            // 
            this.comboPrimaryOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrimaryOutputDevice.FormattingEnabled = true;
            this.comboPrimaryOutputDevice.Location = new System.Drawing.Point(3, 29);
            this.comboPrimaryOutputDevice.MaxLength = 200;
            this.comboPrimaryOutputDevice.Name = "comboPrimaryOutputDevice";
            this.comboPrimaryOutputDevice.Size = new System.Drawing.Size(344, 21);
            this.comboPrimaryOutputDevice.TabIndex = 11;
            this.comboPrimaryOutputDevice.SelectedIndexChanged += new System.EventHandler(this.comboPrimaryOutputDevice_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Additional output device";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sounds (but not the additional input device) will be played to these devices.";
            // 
            // listBoxAdditionalOutputDevices
            // 
            this.listBoxAdditionalOutputDevices.CheckOnClick = true;
            this.listBoxAdditionalOutputDevices.FormattingEnabled = true;
            this.listBoxAdditionalOutputDevices.Location = new System.Drawing.Point(3, 82);
            this.listBoxAdditionalOutputDevices.Name = "listBoxAdditionalOutputDevices";
            this.listBoxAdditionalOutputDevices.Size = new System.Drawing.Size(344, 94);
            this.listBoxAdditionalOutputDevices.TabIndex = 13;
            this.listBoxAdditionalOutputDevices.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listBoxAdditionalOutputDevices_ItemCheck);
            // 
            // checkUseAdditionalInputDevice
            // 
            this.checkUseAdditionalInputDevice.AutoSize = true;
            this.checkUseAdditionalInputDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkUseAdditionalInputDevice.Location = new System.Drawing.Point(3, 179);
            this.checkUseAdditionalInputDevice.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkUseAdditionalInputDevice.Name = "checkUseAdditionalInputDevice";
            this.checkUseAdditionalInputDevice.Size = new System.Drawing.Size(156, 17);
            this.checkUseAdditionalInputDevice.TabIndex = 19;
            this.checkUseAdditionalInputDevice.Text = "Additional input device";
            this.checkUseAdditionalInputDevice.UseVisualStyleBackColor = true;
            this.checkUseAdditionalInputDevice.CheckedChanged += new System.EventHandler(this.checkUseAdditionalInputDevice_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "When used, will play audio from this device to the primary output device.";
            // 
            // comboAdditionalInputDevice
            // 
            this.comboAdditionalInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAdditionalInputDevice.FormattingEnabled = true;
            this.comboAdditionalInputDevice.Location = new System.Drawing.Point(3, 212);
            this.comboAdditionalInputDevice.MaxLength = 200;
            this.comboAdditionalInputDevice.Name = "comboAdditionalInputDevice";
            this.comboAdditionalInputDevice.Size = new System.Drawing.Size(344, 21);
            this.comboAdditionalInputDevice.TabIndex = 17;
            this.comboAdditionalInputDevice.SelectedIndexChanged += new System.EventHandler(this.comboAdditionalInputDevice_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(447, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelVolumeText
            // 
            this.labelVolumeText.AutoSize = true;
            this.labelVolumeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelVolumeText.Location = new System.Drawing.Point(12, 293);
            this.labelVolumeText.Name = "labelVolumeText";
            this.labelVolumeText.Size = new System.Drawing.Size(91, 13);
            this.labelVolumeText.TabIndex = 23;
            this.labelVolumeText.Text = "Sound volume:";
            // 
            // barVolume
            // 
            this.barVolume.AutoSize = false;
            this.barVolume.LargeChange = 10;
            this.barVolume.Location = new System.Drawing.Point(99, 291);
            this.barVolume.Maximum = 100;
            this.barVolume.Name = "barVolume";
            this.barVolume.Size = new System.Drawing.Size(123, 19);
            this.barVolume.TabIndex = 24;
            this.barVolume.TickFrequency = 25;
            this.barVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.barVolume.ValueChanged += new System.EventHandler(this.barVolume_ValueChanged);
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(228, 293);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(22, 13);
            this.labelVolume.TabIndex = 25;
            this.labelVolume.Text = "X%";
            // 
            // labelPlayback
            // 
            this.labelPlayback.AutoSize = true;
            this.labelPlayback.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayback.Location = new System.Drawing.Point(313, 293);
            this.labelPlayback.Name = "labelPlayback";
            this.labelPlayback.Size = new System.Drawing.Size(59, 13);
            this.labelPlayback.TabIndex = 28;
            this.labelPlayback.Text = "Playback";
            this.labelPlayback.Visible = false;
            // 
            // panelTab1
            // 
            this.panelTab1.Controls.Add(this.btnRebuildSoundbank);
            this.panelTab1.Controls.Add(this.btnCreateSoundbank);
            this.panelTab1.Controls.Add(this.btnBrowseSoundbank);
            this.panelTab1.Controls.Add(this.textBoxSoundbank);
            this.panelTab1.Controls.Add(this.label8);
            this.panelTab1.Controls.Add(this.label7);
            this.panelTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab1.Location = new System.Drawing.Point(3, 3);
            this.panelTab1.Name = "panelTab1";
            this.panelTab1.Size = new System.Drawing.Size(521, 254);
            this.panelTab1.TabIndex = 18;
            // 
            // btnRebuildSoundbank
            // 
            this.btnRebuildSoundbank.Location = new System.Drawing.Point(8, 138);
            this.btnRebuildSoundbank.Name = "btnRebuildSoundbank";
            this.btnRebuildSoundbank.Size = new System.Drawing.Size(72, 23);
            this.btnRebuildSoundbank.TabIndex = 23;
            this.btnRebuildSoundbank.Text = "Rebuild";
            this.btnRebuildSoundbank.UseVisualStyleBackColor = true;
            this.btnRebuildSoundbank.Click += new System.EventHandler(this.btnRebuildSoundbank_Click);
            // 
            // btnCreateSoundbank
            // 
            this.btnCreateSoundbank.Location = new System.Drawing.Point(440, 110);
            this.btnCreateSoundbank.Name = "btnCreateSoundbank";
            this.btnCreateSoundbank.Size = new System.Drawing.Size(72, 23);
            this.btnCreateSoundbank.TabIndex = 22;
            this.btnCreateSoundbank.Text = "Create...";
            this.btnCreateSoundbank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateSoundbank.UseVisualStyleBackColor = true;
            this.btnCreateSoundbank.Click += new System.EventHandler(this.btnCreateSoundbank_Click);
            // 
            // btnBrowseSoundbank
            // 
            this.btnBrowseSoundbank.Location = new System.Drawing.Point(362, 110);
            this.btnBrowseSoundbank.Name = "btnBrowseSoundbank";
            this.btnBrowseSoundbank.Size = new System.Drawing.Size(72, 23);
            this.btnBrowseSoundbank.TabIndex = 18;
            this.btnBrowseSoundbank.Text = "Browse...";
            this.btnBrowseSoundbank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseSoundbank.UseVisualStyleBackColor = true;
            this.btnBrowseSoundbank.Click += new System.EventHandler(this.btnBrowseSoundbank_Click);
            // 
            // textBoxSoundbank
            // 
            this.textBoxSoundbank.Location = new System.Drawing.Point(8, 112);
            this.textBoxSoundbank.Name = "textBoxSoundbank";
            this.textBoxSoundbank.Size = new System.Drawing.Size(348, 20);
            this.textBoxSoundbank.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(510, 82);
            this.label8.TabIndex = 20;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Soundbank";
            // 
            // panelTab2
            // 
            this.panelTab2.Controls.Add(this.label13);
            this.panelTab2.Controls.Add(this.comboPlayerScreen);
            this.panelTab2.Controls.Add(this.label14);
            this.panelTab2.Controls.Add(this.label12);
            this.panelTab2.Controls.Add(this.comboPlayerLocation);
            this.panelTab2.Controls.Add(this.label11);
            this.panelTab2.Controls.Add(this.comboPlayerKey);
            this.panelTab2.Controls.Add(this.label9);
            this.panelTab2.Controls.Add(this.label10);
            this.panelTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTab2.Location = new System.Drawing.Point(3, 3);
            this.panelTab2.Name = "panelTab2";
            this.panelTab2.Size = new System.Drawing.Size(521, 254);
            this.panelTab2.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(510, 14);
            this.label13.TabIndex = 31;
            this.label13.Text = "The screen to position the player in.";
            // 
            // comboPlayerScreen
            // 
            this.comboPlayerScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlayerScreen.FormattingEnabled = true;
            this.comboPlayerScreen.Location = new System.Drawing.Point(62, 108);
            this.comboPlayerScreen.Name = "comboPlayerScreen";
            this.comboPlayerScreen.Size = new System.Drawing.Size(124, 21);
            this.comboPlayerScreen.TabIndex = 30;
            this.comboPlayerScreen.SelectedIndexChanged += new System.EventHandler(this.comboPlayerScreen_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(5, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Display:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(5, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(510, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "The location of the player relative to the screen it\'s in.";
            // 
            // comboPlayerLocation
            // 
            this.comboPlayerLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlayerLocation.FormattingEnabled = true;
            this.comboPlayerLocation.Location = new System.Drawing.Point(71, 59);
            this.comboPlayerLocation.Name = "comboPlayerLocation";
            this.comboPlayerLocation.Size = new System.Drawing.Size(100, 21);
            this.comboPlayerLocation.TabIndex = 27;
            this.comboPlayerLocation.SelectedIndexChanged += new System.EventHandler(this.comboPlayerLocation_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(5, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Location:";
            // 
            // comboPlayerKey
            // 
            this.comboPlayerKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlayerKey.FormattingEnabled = true;
            this.comboPlayerKey.Location = new System.Drawing.Point(76, 0);
            this.comboPlayerKey.Name = "comboPlayerKey";
            this.comboPlayerKey.Size = new System.Drawing.Size(162, 21);
            this.comboPlayerKey.TabIndex = 24;
            this.comboPlayerKey.SelectedIndexChanged += new System.EventHandler(this.comboPlayerKey_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(5, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Open key:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(5, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(510, 27);
            this.label10.TabIndex = 25;
            this.label10.Text = "Upon being pressed, this key will cause the Player window to appear. Note that in" +
    "put to all other programs is prevented until a sound is selected or ESC is press" +
    "ed.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 319);
            this.Controls.Add(this.labelPlayback);
            this.Controls.Add(this.labelVolumeText);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.barVolume);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.audioPlayerTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shazbot!";
            this.audioPlayerTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelTab3.ResumeLayout(false);
            this.panelTab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barVolume)).EndInit();
            this.panelTab1.ResumeLayout(false);
            this.panelTab1.PerformLayout();
            this.panelTab2.ResumeLayout(false);
            this.panelTab2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl audioPlayerTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel panelTab3;
        private System.Windows.Forms.CheckBox checkUseAdditionalInputDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAdditionalInputDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox listBoxAdditionalOutputDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPrimaryOutputDevice;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelVolumeText;
        private System.Windows.Forms.TrackBar barVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelPlayback;
        private System.Windows.Forms.Panel panelTab1;
        private System.Windows.Forms.Button btnRebuildSoundbank;
        private System.Windows.Forms.Button btnCreateSoundbank;
        private System.Windows.Forms.Button btnBrowseSoundbank;
        private System.Windows.Forms.TextBox textBoxSoundbank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelTab2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboPlayerScreen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboPlayerLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboPlayerKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}