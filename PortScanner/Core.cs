using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    public class Core
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Deklaration von Konstanten
        /// </summary>
        const bool isStoppedByUser = false;
        const int timeout = 200;



        /// <summary>
        /// Führt den eigentlichen Scan der offenen Ports anhand der angegebenen IP-Adresse aus
        /// </summary>
        /// 
        internal static void Scan(MainForm Form)
        {
            var source = new CancellationTokenSource();
            CancellationToken token = source.Token;
            Task.Run(() =>
            {
                if (IPAddress.TryParse(Form.IPAdress, out IPAddress ipAdress))
                {
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    for (int currentPort = Form.StartPort; currentPort <= Form.EndPort; currentPort++)
                    {
                        if (Form.StoppedByUser)
                        {
                            try
                            {

                                Form.CleanResultUI();
                                Form.StoppedByUser = false;
                                MessageBox.Show("Vom Nutzer abgebrochen.");
                                token.ThrowIfCancellationRequested();
                            }
                            catch (ThreadAbortException)
                            {
                                throw;
                            }
                        }
                        var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        Form.Invoke((MethodInvoker)(() => Form.JobDuration = stopwatch.Elapsed.ToString()));
                        using (TcpClient tcpClient = new TcpClient())
                        {

                            Form.UpdateLogList("Scanne Port: " + currentPort);
                            try
                            {
                                var endpoint = new IPEndPoint(IPAddress.Parse(Form.IPAdress), currentPort);
                                var result = sock.BeginConnect(endpoint, null, null);
                                Form.UpdateProgressbar(currentPort);
                                if (result.AsyncWaitHandle.WaitOne(Form.Timeout, true))
                                {
                                    sock.EndConnect(result);
                                    Form.UpdateOpenPortList(currentPort);
                                }
                                else sock.Close();
                            }

                            catch (SocketException ex)
                            {
                                MessageBox.Show("Eine Exception ist aufgetreten: {0}",
                                ex.InnerException != null
                                    ? ex.InnerException.Message
                                    : ex.Message);
                            }

                        }
                    }
                    stopwatch.Stop();
                    Form.Invoke((MethodInvoker)(() => Form.JobDuration = stopwatch.Elapsed.ToString()));
                    MessageBox.Show("Scan erfolgreich abgeschlossen!");
                }
            }, token);
            source.CancelAfter(1000);
        }

        /// <summary>
        /// Pingt die angebebene IP-Adresse an
        /// <paramref name="Form"/>
        /// </summary>
        internal static void PingPong(MainForm Form)
        {
            bool pingable = false;
            Ping ping = default;

            var t = Task.Run(() =>
            {
                if(IPAddress.TryParse(Form.IPAdress, out IPAddress ipAdress))
                    try
                    {
                        using (ping = new Ping())
                        {
                            PingReply reply = ping.Send(Form.IPAdress);
                            pingable = reply.Status == IPStatus.Success;

                            Form.Invoke((MethodInvoker)(() => Form.Ping = reply.RoundtripTime.ToString() + " ms"));
                        }
                    }

                    catch (PingException ex)
                    {
                        MessageBox.Show("Eine Exception ist aufgetreten: ${0}",
                        ex.InnerException != null
                            ? ex.InnerException.Message
                            : ex.Message);
                        return;
                    }
            });
        }


        internal static void InputHandler(MainForm Form)
        {
            if (!IPAddress.TryParse(Form.IPAdress, out IPAddress ipAdress))
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

