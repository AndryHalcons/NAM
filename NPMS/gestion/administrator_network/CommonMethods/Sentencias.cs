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
        //*********** Comprueba que los parametros de conexion de la BBDD son correctas*************

        public static bool Validar_Conexion_BBDD()
        {
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
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


        //************* Parametros de accion en base de datos,  aportando la tabla destino y la  QuerySQL***********
        public static void Bbdd_apply(string nombre_tabla, string query)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                string Snombre_tabla = nombre_tabla.ToString();
                commandDatabase.Fill(ds, Snombre_tabla);
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
        }

        //Consulta simple en Base de datos con query
        public static void Bbdd_apply_simple(string query)

        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandText = query;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //REVISAR ESTE TIPO DE METODOS QUE NO USAN PROCEDURES
        //Metodo que Realiza las consultas en las BBDD y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_datagridView(string tabla, string query ,DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
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
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //Metodo que hace un select en la BBDD recuperando solamente dos columnas que 
        //mostrará en un Datagridview
        public static void Bbdd_apply_2fields_datagridView(string tabla, string campo1, string campo2, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call simplyselect_view2fields('" + tabla + "','" + campo1 + "','" + campo2 + "');";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //Metodo que obtiene una fila y valida que existe buscando que una fila tenga
        //dos campos especificos con el contenido exacto
        //Valida las credenciales de usuario a nivel de Aplicacion (LOGGING)
        //Compara el usuario y contraseña con la fila correspondiente al usuario en la BBDD
        public static bool Bbdd_apply_two_fields_exact(string tabla,string campo1, string campo2,
            string datocampo1, string datocampo2)
        {
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
            databaseConnection.Open();
            string query = "call simplyselectwhere2fields('"+tabla+"','"+campo1+"','"+campo2+"','"+datocampo1+"','"+datocampo2+"')";
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
        //Metodo que Realiza un SELECT * ALL en las BBDD  
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_all_datagridView(string tabla, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call simplyselectall('"+tabla+"')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //Metodo que Realiza un SELECT * ALL en las BBDD con ORDER DESC 
        //y  muestra el resultado en un DataGridView (IDEAL PARA LOGS)
        public static void Bbdd_apply_all_Desc_datagridView(string tabla, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call simplyselectallorderdesc('" + tabla + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //Metodo que Realiza las consultas en las BBDD filtrando por el valor EXACTO de un campo 
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_where_datagridView(string tabla, string campo,string datocampo, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call simplyselectwhere('" +tabla+ "','" + campo + "','" + datocampo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //Metodo que Realiza las consultas en las BBDD filtrando por el valor "LIKE" (CADENA) de un campo 
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_wherelike_datagridView(string tabla, string campo, string datocampo, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call simplyselectwherelike('" + tabla + "','" + campo + "','" + datocampo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //Metodo que encuentra la vlan correspondiente a una IP y la muestra en un DATAGRIDVIEW
        public static void Bbdd_apply_search_vlan_for_IP(string tabla, string IP, string campoMenor, string campoMayor, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call search_vlan_for_IP('" + tabla + "','" + IP + "','" + campoMenor + "','" + campoMayor + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }

        //Metodo que encuentra la vlan correspondiente a una IP origen y una IP destino
        //y la muestra en un DATAGRIDVIEW (FAST FIREWALL)
        public static void Bbdd_apply_search_vlan_for_Fast_Firewall(string protocolo, string IPorigen, string IPdestino, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                if (protocolo == "IPv4")
                {
                    string query = "call search_vlan_for_Fast_Firewall('vlan_ipv4','" + IPorigen + "','" + IPdestino + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                    databaseConnection.Open();
                    MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                    DataSet ds = new DataSet();
                    commandDatabase.Fill(ds, "vlan_ipv4");
                    Datagrid_Name.DataSource = ds;
                    Datagrid_Name.DataMember = "vlan_ipv4";
                    databaseConnection.Close();
                }
                if (protocolo == "IPv6")
                {
                    string query = "call search_vlan_for_Fast_Firewall('vlan_ipv6','" + IPorigen + "','" + IPdestino + "')";
                    MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                    databaseConnection.Open();
                    MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                    DataSet ds = new DataSet();
                    commandDatabase.Fill(ds, "vlan_ipv6");
                    Datagrid_Name.DataSource = ds;
                    Datagrid_Name.DataMember = "vlan_ipv6";
                    databaseConnection.Close();
                }

            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

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
                Query.CommandText = "call simplyselectwhere('" + tabla + "','" + NombreCampo + "','" + DatoCampo + "')";
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
            Query.CommandText = "call simplyselectwhere('" + tabla + "','" + NombreCampo + "','" + DatoCampo + "')";
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
