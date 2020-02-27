using MySql.Data.MySqlClient;
using NetTools;
using NPMS.gestion.administrator_network.bbdd_adapt;
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
                string conexion = mysql_commands.bbdd_connection_data();
                return conexion;                                    
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
                mysql_commands.Bbdd_apply(nombre_tabla, query);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply(nombre_tabla, query);
            }
        }       
        //Consulta simple en Base de datos con query
        public static void Bbdd_apply_simple(string query)

        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_simple(query);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_simple(query);
            }
        }
        //Metodo que hace un select en la BBDD recuperando solamente dos columnas que 
        //mostrará en un Datagridview
        public static void Bbdd_apply_2fields_datagridView(string tabla, string campo1, string campo2, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_2fields_datagridView(tabla,campo1,campo2,Datagrid_Name);             
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_2fields_datagridView(tabla, campo1, campo2, Datagrid_Name);
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
                mysql_commands.Bbdd_apply_all_datagridView(tabla, Datagrid_Name);     
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_all_datagridView(tabla, Datagrid_Name);
            }
        }
        //Metodo que Realiza un SELECT * ALL en las BBDD con ORDER DESC 
        //y  muestra el resultado en un DataGridView (IDEAL PARA LOGS)
        public static void Bbdd_apply_all_Desc_datagridView(string tabla, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_all_Desc_datagridView(tabla, Datagrid_Name);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_all_Desc_datagridView(tabla, Datagrid_Name);
            }
        }
        //Metodo que Realiza las consultas en las BBDD filtrando por el valor EXACTO de un campo 
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_where_datagridView(string tabla, string campo,string datocampo, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_where_datagridView(tabla, campo, datocampo, Datagrid_Name);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_where_datagridView(tabla, campo, datocampo, Datagrid_Name);
            }
        }
        //Metodo que Realiza las consultas en las BBDD filtrando por el valor "LIKE" (CADENA) de un campo 
        //y  muestra el resultado en un DataGridView
        public static void Bbdd_apply_wherelike_datagridView(string tabla, string campo, string datocampo, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_wherelike_datagridView(tabla, campo, datocampo, Datagrid_Name);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_wherelike_datagridView(tabla, campo, datocampo, Datagrid_Name);
            }
        }
        //Metodo que encuentra la vlan correspondiente a una IP y la muestra en un DATAGRIDVIEW
        public static void Bbdd_apply_search_vlan_for_IP(string tabla, string IP, string campoMenor, string campoMayor, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_search_vlan_for_IP(tabla, IP, campoMenor, campoMayor, Datagrid_Name);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_search_vlan_for_IP(tabla, IP, campoMenor, campoMayor, Datagrid_Name);
            }
        }
        //Metodo que encuentra la vlan correspondiente a una IP origen y una IP destino
        //y la muestra en un DATAGRIDVIEW (FAST FIREWALL)
        public static void Bbdd_apply_search_vlan_for_Fast_Firewall(string protocolo, string IPorigen, string IPdestino, DataGridView Datagrid_Name)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_search_vlan_for_Fast_Firewall(protocolo, IPorigen, IPdestino, Datagrid_Name);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_search_vlan_for_Fast_Firewall(protocolo, IPorigen, IPdestino, Datagrid_Name);
            }
        }
        //Metodo que inserta en la tabla usuarios los campos correpondientes (usuario,pass,rol)
        public static void Bbdd_apply_create_user(string user, string pass, string rol)

        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_create_user(user, pass, rol);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_create_user(user, pass, rol);
            }
        }
        //Metodo que borra una fila que tenga un campo cuyo valor sea exacto al indicado (Borrar usuarios)
        public static void Bbdd_apply_where_delete(string tabla, string campo, string datocampo)

        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_where_delete(tabla, campo, datocampo);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_where_delete(tabla, campo, datocampo);
            }
        }
        //Metodo que actualiza el campo1  al indicado ,siempre que el campo2 del usuario sea exacto al existente.
        //Example (Actualizar el campo "Password (datocampo1)" del usuario "x" (datocampo2)
        public static void Bbdd_apply_where_update(string tabla, string campo1, string campo2, 
            string datocampo1, string datocampo2)

        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Bbdd_apply_where_update(tabla, campo1, campo2,datocampo1,datocampo2);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Bbdd_apply_where_update(tabla, campo1, campo2, datocampo1, datocampo2);
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

        //**************Valida que una tabla existe *************************
        public static bool ValidadorTabla(string NombreTabla)
        {
            /*
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                //mysql_commands.ValidadorTabla(NombreTabla);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
            */
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
            /*
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                //mysql_commands.ValidarExistenciaVlan(id_vlan);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
            */
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
            /*
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                //mysql_commands.ValidarDatoExistente(tabla, campo, Datoaportado);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
            */
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
            /*
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                //mysql_commands.ValidarDatoExistenteConMensaje(tabla, campo, Datoaportado, NombreCampoValidar);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
            */
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
        /*Metodo que borra La Vlan en la tabla de Vlans y tambien borra la tabla IP asociada     
        * Lo hace en relacion a la BBDD que está usando la aplicacion, que se selecciona en
        * Settings.cs
        */
        public static void Delete_Vlan(string protocolo, string id_vlan, string id_tarea)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                    mysql_commands.Delete_Vlan(protocolo, id_vlan, id_tarea);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Delete_Vlan(protocolo, id_vlan, id_tarea);
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
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Insert_vlan(protocolo, tabla, id_vlan, id_nombre_vlan, id_Ubicacion, id_Vsys, id_Descripcion,
                     id_DireccionRed, id_RangoInicio, id_RangoFin, id_Mascara, id_Gateway1,
                     id_Gateway2, id_Gateway3, id_Observaciones, id_Dispositivo,
                     id_Firewall, id_Entorno, id_Normativa, id_Estado, id_TipoRed,
                     id_Equipos, id_Clasificacion, id_Tarea);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                /*sqlserver_commands.Insert_vlan(protocolo, tabla, id_vlan, id_nombre_vlan, id_Ubicacion, id_Vsys, id_Descripcion,
                     id_DireccionRed, id_RangoInicio, id_RangoFin, id_Mascara, id_Gateway1,
                     id_Gateway2, id_Gateway3, id_Observaciones, id_Dispositivo,
                     id_Firewall, id_Entorno, id_Normativa, id_Estado, id_TipoRed,
                     id_Equipos, id_Clasificacion, id_Tarea);*/
            }
        }


        /*Metodo que se encarga del (Delete/Liberar IP) sobre las tablas ip en la base de datos
         * segun el protoclo (IPv4/IPv6) y en relacion a la BBDD que está usando la aplicacion, 
         * que se selecciona en
         * Settings.cs
         */
                public static void Delete_ip(string protocolo, string id_vlan, string id_tarea, string id_ip)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Delete_ip(protocolo, id_vlan, id_tarea, id_ip);  
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Delete_ip(protocolo, id_vlan, id_tarea, id_ip);
            }
        }
        //Metodo que se encarga de reservar una ip (crear) según el protocolo (IPv4/IPv6) y el tipo de base de datos
        public static void Insert_ip(string protocolo, string id_vlan, string id_Ubicacion, string id_mac, string id_dns, string id_Descripcion, string id_hostnameR,
         string id_hostname, string id_Tarea, string id_ip)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {

                mysql_commands.Insert_ip(protocolo, id_vlan, id_Ubicacion, id_mac, id_dns, id_Descripcion,
                    id_hostnameR, id_hostname, id_Tarea, id_ip);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                /*sqlserver_commands.Insert_ip(protocolo, id_vlan, id_Ubicacion, id_mac, id_dns, id_Descripcion,
                   id_hostnameR, id_hostname, id_Tarea, id_ip);*/
            }

        }
        //Metodo que se encarga de insertar un nuevo dispositivo en el inventario 
        //ejecuta la sentencia según  el tipo de base de datos
        public static void Insert_inventory(string hostname, string dns, string comments, string ip, string sn,
            string name, string manufacturer, string location, string environment, string domain, string contact
            , string aditional_info, string ports, string other1, string other2, string worder)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Insert_inventory(hostname, dns, comments, ip, sn, name, manufacturer,
                     location, environment, domain, contact, aditional_info, ports, other1, other2,
                     worder);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                /*sqlserver_commands.Insert_inventory(hostname, dns, comments, ip, sn, name, manufacturer,
                     location, environment, domain, contact, aditional_info, ports, other1, other2,
                     worder);*/
            }
        }
        //Metodo que se encarga de BORRAR un  dispositivo en el inventario 
        //ejecuta la sentencia según  el tipo de base de datos
        public static void Delete_inventory(string SN, string worder)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                mysql_commands.Delete_inventory(SN, worder);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {
                //sqlserver_commands.Delete_inventory(SN, worder);
            }
        }


















    }
}
