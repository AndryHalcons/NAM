using MySql.Data.MySqlClient;
using NetTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network.CommonMethods
{
    class Common
    {



        /*Variable que indica al programa donde se encuentra el archivo
         * que contiene la configuracion de conexion a la base de datos */
        public static string ruta_ArchivoConfBbdd =  Application.StartupPath+"/DatSettings.txt";
       /*Comprueba que el txt que contiene los datos de conexion a BBDD
         * existen en la carpeta del proyecto, si no está lo crea  
         * genera contenido para trabajar con el*/
        public static bool ArchivoConfBbdd()
        {
            try
            {
                StreamReader sr = File.OpenText(ruta_ArchivoConfBbdd);
                sr.Close();
                return true;
            }
            catch
            {
                StreamWriter sw = File.CreateText(ruta_ArchivoConfBbdd);
                sw.WriteLine(SecureCommon.Encriptar("Database User"));
                sw.WriteLine(SecureCommon.Encriptar("Database Pass"));
                sw.WriteLine(SecureCommon.Encriptar("Database Server"));
                sw.WriteLine(SecureCommon.Encriptar("Database schema"));
                sw.WriteLine(SecureCommon.Encriptar("Database Port"));
                sw.WriteLine(SecureCommon.Encriptar("BBDD Type"));
                sw.Close();
                return true;
            }                                                                                                                                             
         }

        ///---------------------------VALIDADORES--------------------------------
        ///Valida que un campo no esté vacio, si lo está muestra un mensaje de error
        ///public static bool Validar_Conexion_BBDD()

        public static bool ValidadorCamposVacios(string Dato_Campo, string NombreCampoVacio)
        { 
        
                if (string.IsNullOrEmpty(Dato_Campo))
                {

                    MessageBox.Show("Complete the  "+NombreCampoVacio+" field");

                    return false;

                }
              else
               {
                return true;
               }
                          
        }

        //Valida que un campo no esté vacio SIN mostrar mensaje de error alguno
        //Retorna false si está vacio
        public static bool ValidadorCamposVacios_SinMensaje(string Dato_Campo)
        {

            if (string.IsNullOrEmpty(Dato_Campo))
            {
                return false;

            }
            else
            {
                return true;
            }

        }
        // Valida que una cadena tipo String puede ser convertida a entero.
        public static bool ValidadorInt(string Dato_Campo, string NombreCampo)
        {
            try
            {
                Int32.Parse(Dato_Campo);
                return true;
            }
            catch
            {
                MessageBox.Show("Complete the " + NombreCampo + " field correctly");
                return false;                

            }
        }
        // Valida que una cadena tipo String puede ser convertida a entero sin mensaje de error
        public static bool ValidadorInt_simple(string Dato_Campo)
        {
            try
            {
                Int32.Parse(Dato_Campo);
                return true;
            }
            catch
            {              
                return false;

            }
        }
        // Valida que una cadena tipo string tenga un formato IP (0.0.0.0) correcto
        public static bool ValidadorIP(string Dato_Campo, string NombreCampoVacio)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(Dato_Campo);
            }
            catch
            {
                MessageBox.Show("Complete the " + NombreCampoVacio + " field correctly");
                return false;
            }

            return true;
        }
        // Valida que una cadena tipo string tenga un formato IPV6 o Ipv4
        //Devuelve false si es IPv4
        //Devuelve true si es IPv6
        public static bool ValidadorIPv6(string Dato_campo, string NombreCampoVacio)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(Dato_campo);
                if (Dato_campo.Contains("."))
                {
                    MessageBox.Show("Incorrect format IPv6 in '" + NombreCampoVacio + "'");
                    return false;
                }
                else
           if (Dato_campo.Contains(":"))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Incorrect format IPv6 in '"+NombreCampoVacio+"'");
                return false;
            }
           
        }

    }
}
