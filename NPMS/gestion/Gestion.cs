using MySql.Data.MySqlClient;
using NPMS.administrate_network;
using NPMS.gestion.administrator_network;
using NPMS.gestion.administrator_network.CommonMethods;
using NPMS.gestion.administrator_network.Logs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS
{
    public partial class Gestion : Form
    {
        
        //
        

        public Gestion(string user_dat,string rol_user)
        {
            // Genera las variables globales que indican el usuario logueado y su rol
            //Necesario para indicar quien realiza las modificaciones en la BBDD desde la app
            InitializeComponent();
            string rol_usuario = Sentencias.Dato_Campo_String("usuarios", "User", user_dat, 2);
            GlobalParam.IDUser = user_dat;
            GlobalParam.IDRol = rol_usuario;
        }          


   
        private void Administrate_ipv4_ip_Click(object sender, EventArgs e)
        {
           Administrate_ipv4_ip_form panel_ip_ipv4 = new Administrate_ipv4_ip_form();
            panel_ip_ipv4.Show();
        }

        private void Administrate_ipv4_vlan_Click(object sender, EventArgs e)
        {
           
            Administrate_ipv4_vlan_form panel_vlan_ipv4 = new Administrate_ipv4_vlan_form();
            panel_vlan_ipv4.Show();
        }

        private void Administrate_ipv6_ip_Click(object sender, EventArgs e)
        {
            Administrate_ipv6_ip_form panel_ip_ipv6 = new Administrate_ipv6_ip_form();
            panel_ip_ipv6.Show();
        }

        private void Administrate_ipv6_vlan_Click(object sender, EventArgs e)
        {
            Administrate_ipv6_vlan_form panel_vlan_ipv6 = new Administrate_ipv6_vlan_form();
            panel_vlan_ipv6.Show();
        }

        private void ButtonUserManagement_Click(object sender, EventArgs e)
        {
            UserManagement panel_user_management = new UserManagement();
            panel_user_management.Show();
        }

        private void ButtonImportData_Click(object sender, EventArgs e)
        {
            ImportData panel_importData = new ImportData();
            panel_importData.Show();
        }

        private void buttonLogsIpIpv4_Click(object sender, EventArgs e)
        {
            ChangesView panel_changes_view = new ChangesView();
            panel_changes_view.Show();
        }

        private void inventory_Click(object sender, EventArgs e)
        {
            Inventory panel_inventory = new Inventory();
            panel_inventory.Show();
        }

        private void patching_switchs_Click(object sender, EventArgs e)
        {
            Patching_switchs panel_patching_switchs = new Patching_switchs();
            panel_patching_switchs.Show();
        }

        private void ButtonFastNetworkFirewall_Click(object sender, EventArgs e)
        {
            string source = textBoxFastSource.Text;
            string destination = textBoxFastDestination.Text;
            bool Vsource = Common.ValidadorIP(source, "Source");
            bool Vdestination = Common.ValidadorIP(destination, "Destination");
            if (Vsource == true && Vdestination == true)
            {
                if (checkBoxIPv6.Checked == true)
                {
                    Sentencias.Bbdd_apply_search_vlan_for_Fast_Firewall("IPv6", source, destination, dataGridViewFastNetworkFirewall);

                }
                else
                {
                    Sentencias.Bbdd_apply_search_vlan_for_Fast_Firewall("IPv4", source, destination, dataGridViewFastNetworkFirewall);

                }
            }
        }

        
    }

   
       
        
    
}
