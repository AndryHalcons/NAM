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
            string query = "SELECT  Usuario,Nivel FROM npms.usuarios;";
            Sentencias.Bbdd_apply_datagridView("usuarios",query,dataGridViewUsers);




        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            listBoxRol.SelectedIndex = 0;         
            bool BUser = Common.ValidadorCamposVacios(textBoxAddName.Text, "User");
            bool BPass = Common.ValidadorCamposVacios(textBoxAddPassword.Text, "Password");
            bool Euser = Common.ValidarDatoExistente("usuarios", "Usuario", textBoxAddName.Text);
            string rol = listBoxRol.SelectedItem.ToString();
            string EncryptUser = textBoxAddName.Text;
            string EncryptPass = SecureCommon.Encriptar(textBoxAddPassword.Text);
            if (Euser == true)
            {
                MessageBox.Show("User already exist!");
            }
            if (BUser == true && BPass == true && Euser == false )
            {
                
                string query = "INSERT INTO `npms`.`usuarios` (`Usuario`, `Password`, `Nivel`) VALUES ('"+EncryptUser+"', '"+EncryptPass+"', '"+rol+"');";
                Sentencias.Bbdd_apply_simple(query);
            }
            DatagridUser();
            textBoxAddName.Text = null;
            textBoxAddPassword.Text = null;
        }

        private void ButtonDelUser_Click(object sender, EventArgs e)
        {
            bool BUser = Common.ValidadorCamposVacios(textBoxDelUser.Text, "User");
            bool ComprobarExistencia = Common.ValidarDatoExistente("usuarios", "Usuario", textBoxDelUser.Text);
            if (ComprobarExistencia == false)
            {
                MessageBox.Show("Username does not exist!");
            }
            if (BUser == true && ComprobarExistencia == true)
            {
                string query = "DELETE FROM `npms`.`usuarios` WHERE (`Usuario` = '" + textBoxDelUser.Text + "');";
                Sentencias.Bbdd_apply_simple(query);
            }
            DatagridUser();
            textBoxDelUser.Text = null;
        }

        private void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            string oldpass = textBoxOldPassword.Text;
            string newpass = textBoxNewPassword.Text;
            string Enewpass = SecureCommon.Encriptar(newpass);
            string Enoldpass = SecureCommon.Encriptar(oldpass);
            string usuario = GlobalParam.IDUser;
            bool Boldpass = Common.ValidadorCamposVacios(oldpass, "Old password");
            bool Bnewpass = Common.ValidadorCamposVacios(newpass, "New password");
            bool ValidarOldPass = Common.EntryUsuarioApp(usuario, Enoldpass);
            if (Boldpass == true && Bnewpass == true && ValidarOldPass == true)
            {
                string query = "UPDATE `npms`.`usuarios` SET `Password` = '"+Enewpass+"' WHERE (`Usuario` = '"+usuario+"');";
                Sentencias.Bbdd_apply("usuarios", query);
            }
            textBoxOldPassword.Text = null;
            textBoxNewPassword.Text = null;
            labelSucessfulPassword.Text = "Successful!";

        }
    }
}
