namespace NPMS.gestion.administrator_network
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.textBox_server_bbdd_settings = new System.Windows.Forms.TextBox();
            this.textBox_user_bbdd_settings = new System.Windows.Forms.TextBox();
            this.textBox_password_bbdd_settings = new System.Windows.Forms.TextBox();
            this.textBox_name_bbdd_settings = new System.Windows.Forms.TextBox();
            this.labelserver = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelbbdd = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelport = new System.Windows.Forms.Label();
            this.textBox_name_port_settings = new System.Windows.Forms.TextBox();
            this.button_change_bbdd_settings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_server_bbdd_settings
            // 
            this.textBox_server_bbdd_settings.Location = new System.Drawing.Point(184, 49);
            this.textBox_server_bbdd_settings.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_server_bbdd_settings.MaxLength = 30;
            this.textBox_server_bbdd_settings.Name = "textBox_server_bbdd_settings";
            this.textBox_server_bbdd_settings.Size = new System.Drawing.Size(164, 28);
            this.textBox_server_bbdd_settings.TabIndex = 1;
            // 
            // textBox_user_bbdd_settings
            // 
            this.textBox_user_bbdd_settings.Location = new System.Drawing.Point(184, 94);
            this.textBox_user_bbdd_settings.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_user_bbdd_settings.MaxLength = 30;
            this.textBox_user_bbdd_settings.Name = "textBox_user_bbdd_settings";
            this.textBox_user_bbdd_settings.Size = new System.Drawing.Size(164, 28);
            this.textBox_user_bbdd_settings.TabIndex = 2;
            // 
            // textBox_password_bbdd_settings
            // 
            this.textBox_password_bbdd_settings.Location = new System.Drawing.Point(184, 139);
            this.textBox_password_bbdd_settings.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password_bbdd_settings.MaxLength = 30;
            this.textBox_password_bbdd_settings.Name = "textBox_password_bbdd_settings";
            this.textBox_password_bbdd_settings.Size = new System.Drawing.Size(164, 28);
            this.textBox_password_bbdd_settings.TabIndex = 3;
            this.textBox_password_bbdd_settings.UseSystemPasswordChar = true;
            // 
            // textBox_name_bbdd_settings
            // 
            this.textBox_name_bbdd_settings.Location = new System.Drawing.Point(184, 184);
            this.textBox_name_bbdd_settings.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name_bbdd_settings.MaxLength = 30;
            this.textBox_name_bbdd_settings.Name = "textBox_name_bbdd_settings";
            this.textBox_name_bbdd_settings.Size = new System.Drawing.Size(164, 28);
            this.textBox_name_bbdd_settings.TabIndex = 4;
            // 
            // labelserver
            // 
            this.labelserver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelserver.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelserver.Location = new System.Drawing.Point(4, 45);
            this.labelserver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelserver.Name = "labelserver";
            this.labelserver.Size = new System.Drawing.Size(164, 36);
            this.labelserver.TabIndex = 11;
            this.labelserver.Text = "Server";
            this.labelserver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeluser
            // 
            this.labeluser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labeluser.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labeluser.Location = new System.Drawing.Point(4, 90);
            this.labeluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(164, 36);
            this.labeluser.TabIndex = 12;
            this.labeluser.Text = "User";
            this.labeluser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelpassword
            // 
            this.labelpassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelpassword.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelpassword.Location = new System.Drawing.Point(4, 135);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(164, 36);
            this.labelpassword.TabIndex = 13;
            this.labelpassword.Text = "Password";
            this.labelpassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelbbdd
            // 
            this.labelbbdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelbbdd.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelbbdd.Location = new System.Drawing.Point(4, 180);
            this.labelbbdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbbdd.Name = "labelbbdd";
            this.labelbbdd.Size = new System.Drawing.Size(164, 36);
            this.labelbbdd.TabIndex = 14;
            this.labelbbdd.Text = "Database";
            this.labelbbdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_server_bbdd_settings, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelserver, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labeluser, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_user_bbdd_settings, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelpassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_password_bbdd_settings, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelbbdd, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name_bbdd_settings, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelport, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_name_port_settings, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_change_bbdd_settings, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 376);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Database Connection Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelport
            // 
            this.labelport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelport.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelport.Location = new System.Drawing.Point(4, 225);
            this.labelport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelport.Name = "labelport";
            this.labelport.Size = new System.Drawing.Size(165, 36);
            this.labelport.TabIndex = 15;
            this.labelport.Text = "Port";
            this.labelport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_name_port_settings
            // 
            this.textBox_name_port_settings.Location = new System.Drawing.Point(184, 229);
            this.textBox_name_port_settings.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name_port_settings.MaxLength = 30;
            this.textBox_name_port_settings.Name = "textBox_name_port_settings";
            this.textBox_name_port_settings.Size = new System.Drawing.Size(165, 28);
            this.textBox_name_port_settings.TabIndex = 17;
            // 
            // button_change_bbdd_settings
            // 
            this.button_change_bbdd_settings.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button_change_bbdd_settings.Location = new System.Drawing.Point(184, 319);
            this.button_change_bbdd_settings.Margin = new System.Windows.Forms.Padding(4);
            this.button_change_bbdd_settings.Name = "button_change_bbdd_settings";
            this.button_change_bbdd_settings.Size = new System.Drawing.Size(168, 34);
            this.button_change_bbdd_settings.TabIndex = 0;
            this.button_change_bbdd_settings.Text = "Apply";
            this.button_change_bbdd_settings.UseVisualStyleBackColor = true;
            this.button_change_bbdd_settings.Click += new System.EventHandler(this.Button_change_bbdd_settings_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(4, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "BBDD Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MySQL",
            "SQLServer"});
            this.comboBox1.Location = new System.Drawing.Point(183, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 25);
            this.comboBox1.TabIndex = 19;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(425, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_server_bbdd_settings;
        private System.Windows.Forms.TextBox textBox_user_bbdd_settings;
        private System.Windows.Forms.TextBox textBox_password_bbdd_settings;
        private System.Windows.Forms.TextBox textBox_name_bbdd_settings;
        private System.Windows.Forms.Label labelserver;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelbbdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelport;
        private System.Windows.Forms.TextBox textBox_name_port_settings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_change_bbdd_settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}