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
        //Consulta simple en Base de datos
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
            Conexion.ConnectionString = Sentencias.bbdd_connection_data();
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


        //Método que se encarga de añadir la Vlan  creada a la base de datos
        //También invoca dentro de el al metodo que crea las tablas IP, correspondiente a la Vlan
        public static void Insert_vlan(string tabla, string id_vlan, string id_nombre_vlan, string id_Ubicacion, string id_Vsys, string id_Descripcion,
         string id_DireccionRed, string id_RangoInicio, string id_RangoFin, string id_Mascara, string id_Gateway1,
         string id_Gateway2, string id_Gateway3, string id_Observaciones, string id_Dispositivo,
         string id_Firewall, string id_Entorno, string id_Normativa, string id_Estado, string id_TipoRed,
         string id_Equipos, string id_Clasificacion, string id_Tarea, string id_Usuario)
        {
            string query =
                "INSERT INTO `npms`.`"+ tabla + "` (`Vlan`, `Nombre`, `Ubicacion`, `Vsys/balanceador/otro`, `Descripcion`, `Direccion_red`,`Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`, `Gateway2`, `Gateway3`,`Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`,`Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`)" +
                "VALUES('" + id_vlan + "','" + id_nombre_vlan + "','" + id_Ubicacion + "','" + id_Vsys + "','" + id_Descripcion + "','" + id_DireccionRed + "','" + id_RangoInicio + "','" + id_RangoFin + "','" + id_Mascara + "',' " + id_Gateway1 + "','" + id_Gateway2 + "', '" + id_Gateway3 + "','" + id_Observaciones + "','" + id_Dispositivo + "','" + id_Firewall + "','" + id_Entorno + "','" + id_Normativa + "',' " + id_Estado + "', '" + id_TipoRed + "', '" + id_Equipos + "','" + id_Clasificacion + "', '" + id_Tarea + "', '" + id_Usuario + "');";
            Bbdd_apply(tabla, query);
            if (tabla == "IPv4")
            {
                CreartablaIpv4(id_DireccionRed, id_vlan, id_Gateway1, id_Gateway2, id_Gateway3);
            }
            if (tabla == "IPv6")
            {
                CreartablaIpv6(id_DireccionRed, id_vlan, id_Gateway1, id_Gateway2, id_Gateway3);
            }                    
        }


        //Metodo que se encarga del Update (Insertar información) sobre las tablas IP en la base de datos
        public static void Insert_ip(string protocolo, string id_vlan, string id_Ubicacion, string id_mac, string id_dns, string id_Descripcion, string id_hostnameR,
          string id_hostname, string id_Tarea, string id_usuario, string id_ip)
        {
            if (protocolo == "IPv4")
            {
                string queryUpdate = "UPDATE `npms`.`" + id_vlan + "` SET `Ubicacion` = '" + id_Ubicacion + "', `Mac` = '" + id_mac + "', `DNS` = '" + id_dns + "', `Descripcion` = '" + id_Descripcion + "', `Hostname_revisado` = '" + id_hostnameR + "', `Hostname` = '" + id_hostname + "', `Tarea` = '" + id_Tarea + "', `usuario` = '" + id_usuario + "' WHERE (`IP` = '" + id_ip + "');";
                Bbdd_apply(id_vlan, queryUpdate);
            }
            if (protocolo == "IPv6")
            {
                string queryUpdate = "UPDATE `npms`.`ipv6_"+id_vlan+"` SET `Ubicacion` = '" + id_Ubicacion + "', `Mac` = '" + id_mac + "', `DNS` = '" + id_dns + "', `Descripcion` = '" + id_Descripcion + "', `Hostname_revisado` = '" + id_hostnameR + "', `Hostname` = '" + id_hostname + "', `Tarea` = '" + id_Tarea + "', `usuario` = '" + id_usuario + "' WHERE (`IP` = '" + id_ip + "');";
                Bbdd_apply("ipv6_"+id_vlan+"", queryUpdate);
            }
            
        }

        //Metodo que se encarga del Update (Delete/Liberar IP) sobre las tablas ip en la base de datos
        public static void Update_ip(string protocolo, string id_vlan, string id_tarea,string id_usuario,string id_ip)
        {
            if (protocolo == "IPv4")
            {
                string queryDel = "UPDATE `npms`.`" + id_vlan + "` SET `Ubicacion` = NULL, `Mac` = NULL, `DNS` = NULL, `Descripcion` = NULL, `Hostname_revisado` = NULL, `Hostname` = NULL, `Tarea` = '" + id_tarea + "', `usuario` = '" + id_usuario + "' WHERE (`IP` = '" + id_ip + "');";
                Bbdd_apply(id_vlan, queryDel);
            }
            if (protocolo == "IPv6")
            {
                string queryDel = "UPDATE `npms`.`ipv6_"+id_vlan+"` SET `Ubicacion` = NULL, `Mac` = NULL, `DNS` = NULL, `Descripcion` = NULL, `Hostname_revisado` = NULL, `Hostname` = NULL, `Tarea` = '" + id_tarea + "', `usuario` = '" + id_usuario + "' WHERE (`IP` = '" + id_ip + "');";
                Bbdd_apply("ipv6_"+id_vlan+"", queryDel);
            }
            
        }

        //Metodo que borra La Vlan en la tabla de Vlans y tambien borra la tabla IP asociada     
        public static void Delete_Vlan(string protocolo, string id_vlan)
        {
            if (protocolo == "IPv4")
            {
                string query2 = "CALL update_vlan_log_ipv4('Delete', '"+ GlobalParam.IDUser + "', '"+id_vlan+"');";
                string query3 = "DROP TABLE IF EXISTS `" + id_vlan + "`;";
                Bbdd_apply_simple(query2);
                Bbdd_apply(id_vlan,query3);
            }
            if (protocolo == "IPv6")
            {
                string tablaipv6 = "ipv6_"+id_vlan+"";
                string query2 = "CALL update_vlan_log_ipv6('Delete', '" + GlobalParam.IDUser + "','" + id_vlan + "','"+tablaipv6+"');";
                string query3 = "DROP TABLE IF EXISTS `" + tablaipv6 + "`;";
                Bbdd_apply_simple(query2);
                Bbdd_apply(id_vlan, query3);
            }
            
            
        }








        //**************-------Este metodo genera la tabla ipv4 correspondiente a la vlan creada.---------******************
        //Tambien rellena la tabla insertando el numero de ips del rango
        public static void CreartablaIpv4(string id_DireccionRed, string id_vlan, string Gateway1, string Gateway2, string Gateway3)
        {
            //Creacion de la tabla de red
            string query = "CREATE TABLE `npms`.`" + id_vlan + "` (`ID` INT NOT NULL AUTO_INCREMENT,`Vlan` INT NOT NULL,`IP` VARCHAR(30) NOT NULL,`Ubicacion` VARCHAR(150) NULL,`Mac` VARCHAR(30) NULL,`DNS` VARCHAR(150) NULL,`Descripcion` VARCHAR(150) NULL,`Hostname_revisado` VARCHAR(150) NULL,`Hostname` VARCHAR(150) NULL,`Fecha_modificacion` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  ON UPDATE CURRENT_TIMESTAMP,`Tarea` VARCHAR(150) NULL,`usuario` VARCHAR(150) NULL,PRIMARY KEY (`ID`,`IP`),UNIQUE INDEX `IP_UNIQUE` (`IP` ASC) VISIBLE);";
            Bbdd_apply(id_vlan, query);
            //Inserción de la enumeración IPs del rango
            foreach (var ip in IPAddressRange.Parse(id_DireccionRed))
            {
                string query2 = "INSERT INTO `npms`.`" + id_vlan + "` (`Vlan`, `IP`) VALUES ('" + id_vlan + "', '" + ip + "');";
                Bbdd_apply(id_vlan, query2);
            }
            //INSERTA en la tabla los Gateways
            //Inserccion del Gateway1 (obligatorio)
            string query3 = "UPDATE `npms`.`" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway1', `Hostname` = 'Gateway1' WHERE  (`IP` = '" + Gateway1 + "');";
            Bbdd_apply(id_vlan, query3);
            //Comprueba que Gateway2 y Gateway3 tienen algún valor, si lo tienen los inserta.
            bool valor_gateway2 = Common.ValidadorCamposVacios_SinMensaje(Gateway2);
            if (valor_gateway2 == true)
            {
                string query4 = "UPDATE `npms`.`" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway2', `Hostname` = 'Gateway2' WHERE  (`IP` = '" + Gateway2 + "');";
                Bbdd_apply(id_vlan, query4);
            }
            bool valor_gateway3 = Common.ValidadorCamposVacios_SinMensaje(Gateway3);
            if (valor_gateway3 == true)
            {
                string query5 = "UPDATE `npms`.`" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway3', `Hostname` = 'Gateway3' WHERE  (`IP` = '" + Gateway3 + "');";
                Bbdd_apply(id_vlan, query5);
            }
            //Borra de la tabla la direccion de red y broadcast
            string queryBorrarRed = "DELETE FROM `npms`.`" + id_vlan + "` WHERE (`ID` = '1');";
            Bbdd_apply(id_vlan, queryBorrarRed);
            string queryBorrarBroadcast = "Delete FROM npms.`" + id_vlan + "` order by  ID desc limit 1; ";
            Bbdd_apply(id_vlan, queryBorrarBroadcast);
        }


        //****************************************************************************
        //***********Crea una tabla de red ipv6****************************************
        ///***************************************************************************
        

        public static void CreartablaIpv6(string id_DireccionRed, string id_vlan, string Gateway1, string Gateway2, string Gateway3)
        {
            //Creacion de la tabla de red
            string query = "CREATE TABLE `npms`.`ipv6_" + id_vlan + "` (`ID` INT NOT NULL AUTO_INCREMENT,`Vlan` INT NOT NULL,`IP` VARCHAR(30) NOT NULL,`Ubicacion` VARCHAR(150) NULL,`Mac` VARCHAR(30) NULL,`DNS` VARCHAR(150) NULL,`Descripcion` VARCHAR(150) NULL,`Hostname_revisado` VARCHAR(150) NULL,`Hostname` VARCHAR(150) NULL,`Fecha_modificacion` TIMESTAMP DEFAULT CURRENT_TIMESTAMP  ON UPDATE CURRENT_TIMESTAMP,`Tarea` VARCHAR(150) NULL,`usuario` VARCHAR(150) NULL,PRIMARY KEY (`ID`,`IP`),UNIQUE INDEX `IP_UNIQUE` (`IP` ASC) VISIBLE);";
            Bbdd_apply(id_vlan, query);
            //Inserción de la enumeración IPs del rango
            foreach (var ip in IPAddressRange.Parse(id_DireccionRed))
            {
                string query2 = "INSERT INTO `npms`.`ipv6_" + id_vlan + "` (`Vlan`, `IP`) VALUES ('" + id_vlan + "', '" + ip + "');";
                Bbdd_apply(id_vlan, query2);
            }
            //INSERTA en la tabla los Gateways
            //Inserccion del Gateway1 (obligatorio)
            string query3 = "UPDATE `npms`.`ipv6_" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway1', `Hostname` = 'Gateway1' WHERE  (`IP` = '" + Gateway1 + "');";
            Bbdd_apply(id_vlan, query3);
            //Comprueba que Gateway2 y Gateway3 tienen algún valor, si lo tienen los inserta.
            bool valor_gateway2 = Common.ValidadorCamposVacios_SinMensaje(Gateway2);
            if (valor_gateway2 == true)
            {
                string query4 = "UPDATE `npms`.`ipv6_" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway2', `Hostname` = 'Gateway2' WHERE  (`IP` = '" + Gateway2 + "');";
                Bbdd_apply(id_vlan, query4);
            }
            bool valor_gateway3 = Common.ValidadorCamposVacios_SinMensaje(Gateway3);
            if (valor_gateway3 == true)
            {
                string query5 = "UPDATE `npms`.`ipv6_" + id_vlan + "` SET `Descripcion` = 'Reservado', `Hostname_revisado` = 'Gateway3', `Hostname` = 'Gateway3' WHERE  (`IP` = '" + Gateway3 + "');";
                Bbdd_apply(id_vlan, query5);
            }
            //Borra de la tabla la direccion de red
            string queryBorrarRed = "DELETE FROM `npms`.`ipv6_" + id_vlan + "` WHERE (`ID` = '1');";
            Bbdd_apply(id_vlan, queryBorrarRed);
        }












    }
}
