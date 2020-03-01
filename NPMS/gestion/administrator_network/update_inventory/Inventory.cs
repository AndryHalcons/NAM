using NPMS.gestion.administrator_network.CommonMethods;
using NPMS.gestion.administrator_network.update_inventory;
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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            comboBoxInventario.SelectedIndex = 0;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string CampoSeleccionado = comboBoxInventario.SelectedItem.ToString();
            string datocampo = textBoxSelect.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Bbdd_apply_all_datagridView("inventory", dataGridViewInventario);
            }
            else 
            {
                if (checkBoxString.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("inventory", CampoSeleccionado, datocampo, dataGridViewInventario);

                }
                else
                {
                    Sentencias.Bbdd_apply_where_datagridView("inventory", CampoSeleccionado, datocampo, dataGridViewInventario);

                }
            }        
        }
        private void Button_Create_Inventory_Click(object sender, EventArgs e)
        {
            Update_inventory panel_update_inventory = new Update_inventory();
            panel_update_inventory.Show();
        }
    }
}
