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
                MessageBox.Show("Vlan " + NombreTabla + " does not exist");
                return false;
            }

        }
        //Valida que una vlan existe Comprueba la id_vlan aportada con el campo Vlan de la tabla
        //Si el return es True es que el dato se encuentra previamente en la base de datos
        public static bool ValidarExistenciaVlan(string id_vlan)
        {
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
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
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
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
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
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

        /*Metodo que borra La Vlan en la tabla de Vlans y tambien borra la tabla IP asociada     
        * Lo hace en relacion a la BBDD que está usando la aplicacion, que se selecciona en
        * Settings.cs
        */
        public static void Delete_Vlan(string protocolo, string id_vlan, string id_tarea)
        {

                if (protocolo == "IPv4")
                {
                    string query = "CALL update_vlan_log_ipv4('Delete', '" + GlobalParam.IDUser + "', '" + id_vlan + "','" + id_tarea + "');";
                    Bbdd_apply_simple(query);

                }
                if (protocolo == "IPv6")
                {
                    string tablaipv6 = "ipv6_" + id_vlan + "";
                    string query = "CALL update_vlan_log_ipv6('Delete', '" + GlobalParam.IDUser + "','" + id_vlan + "','" + tablaipv6 + "','" + id_tarea + "');";
                    Bbdd_apply_simple(query);
                }           
        }

        //Método que se encarga de añadir la Vlan  creada a la base de datos
        //el procedure invocado también crea la tabla de rango ip correspondiente al a vlan

        public static void Insert_vlan(string protocolo, string tabla, string id_vlan, string id_nombre_vlan, string id_Ubicacion, string id_Vsys, string id_Descripcion,
         string id_DireccionRed, string id_RangoInicio, string id_RangoFin, string id_Mascara, string id_Gateway1,
         string id_Gateway2, string id_Gateway3, string id_Observaciones, string id_Dispositivo,
         string id_Firewall, string id_Entorno, string id_Normativa, string id_Estado, string id_TipoRed,
         string id_Equipos, string id_Clasificacion, string id_Tarea)
        {
                if (protocolo == "IPv4")
                {
                    string query = "Call insert_vlan_ipv4('" + id_vlan + "','" + id_nombre_vlan + "','" + id_Ubicacion + "','" + id_Vsys + "','" + id_Descripcion + "','" + id_DireccionRed + "','" + id_RangoInicio + "','" + id_RangoFin + "','" + id_Mascara + "','" + id_Gateway1 + "','" + id_Gateway2 + "','" + id_Gateway3 + "','" + id_Observaciones + "','" + id_Dispositivo + "','" + id_Firewall + "','" + id_Entorno + "','" + id_Normativa + "',' " + id_Estado + "','" + id_TipoRed + "','" + id_Equipos + "','" + id_Clasificacion + "','" + id_Tarea + "','" + GlobalParam.IDUser + "')";
                    Bbdd_apply_simple(query);
                }
                if (protocolo == "IPv6")
                {
                    string query = "Call insert_vlan_ipv6('" + tabla + "','" + id_vlan + "','" + id_nombre_vlan + "','" + id_Ubicacion + "','" + id_Vsys + "','" + id_Descripcion + "','" + id_DireccionRed + "','" + id_RangoInicio + "','" + id_RangoFin + "','" + id_Mascara + "','" + id_Gateway1 + "','" + id_Gateway2 + "','" + id_Gateway3 + "','" + id_Observaciones + "','" + id_Dispositivo + "','" + id_Firewall + "','" + id_Entorno + "','" + id_Normativa + "',' " + id_Estado + "','" + id_TipoRed + "','" + id_Equipos + "','" + id_Clasificacion + "','" + id_Tarea + "','" + GlobalParam.IDUser + "')";
                    Bbdd_apply_simple(query);
                }
        }


        /*Metodo que se encarga del (Delete/Liberar IP) sobre las tablas ip en la base de datos
         * segun el protoclo (IPv4/IPv6) y en relacion a la BBDD que está usando la aplicacion, 
         * que se selecciona en
         * Settings.cs
         */
        public static void Delete_ip(string protocolo, string id_vlan, string id_tarea, string id_ip)
        {
                if (protocolo == "IPv4")
                {
                    string query = "CALL update_ip_log_ipv4('Delete', '" + GlobalParam.IDUser + "','" + id_ip + "', '" + id_vlan + "', '" + id_tarea + "');";
                    Bbdd_apply_simple(query);
                }
                if (protocolo == "IPv6")
                {
                    string FormatoVlanIPv6 = "ipv6_" + id_vlan + "";
                    string query = "CALL update_ip_log_ipv6('Delete', '" + GlobalParam.IDUser + "','" + id_ip + "', '" + FormatoVlanIPv6 + "', '" + id_tarea + "');";
                    Bbdd_apply_simple(query);
                }          
        }
        //Metodo que se encarga de reservar una ip (crear) según el protocolo (IPv4/IPv6) y el tipo de base de datos
        public static void Insert_ip(string protocolo, string id_vlan, string id_Ubicacion, string id_mac, string id_dns, string id_Descripcion, string id_hostnameR,
         string id_hostname, string id_Tarea, string id_ip)
        {
                if (protocolo == "IPv4")
                {

                    string query = "CALL insert_ip_ipv4('Create','" + id_vlan + "'," +
                        "'" + id_ip + "','" + id_Ubicacion + "','" + id_mac + "'," +
                        "'" + id_dns + "','" + id_Descripcion + "','" + id_hostnameR + "'," +
                        "'" + id_hostname + "','" + id_Tarea + "','" + GlobalParam.IDUser + "')";
                    Bbdd_apply_simple(query);

                }
                if (protocolo == "vlan_ipv6")
                {
                    string FormatoVlanIPv6 = "ipv6_" + id_vlan + "";
                    string query = "CALL insert_ip_ipv6('Create','" + id_vlan + "'," +
                        "'" + id_ip + "','" + id_Ubicacion + "','" + id_mac + "'," +
                        "'" + id_dns + "','" + id_Descripcion + "','" + id_hostnameR + "'," +
                        "'" + id_hostname + "','" + id_Tarea + "','" + GlobalParam.IDUser + "'," +
                        "'" + FormatoVlanIPv6 + "')";
                    Bbdd_apply_simple(query);
                }          
        }
        //Metodo que se encarga de insertar un nuevo dispositivo en el inventario 
        //ejecuta la sentencia según  el tipo de base de datos
        public static void Insert_inventory(string hostname, string dns, string comments, string ip, string sn,
            string name, string manufacturer, string location, string environment, string domain, string contact
            , string aditional_info, string ports, string other1, string other2, string worder)
        {

                string query = "call insert_inventory('Create','" + hostname + "'," +
                    "'" + dns + "','" + comments + "','" + ip + "','" + sn + "'," +
                    "'" + name + "','" + manufacturer + "','" + location + "'," +
                    "'" + environment + "','" + domain + "','" + contact + "'," +
                    "'" + aditional_info + "','" + ports + "','" + other1 + "'," +
                    "'" + other2 + "','" + worder + "','" + GlobalParam.IDUser + "') ";

                Bbdd_apply_simple(query);
            

        }
        //Metodo que se encarga de BORRAR un  dispositivo en el inventario 
        //ejecuta la sentencia según  el tipo de base de datos
        public static void Delete_inventory(string SN, string worder)
        {
                string query = "call update_inventory_log('Delete','" + GlobalParam.IDUser + "'," +
                    "'" + SN + "','" + worder + "')";
                Bbdd_apply_simple(query);
            
        }
        //Metodo que obtiene todos los campos de una columna y borra los duplicados (select DISTINCT)
        //Los carga en un listbox (ideal para combobox PATCHING)
        public static void Select_distinct(string tabla,string campo, ComboBox ListboxName)
        {
            string query = "call select_distinct('" + tabla + "','" + campo + "')";
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
            databaseConnection.Open();
            MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
            DataTable dt = new DataTable();
            commandDatabase.Fill(dt);
            ListboxName.DataSource = dt;
            ListboxName.DisplayMember = campo;
            ListboxName.ValueMember = campo;
            databaseConnection.Close();
        }
        //Metodo que obtiene la fila solicitada en PATCHING y lo muestra en un datagridview
        public static void Select_patching(string building,string floor,string closet,string panel,string panel_port, DataGridView Datagrid_Name)
        {
            string query = "call select_patching('" + building + "','" + floor + "','" + closet + "','" + panel + "','" + panel_port + "')";
            MySqlConnection databaseConnection = new MySqlConnection(bbdd_connection_data());
            databaseConnection.Open();
            MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
            DataSet ds = new DataSet();
            commandDatabase.Fill(ds, "patching");
            Datagrid_Name.DataSource = ds;
            Datagrid_Name.DataMember = "patching";
            databaseConnection.Close();
        }
    }
}
