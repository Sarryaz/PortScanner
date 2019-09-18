using System;
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

        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = ipAdressLabel;
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
            get => jobTextBox.Text;
            set => jobTextBox.Text = value;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Core.Scan(this);
            Core.PingPong(this);
        }

        private void IpTextBox_Enter(object sender, EventArgs e)
        {
            ipTextBox.Text = "";
            ipTextBox.ForeColor = Color.Black;
            ipTextBox.Font = new Font(ipTextBox.Font, FontStyle.Regular);
        }

        private void IpTextBox_Leave(object sender, EventArgs e)
        {
            if (!ipTextHasChanged)
            {
                ipTextBox.Text = " Beispiel: 128.105.39.11 ";
                ipTextBox.ForeColor = Color.DarkGray;
                ipTextBox.Font = new Font(ipTextBox.Font, FontStyle.Italic);
            }
        }

        private void IpTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ipTextBox.Text))
                ipTextHasChanged = true;
        }
    }
}
