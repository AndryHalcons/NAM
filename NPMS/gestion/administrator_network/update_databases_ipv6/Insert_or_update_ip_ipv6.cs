using NPMS.gestion.administrator_network.CommonMethods;
using System;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network.update_databases
{
    public partial class Insert_or_update_ip_ipv6 : Form
    {
        public Insert_or_update_ip_ipv6(string ValorVlan)
        {
            InitializeComponent();
            label_vlan_prueba.Text = ValorVlan;
        }

        
        //Guardar nuevos datos sobre una ip
        private void Button_apply_insert_ipv4_Click_1(object sender, EventArgs e)
        {
            string id_vlan = GlobalParam.Vlan_IPv6_Select;
            bool Vip_ip = Common.ValidadorIP(textBoxIp.Text, "IP");
            bool VC_ip = Common.ValidadorCamposVacios(textBoxIp.Text, "IP");
            bool VC_tarea = Common.ValidadorCamposVacios(textBoxTarea.Text, "Tarea");
            bool VC_descripcion = Common.ValidadorCamposVacios(textBoxDescripcion.Text, "Descripcion");
            if (Vip_ip == true && VC_ip == true && VC_tarea == true && VC_descripcion == true)
            {
                string VlanAdaptada = "ipv6_" + id_vlan + "";
                string id_ip = textBoxIp.Text.ToString();
                string id_dns = textBoxDns.Text.ToString();
                string id_mac = textBoxMac.Text.ToString();
                string id_hostname = textBoxHostname.Text.ToString();
                string id_hostnameR = textBoxHostnameR.Text.ToString();
                string id_Ubicacion = textBoxUbicacion.Text.ToString();
                string id_Tarea = textBoxTarea.Text.ToString();
                string id_Descripcion = textBoxDescripcion.Text.ToString();
                string id_usuario = GlobalParam.IDUser;
                string protocolo = "vlan_ipv6";
                bool ValidarAccion = Common.ValidarDatoExistente(VlanAdaptada, "IP", id_ip);
                Sentencias.Insert_ip(protocolo, id_vlan, id_Ubicacion, id_mac, id_dns, id_Descripcion, id_hostnameR,
                id_hostname, id_Tarea, id_usuario, id_ip,ValidarAccion);
                this.Close();
            }

            
        }

        private void ButtonApplyDel_Click(object sender, EventArgs e)
        {
                      
            bool Vid_ip = Common.ValidadorIP(textBoxSelectIpDel.Text, "Select IP");
            bool VC_ip = Common.ValidadorCamposVacios(textBoxSelectIpDel.Text, "Select IP");
            bool V_tarea = Common.ValidadorCamposVacios(textBoxTareaDel.Text, "Tarea");
            if (Vid_ip == true && VC_ip == true && V_tarea == true)
            {
                string id_tarea = textBoxTareaDel.Text.ToString();
                string id_vlan = GlobalParam.Vlan_IPv6_Select;
                string id_ip = textBoxSelectIpDel.Text.ToString();
                string id_usuario = GlobalParam.IDUser;
                string protocolo = "IPv6";
                Sentencias.Update_ip(protocolo, id_vlan, id_tarea, id_usuario, id_ip);
                this.Close();
            }
        }
    }
}
