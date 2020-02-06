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
        //Crea un archivo temporal que guarda una fila con el nombre de usuario
        //Necesario para indicar quien realiza las modificaciones en la BBDD desde la app
        

        public Gestion(string user_dat)
        {
            InitializeComponent();
            string rol_usuario = Sentencias.Dato_Campo_String("usuarios", "Usuario", user_dat, 2);
            Common.CreateSession(user_dat,rol_usuario);
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

        private void ButtonFastNetworkFirewall_Click(object sender, EventArgs e)
        {
            string source = textBoxFastSource.Text;
            string destination = textBoxFastDestination.Text;
            bool Vsource = Common.ValidadorIP(source, "Source");
            bool Vdestination = Common.ValidadorIP(destination, "Destination");
            if (Vsource == true && Vdestination == true)
            {
                string query = "(SELECT * FROM npms.vlan_ipv4 where(INET_ATON('"+source+"') BETWEEN INET_ATON(Rango_ip_inicio)and INET_ATON(Rango_ip_fin)))union(SELECT * FROM npms.vlan_ipv4 where(INET_ATON('"+destination+"') BETWEEN INET_ATON(Rango_ip_inicio)and INET_ATON(Rango_ip_fin))); ";
                Sentencias.Bbdd_apply_datagridView("vlan_ipv4", query, dataGridViewFastNetworkFirewall);           

            }
        }

        private void ButtonImportData_Click(object sender, EventArgs e)
        {
            ImportData panel_importData = new ImportData();
            panel_importData.Show();
        }

        private void buttonLogsIpIpv4_Click(object sender, EventArgs e)
        {
            LogsApp panel_LogsApp = new LogsApp();
            panel_LogsApp.Show();
        }
    }

   
       
        
    
}
