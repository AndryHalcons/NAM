namespace NPMS.gestion.administrator_network
{
    partial class UserManagement
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.textBoxAddPassword = new System.Windows.Forms.TextBox();
            this.listBoxRol = new System.Windows.Forms.ListBox();
            this.labelName2 = new System.Windows.Forms.Label();
            this.textBoxDelUser = new System.Windows.Forms.TextBox();
            this.buttonDelUser = new System.Windows.Forms.Button();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelSucessfulPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.dataGridViewUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.Tan;
            this.dataGridViewUsers.Location = new System.Drawing.Point(4, 16);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(243, 409);
            this.dataGridViewUsers.TabIndex = 5;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonAddUser.Location = new System.Drawing.Point(216, 74);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(205, 30);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.51936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48064F));
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddPassword, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxRol, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddUser, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelName2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDelUser, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelUser, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelOldPass, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelNewPass, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOldPassword, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNewPassword, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonChangePassword, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelSucessfulPassword, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(255, 16);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 375);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelName.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelName.Location = new System.Drawing.Point(4, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(203, 33);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(216, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(4, 43);
            this.textBoxAddName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddName.MaxLength = 30;
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(203, 28);
            this.textBoxAddName.TabIndex = 0;
            // 
            // textBoxAddPassword
            // 
            this.textBoxAddPassword.Location = new System.Drawing.Point(216, 43);
            this.textBoxAddPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddPassword.MaxLength = 30;
            this.textBoxAddPassword.Name = "textBoxAddPassword";
            this.textBoxAddPassword.Size = new System.Drawing.Size(203, 28);
            this.textBoxAddPassword.TabIndex = 1;
            this.textBoxAddPassword.UseSystemPasswordChar = true;
            // 
            // listBoxRol
            // 
            this.listBoxRol.AccessibleName = "";
            this.listBoxRol.FormattingEnabled = true;
            this.listBoxRol.ItemHeight = 17;
            this.listBoxRol.Items.AddRange(new object[] {
            "Administrator",
            "Read Only"});
            this.listBoxRol.Location = new System.Drawing.Point(3, 73);
            this.listBoxRol.Name = "listBoxRol";
            this.listBoxRol.Size = new System.Drawing.Size(205, 38);
            this.listBoxRol.TabIndex = 4;
            // 
            // labelName2
            // 
            this.labelName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelName2.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelName2.Location = new System.Drawing.Point(4, 154);
            this.labelName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName2.Name = "labelName2";
            this.labelName2.Size = new System.Drawing.Size(203, 33);
            this.labelName2.TabIndex = 6;
            this.labelName2.Text = "Name";
            this.labelName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDelUser
            // 
            this.textBoxDelUser.Location = new System.Drawing.Point(4, 192);
            this.textBoxDelUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDelUser.MaxLength = 30;
            this.textBoxDelUser.Name = "textBoxDelUser";
            this.textBoxDelUser.Size = new System.Drawing.Size(203, 28);
            this.textBoxDelUser.TabIndex = 3;
            // 
            // buttonDelUser
            // 
            this.buttonDelUser.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonDelUser.Location = new System.Drawing.Point(216, 192);
            this.buttonDelUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelUser.Name = "buttonDelUser";
            this.buttonDelUser.Size = new System.Drawing.Size(204, 30);
            this.buttonDelUser.TabIndex = 4;
            this.buttonDelUser.Text = "Delete User";
            this.buttonDelUser.UseVisualStyleBackColor = true;
            this.buttonDelUser.Click += new System.EventHandler(this.ButtonDelUser_Click);
            // 
            // labelOldPass
            // 
            this.labelOldPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOldPass.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelOldPass.Location = new System.Drawing.Point(4, 261);
            this.labelOldPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(203, 33);
            this.labelOldPass.TabIndex = 8;
            this.labelOldPass.Text = "Old password";
            this.labelOldPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewPass
            // 
            this.labelNewPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelNewPass.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelNewPass.Location = new System.Drawing.Point(216, 261);
            this.labelNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(203, 33);
            this.labelNewPass.TabIndex = 9;
            this.labelNewPass.Text = "New password";
            this.labelNewPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(4, 305);
            this.textBoxOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOldPassword.MaxLength = 30;
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(203, 28);
            this.textBoxOldPassword.TabIndex = 11;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(216, 305);
            this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNewPassword.MaxLength = 30;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(203, 28);
            this.textBoxNewPassword.TabIndex = 12;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonChangePassword.Location = new System.Drawing.Point(216, 340);
            this.buttonChangePassword.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(204, 30);
            this.buttonChangePassword.TabIndex = 10;
            this.buttonChangePassword.Text = "Change my password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click);
            // 
            // labelSucessfulPassword
            // 
            this.labelSucessfulPassword.AutoSize = true;
            this.labelSucessfulPassword.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelSucessfulPassword.Location = new System.Drawing.Point(3, 336);
            this.labelSucessfulPassword.Name = "labelSucessfulPassword";
            this.labelSucessfulPassword.Size = new System.Drawing.Size(0, 17);
            this.labelSucessfulPassword.TabIndex = 13;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(700, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridViewUsers);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagement";
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonDelUser;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.TextBox textBoxAddPassword;
        private System.Windows.Forms.TextBox textBoxDelUser;
        private System.Windows.Forms.Label labelName2;
        private System.Windows.Forms.ListBox listBoxRol;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelSucessfulPassword;
    }
}