using NPMS.gestion.administrator_network.update_databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using NPMS.gestion.administrator_network.CommonMethods;

namespace NPMS.administrate_network
{
    public partial class Administrate_ipv4_vlan_form : Form
    {
        public Administrate_ipv4_vlan_form()
            
        {           
            //textBoxUsuarioLog.Text = Usuario;
            InitializeComponent();
            comboBoxSearchVlan.SelectedIndex = 0;
        }
      
        private void Button_search_Click(object sender, EventArgs e)
        {
            Consulta_all();
        }

        public void Consulta_all()
        {
            string CampoSeleccionado = comboBoxSearchVlan.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Bbdd_apply_all_datagridView("vlan_ipv4", dataGridView_ipv4_vlan);
            }
            else
            {
                if (checkBoxStringSearch.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("vlan_ipv4", CampoSeleccionado, datocampo, dataGridView_ipv4_vlan);
                }
                else
                {
                    if (CampoSeleccionado == "Date")
                    {
                        Sentencias.Bbdd_apply_wherelike_datagridView("vlan_ipv4", CampoSeleccionado, datocampo, dataGridView_ipv4_vlan);
                    }
                    else
                    {
                        Sentencias.Bbdd_apply_where_datagridView("vlan_ipv4", CampoSeleccionado, datocampo, dataGridView_ipv4_vlan);
                    }

                }
            }

        }
        private void Button_Update_IP_Data_Click(object sender, EventArgs e)
        {
            Insert_or_update_vlan_ipv4 panel_update_ipv4_vlan = new Insert_or_update_vlan_ipv4();
            panel_update_ipv4_vlan.ShowDialog();
        }

        private void ButtonDeleteVlan_Click(object sender, EventArgs e)
        {
            Delete_vlan_ipv4 panel_delete_vlan_ipv4 = new Delete_vlan_ipv4();
            panel_delete_vlan_ipv4.ShowDialog();
        }
    }
    
}
