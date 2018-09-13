namespace EncriptamientoClienteServidor
{
    using System;
    using System.Windows.Forms;
    using MetroFramework;
    using MetroFramework.Forms;

    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scanButton_Click(object sender, System.EventArgs e)
        {
            if (!validate()) return;

            var subnet = subnetTextBox.Text;
            var from = int.Parse(fromTextBox.Text);
            var to = int.Parse(toTextBox.Text);

            progressBar.Visible = true;
            progressLabel.Visible = true;

            Methods.getClients(subnet, from, to, progressBar);

            progressBar.Visible = false;
            progressLabel.Visible = false;
        }

        private bool validate()
        {
            int initialRange;
            int finalRange;

            if (subnetTextBox.Text.Equals(String.Empty))
            {
                MetroMessageBox.Show(this ,"Debe digitar la subred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!validateSubnet()) return false;
            }

            if (fromTextBox.Text.Equals(String.Empty))
            {
                MetroMessageBox.Show(this, "Debe digitar el rango inicial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    initialRange = int.Parse(fromTextBox.Text);
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Sólo se permiten valores numéricos en el rango inicial", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (toTextBox.Text.Equals(String.Empty))
            {
                MetroMessageBox.Show(this, "Debe digitar el rango final", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                try
                {
                    finalRange = int.Parse(toTextBox.Text);
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Sólo se permiten valores numéricos en el rango final", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if(initialRange > finalRange)
            {
                MetroMessageBox.Show(this, "El rango inicial debe ser menor que el rango final", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(initialRange < 1)
            {
                MetroMessageBox.Show(this, "Los rangos deben ser números mayores o iguales a 1",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (finalRange < 1)
            {
                MetroMessageBox.Show(this, "Los rangos deben ser números mayores o iguales a 1",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (initialRange > 255)
            {
                MetroMessageBox.Show(this, "Los rangos deben ser números menores o iguales a 255",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(finalRange > 255)
            {
                MetroMessageBox.Show(this, "Los rangos deben ser números menores o iguales a 255",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool validateSubnet()
        {
            int dots = 0;

            for (int i = 0; i < subnetTextBox.Text.Length; i++)
            {
                if (subnetTextBox.Text[i].Equals('.')) dots++;
            }

            if(dots < 2)
            {
                MetroMessageBox.Show(this, "Digite una dirección de subred en formato válido",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dots > 2)
            {
                MetroMessageBox.Show(this, "Digite una dirección de subred en formato válido",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var octects = subnetTextBox.Text.Split('.');
            int firsOctect;
            int secondOctect;
            int thirdOctect;

            try
            {
                firsOctect = int.Parse(octects[0]);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "En los octetos de la subnet sólo se permiten valores numéricos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                secondOctect = int.Parse(octects[1]);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "En los octetos de la subnet sólo se permiten valores numéricos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                thirdOctect = int.Parse(octects[2]);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "En los octetos de la subnet sólo se permiten valores numéricos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Message message = new Message()
            {
                Body = messageTextBox.Text,
                EncryptionType = encryptionTypeComboBox.SelectedItem.ToString(),
                SenderAddress = "192.168.1.35",
                ReceiverAddress = "192.168.1.35",
            };

            message.encrypt();
        }
    }
}
