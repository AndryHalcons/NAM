namespace NPMS
{
    partial class Gestion
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
            this.administrate_ipv4_ip = new System.Windows.Forms.Button();
            this.administrate_ipv4_vlan = new System.Windows.Forms.Button();
            this.administrate_ipv6_ip = new System.Windows.Forms.Button();
            this.administrate_ipv6_vlan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonLogsIpIpv4 = new System.Windows.Forms.Button();
            this.buttonImportData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFastSource = new System.Windows.Forms.TextBox();
            this.textBoxFastDestination = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFastNetworkFirewall = new System.Windows.Forms.Button();
            this.dataGridViewFastNetworkFirewall = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFastNetworkFirewall)).BeginInit();
            this.SuspendLayout();
            // 
            // administrate_ipv4_ip
            // 
            this.administrate_ipv4_ip.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.administrate_ipv4_ip.Location = new System.Drawing.Point(4, 4);
            this.administrate_ipv4_ip.Margin = new System.Windows.Forms.Padding(4);
            this.administrate_ipv4_ip.Name = "administrate_ipv4_ip";
            this.administrate_ipv4_ip.Size = new System.Drawing.Size(287, 35);
            this.administrate_ipv4_ip.TabIndex = 6;
            this.administrate_ipv4_ip.Text = "Administrate IP IPv4";
            this.administrate_ipv4_ip.UseVisualStyleBackColor = true;
            this.administrate_ipv4_ip.Click += new System.EventHandler(this.Administrate_ipv4_ip_Click);
            // 
            // administrate_ipv4_vlan
            // 
            this.administrate_ipv4_vlan.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.administrate_ipv4_vlan.Location = new System.Drawing.Point(4, 56);
            this.administrate_ipv4_vlan.Margin = new System.Windows.Forms.Padding(4);
            this.administrate_ipv4_vlan.Name = "administrate_ipv4_vlan";
            this.administrate_ipv4_vlan.Size = new System.Drawing.Size(287, 35);
            this.administrate_ipv4_vlan.TabIndex = 7;
            this.administrate_ipv4_vlan.Text = "Administrate VLAN IPv4";
            this.administrate_ipv4_vlan.UseVisualStyleBackColor = true;
            this.administrate_ipv4_vlan.Click += new System.EventHandler(this.Administrate_ipv4_vlan_Click);
            // 
            // administrate_ipv6_ip
            // 
            this.administrate_ipv6_ip.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.administrate_ipv6_ip.Location = new System.Drawing.Point(4, 160);
            this.administrate_ipv6_ip.Margin = new System.Windows.Forms.Padding(4);
            this.administrate_ipv6_ip.Name = "administrate_ipv6_ip";
            this.administrate_ipv6_ip.Size = new System.Drawing.Size(287, 35);
            this.administrate_ipv6_ip.TabIndex = 8;
            this.administrate_ipv6_ip.Text = "Administrate IP IPv6";
            this.administrate_ipv6_ip.UseVisualStyleBackColor = true;
            this.administrate_ipv6_ip.Click += new System.EventHandler(this.Administrate_ipv6_ip_Click);
            // 
            // administrate_ipv6_vlan
            // 
            this.administrate_ipv6_vlan.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.administrate_ipv6_vlan.Location = new System.Drawing.Point(4, 212);
            this.administrate_ipv6_vlan.Margin = new System.Windows.Forms.Padding(4);
            this.administrate_ipv6_vlan.Name = "administrate_ipv6_vlan";
            this.administrate_ipv6_vlan.Size = new System.Drawing.Size(287, 34);
            this.administrate_ipv6_vlan.TabIndex = 9;
            this.administrate_ipv6_vlan.Text = "Administrate VLAN IPv6";
            this.administrate_ipv6_vlan.UseVisualStyleBackColor = true;
            this.administrate_ipv6_vlan.Click += new System.EventHandler(this.Administrate_ipv6_vlan_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.administrate_ipv4_ip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.administrate_ipv4_vlan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.administrate_ipv6_ip, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.administrate_ipv6_vlan, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonUserManagement, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonLogsIpIpv4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonImportData, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 621);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonUserManagement.Location = new System.Drawing.Point(4, 316);
            this.buttonUserManagement.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(287, 34);
            this.buttonUserManagement.TabIndex = 13;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            this.buttonUserManagement.Click += new System.EventHandler(this.ButtonUserManagement_Click);
            // 
            // buttonLogsIpIpv4
            // 
            this.buttonLogsIpIpv4.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonLogsIpIpv4.Location = new System.Drawing.Point(4, 368);
            this.buttonLogsIpIpv4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogsIpIpv4.Name = "buttonLogsIpIpv4";
            this.buttonLogsIpIpv4.Size = new System.Drawing.Size(287, 35);
            this.buttonLogsIpIpv4.TabIndex = 14;
            this.buttonLogsIpIpv4.Text = "View Changes Log";
            this.buttonLogsIpIpv4.UseVisualStyleBackColor = true;
            this.buttonLogsIpIpv4.Click += new System.EventHandler(this.buttonLogsIpIpv4_Click);
            // 
            // buttonImportData
            // 
            this.buttonImportData.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonImportData.Location = new System.Drawing.Point(4, 420);
            this.buttonImportData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonImportData.Name = "buttonImportData";
            this.buttonImportData.Size = new System.Drawing.Size(287, 35);
            this.buttonImportData.TabIndex = 15;
            this.buttonImportData.Text = "Import data";
            this.buttonImportData.UseVisualStyleBackColor = true;
            this.buttonImportData.Click += new System.EventHandler(this.ButtonImportData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast Network Firewall";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label2.Location = new System.Drawing.Point(4, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Source";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFastSource
            // 
            this.textBoxFastSource.Location = new System.Drawing.Point(166, 34);
            this.textBoxFastSource.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFastSource.MaxLength = 30;
            this.textBoxFastSource.Name = "textBoxFastSource";
            this.textBoxFastSource.Size = new System.Drawing.Size(221, 28);
            this.textBoxFastSource.TabIndex = 3;
            // 
            // textBoxFastDestination
            // 
            this.textBoxFastDestination.Location = new System.Drawing.Point(166, 64);
            this.textBoxFastDestination.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFastDestination.MaxLength = 30;
            this.textBoxFastDestination.Name = "textBoxFastDestination";
            this.textBoxFastDestination.Size = new System.Drawing.Size(221, 28);
            this.textBoxFastDestination.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.46973F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.53027F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxFastDestination, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonFastNetworkFirewall, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxFastSource, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(416, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(639, 144);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // buttonFastNetworkFirewall
            // 
            this.buttonFastNetworkFirewall.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonFastNetworkFirewall.Location = new System.Drawing.Point(4, 94);
            this.buttonFastNetworkFirewall.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFastNetworkFirewall.Name = "buttonFastNetworkFirewall";
            this.buttonFastNetworkFirewall.Size = new System.Drawing.Size(153, 37);
            this.buttonFastNetworkFirewall.TabIndex = 5;
            this.buttonFastNetworkFirewall.Text = "Apply";
            this.buttonFastNetworkFirewall.UseVisualStyleBackColor = true;
            this.buttonFastNetworkFirewall.Click += new System.EventHandler(this.ButtonFastNetworkFirewall_Click);
            // 
            // dataGridViewFastNetworkFirewall
            // 
            this.dataGridViewFastNetworkFirewall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFastNetworkFirewall.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewFastNetworkFirewall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFastNetworkFirewall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFastNetworkFirewall.GridColor = System.Drawing.Color.Tan;
            this.dataGridViewFastNetworkFirewall.Location = new System.Drawing.Point(416, 176);
            this.dataGridViewFastNetworkFirewall.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFastNetworkFirewall.Name = "dataGridViewFastNetworkFirewall";
            this.dataGridViewFastNetworkFirewall.ReadOnly = true;
            this.dataGridViewFastNetworkFirewall.Size = new System.Drawing.Size(639, 86);
            this.dataGridViewFastNetworkFirewall.TabIndex = 14;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1076, 762);
            this.Controls.Add(this.dataGridViewFastNetworkFirewall);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gestion";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFastNetworkFirewall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button administrate_ipv4_ip;
        private System.Windows.Forms.Button administrate_ipv4_vlan;
        private System.Windows.Forms.Button administrate_ipv6_ip;
        private System.Windows.Forms.Button administrate_ipv6_vlan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Button buttonLogsIpIpv4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFastSource;
        private System.Windows.Forms.TextBox textBoxFastDestination;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonFastNetworkFirewall;
        private System.Windows.Forms.DataGridView dataGridViewFastNetworkFirewall;
        private System.Windows.Forms.Button buttonImportData;
    }
}