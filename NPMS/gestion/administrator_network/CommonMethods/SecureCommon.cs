using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPMS.gestion.administrator_network.CommonMethods
{
    public  class SecureCommon
    {
        // Este metodo encripta el dato aportado
        public static string Encriptar(string Dato_encriptar)
        {
            string result;
            byte[] encryted = Encoding.Unicode.GetBytes(Dato_encriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }


        // Este metodo desencripta el dato aportado
        public static string DesEncriptar(string Dato_Desencriptar)
        {
            string result;
            byte[] decryted = Convert.FromBase64String(Dato_Desencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
