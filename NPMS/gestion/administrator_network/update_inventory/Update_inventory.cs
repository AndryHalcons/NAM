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

namespace NPMS.gestion.administrator_network.update_inventory
{
    public partial class Update_inventory : Form
    {
        public Update_inventory()
        {
            InitializeComponent();
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            string id_hostname = textBoxHostname.Text.ToString();
            string id_DNS = textBoxDNS.Text.ToString();
            string id_Comments = textBoxComments.Text.ToString();
            string id_IP = textBoxIP.Text.ToString();
            string id_SN = textBoxSN.Text.ToString();
            string id_Name = textBoxName.Text.ToString();
            string id_Manufacturer = textBoxManufacturer.Text.ToString();
            string id_Location = textBoxLocation.Text.ToString();
            string id_Environment = textBoxEnvironment.Text.ToString();
            string id_Domain = textBoxDomain.Text.ToString();
            string id_Contact = textBoxContact.Text.ToString();
            string id_Aditional = textBoxAditional.Text.ToString();
            string id_Ports = textBoxPorts.Text.ToString();
            string id_Other1 = textBoxOther1.Text.ToString();
            string id_Other2 = textBoxOther2.Text.ToString();
            string id_WorkOrder = textBoxWorkOrder.Text.ToString();
            bool VSn = Common.ValidadorCamposVacios(id_SN, "SN");
            bool VWorder = Common.ValidadorCamposVacios(id_WorkOrder, "Work Order");
            if (VSn == true && VWorder == true)
            {
                SentenciasPro.Insert_inventory(id_hostname, id_DNS, id_Comments, id_IP, id_SN, id_Name, id_Manufacturer,
                     id_Location, id_Environment, id_Domain, id_Contact, id_Aditional, id_Ports, id_Other1, id_Other2,
                     id_WorkOrder);
                this.Close();
            }

        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            string id_SN = textBoxSNDel.Text.ToString();
            string id_WorkOrder = textBoxWorderDel.Text.ToString();
            bool VSn = Common.ValidadorCamposVacios(id_SN, "SN");
            bool VWorder = Common.ValidadorCamposVacios(id_WorkOrder, "Work Order");
            if (VSn == true && VWorder == true)
            {
                SentenciasPro.Delete_inventory(id_SN, id_WorkOrder);
                this.Close();
            }
        }
    }
}
