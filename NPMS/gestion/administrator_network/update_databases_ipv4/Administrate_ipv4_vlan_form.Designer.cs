namespace NPMS.administrate_network
{
    partial class Administrate_ipv4_vlan_form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_field_select = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_Update_IP_Data = new System.Windows.Forms.Button();
            this.buttonDeleteVlan = new System.Windows.Forms.Button();
            this.label_String = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ipv4_vlan = new System.Windows.Forms.DataGridView();
            this.textBoxStringSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearchVlan = new System.Windows.Forms.ComboBox();
            this.checkBoxStringSearch = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv4_vlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label_field_select, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_search, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Update_IP_Data, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteVlan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_String, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxStringSearch, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSearchVlan, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxStringSearch, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(614, 165);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label_field_select
            // 
            this.label_field_select.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_field_select.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_field_select.Location = new System.Drawing.Point(249, 0);
            this.label_field_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_field_select.Name = "label_field_select";
            this.label_field_select.Size = new System.Drawing.Size(173, 39);
            this.label_field_select.TabIndex = 1;
            this.label_field_select.Text = "Select Field";
            this.label_field_select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button_search.Location = new System.Drawing.Point(4, 43);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(237, 31);
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
            this.button_Update_IP_Data.Size = new System.Drawing.Size(237, 30);
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
            this.buttonDeleteVlan.Size = new System.Drawing.Size(237, 31);
            this.buttonDeleteVlan.TabIndex = 9;
            this.buttonDeleteVlan.Text = "Delete Vlan";
            this.buttonDeleteVlan.UseVisualStyleBackColor = true;
            this.buttonDeleteVlan.Click += new System.EventHandler(this.ButtonDeleteVlan_Click);
            // 
            // label_String
            // 
            this.label_String.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_String.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_String.Location = new System.Drawing.Point(430, 0);
            this.label_String.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_String.Name = "label_String";
            this.label_String.Size = new System.Drawing.Size(177, 39);
            this.label_String.TabIndex = 2;
            this.label_String.Text = "String";
            this.label_String.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_ipv4_vlan
            // 
            this.dataGridView_ipv4_vlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ipv4_vlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_ipv4_vlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dataGridView_ipv4_vlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ipv4_vlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ipv4_vlan.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_ipv4_vlan.EnableHeadersVisualStyles = false;
            this.dataGridView_ipv4_vlan.GridColor = System.Drawing.Color.Tan;
            this.dataGridView_ipv4_vlan.Location = new System.Drawing.Point(2, 200);
            this.dataGridView_ipv4_vlan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ipv4_vlan.Name = "dataGridView_ipv4_vlan";
            this.dataGridView_ipv4_vlan.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ipv4_vlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_ipv4_vlan.Size = new System.Drawing.Size(751, 332);
            this.dataGridView_ipv4_vlan.TabIndex = 11;
            // 
            // textBoxStringSearch
            // 
            this.textBoxStringSearch.Location = new System.Drawing.Point(429, 42);
            this.textBoxStringSearch.Name = "textBoxStringSearch";
            this.textBoxStringSearch.Size = new System.Drawing.Size(178, 28);
            this.textBoxStringSearch.TabIndex = 10;
            // 
            // comboBoxSearchVlan
            // 
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
            this.comboBoxSearchVlan.Location = new System.Drawing.Point(248, 42);
            this.comboBoxSearchVlan.Name = "comboBoxSearchVlan";
            this.comboBoxSearchVlan.Size = new System.Drawing.Size(174, 25);
            this.comboBoxSearchVlan.TabIndex = 11;
            // 
            // checkBoxStringSearch
            // 
            this.checkBoxStringSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStringSearch.AutoSize = true;
            this.checkBoxStringSearch.Location = new System.Drawing.Point(429, 81);
            this.checkBoxStringSearch.Name = "checkBoxStringSearch";
            this.checkBoxStringSearch.Size = new System.Drawing.Size(182, 32);
            this.checkBoxStringSearch.TabIndex = 12;
            this.checkBoxStringSearch.Text = "String Search";
            this.checkBoxStringSearch.UseVisualStyleBackColor = true;
            // 
            // Administrate_ipv4_vlan_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(766, 536);
            this.Controls.Add(this.dataGridView_ipv4_vlan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrate_ipv4_vlan_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IPv4 Vlan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv4_vlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_field_select;
        private System.Windows.Forms.Label label_String;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Update_IP_Data;
        private System.Windows.Forms.Button buttonDeleteVlan;
        private System.Windows.Forms.DataGridView dataGridView_ipv4_vlan;
        private System.Windows.Forms.TextBox textBoxStringSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchVlan;
        private System.Windows.Forms.CheckBox checkBoxStringSearch;
    }
}