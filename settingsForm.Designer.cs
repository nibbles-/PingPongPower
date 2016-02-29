namespace PingPongPower
{
    partial class settingsForm
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
            this.smtpHostLabel = new System.Windows.Forms.Label();
            this.mailDestinationLabel = new System.Windows.Forms.Label();
            this.smtpHost = new System.Windows.Forms.TextBox();
            this.mailDestination = new System.Windows.Forms.TextBox();
            this.saveSettings = new System.Windows.Forms.Button();
            this.smtpPortLabel = new System.Windows.Forms.Label();
            this.smtpPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // smtpHostLabel
            // 
            this.smtpHostLabel.AutoSize = true;
            this.smtpHostLabel.Location = new System.Drawing.Point(13, 13);
            this.smtpHostLabel.Name = "smtpHostLabel";
            this.smtpHostLabel.Size = new System.Drawing.Size(68, 13);
            this.smtpHostLabel.TabIndex = 0;
            this.smtpHostLabel.Text = "SMTP Host: ";
            // 
            // mailDestinationLabel
            // 
            this.mailDestinationLabel.AutoSize = true;
            this.mailDestinationLabel.Location = new System.Drawing.Point(13, 59);
            this.mailDestinationLabel.Name = "mailDestinationLabel";
            this.mailDestinationLabel.Size = new System.Drawing.Size(78, 13);
            this.mailDestinationLabel.TabIndex = 1;
            this.mailDestinationLabel.Text = "Email address: ";
            // 
            // smtpHost
            // 
            this.smtpHost.Location = new System.Drawing.Point(87, 10);
            this.smtpHost.Name = "smtpHost";
            this.smtpHost.Size = new System.Drawing.Size(100, 20);
            this.smtpHost.TabIndex = 2;
            // 
            // mailDestination
            // 
            this.mailDestination.Location = new System.Drawing.Point(87, 56);
            this.mailDestination.Name = "mailDestination";
            this.mailDestination.Size = new System.Drawing.Size(100, 20);
            this.mailDestination.TabIndex = 3;
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(193, 10);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(56, 66);
            this.saveSettings.TabIndex = 4;
            this.saveSettings.Text = "SAVE";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // smtpPortLabel
            // 
            this.smtpPortLabel.AutoSize = true;
            this.smtpPortLabel.Location = new System.Drawing.Point(13, 37);
            this.smtpPortLabel.Name = "smtpPortLabel";
            this.smtpPortLabel.Size = new System.Drawing.Size(65, 13);
            this.smtpPortLabel.TabIndex = 5;
            this.smtpPortLabel.Text = "SMTP Port: ";
            // 
            // smtpPort
            // 
            this.smtpPort.Location = new System.Drawing.Point(87, 34);
            this.smtpPort.Name = "smtpPort";
            this.smtpPort.Size = new System.Drawing.Size(100, 20);
            this.smtpPort.TabIndex = 6;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 87);
            this.Controls.Add(this.smtpPort);
            this.Controls.Add(this.smtpPortLabel);
            this.Controls.Add(this.saveSettings);
            this.Controls.Add(this.mailDestination);
            this.Controls.Add(this.smtpHost);
            this.Controls.Add(this.mailDestinationLabel);
            this.Controls.Add(this.smtpHostLabel);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Activated += new System.EventHandler(this.settingsForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label smtpHostLabel;
        private System.Windows.Forms.Label mailDestinationLabel;
        private System.Windows.Forms.TextBox smtpHost;
        private System.Windows.Forms.TextBox mailDestination;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Label smtpPortLabel;
        private System.Windows.Forms.TextBox smtpPort;
    }
}