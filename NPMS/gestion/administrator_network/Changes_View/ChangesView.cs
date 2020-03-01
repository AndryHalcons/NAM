using NPMS.gestion.administrator_network.CommonMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network.Logs
{
    public partial class ChangesView : Form
    {
        public ChangesView()
        {
            InitializeComponent();
        }


        private void buttonIP_IPv4_Click(object sender, EventArgs e)
        {
            Sentencias.Bbdd_apply_all_Desc_datagridView("log_ip_ipv4", dataGridViewLogs);
        }

        private void buttonVlanIPv4_Click(object sender, EventArgs e)
        {
            Sentencias.Bbdd_apply_all_Desc_datagridView("log_vlan_ipv4", dataGridViewLogs);
        }

        private void buttonIP_IPv6_Click(object sender, EventArgs e)
        {
            Sentencias.Bbdd_apply_all_Desc_datagridView("log_ip_ipv6", dataGridViewLogs);
        }

        private void buttonVlanIPv6_Click(object sender, EventArgs e)
        {
            Sentencias.Bbdd_apply_all_Desc_datagridView("log_vlan_ipv6", dataGridViewLogs);
        }

        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            Sentencias.Bbdd_apply_all_Desc_datagridView("log_inventory", dataGridViewLogs);
        }

        private void ButtonPatching_Click(object sender, EventArgs e)
        {

        }
    }
}

