using NPMS.gestion.administrator_network.CommonMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            Read_bbdd_settings();

        }

        public void Read_bbdd_settings()
        {
            StreamReader sr = File.OpenText(Common.ruta_ArchivoConfBbdd);
            textBox_user_bbdd_settings.Text = SecureCommon.DesEncriptar(sr.ReadLine());
            textBox_password_bbdd_settings.Text = SecureCommon.DesEncriptar(sr.ReadLine());
            textBox_server_bbdd_settings.Text = SecureCommon.DesEncriptar(sr.ReadLine());
            textBox_name_bbdd_settings.Text = SecureCommon.DesEncriptar(sr.ReadLine());
            textBox_name_port_settings.Text = SecureCommon.DesEncriptar(sr.ReadLine());
            comboBox1.SelectedItem = SecureCommon.DesEncriptar(sr.ReadLine());

            sr.Close();
        }

        private void Button_change_bbdd_settings_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(Common.ruta_ArchivoConfBbdd);
            sw.WriteLine(SecureCommon.Encriptar(textBox_user_bbdd_settings.Text.ToString()));
            sw.WriteLine(SecureCommon.Encriptar(textBox_password_bbdd_settings.Text.ToString()));
            sw.WriteLine(SecureCommon.Encriptar(textBox_server_bbdd_settings.Text.ToString()));
            sw.WriteLine(SecureCommon.Encriptar(textBox_name_bbdd_settings.Text.ToString()));
            sw.WriteLine(SecureCommon.Encriptar(textBox_name_port_settings.Text.ToString()));
            sw.WriteLine(SecureCommon.Encriptar(comboBox1.SelectedItem.ToString()));
            sw.Close();
            this.Close();
        }



    }
}
