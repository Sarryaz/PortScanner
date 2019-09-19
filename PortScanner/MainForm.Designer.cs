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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(PortScanner.MainForm));
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
            this.jobLabel = new System.Windows.Forms.Label();
            this.jobDurationTextBox = new System.Windows.Forms.TextBox();
            this.startPortLabel = new System.Windows.Forms.Label();
            this.startPortTextBox = new System.Windows.Forms.TextBox();
            this.endPortLabel = new System.Windows.Forms.Label();
            this.endPortTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msTextBox = new System.Windows.Forms.TextBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.portGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.SuspendLayout();
            this.printDialog1.UseEXDialog = true;
            this.scanButton.Location = new System.Drawing.Point(273, 177);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(82, 37);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scannen";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            this.stopButton.Location = new System.Drawing.Point(273, 220);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(82, 37);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ipTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ipTextBox.Location = new System.Drawing.Point(31, 32);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(566, 20);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "Beispiel: 128.105.39.11 ";
            this.ipTextBox.TextChanged += new System.EventHandler(this.IpTextBox_TextChanged);
            this.ipTextBox.Enter += new System.EventHandler(this.IpTextBox_Enter);
            this.ipTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ipTextBox_KeyDown);
            this.ipTextBox.Leave += new System.EventHandler(this.IpTextBox_Leave);
            this.pingTextBox.Location = new System.Drawing.Point(76, 128);
            this.pingTextBox.Name = "pingTextBox";
            this.pingTextBox.ReadOnly = true;
            this.pingTextBox.Size = new System.Drawing.Size(116, 23);
            this.pingTextBox.TabIndex = 3;
            this.tcpOpenPortsListBox.FormattingEnabled = true;
            this.tcpOpenPortsListBox.ItemHeight = 15;
            this.tcpOpenPortsListBox.Location = new System.Drawing.Point(20, 37);
            this.tcpOpenPortsListBox.Name = "tcpOpenPortsListBox";
            this.tcpOpenPortsListBox.Size = new System.Drawing.Size(192, 274);
            this.tcpOpenPortsListBox.TabIndex = 4;
            this.portGroupBox.Controls.Add(this.tcpLabel);
            this.portGroupBox.Controls.Add(this.tcpOpenPortsListBox);
            this.portGroupBox.Location = new System.Drawing.Point(33, 158);
            this.portGroupBox.Name = "portGroupBox";
            this.portGroupBox.Size = new System.Drawing.Size(233, 346);
            this.portGroupBox.TabIndex = 5;
            this.portGroupBox.TabStop = false;
            this.portGroupBox.Text = "Offene Ports";
            this.tcpLabel.AutoSize = true;
            this.tcpLabel.Location = new System.Drawing.Point(16, 18);
            this.tcpLabel.Name = "tcpLabel";
            this.tcpLabel.Size = new System.Drawing.Size(60, 15);
            this.tcpLabel.TabIndex = 8;
            this.tcpLabel.Text = "TCP Ports:";
            this.ipAdressLabel.AutoSize = true;
            this.ipAdressLabel.Location = new System.Drawing.Point(31, 10);
            this.ipAdressLabel.Name = "ipAdressLabel";
            this.ipAdressLabel.Size = new System.Drawing.Size(64, 15);
            this.ipAdressLabel.TabIndex = 6;
            this.ipAdressLabel.Text = "IP Adresse:";
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(33, 132);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(34, 15);
            this.pingLabel.TabIndex = 7;
            this.pingLabel.Text = "Ping:";
            this.logGroupBox.Controls.Add(this.currentJobsLabel);
            this.logGroupBox.Controls.Add(this.logListBox);
            this.logGroupBox.Location = new System.Drawing.Point(365, 158);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(233, 346);
            this.logGroupBox.TabIndex = 9;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log:";
            this.currentJobsLabel.AutoSize = true;
            this.currentJobsLabel.Location = new System.Drawing.Point(16, 18);
            this.currentJobsLabel.Name = "currentJobsLabel";
            this.currentJobsLabel.Size = new System.Drawing.Size(79, 15);
            this.currentJobsLabel.TabIndex = 8;
            this.currentJobsLabel.Text = "Aktuelle Jobs:";
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 15;
            this.logListBox.Location = new System.Drawing.Point(20, 37);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(192, 274);
            this.logListBox.TabIndex = 4;
            this.progressBar.Location = new System.Drawing.Point(-1, 534);
            this.progressBar.Minimum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(626, 27);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 1;
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(360, 135);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(62, 15);
            this.jobLabel.TabIndex = 13;
            this.jobLabel.Text = "Job Dauer:";
            this.jobDurationTextBox.Location = new System.Drawing.Point(436, 132);
            this.jobDurationTextBox.Name = "jobDurationTextBox";
            this.jobDurationTextBox.ReadOnly = true;
            this.jobDurationTextBox.Size = new System.Drawing.Size(116, 23);
            this.jobDurationTextBox.TabIndex = 12;
            this.startPortLabel.AutoSize = true;
            this.startPortLabel.Location = new System.Drawing.Point(31, 66);
            this.startPortLabel.Name = "startPortLabel";
            this.startPortLabel.Size = new System.Drawing.Size(56, 15);
            this.startPortLabel.TabIndex = 15;
            this.startPortLabel.Text = "Startport:";
            this.startPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.startPortTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.startPortTextBox.Location = new System.Drawing.Point(93, 61);
            this.startPortTextBox.Name = "startPortTextBox";
            this.startPortTextBox.Size = new System.Drawing.Size(94, 20);
            this.startPortTextBox.TabIndex = 14;
            this.startPortTextBox.Text = "Beispiel: 10";
            this.startPortTextBox.TextChanged += new System.EventHandler(this.StartPortTextBox_TextChanged);
            this.startPortTextBox.Enter += new System.EventHandler(this.StartPortTextBox_Enter);
            this.startPortTextBox.KeyPress +=
                new System.Windows.Forms.KeyPressEventHandler(this.StartPortTextBox_KeyPress);
            this.startPortTextBox.Leave += new System.EventHandler(this.StartPortTextBox_Leave);
            this.endPortLabel.AutoSize = true;
            this.endPortLabel.Location = new System.Drawing.Point(211, 66);
            this.endPortLabel.Name = "endPortLabel";
            this.endPortLabel.Size = new System.Drawing.Size(52, 15);
            this.endPortLabel.TabIndex = 17;
            this.endPortLabel.Text = "Endport:";
            this.endPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.endPortTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.endPortTextBox.Location = new System.Drawing.Point(273, 61);
            this.endPortTextBox.Name = "endPortTextBox";
            this.endPortTextBox.Size = new System.Drawing.Size(94, 20);
            this.endPortTextBox.TabIndex = 16;
            this.endPortTextBox.Text = "Beispiel: 100";
            this.endPortTextBox.TextChanged += new System.EventHandler(this.EndPortTextBox_TextChanged);
            this.endPortTextBox.Enter += new System.EventHandler(this.EndPortTextBox_Enter);
            this.endPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EndPortTextBox_KeyPress);
            this.endPortTextBox.Leave += new System.EventHandler(this.EndPortTextBox_Leave);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Timeout:";
            this.msTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.msTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.msTextBox.Location = new System.Drawing.Point(458, 62);
            this.msTextBox.Name = "msTextBox";
            this.msTextBox.Size = new System.Drawing.Size(94, 20);
            this.msTextBox.TabIndex = 18;
            this.msTextBox.Text = "Beispiel: 200";
            this.msTextBox.TextChanged += new System.EventHandler(this.MsTextBox_TextChanged);
            this.msTextBox.Enter += new System.EventHandler(this.MsTextBox_Enter);
            this.msTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MsTextBox_KeyPress);
            this.msTextBox.Leave += new System.EventHandler(this.MsTextBox_Leave);
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(554, 66);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(23, 15);
            this.msLabel.TabIndex = 20;
            this.msLabel.Text = "ms";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(624, 557);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msTextBox);
            this.Controls.Add(this.endPortLabel);
            this.Controls.Add(this.endPortTextBox);
            this.Controls.Add(this.startPortLabel);
            this.Controls.Add(this.startPortTextBox);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.jobDurationTextBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.pingLabel);
            this.Controls.Add(this.ipAdressLabel);
            this.Controls.Add(this.portGroupBox);
            this.Controls.Add(this.pingTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.stopButton);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.TextBox jobDurationTextBox;
        private System.Windows.Forms.Label startPortLabel;
        private System.Windows.Forms.TextBox startPortTextBox;
        private System.Windows.Forms.Label endPortLabel;
        private System.Windows.Forms.TextBox endPortTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msTextBox;
        private System.Windows.Forms.Label msLabel;
    }
}

