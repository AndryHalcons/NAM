﻿using NPMS.gestion.administrator_network.CommonMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPMS.gestion.administrator_network.Logs
{
    public partial class ChangesView : Form
    {
        public ChangesView()
        {
            InitializeComponent();
            comboBoxSearchVlan.SelectedIndex = 0;
            comboBoxSearchIP.SelectedIndex = 0;
            comboBoxSearchInventory.SelectedIndex = 0;
            comboBoxSearchPatching.SelectedIndex = 0;
            comboBoxSearchUser.SelectedIndex = 0;

        }


        private void buttonIP_IPv4_Click(object sender, EventArgs e)
        {

           
            string CampoSeleccionado = comboBoxSearchIP.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Select_all_ip_desc("IPv4", "log_ip_ipv4", dataGridViewLogs);
            }
            else
            {
                if (CampoSeleccionado == "IP")
                {
                    Sentencias.Select_all_ip_like_logs("IPv4", "log_ip_ipv4", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
                else
                {
                    Sentencias.Select_all_ip_like_others_fields_logs("IPv4", "log_ip_ipv4", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
            }
        }

        private void buttonIP_IPv6_Click(object sender, EventArgs e)
        {
            string CampoSeleccionado = comboBoxSearchIP.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Select_all_ip_desc("IPv6", "log_ip_ipv6", dataGridViewLogs);
            }
            else
            {
                if (checkBoxStringSearch.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("log_ip_ipv6", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
                else
                {
                    if (CampoSeleccionado == "Date")
                    {
                        Sentencias.Bbdd_apply_wherelike_datagridView("log_ip_ipv6", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }
                    else
                    {
                        Sentencias.Bbdd_apply_where_datagridView("log_ip_ipv6", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }

                }
            }

        }
        private void buttonVlanIPv4_Click(object sender, EventArgs e)
        {
            
            string CampoSeleccionado = comboBoxSearchVlan.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Bbdd_apply_all_Desc_datagridView("log_vlan_ipv4", dataGridViewLogs);
            }
            else
            {
                if (checkBoxStringSearch.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("log_vlan_ipv4", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
                else
                {
                    if (CampoSeleccionado == "Date")
                    {
                        Sentencias.Bbdd_apply_wherelike_datagridView("log_vlan_ipv4", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }
                    else
                    {
                        Sentencias.Bbdd_apply_where_datagridView("log_vlan_ipv4", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }

                }
            }
        }

       
        private void buttonVlanIPv6_Click(object sender, EventArgs e)
        {
            string CampoSeleccionado = comboBoxSearchVlan.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Bbdd_apply_all_Desc_datagridView("log_vlan_ipv6", dataGridViewLogs);
            }
            else
            {
                if (checkBoxStringSearch.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("log_vlan_ipv6", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
                else
                {
                    if (CampoSeleccionado == "Date")
                    {
                        Sentencias.Bbdd_apply_wherelike_datagridView("log_vlan_ipv6", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }
                    else
                    {
                        Sentencias.Bbdd_apply_where_datagridView("log_vlan_ipv6", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }

                }
            }
        }

        private void ButtonInventory_Click(object sender, EventArgs e)
        {
            string CampoSeleccionado = comboBoxSearchInventory.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Bbdd_apply_all_Desc_datagridView("log_inventory", dataGridViewLogs);
            }
            else
            {
                if (checkBoxStringSearch.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("log_inventory", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
                else
                {
                    if (CampoSeleccionado == "Date")
                    {
                        Sentencias.Bbdd_apply_wherelike_datagridView("log_inventory", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }
                    else
                    {
                        Sentencias.Bbdd_apply_where_datagridView("log_inventory", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }

                }
            }
        }

        private void ButtonPatching_Click(object sender, EventArgs e)
        {
            string CampoSeleccionado = comboBoxSearchPatching.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Bbdd_apply_all_Desc_datagridView("log_patching", dataGridViewLogs);
            }
            else
            {
                if (checkBoxStringSearch.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("log_patching", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
                else
                {
                    if (CampoSeleccionado == "Date")
                    {
                        Sentencias.Bbdd_apply_wherelike_datagridView("log_patching", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }
                    else
                    {
                        Sentencias.Bbdd_apply_where_datagridView("log_patching", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }

                }
            }
        }
        private void ButtonLog_Click(object sender, EventArgs e)
        {
            string CampoSeleccionado = comboBoxSearchUser.SelectedItem.ToString();
            string datocampo = textBoxStringSearch.Text.ToString();
            if (CampoSeleccionado == "ALL")
            {
                Sentencias.Bbdd_apply_all_Desc_datagridView("log_user", dataGridViewLogs);
            }
            else
            {
                if (checkBoxStringSearch.Checked == true)
                {
                    Sentencias.Bbdd_apply_wherelike_datagridView("log_user", CampoSeleccionado, datocampo, dataGridViewLogs);
                }
                else
                {
                    if (CampoSeleccionado == "Date")
                    {
                        Sentencias.Bbdd_apply_wherelike_datagridView("log_user", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }
                    else
                    {
                        Sentencias.Bbdd_apply_where_datagridView("log_user", CampoSeleccionado, datocampo, dataGridViewLogs);
                    }

                }
            }
        }
    }
}

