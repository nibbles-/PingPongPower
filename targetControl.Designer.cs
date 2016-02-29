namespace PingPongPower
{
    partial class targetControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.targetLabel = new System.Windows.Forms.Label();
            this.targetBox = new System.Windows.Forms.TextBox();
            this.targetStatus = new System.Windows.Forms.ProgressBar();
            this.targetLastseen = new System.Windows.Forms.Label();
            this.targetLastTimeStamp = new System.Windows.Forms.Label();
            this.mailAlert = new System.Windows.Forms.CheckBox();
            this.loggingActive = new System.Windows.Forms.CheckBox();
            this.startStopButton = new System.Windows.Forms.Button();
            this.deleteTarget = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.timeoutLabel = new System.Windows.Forms.Label();
            this.intervallLabel = new System.Windows.Forms.Label();
            this.pingTimeout = new System.Windows.Forms.TextBox();
            this.pingIntervall = new System.Windows.Forms.TextBox();
            this.pingUninterruptible = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(4, 6);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(158, 13);
            this.targetLabel.TabIndex = 0;
            this.targetLabel.Text = "Target hostname or IP address: ";
            // 
            // targetBox
            // 
            this.targetBox.Location = new System.Drawing.Point(168, 3);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(244, 20);
            this.targetBox.TabIndex = 1;
            // 
            // targetStatus
            // 
            this.targetStatus.BackColor = System.Drawing.SystemColors.Control;
            this.targetStatus.Location = new System.Drawing.Point(7, 29);
            this.targetStatus.MarqueeAnimationSpeed = 0;
            this.targetStatus.Name = "targetStatus";
            this.targetStatus.Size = new System.Drawing.Size(405, 13);
            this.targetStatus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.targetStatus.TabIndex = 2;
            // 
            // targetLastseen
            // 
            this.targetLastseen.AutoSize = true;
            this.targetLastseen.Location = new System.Drawing.Point(4, 45);
            this.targetLastseen.Name = "targetLastseen";
            this.targetLastseen.Size = new System.Drawing.Size(61, 13);
            this.targetLastseen.TabIndex = 3;
            this.targetLastseen.Text = "Last Seen: ";
            // 
            // targetLastTimeStamp
            // 
            this.targetLastTimeStamp.AutoSize = true;
            this.targetLastTimeStamp.Location = new System.Drawing.Point(4, 58);
            this.targetLastTimeStamp.Name = "targetLastTimeStamp";
            this.targetLastTimeStamp.Size = new System.Drawing.Size(61, 13);
            this.targetLastTimeStamp.TabIndex = 4;
            this.targetLastTimeStamp.Text = "0000-00-00";
            // 
            // mailAlert
            // 
            this.mailAlert.AutoSize = true;
            this.mailAlert.Location = new System.Drawing.Point(129, 49);
            this.mailAlert.Name = "mailAlert";
            this.mailAlert.Size = new System.Drawing.Size(101, 17);
            this.mailAlert.TabIndex = 5;
            this.mailAlert.Text = "Send Mail alerts";
            this.mailAlert.UseVisualStyleBackColor = true;
            // 
            // loggingActive
            // 
            this.loggingActive.AutoSize = true;
            this.loggingActive.Location = new System.Drawing.Point(129, 71);
            this.loggingActive.Name = "loggingActive";
            this.loggingActive.Size = new System.Drawing.Size(64, 17);
            this.loggingActive.TabIndex = 6;
            this.loggingActive.Text = "Logging";
            this.loggingActive.UseVisualStyleBackColor = true;
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(236, 45);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(55, 23);
            this.startStopButton.TabIndex = 7;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // deleteTarget
            // 
            this.deleteTarget.Location = new System.Drawing.Point(236, 71);
            this.deleteTarget.Name = "deleteTarget";
            this.deleteTarget.Size = new System.Drawing.Size(55, 23);
            this.deleteTarget.TabIndex = 8;
            this.deleteTarget.Text = "Delete";
            this.deleteTarget.UseVisualStyleBackColor = true;
            this.deleteTarget.Click += new System.EventHandler(this.deleteTarget_Click);
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WorkerProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerRunWorkerCompleted);
            // 
            // timeoutLabel
            // 
            this.timeoutLabel.AutoSize = true;
            this.timeoutLabel.Location = new System.Drawing.Point(307, 48);
            this.timeoutLabel.Name = "timeoutLabel";
            this.timeoutLabel.Size = new System.Drawing.Size(67, 13);
            this.timeoutLabel.TabIndex = 9;
            this.timeoutLabel.Text = "Timeout (ms)";
            // 
            // intervallLabel
            // 
            this.intervallLabel.AutoSize = true;
            this.intervallLabel.Location = new System.Drawing.Point(307, 76);
            this.intervallLabel.Name = "intervallLabel";
            this.intervallLabel.Size = new System.Drawing.Size(58, 13);
            this.intervallLabel.TabIndex = 10;
            this.intervallLabel.Text = "Intervall (s)";
            // 
            // pingTimeout
            // 
            this.pingTimeout.Location = new System.Drawing.Point(371, 45);
            this.pingTimeout.Name = "pingTimeout";
            this.pingTimeout.Size = new System.Drawing.Size(41, 20);
            this.pingTimeout.TabIndex = 11;
            this.pingTimeout.Text = "200";
            // 
            // pingIntervall
            // 
            this.pingIntervall.Location = new System.Drawing.Point(371, 71);
            this.pingIntervall.Name = "pingIntervall";
            this.pingIntervall.Size = new System.Drawing.Size(41, 20);
            this.pingIntervall.TabIndex = 12;
            this.pingIntervall.Text = "3";
            // 
            // pingUninterruptible
            // 
            this.pingUninterruptible.AutoSize = true;
            this.pingUninterruptible.Location = new System.Drawing.Point(7, 72);
            this.pingUninterruptible.Name = "pingUninterruptible";
            this.pingUninterruptible.Size = new System.Drawing.Size(94, 17);
            this.pingUninterruptible.TabIndex = 13;
            this.pingUninterruptible.Text = "Uninterruptible";
            this.pingUninterruptible.UseVisualStyleBackColor = true;
            // 
            // targetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pingUninterruptible);
            this.Controls.Add(this.pingIntervall);
            this.Controls.Add(this.pingTimeout);
            this.Controls.Add(this.intervallLabel);
            this.Controls.Add(this.timeoutLabel);
            this.Controls.Add(this.deleteTarget);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.loggingActive);
            this.Controls.Add(this.mailAlert);
            this.Controls.Add(this.targetLastTimeStamp);
            this.Controls.Add(this.targetLastseen);
            this.Controls.Add(this.targetStatus);
            this.Controls.Add(this.targetBox);
            this.Controls.Add(this.targetLabel);
            this.Name = "targetControl";
            this.Size = new System.Drawing.Size(430, 100);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.CheckBox pingUninterruptible;

        #endregion

        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox targetBox;
        private System.Windows.Forms.ProgressBar targetStatus;
        private System.Windows.Forms.Label targetLastseen;
        private System.Windows.Forms.Label targetLastTimeStamp;
        private System.Windows.Forms.CheckBox mailAlert;
        private System.Windows.Forms.CheckBox loggingActive;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button deleteTarget;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.Label intervallLabel;
        private System.Windows.Forms.TextBox pingTimeout;
        private System.Windows.Forms.TextBox pingIntervall;

    }
}
