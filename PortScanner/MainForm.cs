﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    public partial class MainForm : Form
    {
        bool ipTextHasChanged;
        bool startPortHasChanged;
        bool endPortHasChanged;
        bool timeoutHasChanged;

        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = ipAdressLabel;
        }

        public int? ParseIntOrNull(string input)
        {
            if (Int32.TryParse(input, out int output)) return output;
            return null;
        }

        public string IPAdress
        {
            get => ipTextBox.Text;
            set => ipTextBox.Text = value;
        }
        public string Ping
        {
            get => pingTextBox.Text;
            set => pingTextBox.Text = value;
        }
        public string JobDuration
        {
            get => jobDurationTextBox.Text;
            set => jobDurationTextBox.Text = value;
        }
        public int StartPort
        {
            get => ParseIntOrNull(startPortTextBox.Text) ?? 10;
            set => startPortTextBox.Text = value.ToString();
        }
        public int EndPort
        {
            get => ParseIntOrNull(endPortTextBox.Text) ?? 100;
            set => endPortTextBox.Text = value.ToString();
        }
        public int Timeout
        {
            get => ParseIntOrNull(msTextBox.Text) ?? 200;
            set => msTextBox.Text = value.ToString();
        }
        public bool ErrorOccured
        { get; set; }

        public bool StoppedByUser
        { get; set; }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            StoppedByUser = default;
            Core.InputHandler(this);
            if (!ErrorOccured)
            {
                SetProgressbarValues();
                Core.Scan(this);
                Core.PingPong(this);
                CleanResultUI();
            }
            ErrorOccured = false;
        }

        public void CleanResultUI()
        {
            Invoke((MethodInvoker)(() =>
            {
                tcpOpenPortsListBox.Items.Clear();
                logListBox.Items.Clear();
                jobDurationTextBox.Text = "";
                pingTextBox.Text = "";
                progressBar.Value = StartPort;
            }));
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            StoppedByUser = true;
        }

        public void UpdateOpenPortList(int openPort)
        {
            Invoke((MethodInvoker)(() => {
                tcpOpenPortsListBox.Items.Add(openPort);
                tcpOpenPortsListBox.TopIndex = tcpOpenPortsListBox.Items.Count - 1;
            }));
        }
        public void UpdateLogList(string log)
        {
            Invoke((MethodInvoker)(() =>
            {
                logListBox.Items.Add(log);
                logListBox.TopIndex = logListBox.Items.Count - 1;
            }));

        }
        public void UpdateProgressbar(int count)
        {
            Invoke((MethodInvoker)(() => progressBar.Value = count));
        }
        public void SetProgressbarValues()
        {
            progressBar.Minimum = StartPort;
            progressBar.Maximum = EndPort;
        }

        private void IpTextBox_Enter(object sender, EventArgs e)
        {
            if (!ipTextHasChanged)
            {
                ipTextBox.Text = "";
                ipTextBox.ForeColor = Color.Black;
                ipTextBox.Font = new Font(ipTextBox.Font, FontStyle.Regular);
            }
        }
        private void IpTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ipTextBox.Text))
            {
                ipTextBox.Text = " Beispiel: 128.105.39.11 ";
                ipTextBox.ForeColor = Color.DarkGray;
                ipTextBox.Font = new Font(ipTextBox.Font, FontStyle.Italic);
                ipTextHasChanged = false;
            }
            else
            {
                ipTextHasChanged = true;
            }
        }
        private void IpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void StartPortTextBox_Enter(object sender, EventArgs e)
        {
            if (!startPortHasChanged)
            {
                startPortTextBox.Text = "";
                startPortTextBox.ForeColor = Color.Black;
                startPortTextBox.Font = new Font(startPortTextBox.Font, FontStyle.Regular);
            }
        }

        private void StartPortTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(startPortTextBox.Text))
            {
                startPortTextBox.Text = "Beispiel: 10 ";
                startPortTextBox.ForeColor = Color.DarkGray;
                startPortTextBox.Font = new Font(startPortTextBox.Font, FontStyle.Italic);
                startPortHasChanged = false;
            }
            else
            {
                startPortHasChanged = true;
            }
        }

        private void EndPortTextBox_Enter(object sender, EventArgs e)
        {
            if (!endPortHasChanged)
            {
                endPortTextBox.Text = "";
                endPortTextBox.ForeColor = Color.Black;
                endPortTextBox.Font = new Font(endPortTextBox.Font, FontStyle.Regular);
            }
        }

        private void EndPortTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(endPortTextBox.Text))
            {
                endPortTextBox.Text = "Beispiel: 100 ";
                endPortTextBox.ForeColor = Color.DarkGray;
                endPortTextBox.Font = new Font(endPortTextBox.Font, FontStyle.Italic);
                endPortHasChanged = false;
            }
            else
            {
                endPortHasChanged = true;
            }
        }

        private void MsTextBox_Enter(object sender, EventArgs e)
        {
            if (!timeoutHasChanged)
            {
                msTextBox.Text = "";
                msTextBox.ForeColor = Color.Black;
                msTextBox.Font = new Font(msTextBox.Font, FontStyle.Regular);
            }
        }

        private void MsTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msTextBox.Text))
            {
                msTextBox.Text = "Beispiel: 200 ";
                msTextBox.ForeColor = Color.DarkGray;
                msTextBox.Font = new Font(msTextBox.Font, FontStyle.Italic);
                timeoutHasChanged = false;
            }
            else
            {
                timeoutHasChanged = true;
            }
        }

        private void StartPortTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EndPortTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MsTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StartPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EndPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void MsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void ipTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                scanButton.PerformClick();
            }
        }
    }
}
