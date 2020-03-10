using MySql.Data.MySqlClient;
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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
            DatagridUser();
        }
        private void DatagridUser()
        {

            Sentencias.Bbdd_apply_2fields_datagridView("usuarios", "Usuario", "Nivel", dataGridViewUsers);

        }
        //Este método crea los nuevos usuarios de la aplicacion
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            listBoxRol.SelectedIndex = 0;         
            bool BUser = Common.ValidadorCamposVacios(textBoxAddName.Text, "User");
            bool BPass = Common.ValidadorCamposVacios(textBoxAddPassword.Text, "Password");
            bool Euser = Sentencias.ValidarDatoExistente("usuarios", "User", textBoxAddName.Text);
            string rol = listBoxRol.SelectedItem.ToString();
            string EncryptUser = textBoxAddName.Text;
            string EncryptPass = SecureCommon.EncryptHash(textBoxAddPassword.Text);
            if (Euser == true)
            {
                MessageBox.Show("User already exist!");
            }
            if (BUser == true && BPass == true && Euser == false )
            {
                
                //string query = "INSERT INTO `npms`.`usuarios` (`Usuario`, `Password`, `Nivel`) " +"VALUES ('"+EncryptUser+"', '"+EncryptPass+"', '"+rol+"');";
                //Sentencias.Bbdd_apply_simple(query);
                Sentencias.Bbdd_apply_create_user(EncryptUser, EncryptPass, rol);
            }
            DatagridUser();
            textBoxAddName.Text = null;
            textBoxAddPassword.Text = null;
        }
        //Este método borra los usuarios de la aplicacion
        private void ButtonDelUser_Click(object sender, EventArgs e)
        {
            bool BUser = Common.ValidadorCamposVacios(textBoxDelUser.Text, "User");
            bool ComprobarExistencia = Sentencias.ValidarDatoExistente("usuarios", "User", textBoxDelUser.Text);
            if (ComprobarExistencia == false)
            {
                MessageBox.Show("Username does not exist!");
            }
            if (BUser == true && ComprobarExistencia == true)
            {
                Sentencias.Bbdd_apply_where_delete("usuarios", "User", textBoxDelUser.Text);
            }
            DatagridUser();
            textBoxDelUser.Text = null;
        }
        //Este método sirve para cambiar la contraseña de el usuario en la aplicacion
        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            string oldpass = textBoxOldPassword.Text;
            string newpass = textBoxNewPassword.Text;
            string Enewpass = SecureCommon.EncryptHash(newpass);
            string Enoldpass = SecureCommon.EncryptHash(oldpass);
            string usuario = GlobalParam.IDUser;
            bool Boldpass = Common.ValidadorCamposVacios(oldpass, "Old password");
            bool Bnewpass = Common.ValidadorCamposVacios(newpass, "New password");
            bool ValidarOldPass = Sentencias.Bbdd_apply_two_fields_exact("usuarios", "User", "Password", usuario, Enoldpass);
            if (Boldpass == true && Bnewpass == true && ValidarOldPass == true)
            {
                Sentencias.Bbdd_apply_where_update("usuarios", "Password", "Usuario", Enewpass, usuario);
            }
            textBoxOldPassword.Text = null;
            textBoxNewPassword.Text = null;
            labelSucessfulPassword.Text = "Successful!";

        }
    }
}
