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

namespace NPMS.gestion.administrator_network
{
    public partial class ImportData : Form
    {
        public ImportData()
        {
            InitializeComponent();
            listBoxVlan.SelectedIndex = 0;
            listBoxIP.SelectedIndex = 0;
        }
        // Esta parte selecciona los EXCEL
        //
        //
        private void ButtonAbrirExcelVlan_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.Title = "Open Excel File";
            Dialogo.Filter = "Excel Files | *.xls;*xlsx";
            Dialogo.InitialDirectory = @"C:\";
            if (Dialogo.ShowDialog()== DialogResult.OK)
            {
                labelVlan.Text = Dialogo.FileName;
            }
            
        }
        private void ButtonAbrirExcelIp_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.Title = "Open Excel File";
            Dialogo.Filter = "Excel Files | *.xls;*xlsx";
            Dialogo.InitialDirectory = @"C:\";
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                labelIP.Text = Dialogo.FileName;
            }
            
        }
        private void ButtonOpenExcelInventory_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.Title = "Open Excel File";
            Dialogo.Filter = "Excel Files | *.xls;*xlsx";
            Dialogo.InitialDirectory = @"C:\";
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                labelInventory.Text = Dialogo.FileName;
            }
        }
        private void ButtonOpenExcelPatching_Click(object sender, EventArgs e)
        {

            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.Title = "Open Excel File";
            Dialogo.Filter = "Excel Files | *.xls;*xlsx";
            Dialogo.InitialDirectory = @"C:\";
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                labelPatching.Text = Dialogo.FileName;
            }    
        }

        //Esta parte importa los datos

        private void ButtonProcesarExcelVlan_Click(object sender, EventArgs e)
        { 
            
            /*
               MySqlConnection conn = new MySqlConnection(Sentencias.bbdd_connection_data());
               conn.Open();
               MySqlCommand comm = conn.CreateCommand();
                bool ipv4;
                                      
               Excel.Application xlApp = new Excel.Application();
               Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(labelExcelNameVlan.Text);
               Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
               Excel.Range range = xlWorksheet.UsedRange;
               int rows = range.Rows.Count;
               int cols = range.Columns.Count;
               for (int i = 1; i <= rows; i++)
                   {
                     comm.Parameters.Clear();
                     comm.Parameters.AddWithValue("@vlan", range.Cells[i, 1].Value2.ToString());
                     comm.Parameters.AddWithValue("@nombre", range.Cells[i, 2].Value2.ToString());
                     comm.Parameters.AddWithValue("@ubicacion", range.Cells[i, 3].Value2.ToString());
                     comm.Parameters.AddWithValue("@vsys/balanceador/otro", range.Cells[i, 4].Value2.ToString());
                     comm.Parameters.AddWithValue("@descripcion", range.Cells[i, 5].Value2.ToString());
                     comm.Parameters.AddWithValue("@direccionred", range.Cells[i, 6].Value2.ToString());
                     comm.Parameters.AddWithValue("@rangoipinicio", range.Cells[i, 7].Value2.ToString());
                     comm.Parameters.AddWithValue("@rangoipfin", range.Cells[i, 8].Value2.ToString());
                     comm.Parameters.AddWithValue("@mascara", range.Cells[i, 9].Value2.ToString());
                     comm.Parameters.AddWithValue("@gateway", range.Cells[i, 10].Value2.ToString());
                     comm.Parameters.AddWithValue("@gateway2", range.Cells[i, 11].Value2.ToString());
                     comm.Parameters.AddWithValue("@gateway3", range.Cells[i, 12].Value2.ToString());
                     comm.Parameters.AddWithValue("@observaciones", range.Cells[i, 13].Value2.ToString());
                     comm.Parameters.AddWithValue("@dispositivo", range.Cells[i, 14].Value2.ToString());
                     comm.Parameters.AddWithValue("@firewall", range.Cells[i, 15].Value2.ToString());
                     comm.Parameters.AddWithValue("@entorno", range.Cells[i, 16].Value2.ToString());
                     comm.Parameters.AddWithValue("@normativa", range.Cells[i, 17].Value2.ToString());
                     comm.Parameters.AddWithValue("@estado", range.Cells[i, 18].Value2.ToString());
                     comm.Parameters.AddWithValue("@tipodered", range.Cells[i, 19].Value2.ToString());
                     comm.Parameters.AddWithValue("@equipos", range.Cells[i, 20].Value2.ToString());
                     comm.Parameters.AddWithValue("@clasificacion", range.Cells[i, 21].Value2.ToString());
                     comm.Parameters.AddWithValue("@tarea", range.Cells[i, 22].Value2.ToString());
                     comm.Parameters.AddWithValue("@usuario", range.Cells[i, 23].Value2.ToString());
                    string ipv4query;


                    if (listBoxVlan.SelectedIndex == 0)
                    {
                        ipv4query = "INSERT INTO `npms`.`" + range.Cells[i, 2].Value2.ToString() + "` (`Vlan`, `Nombre`, `Ubicacion`, `Vsys / balanceador / otro`, `Descripcion`, `Direccion_red`, `Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`, `Gateway2`, `Gateway3`, `Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`, `Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`) " +
                       "VALUES('@vlan', '@nombre', '@ubicacion', '@vsys/balanceador/otro', '@descripcion', '@direccionred', '@rangoipinicio', '@rangoipfin', '@mascara', '@gateway', '@gateway2', '@gateway3', '@observaciones', '@dispositivo', '@firewall', '@entorno', '@normativa', '@estado', '@tipodered', '@equipos', '@clasificacion', '@tarea', '@usuario');";
                        ipv4 = true;
                    }
                    else
                    {
                        ipv4query = "INSERT INTO `npms`.`ipv6_" + range.Cells[i, 2].Value2.ToString() + "` (`Vlan`, `Nombre`, `Ubicacion`, `Vsys / balanceador / otro`, `Descripcion`, `Direccion_red`, `Rango_ip_inicio`, `Rango_ip_fin`, `Mascara`, `Gateway`, `Gateway2`, `Gateway3`, `Observaciones`, `Dispositivo`, `Firewall`, `Entorno`, `Normativa`, `Estado`, `Tipo_de_red`, `Equipos`, `Clasificacion`, `Tarea`, `Usuario`) " +
                       "VALUES('@vlan', '@nombre', '@ubicacion', '@vsys/balanceador/otro', '@descripcion', '@direccionred', '@rangoipinicio', '@rangoipfin', '@mascara', '@gateway', '@gateway2', '@gateway3', '@observaciones', '@dispositivo', '@firewall', '@entorno', '@normativa', '@estado', '@tipodered', '@equipos', '@clasificacion', '@tarea', '@usuario');";
                        ipv4 = false;
                    }

                    comm.CommandText = ipv4query;
                    comm.ExecuteNonQuery();
                     if (ipv4 == true)
                    {
                        Sentencias.CreartablaIpv4(range.Cells[i, 6].Value2.ToString(), range.Cells[i, 1].Value2.ToInt32(), range.Cells[i, 10].Value2.ToString(), range.Cells[i, 11].Value2.ToString(), range.Cells[i, 12].Value2.ToString());
                    }
                     else
                    {
                        Sentencias.CreartablaIpv6(range.Cells[i, 6].Value2.ToString(), range.Cells[i, 1].Value2.ToInt32(), range.Cells[i, 10].Value2.ToString(), range.Cells[i, 11].Value2.ToString(), range.Cells[i, 12].Value2.ToString());

                    }
                    Marshal.ReleaseComObject(range);
                     Marshal.ReleaseComObject(xlWorksheet);
                     xlWorkbook.Close();
                     Marshal.ReleaseComObject(xlWorkbook);
                     xlApp.Quit();
                     Marshal.ReleaseComObject(xlApp);                    
                     conn.Close();
                     
                   }

                MessageBox.Show("Successful importation!");
                */
            
            
            
        }

        private void ButtonProcessExcelIp_Click(object sender, EventArgs e)
        {

        }

        private void ButtonProcessExcelInventory_Click(object sender, EventArgs e)
        {

        }

        private void ButtonProcessExcelPatching_Click(object sender, EventArgs e)
        {

            /////////////MYSQL///////////////////////
            string connectString = bbdd_adapt.mysql_commands.bbdd_connection_data();
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `npms`.`patching` (`Building`, `Floor`, `Closet`, `Panel`, `Panel_Port`, `Stack`, `Switch`, `Switch_Port`, `Interfaz`, `Link`, `Speed`, `Duplex`, `Type`, `Vlan`, `Description`, `IP_Switch`) " +
                "VALUES ('@building', '@floor', '@closet', '@panel', '@panel_port', '@stack', '@switch', '@switch_port', '@interfaz', '@link', '@speed', '@duplex', '@type', '@vlan', '@description', '@ip_switch');";
            ////////////////EXCEL/////////////////
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@labelPatching.Text);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range range = xlWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            int marcador = rows;
            for (int i = 2; i <= rows; i++)
            {
             marcador = marcador - 1;
                labelCountPatching.Text = marcador.ToString();
             string building = range.Cells[i, 1].Value2.ToString();
             string floor =  range.Cells[i, 2].Value2.ToString();
             string closet = range.Cells[i, 3].Value2.ToString();
             string panel = range.Cells[i, 4].Value2.ToString();
             string panel_port = range.Cells[i, 5].Value2.ToString();
             string stack = range.Cells[i, 6].Value2.ToString();
             string switch_ = range.Cells[i, 7].Value2.ToString();
             string switchport = range.Cells[i, 8].Value2.ToString();
             string interfaz = range.Cells[i, 9].Value2.ToString();
             string link = range.Cells[i, 10].Value2.ToString();
             string speed = range.Cells[i, 11].Value2.ToString();
             string duplex =  range.Cells[i, 12].Value2.ToString();
             string type =  range.Cells[i, 13].Value2.ToString();
             string vlan =   range.Cells[i, 14].Value2.ToString();
             string description = range.Cells[i, 15].Value2.ToString();
             string ip_switch = range.Cells[i, 16].Value2.ToString();
                comm.CommandText = "INSERT INTO `npms`.`patching` (`Building`, `Floor`, `Closet`, `Panel`, `Panel_Port`, `Stack`, `Switch`, `Switch_Port`, `Interfaz`, `Link`, `Speed`, `Duplex`, `Type`, `Vlan`, `Description`, `IP_Switch`) " +
                "VALUES ('" + building + "', '" + floor + "', '" + closet + "', '" + panel + "'," +
                " '" + panel_port + "', '" + stack + "', '" + switch_ + "', '" + switchport + "'," +
                " '" + interfaz + "', '" + link + "', '" + speed + "', '" + duplex + "'," +
                " '" + type + "', '" + vlan + "', '" + description + "', '" + ip_switch + "');";
                comm.ExecuteNonQuery();
            }
            /////////////////CLOSE EXCEL/////////////////
            Marshal.ReleaseComObject(range);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
            /////////////CLOSE DATABASE//////////
            conn.Close();
            MessageBox.Show("Import Completed");
            
        }
    }
}
