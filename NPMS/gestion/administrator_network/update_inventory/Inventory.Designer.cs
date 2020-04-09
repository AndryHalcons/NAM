namespace NPMS.gestion.administrator_network
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.comboBoxInventario = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.checkBoxString = new System.Windows.Forms.CheckBox();
            this.Button_Create_Inventory = new System.Windows.Forms.Button();
            this.dataGridViewInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxInventario
            // 
            this.comboBoxInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInventario.FormattingEnabled = true;
            this.comboBoxInventario.Items.AddRange(new object[] {
            "ALL",
            "HOSTNAME",
            "DNS",
            "IP",
            "SN",
            "NAME",
            "MANUFACTURER",
            "LOCATION",
            "ENVIRONMENT",
            "DOMAIN",
            "CONTACT PROPERTY",
            "ADITIONAL INFO",
            "OTHER_1",
            "OTHER_2",
            "COMMENTS"});
            this.comboBoxInventario.Location = new System.Drawing.Point(12, 39);
            this.comboBoxInventario.Name = "comboBoxInventario";
            this.comboBoxInventario.Size = new System.Drawing.Size(241, 25);
            this.comboBoxInventario.TabIndex = 34;
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button_search.Location = new System.Drawing.Point(12, 111);
            this.button_search.Margin = new System.Windows.Forms.Padding(4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(241, 28);
            this.button_search.TabIndex = 35;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(12, 76);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(241, 28);
            this.textBoxSelect.TabIndex = 36;
            // 
            // checkBoxString
            // 
            this.checkBoxString.AutoSize = true;
            this.checkBoxString.Location = new System.Drawing.Point(12, 12);
            this.checkBoxString.Name = "checkBoxString";
            this.checkBoxString.Size = new System.Drawing.Size(115, 21);
            this.checkBoxString.TabIndex = 38;
            this.checkBoxString.Text = "String Search";
            this.checkBoxString.UseVisualStyleBackColor = true;
            // 
            // Button_Create_Inventory
            // 
            this.Button_Create_Inventory.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.Button_Create_Inventory.Location = new System.Drawing.Point(271, 111);
            this.Button_Create_Inventory.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Create_Inventory.Name = "Button_Create_Inventory";
            this.Button_Create_Inventory.Size = new System.Drawing.Size(241, 28);
            this.Button_Create_Inventory.TabIndex = 40;
            this.Button_Create_Inventory.Text = "Update Inventory";
            this.Button_Create_Inventory.UseVisualStyleBackColor = true;
            this.Button_Create_Inventory.Click += new System.EventHandler(this.Button_Create_Inventory_Click);
            // 
            // dataGridViewInventario
            // 
            this.dataGridViewInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewInventario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dataGridViewInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInventario.EnableHeadersVisualStyles = false;
            this.dataGridViewInventario.GridColor = System.Drawing.Color.Tan;
            this.dataGridViewInventario.Location = new System.Drawing.Point(3, 147);
            this.dataGridViewInventario.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewInventario.Name = "dataGridViewInventario";
            this.dataGridViewInventario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewInventario.Size = new System.Drawing.Size(733, 367);
            this.dataGridViewInventario.TabIndex = 41;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(737, 516);
            this.Controls.Add(this.dataGridViewInventario);
            this.Controls.Add(this.Button_Create_Inventory);
            this.Controls.Add(this.checkBoxString);
            this.Controls.Add(this.textBoxSelect);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.comboBoxInventario);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxInventario;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.CheckBox checkBoxString;
        private System.Windows.Forms.Button Button_Create_Inventory;
        private System.Windows.Forms.DataGridView dataGridViewInventario;
    }
}