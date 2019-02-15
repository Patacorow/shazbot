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
            this.audioPlayerTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.audioPlayerTabs.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // audioPlayerTabs
            // 
            this.audioPlayerTabs.Controls.Add(this.tabPage1);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(527, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sounds";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 319);
            this.Controls.Add(this.audioPlayerTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.audioPlayerTabs.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
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
    }
}