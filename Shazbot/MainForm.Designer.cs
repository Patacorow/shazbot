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
            this.btnCreateSoundbank = new System.Windows.Forms.Button();
            this.btnBrowseSoundbank = new System.Windows.Forms.Button();
            this.textBoxSoundbank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPrimaryOutputDevice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAdditionalOutputDevices = new System.Windows.Forms.CheckedListBox();
            this.checkUseAdditionalInputDevice = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboAdditionalInputDevice = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkAutoKeyHold = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.comboPlayerKey = new System.Windows.Forms.ComboBox();
            this.audioPlayerTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // audioPlayerTabs
            // 
            this.audioPlayerTabs.Controls.Add(this.tabPage1);
            this.audioPlayerTabs.Controls.Add(this.tabPage4);
            this.audioPlayerTabs.Controls.Add(this.tabPage2);
            this.audioPlayerTabs.Controls.Add(this.tabPage3);
            this.audioPlayerTabs.Location = new System.Drawing.Point(0, 0);
            this.audioPlayerTabs.Name = "audioPlayerTabs";
            this.audioPlayerTabs.SelectedIndex = 0;
            this.audioPlayerTabs.Size = new System.Drawing.Size(535, 286);
            this.audioPlayerTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreateSoundbank);
            this.tabPage1.Controls.Add(this.btnBrowseSoundbank);
            this.tabPage1.Controls.Add(this.textBoxSoundbank);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sounds";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreateSoundbank
            // 
            this.btnCreateSoundbank.Location = new System.Drawing.Point(443, 97);
            this.btnCreateSoundbank.Name = "btnCreateSoundbank";
            this.btnCreateSoundbank.Size = new System.Drawing.Size(72, 23);
            this.btnCreateSoundbank.TabIndex = 16;
            this.btnCreateSoundbank.Text = "Create...";
            this.btnCreateSoundbank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateSoundbank.UseVisualStyleBackColor = true;
            this.btnCreateSoundbank.Click += new System.EventHandler(this.btnCreateSoundbank_Click);
            // 
            // btnBrowseSoundbank
            // 
            this.btnBrowseSoundbank.Location = new System.Drawing.Point(365, 97);
            this.btnBrowseSoundbank.Name = "btnBrowseSoundbank";
            this.btnBrowseSoundbank.Size = new System.Drawing.Size(72, 23);
            this.btnBrowseSoundbank.TabIndex = 1;
            this.btnBrowseSoundbank.Text = "Browse...";
            this.btnBrowseSoundbank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseSoundbank.UseVisualStyleBackColor = true;
            this.btnBrowseSoundbank.Click += new System.EventHandler(this.btnBrowseSoundbank_Click);
            // 
            // textBoxSoundbank
            // 
            this.textBoxSoundbank.Location = new System.Drawing.Point(11, 99);
            this.textBoxSoundbank.Name = "textBoxSoundbank";
            this.textBoxSoundbank.Size = new System.Drawing.Size(348, 20);
            this.textBoxSoundbank.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(510, 80);
            this.label8.TabIndex = 14;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Soundbank";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(527, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input/Output";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.comboPrimaryOutputDevice);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.listBoxAdditionalOutputDevices);
            this.flowLayoutPanel1.Controls.Add(this.checkUseAdditionalInputDevice);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.comboAdditionalInputDevice);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(521, 254);
            this.flowLayoutPanel1.TabIndex = 11;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(527, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.checkAutoKeyHold);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.comboBox1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(521, 254);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // checkAutoKeyHold
            // 
            this.checkAutoKeyHold.AutoSize = true;
            this.checkAutoKeyHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkAutoKeyHold.Location = new System.Drawing.Point(3, 0);
            this.checkAutoKeyHold.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkAutoKeyHold.Name = "checkAutoKeyHold";
            this.checkAutoKeyHold.Size = new System.Drawing.Size(104, 17);
            this.checkAutoKeyHold.TabIndex = 22;
            this.checkAutoKeyHold.Text = "Auto key hold";
            this.checkAutoKeyHold.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "If enabled, this key will be held as long as a sound is playing.";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 33);
            this.comboBox1.MaxLength = 200;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 21);
            this.comboBox1.TabIndex = 20;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboPlayerKey);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(527, 260);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Player";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Player open key:";
            // 
            // comboPlayerKey
            // 
            this.comboPlayerKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlayerKey.FormattingEnabled = true;
            this.comboPlayerKey.Location = new System.Drawing.Point(114, 0);
            this.comboPlayerKey.Name = "comboPlayerKey";
            this.comboPlayerKey.Size = new System.Drawing.Size(59, 21);
            this.comboPlayerKey.TabIndex = 15;
            this.comboPlayerKey.SelectedIndexChanged += new System.EventHandler(this.comboPlayerKey_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 319);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.audioPlayerTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.audioPlayerTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl audioPlayerTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkUseAdditionalInputDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboAdditionalInputDevice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox listBoxAdditionalOutputDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPrimaryOutputDevice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkAutoKeyHold;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCreateSoundbank;
        private System.Windows.Forms.Button btnBrowseSoundbank;
        private System.Windows.Forms.TextBox textBoxSoundbank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboPlayerKey;
    }
}