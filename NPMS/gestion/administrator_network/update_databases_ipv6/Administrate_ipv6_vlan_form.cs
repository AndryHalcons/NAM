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
    public partial class Administrate_ipv6_vlan_form : Form
    {
        public Administrate_ipv6_vlan_form()
            
        {
            //textBoxUsuarioLog.Text = Usuario;
            InitializeComponent();
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
                Sentencias.Bbdd_apply_all_datagridView("vlan_ipv6", dataGridView_ipv6_vlan);
            }
            else
            {
                if (CampoSeleccionado == "For IP")
                {
                    Sentencias.Bbdd_apply_search_vlan_for_IP("IPv4", "vlan_ipv4", datocampo, dataGridView_ipv6_vlan);
                }
                else
                {

                
                    if (checkBoxStringSearch.Checked == true)
                     {
                       Sentencias.Bbdd_apply_wherelike_datagridView("vlan_ipv6", CampoSeleccionado, datocampo, dataGridView_ipv6_vlan);
                     }
                     else
                      {
                           if (CampoSeleccionado == "Date")
                           {
                                Sentencias.Bbdd_apply_wherelike_datagridView("vlan_ipv6", CampoSeleccionado, datocampo, dataGridView_ipv6_vlan);
                           }
                         else
                          {
                            Sentencias.Bbdd_apply_where_datagridView("vlan_ipv6", CampoSeleccionado, datocampo, dataGridView_ipv6_vlan);
                          }
                      }
                }
            }
        }
        private void Button_Update_IP_Data_Click(object sender, EventArgs e)
        {
            Insert_or_update_vlan_ipv6 panel_update_ipv6_vlan = new Insert_or_update_vlan_ipv6();
            panel_update_ipv6_vlan.ShowDialog();
        }

        private void ButtonDeleteVlan_Click(object sender, EventArgs e)
        {
            Delete_vlan_ipv6 panel_delete_vlan_ipv6 = new Delete_vlan_ipv6();
            panel_delete_vlan_ipv6.ShowDialog();
        }
    }
    
}
