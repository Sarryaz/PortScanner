using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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
        const string invalidIpAdress = "Bitte gebe eine IP-Adresse ein.";
        const int lowestPossiblePort = 1;
        const int highestPossiblePort = 65535;

        /// <summary>
        /// Deklaration von Konstanten
        /// </summary>
        internal static void Scan(MainForm Form)
        {
            string jobDuration;

            if (!string.IsNullOrEmpty(Form.IPAdress))
            {
                try
                {
                    var t = Task.Run(() =>
                    {
                        Timer timer = new Timer();
                    timer.Start();


                    timer.Stop();
                    jobDuration = timer.ToString();
                        Form.Invoke((MethodInvoker)(() =>
                        {
                            Form.JobDuration = jobDuration;
                        }));
                    });
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show(invalidIpAdress);
            }
        }

        /// <summary>
        /// Pingt die angebebene IP-Adresse an
        /// </summary>
        internal static void PingPong(MainForm Form)
        {
            bool pingable = false;
            Ping ping = default;

            if (IPAddress.TryParse(Form.IPAdress, out IPAddress ip))
            {
                try
                {
                    var t = Task.Run(() =>
                   {
                       ping = new Ping();
                       PingReply reply = ping.Send(Form.IPAdress);
                       pingable = reply.Status == IPStatus.Success;

                       Form.Invoke((MethodInvoker)(() =>
                        {
                            Form.Ping = reply.RoundtripTime.ToString() + " ms";
                        }));
                   });
                }

                catch (PingException ex)
                {
                    MessageBox.Show("Eine Exception ist aufgetreten: {0}",
                    ex.InnerException != null
                        ? ex.InnerException.Message
                        : ex.Message);
                    return;
                }

                //finally
                //{
                //    if (string.IsNullOrEmpty(ping.ToString()))
                //    { ping.Dispose(); }
                //}
            }

            else
            { MessageBox.Show(invalidIpAdress); }
        }
    }
}

