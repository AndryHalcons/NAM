using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using MySql.Data;
using com.sun.xml.@internal.bind.v2.model.core;
using NPMS.gestion.administrator_network.update_databases;
using NPMS.gestion.administrator_network.CommonMethods;

namespace NPMS.administrate_network
{
    public partial class Administrate_ipv6_ip_form : Form
    {
        
       

        public Administrate_ipv6_ip_form()
        {
 
            InitializeComponent();
            comboBoxSearchIP.SelectedIndex = 0;

        }     
        //Valida que el campo Vlan tiene un valor y abre el form Insert_or_update_ip_ipv4
        // Si el campo vlan no es de tipo entero, o no tiene valor, no permite abrir el form
        private void Button_Update_IP_Data_Click(object sender, EventArgs e)
        {
            GlobalParam.Vlan_IPv6_in_IP_Select = textBox_Vlan.Text;
            string VlanAdaptada = "ipv6_" + textBox_Vlan.Text + "";
            bool VVlan = Common.ValidadorInt(textBox_Vlan.Text, "Vlan");
            bool VClan = Common.ValidadorCamposVacios(textBox_Vlan.Text, "Vlan");
            bool ValidaDatoInsertado_Vacio = Common.ValidadorCamposVacios_SinMensaje(textBoxStringSearch.Text);
            bool ComprobarExistencia = Sentencias.ValidadorTabla(VlanAdaptada);
            if (VVlan == true && VClan == true && ComprobarExistencia == true)
            {
                string ValorVlan = textBox_Vlan.Text.ToString();
                Insert_or_update_ip_ipv6 panel_update_ip_ipv6 = new Insert_or_update_ip_ipv6(ValorVlan);
                panel_update_ip_ipv6.ShowDialog();
            }
           
        }
        //Boton de consulta
        private void Button_search_Click(object sender, EventArgs e)
        {
            Consulta_all();
        }

        //Metodo que genera la consulta y muestra el resultado
        public void Consulta_all()
        {
            string VlanAdaptada = "ipv6_"+textBox_Vlan.Text+"";
            GlobalParam.Vlan_IPv6_in_IP_Select = textBox_Vlan.Text;
            bool ValidaDatoInsertado_Vacio = Common.ValidadorCamposVacios_SinMensaje(textBoxStringSearch.Text);
            string CampoSeleccionado = comboBoxSearchIP.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();


            if (CampoSeleccionado == "Hostname in All Vlan")
            {
                Sentencias.select_ip_hostname_all_vlan(datocampo, dataGridView_ipv6);
            }
            else
            {
                GlobalParam.Vlan_IPv4_in_IP_Select = textBox_Vlan.Text;
                bool VVlan = Common.ValidadorInt(textBox_Vlan.Text, "Vlan");
                bool ValidaExistencia = Sentencias.ValidadorTabla(VlanAdaptada);

                if (VVlan == true && ValidaExistencia == true)
                {
                    //Sentencias.Select_all_ip("IPv4",textBox_Vlan.Text, dataGridView_ipv4);
                    if (CampoSeleccionado == "ALL")
                    {
                        Sentencias.Select_all_ip("IPv6", textBox_Vlan.Text, dataGridView_ipv6);
                    }

                    else
                    {
                        if (CampoSeleccionado == "IP" && ValidaDatoInsertado_Vacio == true)
                        {
                            bool ValidaFormatoIP = Common.ValidadorIP(datocampo, "IP");
                            if (ValidaFormatoIP == true)
                            {
                                Sentencias.Select_all_ip_like("IPv6", VlanAdaptada, CampoSeleccionado, datocampo, dataGridView_ipv6);
                            }
                        }
                        else if (CampoSeleccionado == "Hostname in All Vlan")
                        {
                            Sentencias.select_ip_hostname_all_vlan(datocampo, dataGridView_ipv6);
                        }
                        else
                        {
                            Sentencias.Select_all_ip_like_others_fields("IPv6", VlanAdaptada, CampoSeleccionado, datocampo, dataGridView_ipv6);
                        }
                    }
                }
            }



        }

   
    }   
}
