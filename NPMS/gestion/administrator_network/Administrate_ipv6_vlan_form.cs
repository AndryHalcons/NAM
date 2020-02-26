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
            bool Bdata_IpOctets = Common.ValidadorCamposVacios_SinMensaje(textBox_Ip.Text);
            bool Bdata_vlan = Common.ValidadorCamposVacios_SinMensaje(textBox_Vlan.Text);
            string source = textBox_Ip.Text.ToString();
            string data_Vlan = textBox_Vlan.Text.ToString();
            if (Bdata_IpOctets == true && Bdata_vlan == true)
            {
                MessageBox.Show("You cannot search in two fields at the same time");
            }
            
            if (Bdata_IpOctets == true && Bdata_vlan == false)
            {
                //Revisar INER ATON NO SOPORTA IPV6
                Sentencias.Bbdd_apply_search_vlan_for_IP("vlan_ipv6", source, "Rango_ip_inicio", "Rango_ip_fin",dataGridView_ipv4_vlan);

            }
            if (Bdata_IpOctets == false && Bdata_vlan == true)
            {
                Sentencias.Bbdd_apply_where_datagridView("vlan_ipv6", "Vlan", data_Vlan, dataGridView_ipv4_vlan);

            }
            if (Bdata_IpOctets == false && Bdata_vlan == false)
            {
                Sentencias.Bbdd_apply_all_datagridView("vlan_ipv6", dataGridView_ipv4_vlan);

            }        
        }
        private void Button_Update_IP_Data_Click(object sender, EventArgs e)
        {
            Insert_or_update_vlan_ipv6 panel_update_ipv6_vlan = new Insert_or_update_vlan_ipv6();
            panel_update_ipv6_vlan.Show();
        }

        private void ButtonDeleteVlan_Click(object sender, EventArgs e)
        {
            Delete_vlan_ipv6 panel_delete_vlan_ipv6 = new Delete_vlan_ipv6();
            panel_delete_vlan_ipv6.Show();
        }
    }
    
}
