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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Ip = new System.Windows.Forms.TextBox();
            this.label_Ip_octets = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_Update_IP_Data = new System.Windows.Forms.Button();
            this.buttonDeleteVlan = new System.Windows.Forms.Button();
            this.label_Vlan = new System.Windows.Forms.Label();
            this.textBox_Vlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_ipv4_vlan = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv4_vlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.6975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.116F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Ip, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Ip_octets, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_search, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Update_IP_Data, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteVlan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Vlan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Vlan, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
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
            // textBox_Ip
            // 
            this.textBox_Ip.Location = new System.Drawing.Point(230, 43);
            this.textBox_Ip.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ip.MaxLength = 20;
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(166, 28);
            this.textBox_Ip.TabIndex = 4;
            // 
            // label_Ip_octets
            // 
            this.label_Ip_octets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Ip_octets.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_Ip_octets.Location = new System.Drawing.Point(230, 0);
            this.label_Ip_octets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ip_octets.Name = "label_Ip_octets";
            this.label_Ip_octets.Size = new System.Drawing.Size(166, 39);
            this.label_Ip_octets.TabIndex = 1;
            this.label_Ip_octets.Text = "IP";
            this.label_Ip_octets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label_Vlan
            // 
            this.label_Vlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Vlan.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_Vlan.Location = new System.Drawing.Point(404, 0);
            this.label_Vlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Vlan.Name = "label_Vlan";
            this.label_Vlan.Size = new System.Drawing.Size(188, 39);
            this.label_Vlan.TabIndex = 2;
            this.label_Vlan.Text = "Vlan";
            this.label_Vlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Vlan
            // 
            this.textBox_Vlan.Location = new System.Drawing.Point(404, 43);
            this.textBox_Vlan.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Vlan.MaxLength = 20;
            this.textBox_Vlan.Name = "textBox_Vlan";
            this.textBox_Vlan.Size = new System.Drawing.Size(188, 28);
            this.textBox_Vlan.TabIndex = 5;
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
            // dataGridView_ipv4_vlan
            // 
            this.dataGridView_ipv4_vlan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ipv4_vlan.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView_ipv4_vlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ipv4_vlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ipv4_vlan.GridColor = System.Drawing.Color.Tan;
            this.dataGridView_ipv4_vlan.Location = new System.Drawing.Point(13, 189);
            this.dataGridView_ipv4_vlan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ipv4_vlan.Name = "dataGridView_ipv4_vlan";
            this.dataGridView_ipv4_vlan.ReadOnly = true;
            this.dataGridView_ipv4_vlan.Size = new System.Drawing.Size(684, 386);
            this.dataGridView_ipv4_vlan.TabIndex = 11;
            // 
            // Administrate_ipv6_vlan_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(714, 588);
            this.Controls.Add(this.dataGridView_ipv4_vlan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrate_ipv6_vlan_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IPv6 Vlan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv4_vlan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.Label label_Ip_octets;
        private System.Windows.Forms.Label label_Vlan;
        private System.Windows.Forms.TextBox textBox_Vlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Update_IP_Data;
        private System.Windows.Forms.Button buttonDeleteVlan;
        private System.Windows.Forms.DataGridView dataGridView_ipv4_vlan;
    }
}