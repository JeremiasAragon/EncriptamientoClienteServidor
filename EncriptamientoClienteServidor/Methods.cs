namespace EncriptamientoClienteServidor
{
    using MetroFramework;
    using MetroFramework.Controls;
    using System;
    using System.Collections.Generic;
    using System.Net.NetworkInformation;
    using System.Windows.Forms;

    public class Methods
    {
        public static void getClients(string subnet, int from, int to, MetroProgressBar progressBar)
        {
            Ping myPing;
            PingReply reply;
            List<String> listVAddr = new List<String>();
            progressBar.Minimum = from;
            progressBar.Maximum = to;

            for (int i = from; i < to; i++)
            {
                string subnetn = "." + i;
                myPing = new Ping();
                reply = myPing.Send($"{subnet}{subnetn}", 900);

                if (reply.Status == IPStatus.Success)
                {
                    //MessageBox.Show($"{subnet}{subnetn}");
                    progressBar.PerformStep();
                }
            }

            progressBar.Value = progressBar.Maximum;
            MetroMessageBox.Show(Form1.ActiveForm, "Red escaneada con éxito",
                "Operación concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
