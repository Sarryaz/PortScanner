using System;
using System.Drawing;
using System.Windows.Forms;

namespace PortScanner
{
    /// <summary>
    /// Klasse für UI Methodiken
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Globale Variable
        /// </summary>
        bool ipTextHasChanged;
        bool startPortHasChanged;
        bool endPortHasChanged;
        bool timeoutHasChanged;
        
        public bool Scanning;

        /// <summary>
        /// Haupteinstiegspunkt für die Oberfläche
        /// </summary>
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
        /// <summary>
        /// Holt/Setzt die IP Adresse
        /// </summary>
        public string IPAdress
        {
            get => ipTextBox.Text;
            set => ipTextBox.Text = value;
        }

        /// <summary>
        /// Holt/Setzt die Zeit um den Host zu pingen
        /// </summary>
        public string Ping
        {
            get => pingTextBox.Text;
            set => pingTextBox.Text = value;
        }

        /// <summary>
        /// Holt/Setzt die Jobdauer
        /// </summary>
        public string JobDuration
        {
            get => jobDurationTextBox.Text;
            set => jobDurationTextBox.Text = value;
        }

        /// <summary>
        /// Holt/Setzt den Startport
        /// </summary>
        public int StartPort
        {
            get => ParseIntOrNull(startPortTextBox.Text) ?? 10;
            set => startPortTextBox.Text = value.ToString();
        }

        /// <summary>
        /// Holt/Setzt den Endport
        /// </summary>
        public int EndPort
        {
            get => ParseIntOrNull(endPortTextBox.Text) ?? 100;
            set => endPortTextBox.Text = value.ToString();
        }

        /// <summary>
        /// Holt/Setzt den Timeout
        /// </summary>
        public int Timeout
        {
            get => ParseIntOrNull(msTextBox.Text) ?? 200;
            set => msTextBox.Text = value.ToString();
        }

        /// <summary>
        /// Holt/Setzt, ob ein Fehler aufgetreten ist
        /// </summary>
        public bool ErrorOccured
        { get; set; }

        /// <summary>
        /// Holt/Setzt, ob der Nutzer den Vorgang abgebrochen hat
        /// </summary>
        public bool StoppedByUser
        { get; set; }

