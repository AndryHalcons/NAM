using NPMS.gestion.administrator_network;
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

namespace NPMS
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            

        }

        
        private void Validar_credenciales_Click(object sender, EventArgs e)
        {           
            string User = textBoxUser.Text.ToString();
            string Pass = SecureCommon.Encriptar(textBoxPassword.Text.ToString());
            
            //Esta parte valida la configuracion de acceso a la BBDD 
            bool ValidaAccesoBBDD = Common.EntryUsuarioBBDD();
            if (ValidaAccesoBBDD == true)
            {
                bool ValidaAccesoAPP = Common.EntryUsuarioApp(User, Pass);
                if (ValidaAccesoAPP == true)
                {
                    string Rol = Sentencias.Dato_Campo_String("usuarios", "Usuario", User, 2);
                    Gestion panelgestion = new Gestion(User,Rol);
                    this.Hide();
                    panelgestion.ShowDialog();
                    this.Close();

                }
            }
                       
            
            
        }
        private void Button_connection_settings_Click(object sender, EventArgs e)
        {
            bool ComprobarArchivoBBDD = Common.ArchivoConfBbdd();
            if (ComprobarArchivoBBDD == true)
            {
                Settings panel_settings = new Settings();
                panel_settings.Show();
            }
            
        }
   
    
    }
}
