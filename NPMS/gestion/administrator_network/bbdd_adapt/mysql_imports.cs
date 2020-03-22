using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NPMS.gestion.administrator_network.CommonMethods;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.Net;

namespace NPMS.gestion.administrator_network.bbdd_adapt
{
    class mysql_imports
    {
        public static void Import_Patching(Label url_Excel, Label labelCount)
        {
           
            ////////////////OPEN EXCEL/////////////////
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@url_Excel.Text);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range range = xlWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            int marcador = rows;
            string workOrder = "" + GlobalParam.IDUser + "_Import_Data";
            for (int i = 2; i <= rows; i++)
            {
                marcador = marcador - 1;
                labelCount.Text = marcador.ToString();
                string building = range.Cells[i, 1].Value2.ToString();
                string floor = range.Cells[i, 2].Value2.ToString();
                string closet = range.Cells[i, 3].Value2.ToString();
                string panel = range.Cells[i, 4].Value2.ToString();
                string panel_port = range.Cells[i, 5].Value2.ToString();
                string stack = range.Cells[i, 6].Value2.ToString();
                string switch_ = range.Cells[i, 7].Value2.ToString();
                string switchport = range.Cells[i, 8].Value2.ToString();
                string interfaz = range.Cells[i, 9].Value2.ToString();
                string link = range.Cells[i, 10].Value2.ToString();
                string speed = range.Cells[i, 11].Value2.ToString();
                string duplex = range.Cells[i, 12].Value2.ToString();
                string type = range.Cells[i, 13].Value2.ToString();
                string vlan = range.Cells[i, 14].Value2.ToString();
                string description = range.Cells[i, 15].Value2.ToString();
                string ip_switch = range.Cells[i, 16].Value2.ToString();
                //////////BBDD INSERT///////////////////////////
                Sentencias.Insert_Patching(building, floor, closet, panel, panel_port, stack, switch_,
                        switchport, interfaz, link, speed, duplex, type, vlan, description, ip_switch, workOrder);
            }
            /////////////////CLOSE EXCEL/////////////////
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show("Import Completed");

        
         }
        public static void Import_Inventory(Label url_Excel, Label labelCount)
        {
            ////////////////OPEN EXCEL/////////////////
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@url_Excel.Text);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range range = xlWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            int marcador = rows;
            string workOrder = "" + GlobalParam.IDUser + "_Import_Data";
            for (int i = 2; i <= rows; i++)
            {
                marcador = marcador - 1;
                labelCount.Text = marcador.ToString();
                string hostname = range.Cells[i, 1].Value2.ToString();
                string dns = range.Cells[i, 2].Value2.ToString();
                string comments = range.Cells[i, 3].Value2.ToString();
                string ip = range.Cells[i, 4].Value2.ToString();
                string sn = range.Cells[i, 5].Value2.ToString();
                string name = range.Cells[i, 6].Value2.ToString();
                string manufacturer = range.Cells[i, 7].Value2.ToString();
                string location = range.Cells[i, 8].Value2.ToString();
                string environment = range.Cells[i, 9].Value2.ToString();
                string domain = range.Cells[i, 10].Value2.ToString();
                string contact = range.Cells[i, 11].Value2.ToString();
                string aditional_info = range.Cells[i, 12].Value2.ToString();
                string ports = range.Cells[i, 13].Value2.ToString();
                string other1 = range.Cells[i, 14].Value2.ToString();
                string other2 = range.Cells[i, 15].Value2.ToString();
                //////////BBDD INSERT///////////////////////////
                Sentencias.Insert_inventory(hostname, dns, comments, ip, sn, name, manufacturer,
                    location, environment, domain, contact, aditional_info, ports, other1, other2,
                    workOrder);
            }
            /////////////////CLOSE EXCEL/////////////////
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show("Import Completed");
        }



        public static void Import_Vlan_IPv4(Label url_Excel, Label labelCount)
        {
          
            ////////////////OPEN EXCEL/////////////////
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@url_Excel.Text);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range range = xlWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            int marcador = rows;
            string workOrder = "" + GlobalParam.IDUser + "_Import_Data";          
            for (int i = 2; i <= rows; i++)
            {
                marcador = marcador - 1;
                labelCount.Text = marcador.ToString();
                string id_vlan = range.Cells[i, 1].Value2.ToString();
                string id_nombre_vlan = range.Cells[i, 2].Value2.ToString();
                string id_Ubicacion = range.Cells[i, 3].Value2.ToString();
                string id_Vsys = range.Cells[i, 4].Value2.ToString();
                string id_Descripcion = range.Cells[i, 5].Value2.ToString();
                string id_DireccionRed = range.Cells[i, 6].Value2.ToString();
                string id_Gateway1 = range.Cells[i, 7].Value2.ToString();
                string id_Observaciones = range.Cells[i, 8].Value2.ToString();
                string id_Dispositivo = range.Cells[i, 9].Value2.ToString();
                string id_Firewall = range.Cells[i, 10].Value2.ToString();
                string id_Entorno = range.Cells[i, 11].Value2.ToString();
                string id_Normativa = range.Cells[i, 12].Value2.ToString();
                string id_Estado = range.Cells[i, 13].Value2.ToString();
                string id_TipoRed = range.Cells[i, 14].Value2.ToString();
                string id_Equipos = range.Cells[i, 15].Value2.ToString();
                string id_Clasificacion = range.Cells[i, 16].Value2.ToString();
                //////////BBDD INSERT///////////////////////////
                ///
                IPNetwork ipnetwork = IPNetwork.Parse(id_DireccionRed);
                string id_Mascara = Convert.ToString(ipnetwork.Netmask);
                string id_RangoInicio = Convert.ToString(ipnetwork.FirstUsable);
                string id_RangoFin = Convert.ToString(ipnetwork.LastUsable);               
                string id_Broadcast = Convert.ToString(ipnetwork.Broadcast);

                Sentencias.Insert_vlan_IPv4(id_vlan, id_nombre_vlan, id_Ubicacion, id_Vsys, id_Descripcion,
                     id_DireccionRed, id_RangoInicio, id_RangoFin, id_Mascara, id_Gateway1,
                     id_Broadcast, id_Observaciones, id_Dispositivo,
                     id_Firewall, id_Entorno, id_Normativa, id_Estado, id_TipoRed,
                     id_Equipos, id_Clasificacion, workOrder);
                
     

                
            }
            /////////////////CLOSE EXCEL/////////////////
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show("Import Completed");
        }


        public static void Import_IP_IPv4(Label url_Excel, Label labelCount)
        {

            ////////////////OPEN EXCEL/////////////////
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@url_Excel.Text);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range range = xlWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            int marcador = rows;
            string protocolo = "IPv4";
            string workOrder = "" + GlobalParam.IDUser + "_Import_Data";
            //REcorremos el EXCEL
            for (int i = 2; i <= rows; i++)
            {
                marcador = marcador - 1;
                labelCount.Text = marcador.ToString();
                string id_ip = range.Cells[i, 1].Value2.ToString();
                string id_Location = range.Cells[i, 2].Value2.ToString();
                string id_Mac = range.Cells[i, 3].Value2.ToString();
                string id_DNS = range.Cells[i, 4].Value2.ToString();
                string id_Descripcion = range.Cells[i, 5].Value2.ToString();
                string id_HostnameRevisado = range.Cells[i, 6].Value2.ToString();
                string id_Hostname= range.Cells[i, 7].Value2.ToString();
                //obtiene la vlan de la ip, para insertarla en la vlan correcta
                string id_vlan = Sentencias.Dato_campo_string_vlan_for_ip_ipv4(id_ip);
                
               
                    //////////BBDD INSERT///////////////////////////
                    Sentencias.Insert_ip(protocolo, id_vlan, id_Location, id_Mac, id_DNS, id_Descripcion, id_HostnameRevisado,
                        id_Hostname, workOrder, id_ip);
                          
            }
            /////////////////CLOSE EXCEL/////////////////
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show("Import Completed");
        }


        public static void Import_IP_IPv6(Label url_Excel, Label labelCount)
        {

            ////////////////OPEN EXCEL/////////////////
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@url_Excel.Text);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range range = xlWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            int marcador = rows;
            string protocolo = "IPv6";
            string workOrder = "" + GlobalParam.IDUser + "_Import_Data";
            //REcorremos el EXCEL
            for (int i = 2; i <= rows; i++)
            {
                marcador = marcador - 1;
                labelCount.Text = marcador.ToString();
                string id_ip = range.Cells[i, 1].Value2.ToString();
                string id_Location = range.Cells[i, 2].Value2.ToString();
                string id_Mac = range.Cells[i, 3].Value2.ToString();
                string id_DNS = range.Cells[i, 4].Value2.ToString();
                string id_Descripcion = range.Cells[i, 5].Value2.ToString();
                string id_HostnameRevisado = range.Cells[i, 6].Value2.ToString();
                string id_Hostname = range.Cells[i, 7].Value2.ToString();
                //obtiene la vlan de la ip, para insertarla en la vlan correcta
                string id_vlan = Sentencias.Dato_campo_string_vlan_for_ip_ipv4(id_ip);


                //////////BBDD INSERT///////////////////////////
                Sentencias.Insert_ip(protocolo, id_vlan, id_Location, id_Mac, id_DNS, id_Descripcion, id_HostnameRevisado,
                    id_Hostname, workOrder, id_ip);

            }
            /////////////////CLOSE EXCEL/////////////////
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            MessageBox.Show("Import Completed");
        }
    }
}
