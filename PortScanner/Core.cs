using System;
using System.Net;
using System.Windows.Forms;

namespace PortScanner
{
    /// <summary>
    /// Klasse für Anwendungskern
    /// </summary>
    public class Core
    {
        /// <summary>
        /// Haupteinstiegspunkt für die Anwendung
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Behandelt diverse Ausnahmesituationen
        /// </summary>
        /// <param name="Form">Gibt eine Form vom Typ MainForm in die Methode</param>
        internal static void InputHandler(MainForm Form)
        {
            int dnsEntries;
            try
            {
                dnsEntries = Dns.GetHostAddresses(Form.IPAdress).Length;
            }
            catch (Exception e)
            {
                dnsEntries = 0;
            }
            
            if (dnsEntries <= 0)
            {
                MessageBox.Show("Bitte gebe eine gültige IP-Adresse an.");
                Form.ErrorOccured = true;
                return;
            }

            if (Form.StartPort <= 0)
            {
                MessageBox.Show("Bitte gebe einen gültigen Startport an.");
                Form.ErrorOccured = true;
                return;
            }

            if (Form.StartPort > 65535)
            {
                MessageBox.Show("Bitte gebe einen gültigen Startport an.");
                Form.ErrorOccured = true;
                return;
            }

            if (Form.EndPort <= 0)
            {
                MessageBox.Show("Bitte gebe einen gültigen Endport an.");
                Form.ErrorOccured = true;
                return;
            }

            if (Form.EndPort > 65535)
            {
                MessageBox.Show("Bitte gebe einen gültigen Endport an.");
                Form.ErrorOccured = true;
                return;
            }

            if (Form.Timeout <= 0)
            {
                MessageBox.Show("Bitte gebe einen gültigen Timeout Wert an.");
                Form.ErrorOccured = true;
                return;
            }

            if (Form.StartPort > Form.EndPort)
            {
                MessageBox.Show("Bitte gebe eine Startport kleiner als den Endport an.");
                Form.ErrorOccured = true;
                return;
            }

        }

    }
}

