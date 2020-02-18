using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NPMS.gestion.administrator_network.CommonMethods
{
    public  class SecureCommon
    {
        // Este metodo encripta el dato aportado en base64
        public static string Encriptar(string Dato_encriptar)
        {
            string result;
            byte[] encryted = Encoding.Unicode.GetBytes(Dato_encriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }


        // Este metodo desencripta el dato aportado en base 64
        public static string DesEncriptar(string Dato_Desencriptar)
        {
            string result;
            byte[] decryted = Convert.FromBase64String(Dato_Desencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = Encoding.Unicode.GetString(decryted);
            return result;
        }
        //Método para generar una clave con un hash SHA-1, a partir de una cadena dada
        public static string EncryptHash(string Dato_Encriptar)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(Dato_Encriptar);
            byte[] result;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            result = sha.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                // Convertimos los valores en hexadecimal
                // cuando tiene una cifra hay que rellenarlo con cero
                // para que siempre ocupen dos dígitos.
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            //Devolvemos la cadena con el hash en mayúsculas
            return sb.ToString().ToUpper();
        }
    }
}
