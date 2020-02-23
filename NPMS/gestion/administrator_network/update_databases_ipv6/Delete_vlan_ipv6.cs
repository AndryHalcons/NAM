using NPMS.gestion.administrator_network.CommonMethods;
using System;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network.update_databases
{
    public partial class Delete_vlan_ipv6 : Form
    {
        public Delete_vlan_ipv6()
        {
            InitializeComponent();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            bool Campo_vlan = Common.ValidadorCamposVacios_SinMensaje(textBoxVlan.Text);
            bool Bid_vlan = Common.ValidadorInt(textBoxVlan.Text,"Vlan");
            bool V_tarea = Common.ValidadorCamposVacios(textBoxTareaDel.Text, "Tarea");
            bool E_Vlan = Common.ValidarDatoExistente("vlan_ipv6", "Vlan", textBoxVlan.Text);
            if (E_Vlan == false)
            {
                MessageBox.Show("The vlan does not exist!");
            }
            if (Campo_vlan == true && Bid_vlan == true && V_tarea == true && E_Vlan == true)
            {
                string protocolo = "IPv6";
                string id_vlan = textBoxVlan.Text.ToString();
                SentenciasPro.Delete_Vlan(protocolo, id_vlan,textBoxTareaDel.Text);
                this.Close();

            }
        }
    }
}
