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
            //Metodo que le indica al programa antes de iniciar que tipo de BBDD se va a usar
            //Necesario para que se cargue el string de conexion de la BBDD correspondiente
            Common.Type_bbdd_connection_data();
            //Variables que contienen los datos USUARIO y PASSWORD introducidos por el usuario
            string User = textBoxUser.Text.ToString();
            string Pass = SecureCommon.EncryptHash(textBoxPassword.Text.ToString());         
            //Esta parte valida la configuracion de acceso a la BBDD 
            //Si es true permite que se valide en la aplicacion
            bool ValidaAccesoBBDD = Sentencias.Validar_Conexion_BBDD();
            if (ValidaAccesoBBDD == true)
            {
                //Valida que el usuario y contraseña son correctos y permite iniciar la aplicacion
                bool ValidaAccesoAPP = Sentencias.Bbdd_apply_two_fields_exact("usuarios", "User", "Password", User, Pass);
                if (ValidaAccesoAPP == true)
                {
                    //Obtiene el rol de el usuario
                    string Rol = Sentencias.Dato_Campo_String("usuarios", "User", User, 2);
                    Gestion panelgestion = new Gestion(User,Rol);
                    this.Hide();
                    panelgestion.ShowDialog();
                    this.Close();

                }
            }
                       
            
            
        }
        //Abre el panel de configuracion de acceso a la BBDD
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
