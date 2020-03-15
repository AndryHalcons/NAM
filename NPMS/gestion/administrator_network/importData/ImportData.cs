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

            string protocolo = listBoxVlan.Text;
            Sentencias.Import_Vlan(labelVlan, labelCountVlan, protocolo);   
        }

        private void ButtonProcessExcelIp_Click(object sender, EventArgs e)
        {
            string protocolo = listBoxIP.Text;
            Sentencias.Import_IP(labelIP, labelCountIP, protocolo);
        }

        private void ButtonProcessExcelInventory_Click(object sender, EventArgs e)
        {
            Sentencias.Import_Inventory(labelInventory, labelCountInventory);
        }

        private void ButtonProcessExcelPatching_Click(object sender, EventArgs e)
        {                     
                Sentencias.Import_Patching(labelPatching, labelCountPatching);                                      
        }
    }
}
