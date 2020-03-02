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

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string in_building = BoxBuilding.Text.ToString();
            string in_Floor = BoxFloor.Text.ToString();
            string in_Closet = BoxCloset.Text.ToString();
            string in_Panel = BoxPanel.Text.ToString();
            string in_PanelPort = BoxPanelPort.Text.ToString();
            string in_Stack = BoxStack.Text.ToString();
            string in_Switch = BoxSwitch.Text.ToString();
            string in_SwitchPort = BoxSwitchPort.Text.ToString();
            string in_interface = BoxInterface.Text.ToString();
            string in_link = BoxLink.Text.ToString();
            string in_Speed = BoxSpeed.Text.ToString();
            string in_Duplex = BoxDuplex.Text.ToString();
            string in_Type = BoxType.Text.ToString();
            string in_Vlan = BoxVlan.Text.ToString();
            string in_Description = BoxDescription.Text.ToString();
            string in_IP_Switch = BoxIPSwitch.Text.ToString();
            bool Int_floor = Common.ValidadorInt(in_Floor, "Floor");
            bool Vin_building = Common.ValidadorCamposVacios(in_building, "Building");
            bool Vin_Floor = Common.ValidadorCamposVacios(in_Floor, "Floor");
            bool Vin_Closet = Common.ValidadorCamposVacios(in_Closet, "Closet");
            bool Vin_Panel = Common.ValidadorCamposVacios(in_Panel, "Panel");
            bool Vin_PanelPort= Common.ValidadorCamposVacios(in_PanelPort, "Panel Port");
            bool Vin_SwitchPort = Common.ValidadorCamposVacios(in_SwitchPort, "Switch Port");
            bool Vin_IPSwitch = Common.ValidadorCamposVacios(in_IP_Switch, "IP Switch");
            if (Int_floor == true && Vin_building == true && Vin_Floor == true && Vin_Closet == true 
                && Vin_Panel == true && Vin_PanelPort == true && Vin_SwitchPort == true && Vin_IPSwitch == true)
            {
                Sentencias.Insert_Patching(in_building, in_Floor, in_Closet, in_Panel, in_PanelPort, in_Stack,
                    in_Switch, in_SwitchPort, in_interface, in_link, in_Speed, in_Duplex,
                    in_Type, in_Vlan, in_Description, in_IP_Switch);
            }
        }
    }
}
