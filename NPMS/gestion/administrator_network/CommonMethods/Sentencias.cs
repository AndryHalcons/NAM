using MySql.Data.MySqlClient;
using NetTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network.CommonMethods
{
    class Sentencias
    {

        //*********** Aporta los datos de conexion a la BBDD desencriptandolos*************

     
        public static string bbdd_connection_data()
        {
                StreamReader sr = File.OpenText(Common.ruta_ArchivoConfBbdd);
                string user_name = SecureCommon.DesEncriptar(sr.ReadLine());
                string password_name = SecureCommon.DesEncriptar(sr.ReadLine());
                string server_name = SecureCommon.DesEncriptar(sr.ReadLine());
                string bbdd_name = SecureCommon.DesEncriptar(sr.ReadLine());
                string port_name = SecureCommon.DesEncriptar(sr.ReadLine());
                GlobalParam.BBDD_Type = SecureCommon.DesEncriptar(sr.ReadLine());
                sr.Close();
                string connectionString = "datasource=" + server_name + ";port=" + port_name + ";username=" + user_name + ";password=" + password_name + ";database=" + bbdd_name + ";";
                return connectionString;
                        
        }          
        //************* Parametros de accion en base de datos,  aportando la tabla destino y la  QuerySQL***********
        public static void Bbdd_apply(string nombre_tabla, string query)
        {
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
            databaseConnection.Open();
            MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
            DataSet ds = new DataSet();
            string Snombre_tabla = nombre_tabla.ToString();
            commandDatabase.Fill(ds, Snombre_tabla);
            databaseConnection.Close();
        }
        //Consulta simple en Base de datos con query
        public static void Bbdd_apply_simple(string query)
        {
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
            databaseConnection.Open();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandText = query;
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();
        }
        //Metodo que Realiza las consultas en las BBDD y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_datagridView(string tabla, string query ,DataGridView Datagrid_Name)
        {
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
            databaseConnection.Open();
            MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
            DataSet ds = new DataSet();
            commandDatabase.Fill(ds, tabla);
            Datagrid_Name.DataSource = ds;
            Datagrid_Name.DataMember = tabla;
            databaseConnection.Close();
        }


        //Obtiene el dato de un campo de tipo INT
        public static int Dato_Campo_Int(string tabla, string NombreCampo, string DatoCampo, int PosicionCampo)
        {
            MySqlCommand Query = new MySqlCommand();
            MySqlConnection Conexion = new MySqlConnection();
            MySqlDataReader consultar;
            Conexion = new MySqlConnection();
            Conexion.ConnectionString = bbdd_connection_data();
            Conexion.Open();
            Query.CommandText = "SELECT * FROM npms." + tabla + " WHERE " + NombreCampo + " = '" + DatoCampo + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            consultar.Read();
            int Rol = consultar.GetInt32(PosicionCampo);
            Conexion.Close();
            return Rol;
        }
        //Obtiene el dato de un campo de tipo String,
        public static string Dato_Campo_String(string tabla, string NombreCampo, string DatoCampo, int PosicionCampo)
        {
            MySqlCommand Query = new MySqlCommand();
            MySqlConnection Conexion = new MySqlConnection();
            MySqlDataReader consultar;
            Conexion = new MySqlConnection();
            Conexion.ConnectionString = bbdd_connection_data();
            Conexion.Open();
            Query.CommandText = "SELECT * FROM npms." + tabla + " WHERE " + NombreCampo + " = '" + DatoCampo + "';";
            Query.Connection = Conexion;
            consultar = Query.ExecuteReader();
            consultar.Read();
            string Rol = consultar.GetString(PosicionCampo);
            Conexion.Close();
            return Rol;
        }
        
        //*******************************************************************************************//



    


  
        
    


 










    }
}
