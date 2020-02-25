using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPMS.gestion.administrator_network.CommonMethods
{
    class SentenciasPro
    {
        /*Metodo que borra La Vlan en la tabla de Vlans y tambien borra la tabla IP asociada     
         * Lo hace en relacion a la BBDD que está usando la aplicacion, que se selecciona en
         * Settings.cs
         */
        public static void Delete_Vlan(string protocolo, string id_vlan, string id_tarea)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                if (protocolo == "IPv4")
                {
                    string query = "CALL update_vlan_log_ipv4('Delete', '" + GlobalParam.IDUser + "', '" + id_vlan + "','" + id_tarea + "');";
                    Sentencias.Bbdd_apply_simple(query);

                }
                if (protocolo == "IPv6")
                {
                    string tablaipv6 = "ipv6_" + id_vlan + "";
                    string query = "CALL update_vlan_log_ipv6('Delete', '" + GlobalParam.IDUser + "','" + id_vlan + "','" + tablaipv6 + "','" + id_tarea + "');";
                    Sentencias.Bbdd_apply_simple(query);
                }
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
        }

        //Método que se encarga de añadir la Vlan  creada a la base de datos
        //el procedure invocado también crea la tabla de rango ip correspondiente al a vlan
      
        public static void Insert_vlan(string protocolo,string tabla, string id_vlan, string id_nombre_vlan, string id_Ubicacion, string id_Vsys, string id_Descripcion,
         string id_DireccionRed, string id_RangoInicio, string id_RangoFin, string id_Mascara, string id_Gateway1,
         string id_Gateway2, string id_Gateway3, string id_Observaciones, string id_Dispositivo,
         string id_Firewall, string id_Entorno, string id_Normativa, string id_Estado, string id_TipoRed,
         string id_Equipos, string id_Clasificacion, string id_Tarea)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {

          
                if (protocolo == "IPv4")
                {
                    string query = "Call insert_vlan_ipv4('" + id_vlan + "','" + id_nombre_vlan + "','" + id_Ubicacion + "','" + id_Vsys + "','" + id_Descripcion + "','" + id_DireccionRed + "','" + id_RangoInicio + "','" + id_RangoFin + "','" + id_Mascara + "','" + id_Gateway1 + "','" + id_Gateway2 + "','" + id_Gateway3 + "','" + id_Observaciones + "','" + id_Dispositivo + "','" + id_Firewall + "','" + id_Entorno + "','" + id_Normativa + "',' " + id_Estado + "','" + id_TipoRed + "','" + id_Equipos + "','" + id_Clasificacion + "','" + id_Tarea + "','" + GlobalParam.IDUser + "')";
                    Sentencias.Bbdd_apply_simple(query);
                }
                if (protocolo == "IPv6")
                {
                    string query = "Call insert_vlan_ipv6('" + tabla + "','" + id_vlan + "','" + id_nombre_vlan + "','" + id_Ubicacion + "','" + id_Vsys + "','" + id_Descripcion + "','" + id_DireccionRed + "','" + id_RangoInicio + "','" + id_RangoFin + "','" + id_Mascara + "','" + id_Gateway1 + "','" + id_Gateway2 + "','" + id_Gateway3 + "','" + id_Observaciones + "','" + id_Dispositivo + "','" + id_Firewall + "','" + id_Entorno + "','" + id_Normativa + "',' " + id_Estado + "','" + id_TipoRed + "','" + id_Equipos + "','" + id_Clasificacion + "','" + id_Tarea + "','" + GlobalParam.IDUser + "')";
                    Sentencias.Bbdd_apply_simple(query);
                }
            }

            if (GlobalParam.BBDD_Type == "SQLServer")
            {

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

                if (protocolo == "IPv4")
                {
                    string query = "CALL update_ip_log_ipv4('Delete', '" + GlobalParam.IDUser + "','" + id_ip + "', '" + id_vlan + "', '" + id_tarea + "');";
                    Sentencias.Bbdd_apply_simple(query);
                }
                if (protocolo == "IPv6")
                {
                    string FormatoVlanIPv6 = "ipv6_" + id_vlan + "";
                    string query = "CALL update_ip_log_ipv6('Delete', '" + GlobalParam.IDUser + "','" + id_ip + "', '" + FormatoVlanIPv6 + "', '" + id_tarea + "');";
                    Sentencias.Bbdd_apply_simple(query);
                }
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
        }
        //Metodo que se encarga de reservar una ip (crear) según el protocolo (IPv4/IPv6) y el tipo de base de datos
        public static void Insert_ip(string protocolo, string id_vlan, string id_Ubicacion, string id_mac, string id_dns, string id_Descripcion, string id_hostnameR,
         string id_hostname, string id_Tarea, string id_ip)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {


                if (protocolo == "IPv4")
                {

                    string query = "CALL insert_ip_ipv4('Create','" + id_vlan + "'," +
                        "'" + id_ip + "','" + id_Ubicacion + "','" + id_mac + "'," +
                        "'" + id_dns + "','" + id_Descripcion + "','" + id_hostnameR + "'," +
                        "'" + id_hostname + "','" + id_Tarea + "','" + GlobalParam.IDUser + "')";
                        Sentencias.Bbdd_apply_simple(query);
                    
                }
                if (protocolo == "vlan_ipv6")
                {
                    string FormatoVlanIPv6 = "ipv6_" + id_vlan + "";
                    string query = "CALL insert_ip_ipv4('Create','" + id_vlan + "'," +
                        "'" + id_ip + "','" + id_Ubicacion + "','" + id_mac + "'," +
                        "'" + id_dns + "','" + id_Descripcion + "','" + id_hostnameR + "'," +
                        "'" + id_hostname + "','" + id_Tarea + "','" + GlobalParam.IDUser + "'," +
                        "'" + FormatoVlanIPv6 + "')";
                    Sentencias.Bbdd_apply_simple(query);
                }
            }

            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }

        }
        //Metodo que se encarga de insertar un nuevo dispositivo en el inventario 
        //ejecuta la sentencia según  el tipo de base de datos
        public static void Insert_inventory(string hostname,string dns, string comments, string ip, string sn,
            string name,string manufacturer, string location, string environment, string domain, string contact
            , string aditional_info, string ports, string other1, string other2, string worder)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call insert_inventory('Create','" + hostname + "'," +
                    "'" + dns + "','" + comments + "','" + ip + "','" + sn + "'," +
                    "'" + name + "','" + manufacturer + "','" + location + "'," +
                    "'" + environment + "','" + domain + "','" + contact + "'," +
                    "'" + aditional_info + "','" + ports + "','" + other1 + "'," +
                    "'" + other2 + "','" + worder + "','" + GlobalParam.IDUser + "') ";

                Sentencias.Bbdd_apply_simple(query);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
        }
        //Metodo que se encarga de BORRAR un  dispositivo en el inventario 
        //ejecuta la sentencia según  el tipo de base de datos
        public static void Delete_inventory(string SN, string worder)
        {
            if (GlobalParam.BBDD_Type == "MySQL")
            {
                string query = "call update_inventory_log('Delete','" + GlobalParam.IDUser + "'," +
                    "'" + SN + "','" + worder + "')";
                Sentencias.Bbdd_apply_simple(query);
            }
            if (GlobalParam.BBDD_Type == "SQLServer")
            {

            }
        }

    }
}
