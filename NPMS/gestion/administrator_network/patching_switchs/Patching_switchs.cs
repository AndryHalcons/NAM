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
            Sentencias.Select_distinct("patching", "Building", comboBoxBuilding1);
            Sentencias.Select_distinct("patching", "Building", comboBoxBuilding2);
            Sentencias.Select_distinct("patching", "Floor", comboBoxDelFloor2);
            Sentencias.Select_distinct("patching", "Building", comboBoxBuilding0);
            Sentencias.Select_distinct("patching", "Floor", comboBoxFloor0);
            Sentencias.Select_distinct("patching", "Closet", comboBoxCloset0);
            Sentencias.Select_distinct("patching", "Panel", comboBoxPanel0);
            Sentencias.Select_distinct("patching", "Panel_Port", comboBoxPanelPort0);
            Sentencias.Select_distinct("patching", "Stack", comboBoxStack0);       
            Sentencias.Select_distinct("patching", "Building", comboBoxBuilding3);
            Sentencias.Select_distinct("patching", "Floor", comboBoxDelFloor3);
            Sentencias.Select_distinct("patching", "Closet", comboBoxDelCloset3);


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
            if (Vbuilding == true && (Vfloor == false | Vcloset == false | Vpanel == false | Vport_panel == false))
            {
                Sentencias.Bbdd_apply_where_datagridView("patching", "Building", building, dataGridView_patching);
            }
            else if (Vbuilding == false | Vfloor == false | Vcloset == false | Vpanel == false | Vport_panel == false)
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
            string in_WorkOrder = BoxWorkOrder.Text.ToString();
            bool Int_floor = Common.ValidadorInt(in_Floor, "Floor");
            bool Vin_building = Common.ValidadorCamposVacios(in_building, "Building");
            bool Vin_Floor = Common.ValidadorCamposVacios(in_Floor, "Floor");
            bool Vin_Closet = Common.ValidadorCamposVacios(in_Closet, "Closet");
            bool Vin_Panel = Common.ValidadorCamposVacios(in_Panel, "Panel");
            bool Vin_PanelPort= Common.ValidadorCamposVacios(in_PanelPort, "Panel Port");
            bool Vin_SwitchPort = Common.ValidadorCamposVacios(in_SwitchPort, "Switch Port");
            bool Vin_IPSwitch = Common.ValidadorCamposVacios(in_IP_Switch, "IP Switch");
            bool Vin_WorkOrder = Common.ValidadorCamposVacios(in_WorkOrder, "Work Order");
            if (Int_floor == true && Vin_building == true && Vin_Floor == true && Vin_Closet == true 
                && Vin_Panel == true && Vin_PanelPort == true && Vin_SwitchPort == true && Vin_IPSwitch == true
                && Vin_WorkOrder == true)
            {
                Sentencias.Insert_Patching(in_building, in_Floor, in_Closet, in_Panel, in_PanelPort, in_Stack,
                    in_Switch, in_SwitchPort, in_interface, in_link, in_Speed, in_Duplex,
                    in_Type, in_Vlan, in_Description, in_IP_Switch,in_WorkOrder);
            }
        }

        private void buttonDeleteSimply_Click(object sender, EventArgs e)
        {
            string DS_building = comboBoxBuilding0.Text.ToString();
            string DS_Floor = comboBoxFloor0.Text.ToString();
            string DS_Closet = comboBoxCloset0.Text.ToString();
            string DS_Panel = comboBoxPanel0.Text.ToString();
            string DS_Panel_port = comboBoxPanelPort0.Text.ToString();
            string DS_Stack = comboBoxStack0.Text.ToString();
            string DS_IPSwitch = textSimplyDelIPSwitch0.Text.ToString();
            string DS_Worder = textSimplyDelWorder0.Text.ToString();                
            bool VDS_building = Common.ValidadorCamposVacios(DS_building, "Building");
            bool VDS_Floor = Common.ValidadorCamposVacios(DS_Floor, "Floor");
            bool VDS_Closet = Common.ValidadorCamposVacios(DS_Closet, "Closet");
            bool VDS_Panel = Common.ValidadorCamposVacios(DS_Panel, "Panel");
            bool VDS_Panel_port = Common.ValidadorCamposVacios(DS_Panel_port, "Panel");
            bool VDS_Stack = Common.ValidadorCamposVacios(DS_Stack, "Stack");
            bool VDS_IPSwitch = Common.ValidadorCamposVacios(DS_IPSwitch, "IP switch");
            bool Vexists_IPSwitch = Sentencias.ValidarDatoExistente("patching", "IP_Switch", DS_IPSwitch);
            bool VDS_Worder = Common.ValidadorCamposVacios(DS_Worder, "Work Order");
            if (Vexists_IPSwitch == false)
            {
                MessageBox.Show("The IP Switch no exists! ");
            }
            if (VDS_building == true && VDS_Floor == true && VDS_Closet == true && VDS_Panel == true && VDS_Panel_port == true
                && VDS_Stack == true && VDS_IPSwitch == true && VDS_Worder == true && Vexists_IPSwitch == true)
            {
                Sentencias.Delete_field_patching(DS_building, DS_Floor, DS_Closet, DS_Panel, DS_Panel_port,DS_Stack, DS_IPSwitch, DS_Worder);

            }

        }

        private void buttonDelBuilding_Click(object sender, EventArgs e)
        {
            string DB_building = comboBoxBuilding1.Text.ToString();
            string DB_worder = textBoxWorder1.Text.ToString();
            bool VDB_building = Common.ValidadorCamposVacios(DB_building, "Building");
            bool VDB_worder = Common.ValidadorCamposVacios(DB_worder, "Work Order");
            if (VDB_building == true && VDB_worder == true)
            {
                Sentencias.Delete_patching_building(DB_building, DB_worder);
                labelDelBuildingCheck.Text = "successful!";
            }
        }

        private void buttonDelFloor_Click(object sender, EventArgs e)
        {
            string DF_building = comboBoxBuilding2.Text.ToString();
            string DF_Floor = comboBoxDelFloor2.Text.ToString();
            string DF_worder = textBoxDelWorder2.Text.ToString();
            bool VDF_building = Common.ValidadorCamposVacios(DF_building, "Building");
            bool VDF_Floor = Common.ValidadorCamposVacios(DF_Floor, "Building");
            bool VDF_worder = Common.ValidadorCamposVacios(DF_worder, "Work Order");
            if (VDF_building == true && VDF_Floor == true && VDF_worder == true)
            {
                Sentencias.Delete_all_floor(DF_building, DF_worder, DF_Floor);
                labelDelFloorCheck.Text = "successful!";
            }
        }

        private void buttonDelCloset_Click(object sender, EventArgs e)
        {
            string DC_building = comboBoxBuilding3.Text.ToString();
            string DC_Floor = comboBoxDelFloor3.Text.ToString();
            string DC_Closet = comboBoxDelCloset3.Text.ToString();
            string DC_worder = textBoxDelWorder3.Text.ToString();
            bool VDC_building = Common.ValidadorCamposVacios(DC_building, "Building");
            bool VDC_Floor = Common.ValidadorCamposVacios(DC_Floor, "Floor");
            bool VDC_Closet = Common.ValidadorCamposVacios(DC_Closet, "Closet");
            bool VDC_worder = Common.ValidadorCamposVacios(DC_worder, "Work Order");
            if (VDC_building == true && VDC_Floor == true && VDC_Closet == true && VDC_worder == true)
            {
                Sentencias.Delete_all_closet(DC_building, DC_Floor, DC_Closet, DC_worder);
                labelDelClosetCheck.Text = "successful!";

            }
        }
    }
}
