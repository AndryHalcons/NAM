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
using NetTools;

namespace NPMS.administrate_network
{
    public partial class pruebas_ipv4 : Form
    {
        
        //Variable que se manda a insert_or_update_ip_ipv4 para buscar en la tabla
       

        public pruebas_ipv4()
        {
 
            InitializeComponent();
            label3.Text = GlobalParam.BBDD_Type;
            
        }
        //Valida que el campo Vlan tiene un valor y abre el form Insert_or_update_ip_ipv4
        // Si el campo vlan no es de tipo entero, o no tiene valor, no permite abrir el form
        private void button_Update_IP_Data_Click(object sender, EventArgs e)
        {
            GlobalParam.Vlan_IPv4_Select = textBox_Vlan.Text;
            bool VVlan = Common.ValidadorInt(textBox_Vlan.Text, "Vlan");
            bool VClan = Common.ValidadorCamposVacios(textBox_Vlan.Text, "Vlan");
            bool ComprobarExistencia = Common.ValidadorTabla(textBox_Vlan.Text);
            if (VVlan == true && VClan == true && ComprobarExistencia == true)
            {
                string ValorVlan = textBox_Vlan.Text.ToString();
                Insert_or_update_ip_ipv4 panel_update_ip_ipv4 = new Insert_or_update_ip_ipv4(ValorVlan);
                panel_update_ip_ipv4.Show();
            }
        }
        //Boton de consulta
        private void button_search_Click(object sender, EventArgs e)
        {
            Consulta_all();
        }

        //Metodo que genera la consulta y muestra el resultado
        public void Consulta_all()
        {
            GlobalParam.Vlan_IPv4_Select = textBox_Vlan.Text;
            bool VVlan = Common.ValidadorInt(textBox_Vlan.Text, "Vlan");
            bool ValidaExistencia = Common.ValidadorTabla(textBox_Vlan.Text);
            if (VVlan == true && ValidaExistencia == true)
            {
                string Vlan = textBox_Vlan.Text.ToString();
                string query = "SELECT * FROM npms.`" + Vlan + "`;";
                Sentencias.Bbdd_apply_datagridView(Vlan,query,dataGridView_ipv4);              
            }
                        

        }

        private void ButtonFree_Click(object sender, EventArgs e)
        {
            GlobalParam.Vlan_IPv4_Select = textBox_Vlan.Text;
            bool VVlan = Common.ValidadorInt(textBox_Vlan.Text, "Vlan");
            bool ValidaExistencia = Common.ValidadorTabla(textBox_Vlan.Text);
            if (VVlan == true && ValidaExistencia == true) 
            {
                string Vlan = textBox_Vlan.Text.ToString();           
                string id_DireccionRed = Sentencias.Dato_Campo_String("vlan_ipv4", "Vlan", Vlan, 5);
                label2.Text = id_DireccionRed;
                //Extrae los campos ip de la tabla
                string query = "SELECT IP FROM npms.`" + Vlan + "`;";
                //Sentencias.Bbdd_apply_datagridView(Vlan, query, dataGridView_ipv4);

                MySqlConnection databaseConnection = new MySqlConnection(Sentencias.bbdd_connection_data());
                databaseConnection.Open();
                MySqlDataAdapter commandDatabase = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds2 = new DataSet();
                commandDatabase.Fill(ds2, Vlan);
                dataGridView_ipv4.DataSource = ds2;
                dataGridView_ipv4.DataMember = Vlan;
                databaseConnection.Close();
                
                //Parte que genera el rango
                DataTable dt = new DataTable();
                dt.Columns.Add("IP");
                dataGridView_ipv4.DataSource = dt;              
                foreach (var ip in IPAddressRange.Parse(id_DireccionRed))
                {

                        DataRow row = dt.NewRow();
                        row["IP"] = ip;
                        dt.Rows.Add(row);
                    
                    
                }
                
                databaseConnection.Close();

            }

        }
    }
}
