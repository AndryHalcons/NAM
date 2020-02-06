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
        
        //Variable que se manda a insert_or_update_ip_ipv4 para buscar en la tabla
       

        public Administrate_ipv6_ip_form()
        {
 
            InitializeComponent();
            
        }     
        //Valida que el campo Vlan tiene un valor y abre el form Insert_or_update_ip_ipv4
        // Si el campo vlan no es de tipo entero, o no tiene valor, no permite abrir el form
        private void Button_Update_IP_Data_Click(object sender, EventArgs e)
        {
            
            bool VVlan = Common.ValidadorInt(textBox_Vlan.Text, "Vlan");
            bool VClan = Common.ValidadorCamposVacios(textBox_Vlan.Text, "Vlan");
            bool ComprobarExistencia = Common.ValidadorTabla(textBox_Vlan.Text);
            if (VVlan == true && VClan == true && ComprobarExistencia == true)
            {
                string ValorVlan = textBox_Vlan.Text.ToString();
                Insert_or_update_ip_ipv6 panel_update_ip_ipv6 = new Insert_or_update_ip_ipv6(ValorVlan);
                panel_update_ip_ipv6.Show();
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

            bool VVlan = Common.ValidadorInt(textBox_Vlan.Text, "Vlan");
            string VlanAdaptada = "ipv6_" + textBox_Vlan.Text + "";
            bool ValidaExistencia = Common.ValidadorTabla(VlanAdaptada);
            if (VVlan == true && ValidaExistencia == true)
            {
                string Vlan = textBox_Vlan.Text.ToString();
                string query = "SELECT * FROM npms.`ipv6_" + Vlan + "`;";
                Sentencias.Bbdd_apply_datagridView(Vlan,query,dataGridView_ipv4);              
            }
                        

        }


    }
}
