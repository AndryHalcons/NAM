﻿namespace NPMS.administrate_network
{
    partial class Administrate_ipv4_ip_form
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
            this.dataGridView_ipv4 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Vlan = new System.Windows.Forms.TextBox();
            this.label_Vlan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_Update_IP_Data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv4)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ipv4
            // 
            this.dataGridView_ipv4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ipv4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dataGridView_ipv4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ipv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ipv4.GridColor = System.Drawing.Color.Tan;
            this.dataGridView_ipv4.Location = new System.Drawing.Point(2, 132);
            this.dataGridView_ipv4.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ipv4.Name = "dataGridView_ipv4";
            this.dataGridView_ipv4.ReadOnly = true;
            this.dataGridView_ipv4.Size = new System.Drawing.Size(696, 332);
            this.dataGridView_ipv4.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Vlan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Vlan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_search, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Update_IP_Data, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 87);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // textBox_Vlan
            // 
            this.textBox_Vlan.Location = new System.Drawing.Point(4, 43);
            this.textBox_Vlan.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Vlan.MaxLength = 20;
            this.textBox_Vlan.Name = "textBox_Vlan";
            this.textBox_Vlan.Size = new System.Drawing.Size(63, 28);
            this.textBox_Vlan.TabIndex = 5;
            // 
            // label_Vlan
            // 
            this.label_Vlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Vlan.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_Vlan.Location = new System.Drawing.Point(4, 0);
            this.label_Vlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Vlan.Name = "label_Vlan";
            this.label_Vlan.Size = new System.Drawing.Size(63, 39);
            this.label_Vlan.TabIndex = 2;
            this.label_Vlan.Text = "Select Vlan";
            this.label_Vlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button_search.Location = new System.Drawing.Point(75, 43);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(122, 38);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_Update_IP_Data
            // 
            this.button_Update_IP_Data.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button_Update_IP_Data.Location = new System.Drawing.Point(209, 43);
            this.button_Update_IP_Data.Margin = new System.Windows.Forms.Padding(4);
            this.button_Update_IP_Data.Name = "button_Update_IP_Data";
            this.button_Update_IP_Data.Size = new System.Drawing.Size(245, 38);
            this.button_Update_IP_Data.TabIndex = 8;
            this.button_Update_IP_Data.Text = "Update To Row IP Data";
            this.button_Update_IP_Data.UseVisualStyleBackColor = true;
            this.button_Update_IP_Data.Click += new System.EventHandler(this.button_Update_IP_Data_Click);
            // 
            // Administrate_ipv4_ip_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(700, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView_ipv4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrate_ipv4_ip_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IPv4 IP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv4)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_ipv4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_Vlan;
        private System.Windows.Forms.Label label_Vlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Update_IP_Data;
    }
}