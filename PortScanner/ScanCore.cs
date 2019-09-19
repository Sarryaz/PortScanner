using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    /// <summary>
    /// Klasse für Scan Methodiken
    /// </summary>
    class ScanCore
    {
        /// <summary>
        /// Führt den eigentlichen Scan der offenen Ports anhand der angegebenen IP-Adresse aus
        /// </summary>
        /// <param name="Form">Gibt eine Form vom Typ MainForm in die Methode</param>
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
                                Form.ResetProgressbarValues();
                                Form.StoppedByUser = false;
                                MessageBox.Show("Vom Nutzer abgebrochen.");
                                token.ThrowIfCancellationRequested();
                            }
                            catch (ThreadAbortException)
                            { throw; }
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
    }
}
