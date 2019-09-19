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
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(234, 153);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(70, 32);
            this.scanButton.TabIndex = 1;
            this.scanButton.Text = "Scannen";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(234, 191);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(70, 32);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ipTextBox.Location = new System.Drawing.Point(27, 28);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(486, 20);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.Text = "Beispiel: 128.105.39.11 ";
            this.ipTextBox.TextChanged += new System.EventHandler(this.IpTextBox_TextChanged);
            this.ipTextBox.Enter += new System.EventHandler(this.IpTextBox_Enter);
            this.ipTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ipTextBox_KeyDown);
            this.ipTextBox.Leave += new System.EventHandler(this.IpTextBox_Leave);
            // 
            // pingTextBox
            // 
            this.pingTextBox.Location = new System.Drawing.Point(65, 111);
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
            this.tcpOpenPortsListBox.Size = new System.Drawing.Size(165, 238);
            this.tcpOpenPortsListBox.TabIndex = 4;
            // 
            // portGroupBox
            // 
            this.portGroupBox.Controls.Add(this.tcpLabel);
            this.portGroupBox.Controls.Add(this.tcpOpenPortsListBox);
            this.portGroupBox.Location = new System.Drawing.Point(28, 137);
            this.portGroupBox.Name = "portGroupBox";
            this.portGroupBox.Size = new System.Drawing.Size(200, 300);
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
            this.ipAdressLabel.Location = new System.Drawing.Point(27, 9);
            this.ipAdressLabel.Name = "ipAdressLabel";
            this.ipAdressLabel.Size = new System.Drawing.Size(61, 13);
            this.ipAdressLabel.TabIndex = 6;
            this.ipAdressLabel.Text = "IP Adresse:";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Location = new System.Drawing.Point(28, 114);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(31, 13);
            this.pingLabel.TabIndex = 7;
            this.pingLabel.Text = "Ping:";
            // 
            // logGroupBox
            // 
            this.logGroupBox.Controls.Add(this.currentJobsLabel);
            this.logGroupBox.Controls.Add(this.logListBox);
            this.logGroupBox.Location = new System.Drawing.Point(313, 137);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(200, 300);
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
            this.logListBox.Size = new System.Drawing.Size(165, 238);
            this.logListBox.TabIndex = 4;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 463);
            this.progressBar.Minimum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(537, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            this.progressBar.Value = 1;
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(309, 117);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(59, 13);
            this.jobLabel.TabIndex = 13;
            this.jobLabel.Text = "Job Dauer:";
            // 
            // jobDurationTextBox
            // 
            this.jobDurationTextBox.Location = new System.Drawing.Point(374, 114);
            this.jobDurationTextBox.Name = "jobDurationTextBox";
            this.jobDurationTextBox.ReadOnly = true;
            this.jobDurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.jobDurationTextBox.TabIndex = 12;
            // 
            // startPortLabel
            // 
            this.startPortLabel.AutoSize = true;
            this.startPortLabel.Location = new System.Drawing.Point(27, 57);
            this.startPortLabel.Name = "startPortLabel";
            this.startPortLabel.Size = new System.Drawing.Size(50, 13);
            this.startPortLabel.TabIndex = 15;
            this.startPortLabel.Text = "Startport:";
            // 
            // startPortTextBox
            // 
            this.startPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPortTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.startPortTextBox.Location = new System.Drawing.Point(80, 53);
            this.startPortTextBox.Name = "startPortTextBox";
            this.startPortTextBox.Size = new System.Drawing.Size(81, 20);
            this.startPortTextBox.TabIndex = 14;
            this.startPortTextBox.Text = "Beispiel: 10";
            this.startPortTextBox.TextChanged += new System.EventHandler(this.StartPortTextBox_TextChanged);
            this.startPortTextBox.Enter += new System.EventHandler(this.StartPortTextBox_Enter);
            this.startPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartPortTextBox_KeyPress);
            this.startPortTextBox.Leave += new System.EventHandler(this.StartPortTextBox_Leave);
            // 
            // endPortLabel
            // 
            this.endPortLabel.AutoSize = true;
            this.endPortLabel.Location = new System.Drawing.Point(181, 57);
            this.endPortLabel.Name = "endPortLabel";
            this.endPortLabel.Size = new System.Drawing.Size(47, 13);
            this.endPortLabel.TabIndex = 17;
            this.endPortLabel.Text = "Endport:";
            // 
            // endPortTextBox
            // 
            this.endPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endPortTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.endPortTextBox.Location = new System.Drawing.Point(234, 53);
            this.endPortTextBox.Name = "endPortTextBox";
            this.endPortTextBox.Size = new System.Drawing.Size(81, 20);
            this.endPortTextBox.TabIndex = 16;
            this.endPortTextBox.Text = "Beispiel: 100";
            this.endPortTextBox.TextChanged += new System.EventHandler(this.EndPortTextBox_TextChanged);
            this.endPortTextBox.Enter += new System.EventHandler(this.EndPortTextBox_Enter);
            this.endPortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EndPortTextBox_KeyPress);
            this.endPortTextBox.Leave += new System.EventHandler(this.EndPortTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Timeout:";
            // 
            // msTextBox
            // 
            this.msTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.msTextBox.Location = new System.Drawing.Point(393, 54);
            this.msTextBox.Name = "msTextBox";
            this.msTextBox.Size = new System.Drawing.Size(81, 20);
            this.msTextBox.TabIndex = 18;
            this.msTextBox.Text = "Beispiel: 200";
            this.msTextBox.TextChanged += new System.EventHandler(this.MsTextBox_TextChanged);
            this.msTextBox.Enter += new System.EventHandler(this.MsTextBox_Enter);
            this.msTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MsTextBox_KeyPress);
            this.msTextBox.Leave += new System.EventHandler(this.MsTextBox_Leave);
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(475, 57);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(20, 13);
            this.msLabel.TabIndex = 20;
            this.msLabel.Text = "ms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(535, 483);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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

