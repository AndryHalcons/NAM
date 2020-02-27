using MySql.Data.MySqlClient;
using NPMS.gestion.administrator_network.CommonMethods;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network.bbdd_adapt
{
    class mysql_commands
    {
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
        

        //Metodo que hace un select en la BBDD recuperando solamente dos columnas que 
        //mostrará en un Datagridview
        public static void Bbdd_apply_2fields_datagridView(string tabla, string campo1, string campo2, DataGridView Datagrid_Name)
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
        //Metodo que obtiene una fila y valida que existe buscando que una fila tenga
        //dos campos especificos con el contenido exacto
        //Valida las credenciales de usuario a nivel de Aplicacion (LOGGING)
        //Compara el usuario y contraseña con la fila correspondiente al usuario en la BBDD
        public static bool Bbdd_apply_two_fields_exact(string tabla, string campo1, string campo2,
            string datocampo1, string datocampo2)
        {
            string query = "call simplyselectwhere2fields('" + tabla + "','" + campo1 + "','" + campo2 + "','" + datocampo1 + "','" + datocampo2 + "')";
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
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
                MessageBox.Show("Incorrect logging data");
                return false;
            }
        }
        //Metodo que Realiza un SELECT * ALL en las BBDD  
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_all_datagridView(string tabla, DataGridView Datagrid_Name)
        {
                string query = "call simplyselectall('" + tabla + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
        }
        //Metodo que Realiza un SELECT * ALL en las BBDD con ORDER DESC 
        //y  muestra el resultado en un DataGridView (IDEAL PARA LOGS)
        public static void Bbdd_apply_all_Desc_datagridView(string tabla, DataGridView Datagrid_Name)
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
        //Metodo que Realiza las consultas en las BBDD filtrando por el valor EXACTO de un campo 
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_where_datagridView(string tabla, string campo, string datocampo, DataGridView Datagrid_Name)
        {
                string query = "call simplyselectwhere('" + tabla + "','" + campo + "','" + datocampo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                commandDatabase.Fill(ds, tabla);
                Datagrid_Name.DataSource = ds;
                Datagrid_Name.DataMember = tabla;
                databaseConnection.Close();
        }
        //Metodo que Realiza las consultas en las BBDD filtrando por el valor "LIKE" (CADENA) de un campo 
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_wherelike_datagridView(string tabla, string campo, string datocampo, DataGridView Datagrid_Name)
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
        //Metodo que encuentra la vlan correspondiente a una IP y la muestra en un DATAGRIDVIEW
        public static void Bbdd_apply_search_vlan_for_IP(string tabla, string IP, string campoMenor, string campoMayor, DataGridView Datagrid_Name)
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

        //Metodo que encuentra la vlan correspondiente a una IP origen y una IP destino
        //y la muestra en un DATAGRIDVIEW (FAST FIREWALL)
        public static void Bbdd_apply_search_vlan_for_Fast_Firewall(string protocolo, string IPorigen, string IPdestino, DataGridView Datagrid_Name)
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
        //Metodo que inserta en la tabla usuarios los campos correpondientes (usuario,pass,rol)
        public static void Bbdd_apply_create_user(string user, string pass, string rol)

        {

                string query = "call create_user('" + user + "','" + pass + "','" + rol + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandText = query;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
        }
        //Metodo que borra una fila que tenga un campo cuyo valor sea exacto al indicado (Borrar usuarios)
        public static void Bbdd_apply_where_delete(string tabla, string campo, string datocampo)

        {
                string query = "call simply_delete_where('" + tabla + "','" + campo + "','" + datocampo + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandText = query;
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
        }
        //Metodo que actualiza el campo1  al indicado ,siempre que el campo2 del usuario sea exacto al existente.
        //Example (Actualizar el campo "Password (datocampo1)" del usuario "x" (datocampo2)
        public static void Bbdd_apply_where_update(string tabla, string campo1, string campo2,
            string datocampo1, string datocampo2)

        {
                string query = "call symply_where_update('" + tabla + "','" + campo1 + "','" + campo2 + "'" +
                    ",'" + datocampo1 + "','" + datocampo2 + "')";
                MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandText = query;
                commandDatabase.ExecuteNonQuery();
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

        //**************Valida que una tabla existe *************************
        public static bool ValidadorTabla(string NombreTabla)
        {
            string query = "call table_exists('" + NombreTabla + "');";
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
                MessageBox.Show("Vlan " + NombreTabla + " does not exist");
                return false;
            }

        }
        //Valida que una vlan existe Comprueba la id_vlan aportada con el campo Vlan de la tabla
        //Si el return es True es que el dato se encuentra previamente en la base de datos
        public static bool ValidarExistenciaVlan(string id_vlan)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            databaseConnection.Open();
            string query = "call simplyselectwhere('vlan_ipv4','Vlan','" + id_vlan + "')";
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
        public static bool ValidarDatoExistente(string tabla, string campo, string Datoaportado)
        {
            MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
            databaseConnection.Open();
            string query = "call simplyselectwhere('" + tabla + "','" + campo + "','" + Datoaportado + "')";
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
            string query = "call simplyselectwhere('" + tabla + "','" + campo + "','" + Datoaportado + "')";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.Prepare();
            var reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("The " + NombreCampoValidar + " already exists! ");
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
