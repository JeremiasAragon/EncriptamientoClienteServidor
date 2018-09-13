using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncriptamientoClienteServidor
{
    public class Message
    {
        public string Body { get; set; }
        public string EncryptionType { get; set; }
        public string ReceiverAddress { get; set; }
        public string SenderAddress { get; set; }

        public void encrypt()
        {
            if(EncryptionType.Equals("Cifrado por sustitución"))
            {
                Body = cesarEncryption.Cifrar(Body, 3);
            }
        }

        private void decode()
        {

        }
    }
}
