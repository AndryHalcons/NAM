namespace NPMS.gestion.administrator_network.update_databases
{
    partial class Delete_vlan_ipv4
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
            this.textBoxVlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTareaDel = new System.Windows.Forms.TextBox();
            this.labelDelSuccessful = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxVlan, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTareaDel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDelSuccessful, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 131);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxVlan
            // 
            this.textBoxVlan.Location = new System.Drawing.Point(243, 4);
            this.textBoxVlan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxVlan.MaxLength = 20;
            this.textBoxVlan.Name = "textBoxVlan";
            this.textBoxVlan.Size = new System.Drawing.Size(227, 28);
            this.textBoxVlan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Vlan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarea";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTareaDel
            // 
            this.textBoxTareaDel.Location = new System.Drawing.Point(243, 47);
            this.textBoxTareaDel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTareaDel.MaxLength = 50;
            this.textBoxTareaDel.Name = "textBoxTareaDel";
            this.textBoxTareaDel.Size = new System.Drawing.Size(227, 28);
            this.textBoxTareaDel.TabIndex = 2;
            // 
            // labelDelSuccessful
            // 
            this.labelDelSuccessful.AutoSize = true;
            this.labelDelSuccessful.Location = new System.Drawing.Point(4, 86);
            this.labelDelSuccessful.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDelSuccessful.Name = "labelDelSuccessful";
            this.labelDelSuccessful.Size = new System.Drawing.Size(0, 17);
            this.labelDelSuccessful.TabIndex = 5;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonDelete.Location = new System.Drawing.Point(243, 90);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(227, 37);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // Delete_vlan_ipv4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(558, 154);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Delete_vlan_ipv4";
            this.Text = "Delete_vlan_ipv4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVlan;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTareaDel;
        private System.Windows.Forms.Label labelDelSuccessful;
    }
}