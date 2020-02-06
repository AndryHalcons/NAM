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
        
 
       
        //Variable que indica al programa donde se encuentra el archivo
        //que contiene la configuracion de conexion a la base de datos 
        public static string ruta_ArchivoConfBbdd =  Application.StartupPath+"/DatSettings.txt";
     
        //Variable que contiene la ruta temporal donde se crea el archivo de SESION
        public static string tempArch = Path.GetTempFileName();
       
        //Comprueba que el txt que contiene los datos de conexion a BBDD
        //Existen en la carpeta del proyecto, si no está lo crea 
        // genera contenido para trabajar con el


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
                sw.WriteLine(SecureCommon.Encriptar("Database user"));
                sw.WriteLine(SecureCommon.Encriptar("Database Pass"));
                sw.WriteLine(SecureCommon.Encriptar("Database Server"));
                sw.WriteLine(SecureCommon.Encriptar("Database schema"));
                sw.WriteLine(SecureCommon.Encriptar("Database Port"));
                sw.Close();
                return true;
            }                                                                                                                                             
         }

        //Encripta e Inserta en un archivo temporal creado por la variable tempArch
        // el nombre de usuario y el rol
        public static void CreateSession(string usuario, string rol)
        {
            StreamWriter sw = File.CreateText(tempArch);
            sw.WriteLine(SecureCommon.Encriptar(usuario));
            sw.WriteLine(SecureCommon.Encriptar(rol));
            sw.Close();

        }

        //De aqui sacara la app el nombre de usuario de la sesion cada vez que lo necesite
        //Desencriptandolo
        public static string UsuarioLogueado()
        {
            StreamReader sr = File.OpenText(tempArch);
            string user_name = SecureCommon.DesEncriptar(sr.ReadLine());
            sr.Close();
            return user_name;
        }
        //De aqui sacara la app el ROL de usuario de las sesion cada vez eu lo necsite
        //Desencriptandolo
        public static string RolUsuarioLogueado()
        {
            StreamReader sr = File.OpenText(tempArch);
            string user_name = SecureCommon.DesEncriptar(sr.ReadLine());
            string user_rol = SecureCommon.DesEncriptar(sr.ReadLine());
            sr.Close();
            return user_rol;
        }

        //VALIDA el usuario a nivel de BBDD revisa que los parametros de conexion
        //son correctos
        public static bool EntryUsuarioBBDD()
        {
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            try
            {
                databaseConnection.Open();
                databaseConnection.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Database access error");
                return false;
            }
        }
        //Valida las credenciales de usuario a nivel de Aplicacion
        //Compara el usuario y contraseña con la fila correspondiente al usuario en la BBDD
        public static bool EntryUsuarioApp(string Usuario, string Password)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            databaseConnection.Open();
            string query = "SELECT * FROM npms.usuarios WHERE Usuario = '"+Usuario+"' and Password = '"+Password+"';";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Prepare();
            var reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                databaseConnection.Close();
                return true;

            }
            else
            {
                databaseConnection.Close();
                MessageBox.Show("Incorrect logging data");
                return false;
            }
        }
       

        public static void ConsultatablaIP(string nombre_tabla, string query)
        {
            Sentencias.Bbdd_apply(nombre_tabla, query);
        }

        ///---------------------------VALIDADORES--------------------------------
        ///Valida que un campo no esté vacio, si lo está muestra un mensaje de error
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
                    MessageBox.Show("Incorrect format IpV6 in '" + NombreCampoVacio + "'");
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
                MessageBox.Show("Incorrect format IpV6 in '"+NombreCampoVacio+"'");
                return false;
            }
           
        }


        //**************Valida que una tabla existe *************************
        public static bool ValidadorTabla(string NombreTabla)
        {
            string query = "SHOW TABLES LIKE '" + NombreTabla + "';";
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Prepare();
            var reader = commandDatabase.ExecuteReader();           
            if (reader.HasRows)
            {
                databaseConnection.Close();
                return true;              

            }
            else
            {
                databaseConnection.Close();
                MessageBox.Show("Vlan "+NombreTabla+" does not exist");
                return false;
            }

        }
        //Valida que una vlan existe Comprueba la id_vlan aportada con el campo Vlan de la tabla
        //Si el return es True es que el dato se encuentra previamente en la base de datos
        public static bool ValidarExistenciaVlan(string id_vlan)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            databaseConnection.Open();
            string query = "SELECT * FROM npms.vlan_ipv4 WHERE Vlan = '" + id_vlan + "';";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Prepare();
            var reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {

                MessageBox.Show("The Vlan already exists");
                databaseConnection.Close();
                return true;
            }
            else
            {
                
                databaseConnection.Close();              
                return false;
            }
        }
        //Comprueba que el dato no esté en la tabla previamente sin mensaje
        //Devuelve True si el dato ya se encuentra previamente en la BBDD
        public static bool ValidarDatoExistente(string tabla,string campo,string Datoaportado)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            databaseConnection.Open();
            string query = "SELECT * FROM npms."+tabla+" WHERE "+campo+" = '" + Datoaportado + "';";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Prepare();
            var reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                databaseConnection.Close();
                return true;
            }
            else
            {
                databaseConnection.Close();
                return false;
            }
        }
        //Comprueba que el dato no esté en la tabla previamente con mensaje
        //Devuelve True si el dato ya se encuentra previamente en la BBDD
        public static bool ValidarDatoExistenteConMensaje(string tabla, string campo, string Datoaportado, string NombreCampoValidar)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            databaseConnection.Open();
            string query = "SELECT * FROM npms." + tabla + " WHERE " + campo + " = '" + Datoaportado + "';";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Prepare();
            var reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("The "+NombreCampoValidar+ " already exists! ");
                databaseConnection.Close();
                return true;
            }
            else
            {
                databaseConnection.Close();
                return false;
            }
        }
















    }
}
