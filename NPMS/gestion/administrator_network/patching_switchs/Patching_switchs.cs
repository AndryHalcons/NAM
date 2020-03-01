using NPMS.gestion.administrator_network.CommonMethods;
using NPMS.gestion.administrator_network.patching_switchs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network
{
    public partial class Patching_switchs : Form
    {
        public Patching_switchs()
        {
            InitializeComponent();
            Sentencias.Select_distinct("patching", "Building",comboBoxBuilding);
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            string building = comboBoxBuilding.Text.ToString();
            string floor = textBoxFloor.Text.ToString();
            string closet = textBoxCloset.Text.ToString();
            string panel = textBoxPanel.Text.ToString();
            string port_panel = textBoxPortPanel.Text.ToString();
            bool Vbuilding = Common.ValidadorCamposVacios_SinMensaje(building);
            bool Vfloor = Common.ValidadorCamposVacios_SinMensaje(floor);
            bool Vcloset = Common.ValidadorCamposVacios_SinMensaje(closet);
            bool Vpanel = Common.ValidadorCamposVacios_SinMensaje(panel);
            bool Vport_panel = Common.ValidadorCamposVacios_SinMensaje(port_panel);
            if (Vbuilding == false | Vfloor == false | Vcloset == false | Vpanel == false | Vport_panel == false)
            {
                Sentencias.Bbdd_apply_all_datagridView("patching", dataGridView_patching);
            }
            else
            {
                Sentencias.Select_patching(building, floor, closet, panel, port_panel, dataGridView_patching);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_patching panel_update_patching = new Update_patching();
            panel_update_patching.Show();

        }
    }
}