        /// <summary>
        /// Löst einen Job zum Scannen offener Ports aus
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void ScanButton_Click(object sender, EventArgs e)
        {
            if (Scanning) return;
            Scanning = true;
            StoppedByUser = default;
            Core.InputHandler(this);
            if (!ErrorOccured)
            {
                SetProgressbarValues();
                ScanCore.Scan(this);
                PingCore.PingPong(this);
                CleanResultUI();
            }
            else
               Scanning = false;
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

            /// <summary>
            /// Löst den Abbruch des aktuellen Scanvorgangs aus
            /// </summary>
            /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
            /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void StopButton_Click(object sender, EventArgs e)
        { StoppedByUser = true; }

        public void UpdateOpenPortList(int openPort)
        {
            Invoke((MethodInvoker)(() => {
                tcpOpenPortsListBox.Items.Add(openPort);
                tcpOpenPortsListBox.TopIndex = tcpOpenPortsListBox.Items.Count - 1;
            }));
        }

        /// <summary>
        /// Aktualisiert die Aktivitätseinträge der logListBox
        /// </summary>
        /// <param name="log">Enthält den aktuellen Aktivitätseintrag</param>
        public void UpdateLogList(string log)
        {
            Invoke((MethodInvoker)(() =>
            {
                logListBox.Items.Add(log);
                logListBox.TopIndex = logListBox.Items.Count - 1;
            }));

        }

        /// <summary>
        /// Aktualisiert den Fortschritt der Progressbar
        /// </summary>
        /// <param name="count">Enthält den aktuellen Fortschritt der Progressbar</param>
        public void UpdateProgressbar(int count)
        { Invoke((MethodInvoker)(() => progressBar.Value = count)); }

        /// <summary>
        /// Aktualisiert die Minimum-/Maximum Werte, welche die Progressbar annehmen kann 
        /// </summary>
        public void SetProgressbarValues()
        {
            progressBar.Minimum = StartPort;
            progressBar.Maximum = EndPort;
        }

        /// <summary>
        /// Aktualisiert die Minimum-/Maximum Werte, welche die Progressbar annehmen kann 
        /// </summary>
        public void ResetProgressbarValues()
        { Invoke((MethodInvoker)(() => progressBar.Value = StartPort)); }

        /// <summary>
        /// Prüft ob der Nutzer in das Control geklickt hat
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void IpTextBox_Enter(object sender, EventArgs e)
        {
            if (!ipTextHasChanged)
            {
                ipTextBox.Text = "";
                ipTextBox.ForeColor = Color.Black;
                ipTextBox.Font = new Font(ipTextBox.Font, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Prüft ob der Nutzer den Text des Feldes geändert hat und ändert diesen ggf. wieder in den Ursprungszustand
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
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

        /// <summary>
        /// Prüft ob der Nutzer in das Control geklickt hat
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void StartPortTextBox_Enter(object sender, EventArgs e)
        {
            if (!startPortHasChanged)
            {
                startPortTextBox.Text = "";
                startPortTextBox.ForeColor = Color.Black;
                startPortTextBox.Font = new Font(startPortTextBox.Font, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Prüft ob der Nutzer den Text des Feldes geändert hat und ändert diesen ggf. wieder in den Ursprungszustand
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void StartPortTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(startPortTextBox.Text))
            {
                startPortTextBox.Text = "Beispiel: 10";
                startPortTextBox.ForeColor = Color.DarkGray;
                startPortTextBox.Font = new Font(startPortTextBox.Font, FontStyle.Italic);
                startPortHasChanged = false;
            }
            else
            {
                startPortHasChanged = true;
            }
        }

        /// <summary>
        /// Prüft ob der Nutzer in das Control geklickt hat
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void EndPortTextBox_Enter(object sender, EventArgs e)
        {
            if (!endPortHasChanged)
            {
                endPortTextBox.Text = "";
                endPortTextBox.ForeColor = Color.Black;
                endPortTextBox.Font = new Font(endPortTextBox.Font, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Prüft ob der Nutzer den Text des Feldes geändert hat und ändert diesen ggf. wieder in den Ursprungszustand
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void EndPortTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(endPortTextBox.Text))
            {
                endPortTextBox.Text = "Beispiel: 100";
                endPortTextBox.ForeColor = Color.DarkGray;
                endPortTextBox.Font = new Font(endPortTextBox.Font, FontStyle.Italic);
                endPortHasChanged = false;
            }
            else
            {
                endPortHasChanged = true;
            }
        }

        /// <summary>
        /// Prüft ob der Nutzer in das Control geklickt hat
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void MsTextBox_Enter(object sender, EventArgs e)
        {
            if (!timeoutHasChanged)
            {
                msTextBox.Text = "";
                msTextBox.ForeColor = Color.Black;
                msTextBox.Font = new Font(msTextBox.Font, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Prüft ob der Nutzer den Text des Feldes geändert hat und ändert diesen ggf. wieder in den Ursprungszustand
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
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

        /// <summary>
        /// Prüft ob der Text vom Nutzer verändert wurde
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void IpTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Prüft ob der Text vom Nutzer verändert wurde
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void StartPortTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Prüft ob der Text vom Nutzer verändert wurde
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void EndPortTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Prüft ob der Text vom Nutzer verändert wurde
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void MsTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Prüft ob der Nutzer eine numerische Taste gedrückt hat
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void StartPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Prüft ob der Nutzer eine numerische Taste gedrückt hat
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
        private void EndPortTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        /// <summary>
        /// Prüft ob der Nutzer eine numerische Taste gedrückt hat
        /// </summary>
        /// <param name="sender">Enthält die Referenz zum Objekt/Control, welches das Event ausgelöst hat</param>
        /// <param name="e">Enthält die Daten des aufgetretenen Events</param>
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
