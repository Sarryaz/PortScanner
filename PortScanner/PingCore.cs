using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortScanner
{
    /// <summary>
    /// Klasse für Ping Methodiken
    /// </summary>
    class PingCore
    {
        /// <summary>
        /// Pingt die vom Nutzer spezifizierte IP Adresse an und liefert die benötigte Zeit an das UI zurück.
        /// </summary>
        /// <param name="Form">Gibt eine Form vom Typ MainForm in die Methode</param>
        internal static void PingPong(MainForm Form)
        {
            bool pingable = false;
            Ping ping = default;

            var t = Task.Run(() =>
            {
                if (IPAddress.TryParse(Form.IPAdress, out IPAddress ipAdress))
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
                        MessageBox.Show("Ein Fehler ist Aufgetreten: Der angegebene Host konnte nicht erreicht werden.",
                        ex.InnerException != null
                            ? ex.InnerException.Message
                            : ex.Message);
                        return;
                    }
            });
        }
    }
}
