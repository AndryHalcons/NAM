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

namespace NPMS.gestion.administrator_network.bbdd_adapt
{
    class mysql_imports
    {
        private void ButtonProcessExcelPatching_Click(object sender, EventArgs e)
        {
            //
            
            /////////////MYSQL///////////////////////
            string connectString = bbdd_adapt.mysql_commands.bbdd_connection_data();
            MySqlConnection conn = new MySqlConnection(connectString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `npms`.`patching` (`Building`, `Floor`, `Closet`, `Panel`, `Panel_Port`, `Stack`, `Switch`, `Switch_Port`, `Interfaz`, `Link`, `Speed`, `Duplex`, `Type`, `Vlan`, `Description`, `IP_Switch`) " +
                "VALUES ('@building', '@floor', '@closet', '@panel', '@panel_port', '@stack', '@switch', '@switch_port', '@interfaz', '@link', '@speed', '@duplex', '@type', '@vlan', '@description', '@ip_switch');";
            ////////////////EXCEL/////////////////
            Excel.Application xlApp = new Excel.Application();
            string variabletapaerrores = "aqui va el @label.txt con @";
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(variabletapaerrores);
            Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range range = xlWorksheet.UsedRange;
            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            for (int i = 2; i <= rows; i++)
            {
                comm.Parameters.Clear();
                comm.Parameters.AddWithValue("@building", range.Cells[i, 1].Value2.ToString());
                comm.Parameters.AddWithValue("@floor", range.Cells[i, 2].Value2.ToString());
                comm.Parameters.AddWithValue("@closet", range.Cells[i, 3].Value2.ToString());
                comm.Parameters.AddWithValue("@panel", range.Cells[i, 4].Value2.ToString());
                comm.Parameters.AddWithValue("@panel_port", range.Cells[i, 5].Value2.ToString());
                comm.Parameters.AddWithValue("@stack", range.Cells[i, 6].Value2.ToString());
                comm.Parameters.AddWithValue("@switch", range.Cells[i, 7].Value2.ToString());
                comm.Parameters.AddWithValue("@switch_port", range.Cells[i, 8].Value2.ToString());
                comm.Parameters.AddWithValue("@interfaz", range.Cells[i, 9].Value2.ToString());
                comm.Parameters.AddWithValue("@link", range.Cells[i, 10].Value2.ToString());
                comm.Parameters.AddWithValue("@speed", range.Cells[i, 11].Value2.ToString());
                comm.Parameters.AddWithValue("@duplex", range.Cells[i, 12].Value2.ToString());
                comm.Parameters.AddWithValue("@type", range.Cells[i, 13].Value2.ToString());
                comm.Parameters.AddWithValue("@vlan", range.Cells[i, 14].Value2.ToString());
                comm.Parameters.AddWithValue("@description", range.Cells[i, 15].Value2.ToString());
                comm.Parameters.AddWithValue("@ip_Switch", range.Cells[i, 16].Value2.ToString());
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
            MessageBox.Show("importado ...o eso creo");

        }
    }
}
