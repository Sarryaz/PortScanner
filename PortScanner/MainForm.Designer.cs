namespace PortScanner
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.scanButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.pingTextBox = new System.Windows.Forms.TextBox();
            this.tcpOpenPortsListBox = new System.Windows.Forms.ListBox();
            this.portGroupBox = new System.Windows.Forms.GroupBox();
            this.tcpLabel = new System.Windows.Forms.Label();
            this.ipAdressLabel = new System.Windows.Forms.Label();
            this.pingLabel = new System.Windows.Forms.Label();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.currentJobsLabel = new System.Windows.Forms.Label();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.footerLabel = new System.Windows.Forms.Label();
            this.jobLabel = new System.Windows.Forms.Label();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.portGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(217, 162);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(111, 45);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scannen";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(217, 264);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(111, 45);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ipTextBox.Location = new System.Drawing.Point(27, 41);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(457, 20);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "Beispiel: 128.105.39.11 ";
            this.ipTextBox.TextChanged += new System.EventHandler(this.IpTextBox_TextChanged);
            this.ipTextBox.Enter += new System.EventHandler(this.IpTextBox_Enter);
            this.ipTextBox.Leave += new System.EventHandler(this.IpTextBox_Leave);
            // 
            // pingTextBox
            // 
            this.pingTextBox.Location = new System.Drawing.Point(64, 67);
            this.pingTextBox.Name = "pingTextBox";
            this.pingTextBox.ReadOnly = true;
            this.pingTextBox.Size = new System.Drawing.Size(100, 20);
            this.pingTextBox.TabIndex = 3;
            // 
            // tcpOpenPortsListBox
            // 
            this.tcpOpenPortsListBox.FormattingEnabled = true;
            this.tcpOpenPortsListBox.Location = new System.Drawing.Point(17, 32);
            this.tcpOpenPortsListBox.Name = "tcpOpenPortsListBox";
            this.tcpOpenPortsListBox.Size = new System.Drawing.Size(120, 238);
            this.tcpOpenPortsListBox.TabIndex = 4;
            // 
            // portGroupBox
            // 
            this.portGroupBox.Controls.Add(this.tcpLabel);
            this.portGroupBox.Controls.Add(this.tcpOpenPortsListBox);
            this.portGroupBox.Location = new System.Drawing.Point(27, 93);
            this.portGroupBox.Name = "portGroupBox";
            this.portGroupBox.Size = new System.Drawing.Size(167, 291);
            this.portGroupBox.TabIndex = 5;
            this.portGroupBox.TabStop = false;
            this.portGroupBox.Text = "Offene Ports";
            // 
            // tcpLabel
            // 
            this.tcpLabel.AutoSize = true;
            this.tcpLabel.Location = new System.Drawing.Point(14, 16);
            this.tcpLabel.Name = "tcpLabel";
            this.tcpLabel.Size = new System.Drawing.Size(58, 13);
            this.tcpLabel.TabIndex = 8;
            this.tcpLabel.Text = "TCP Ports:";
            // 
            // ipAdressLabel
            // 
            this.ipAdressLabel.AutoSize = true;
            this.ipAdressLabel.Location = new System.Drawing.Point(27, 22);
            this.ipAdressLabel.Name = "ipAdressLabel";
            this.ipAdressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAdressLabel.TabIndex = 6;
            this.ipAdressLabel.Text = "IP Adresse:";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(27, 70);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(31, 13);
            this.pingLabel.TabIndex = 7;
            this.pingLabel.Text = "Ping:";
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.currentJobsLabel);
            this.logGroupBox.Controls.Add(this.logListBox);
            this.logGroupBox.Location = new System.Drawing.Point(347, 93);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(167, 291);
            this.logGroupBox.TabIndex = 9;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log:";
            // 
            // currentJobsLabel
            // 
            this.currentJobsLabel.AutoSize = true;
            this.currentJobsLabel.Location = new System.Drawing.Point(14, 16);
            this.currentJobsLabel.Name = "currentJobsLabel";
            this.currentJobsLabel.Size = new System.Drawing.Size(73, 13);
            this.currentJobsLabel.TabIndex = 8;
            this.currentJobsLabel.Text = "Aktuelle Jobs:";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(17, 32);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(120, 238);
            this.logListBox.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(217, 225);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(111, 23);
            this.progressBar.TabIndex = 10;
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerLabel.Location = new System.Drawing.Point(475, 396);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(61, 7);
            this.footerLabel.TabIndex = 11;
            this.footerLabel.Text = "-by Tim Semisch-";
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(319, 70);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(59, 13);
            this.jobLabel.TabIndex = 13;
            this.jobLabel.Text = "Job Dauer:";
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(384, 67);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.ReadOnly = true;
            this.jobTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobTextBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(535, 403);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.footerLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.pingLabel);
            this.Controls.Add(this.ipAdressLabel);
            this.Controls.Add(this.portGroupBox);
            this.Controls.Add(this.pingTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.stopButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PortScanner";
            this.portGroupBox.ResumeLayout(false);
            this.portGroupBox.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox pingTextBox;
        private System.Windows.Forms.ListBox tcpOpenPortsListBox;
        private System.Windows.Forms.GroupBox portGroupBox;
        private System.Windows.Forms.Label ipAdressLabel;
        private System.Windows.Forms.Label pingLabel;
        private System.Windows.Forms.Label tcpLabel;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.Label currentJobsLabel;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.TextBox jobTextBox;
    }
}

