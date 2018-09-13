using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncriptamientoClienteServidor
{
    public class cesarEncryption
    {
        public static string Cifrar(string texto, int codigo)
        {
            if (texto.Length == 0) return String.Empty;

            char chr = texto[0].ToString().ToLower()[0];

            var code = IsBasicLetter(chr) ? (char)(((chr - 'a' + codigo) % 26) + 'a') : chr;
            return code + Cifrar(texto.Substring(1), codigo);
        }

        public static string Descifrar(string texto, int codigo)
        {
            if (texto.Length == 0) return String.Empty;

            char chr = texto[0].ToString().ToLower()[0];

            var code = IsBasicLetter(chr) ? (char)('z' - (('z' - chr + codigo) % 26)) : chr;
            return code + Descifrar(texto.Substring(1), codigo);
        }

        private static bool IsBasicLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
    }
}
