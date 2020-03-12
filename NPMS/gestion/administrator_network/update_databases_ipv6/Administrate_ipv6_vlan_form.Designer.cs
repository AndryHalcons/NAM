namespace NPMS.administrate_network
{
    partial class Administrate_ipv6_vlan_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_search = new System.Windows.Forms.Button();
            this.button_Update_IP_Data = new System.Windows.Forms.Button();
            this.buttonDeleteVlan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_field_select = new System.Windows.Forms.Label();
            this.comboBoxSearchVlan = new System.Windows.Forms.ComboBox();
            this.label_String = new System.Windows.Forms.Label();
            this.textBoxStringSearch = new System.Windows.Forms.TextBox();
            this.checkBoxStringSearch = new System.Windows.Forms.CheckBox();
            this.dataGridView_ipv6_vlan = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv6_vlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.6975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.116F));
            this.tableLayoutPanel1.Controls.Add(this.button_search, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Update_IP_Data, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteVlan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_field_select, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSearchVlan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_String, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStringSearch, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxStringSearch, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 165);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button_search.Location = new System.Drawing.Point(4, 43);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(218, 31);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // button_Update_IP_Data
            // 
            this.button_Update_IP_Data.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button_Update_IP_Data.Location = new System.Drawing.Point(4, 82);
            this.button_Update_IP_Data.Margin = new System.Windows.Forms.Padding(4);
            this.button_Update_IP_Data.Name = "button_Update_IP_Data";
            this.button_Update_IP_Data.Size = new System.Drawing.Size(218, 30);
            this.button_Update_IP_Data.TabIndex = 8;
            this.button_Update_IP_Data.Text = "Create Vlan";
            this.button_Update_IP_Data.UseVisualStyleBackColor = true;
            this.button_Update_IP_Data.Click += new System.EventHandler(this.Button_Update_IP_Data_Click);
            // 
            // buttonDeleteVlan
            // 
            this.buttonDeleteVlan.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonDeleteVlan.Location = new System.Drawing.Point(4, 120);
            this.buttonDeleteVlan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteVlan.Name = "buttonDeleteVlan";
            this.buttonDeleteVlan.Size = new System.Drawing.Size(218, 31);
            this.buttonDeleteVlan.TabIndex = 9;
            this.buttonDeleteVlan.Text = "Delete Vlan";
            this.buttonDeleteVlan.UseVisualStyleBackColor = true;
            this.buttonDeleteVlan.Click += new System.EventHandler(this.ButtonDeleteVlan_Click);
            // 
            // label1
            // 
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_field_select
            // 
            this.label_field_select.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_field_select.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_field_select.Location = new System.Drawing.Point(230, 0);
            this.label_field_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_field_select.Name = "label_field_select";
            this.label_field_select.Size = new System.Drawing.Size(166, 39);
            this.label_field_select.TabIndex = 10;
            this.label_field_select.Text = "Select Field";
            this.label_field_select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSearchVlan
            // 
            this.comboBoxSearchVlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchVlan.FormattingEnabled = true;
            this.comboBoxSearchVlan.Items.AddRange(new object[] {
            "ALL",
            "Vlan",
            "Name",
            "Location",
            "Description",
            "Network",
            "Initial_Range",
            "Final_Range",
            "Mask",
            "Observations",
            "Device",
            "Firewall",
            "Environment",
            "Normative",
            "Status",
            "Network_Type",
            "Equipment",
            "Classification",
            "Work_Order",
            "User",
            "Date"});
            this.comboBoxSearchVlan.Location = new System.Drawing.Point(229, 42);
            this.comboBoxSearchVlan.Name = "comboBoxSearchVlan";
            this.comboBoxSearchVlan.Size = new System.Drawing.Size(168, 25);
            this.comboBoxSearchVlan.TabIndex = 12;
            // 
            // label_String
            // 
            this.label_String.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_String.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_String.Location = new System.Drawing.Point(404, 0);
            this.label_String.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_String.Name = "label_String";
            this.label_String.Size = new System.Drawing.Size(177, 39);
            this.label_String.TabIndex = 13;
            this.label_String.Text = "String";
            this.label_String.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStringSearch
            // 
            this.textBoxStringSearch.Location = new System.Drawing.Point(403, 42);
            this.textBoxStringSearch.Name = "textBoxStringSearch";
            this.textBoxStringSearch.Size = new System.Drawing.Size(178, 28);
            this.textBoxStringSearch.TabIndex = 14;
            // 
            // checkBoxStringSearch
            // 
            this.checkBoxStringSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStringSearch.AutoSize = true;
            this.checkBoxStringSearch.Location = new System.Drawing.Point(403, 81);
            this.checkBoxStringSearch.Name = "checkBoxStringSearch";
            this.checkBoxStringSearch.Size = new System.Drawing.Size(275, 32);
            this.checkBoxStringSearch.TabIndex = 15;
            this.checkBoxStringSearch.Text = "String Search";
            this.checkBoxStringSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ipv6_vlan
            // 
            this.dataGridView_ipv6_vlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ipv6_vlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_ipv6_vlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dataGridView_ipv6_vlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ipv6_vlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ipv6_vlan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ipv6_vlan.EnableHeadersVisualStyles = false;
            this.dataGridView_ipv6_vlan.GridColor = System.Drawing.Color.Tan;
            this.dataGridView_ipv6_vlan.Location = new System.Drawing.Point(5, 189);
            this.dataGridView_ipv6_vlan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ipv6_vlan.Name = "dataGridView_ipv6_vlan";
            this.dataGridView_ipv6_vlan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ipv6_vlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ipv6_vlan.Size = new System.Drawing.Size(705, 287);
            this.dataGridView_ipv6_vlan.TabIndex = 11;
            // 
            // Administrate_ipv6_vlan_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(714, 478);
            this.Controls.Add(this.dataGridView_ipv6_vlan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrate_ipv6_vlan_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IPv6 Vlan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv6_vlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Update_IP_Data;
        private System.Windows.Forms.Button buttonDeleteVlan;
        private System.Windows.Forms.DataGridView dataGridView_ipv6_vlan;
        private System.Windows.Forms.Label label_field_select;
        private System.Windows.Forms.ComboBox comboBoxSearchVlan;
        private System.Windows.Forms.Label label_String;
        private System.Windows.Forms.TextBox textBoxStringSearch;
        private System.Windows.Forms.CheckBox checkBoxStringSearch;
    }
}