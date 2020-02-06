﻿using System;
using System.Windows.Forms;
using NPMS.gestion.administrator_network.CommonMethods;
using System.Net;

namespace NPMS.gestion.administrator_network.update_databases
{
    public partial class Insert_or_update_vlan_ipv4 : Form
    {
        
        public Insert_or_update_vlan_ipv4()
        {
            InitializeComponent();
            
        }
        

        private void Button_generate_data_Click(object sender, EventArgs e)
        {          
            try
            {               
                IPNetwork ipnetwork = IPNetwork.Parse(textBoxAutomatic.Text);
                string redMask = Convert.ToString(ipnetwork.Cidr);
                string redNetwork = Convert.ToString(ipnetwork.Network);
                string networkandmask = "" + redNetwork + "/" + redMask + "";              
                textBoxDireccionRed.Text = networkandmask;
                textBoxMascara.Text = Convert.ToString(ipnetwork.Netmask);
                textBoxRangoInicio.Text = Convert.ToString(ipnetwork.FirstUsable);
                textBoxRangoFin.Text = Convert.ToString(ipnetwork.LastUsable);
                textBoxGateway1.Text = Convert.ToString(ipnetwork.LastUsable);
            }
            catch
            {
                MessageBox.Show("No ha introducido correctamente el formato 0.0.0.0/0 en 'Generate Data'");
            }                     
        }
        private void Button_apply_update_ipv4_Click(object sender, EventArgs e)
        {
         
            bool BredNetwork = Common.ValidarDatoExistenteConMensaje("vlan_ipv4", "Direccion_red", textBoxDireccionRed.Text,"Network");
            bool VVlan = Common.ValidadorInt(textBoxVlan.Text, "Vlan");
            bool CVlan = Common.ValidadorCamposVacios(textBoxVlan.Text, "Vlan");
            bool CNombreVlan = Common.ValidadorCamposVacios(textBoxNombre.Text,"Nombre");
            bool CRangoInicio = Common.ValidadorCamposVacios(textBoxRangoInicio.Text, "Rango Inicio");
            bool CRangoFin = Common.ValidadorCamposVacios(textBoxRangoFin.Text, "Rango Fin");
            bool CMascara = Common.ValidadorCamposVacios(textBoxMascara.Text, "Mascara");
            bool CDireccionRed = Common.ValidadorCamposVacios(textBoxDireccionRed.Text, "Direccion de Red");
            bool CUbicacion = Common.ValidadorCamposVacios(textBoxUbicacion.Text, "Ubicacion");
            bool CGateway1 = Common.ValidadorCamposVacios(textBoxGateway1.Text, "Gateway 1");
            bool CTarea = Common.ValidadorCamposVacios(textBoxTarea.Text, "Tarea");
            

            

            if (VVlan == true && CVlan == true && CNombreVlan == true && CRangoInicio == true |
                CRangoFin == true && CMascara == true && CDireccionRed == true |
                CUbicacion == true && CGateway1 == true && CTarea == true && BredNetwork == false)
            {

                string id_vlan = textBoxVlan.Text.ToString();               
                string id_nombre_vlan = textBoxNombre.Text.ToString();
                string id_RangoInicio = textBoxRangoInicio.Text.ToString();
                string id_RangoFin = textBoxRangoFin.Text.ToString();
                string id_Mascara = textBoxMascara.Text.ToString();
                string id_DireccionRed = textBoxDireccionRed.Text.ToString();
                string id_Ubicacion = textBoxUbicacion.Text.ToString();
                string id_Gateway1 = textBoxGateway1.Text.ToString();
                string id_Gateway2 = textBoxGateway2.Text.ToString();
                string id_Gateway3 = textBoxGateway3.Text.ToString();
                string id_TipoRed = textBoxTipoRed.Text.ToString();
                string id_Dispositivo = textBoxDispositivo.Text.ToString();
                string id_Clasificacion = textBoxClasificacion.Text.ToString();
                string id_Normativa = textBoxNormativa.Text.ToString();
                string id_Estado = textBoxEstado.Text.ToString();
                string id_Vsys = textBoxVsys.Text.ToString();
                string id_Firewall = textBoxFirewall.Text.ToString();
                string id_Entorno = textBoxEntorno.Text.ToString();
                string id_Observaciones = textBoxObservaciones.Text.ToString();
                string id_Equipos = textBoxEquipos.Text.ToString();
                string id_Descripcion = textBoxDescripcion.Text.ToString();
                string id_Tarea = textBoxTarea.Text.ToString();
                string id_Usuario = Common.UsuarioLogueado();
                bool Exists_Vlan = Common.ValidarExistenciaVlan(id_vlan);
                string tabla = "vlan_ipv4";
                //////////////////////////////////////             
                if (Exists_Vlan == false)
                {
                    Sentencias.Insert_vlan(tabla, id_vlan, id_nombre_vlan, id_Ubicacion, id_Vsys, id_Descripcion,
                     id_DireccionRed, id_RangoInicio, id_RangoFin, id_Mascara, id_Gateway1,
                     id_Gateway2, id_Gateway3, id_Observaciones, id_Dispositivo,
                     id_Firewall, id_Entorno, id_Normativa, id_Estado, id_TipoRed,
                     id_Equipos, id_Clasificacion, id_Tarea, id_Usuario);
                    this.Close();
                }                                                                                 
            }
            else
            {
                MessageBox.Show("Recuerde completar los campos en azul correctamente");
            }
           







        }


    }
}
