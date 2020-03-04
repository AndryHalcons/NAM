namespace NPMS.gestion.administrator_network
{
    partial class ImportData
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
            this.labelExcelNameVlan = new System.Windows.Forms.Label();
            this.ButtonOpenExcelIp = new System.Windows.Forms.Button();
            this.ButtonProcessExcelIp = new System.Windows.Forms.Button();
            this.labelExcelNameIP = new System.Windows.Forms.Label();
            this.labelVlanIdIp = new System.Windows.Forms.Label();
            this.textBoxIpId = new System.Windows.Forms.TextBox();
            this.ButtonProcessExcelVlan = new System.Windows.Forms.Button();
            this.ButtonOpenExcelVlan = new System.Windows.Forms.Button();
            this.listBoxVlan = new System.Windows.Forms.ListBox();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonOpenExcelInventory = new System.Windows.Forms.Button();
            this.ButtonProcessExcelInventory = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelVlan = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelIP = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelInventory = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCountPatching = new System.Windows.Forms.Label();
            this.labelPatching = new System.Windows.Forms.Label();
            this.ButtonProcessExcelPatching = new System.Windows.Forms.Button();
            this.ButtonOpenExcelPatching = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCountInventory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCountVlan = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelExcelNameVlan
            // 
            this.labelExcelNameVlan.Location = new System.Drawing.Point(0, 0);
            this.labelExcelNameVlan.Name = "labelExcelNameVlan";
            this.labelExcelNameVlan.Size = new System.Drawing.Size(100, 23);
            this.labelExcelNameVlan.TabIndex = 36;
            // 
            // ButtonOpenExcelIp
            // 
            this.ButtonOpenExcelIp.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonOpenExcelIp.Location = new System.Drawing.Point(5, 94);
            this.ButtonOpenExcelIp.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonOpenExcelIp.Name = "ButtonOpenExcelIp";
            this.ButtonOpenExcelIp.Size = new System.Drawing.Size(232, 30);
            this.ButtonOpenExcelIp.TabIndex = 22;
            this.ButtonOpenExcelIp.Text = "Open Excel IP";
            this.ButtonOpenExcelIp.UseVisualStyleBackColor = true;
            this.ButtonOpenExcelIp.Click += new System.EventHandler(this.ButtonAbrirExcelIp_Click);
            // 
            // ButtonProcessExcelIp
            // 
            this.ButtonProcessExcelIp.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonProcessExcelIp.Location = new System.Drawing.Point(8, 134);
            this.ButtonProcessExcelIp.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonProcessExcelIp.Name = "ButtonProcessExcelIp";
            this.ButtonProcessExcelIp.Size = new System.Drawing.Size(232, 30);
            this.ButtonProcessExcelIp.TabIndex = 23;
            this.ButtonProcessExcelIp.Text = "Process excel IP";
            this.ButtonProcessExcelIp.UseVisualStyleBackColor = true;
            this.ButtonProcessExcelIp.Click += new System.EventHandler(this.ButtonProcessExcelIp_Click);
            // 
            // labelExcelNameIP
            // 
            this.labelExcelNameIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExcelNameIP.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelExcelNameIP.Location = new System.Drawing.Point(8, 59);
            this.labelExcelNameIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExcelNameIP.Name = "labelExcelNameIP";
            this.labelExcelNameIP.Size = new System.Drawing.Size(232, 30);
            this.labelExcelNameIP.TabIndex = 24;
            this.labelExcelNameIP.Text = "Excel selected";
            this.labelExcelNameIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVlanIdIp
            // 
            this.labelVlanIdIp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVlanIdIp.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelVlanIdIp.Location = new System.Drawing.Point(249, 134);
            this.labelVlanIdIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVlanIdIp.Name = "labelVlanIdIp";
            this.labelVlanIdIp.Size = new System.Drawing.Size(87, 28);
            this.labelVlanIdIp.TabIndex = 25;
            this.labelVlanIdIp.Text = "Vlan ID";
            this.labelVlanIdIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIpId
            // 
            this.textBoxIpId.Location = new System.Drawing.Point(342, 134);
            this.textBoxIpId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIpId.MaxLength = 30;
            this.textBoxIpId.Name = "textBoxIpId";
            this.textBoxIpId.Size = new System.Drawing.Size(93, 28);
            this.textBoxIpId.TabIndex = 26;
            // 
            // ButtonProcessExcelVlan
            // 
            this.ButtonProcessExcelVlan.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonProcessExcelVlan.Location = new System.Drawing.Point(49, 136);
            this.ButtonProcessExcelVlan.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonProcessExcelVlan.Name = "ButtonProcessExcelVlan";
            this.ButtonProcessExcelVlan.Size = new System.Drawing.Size(232, 30);
            this.ButtonProcessExcelVlan.TabIndex = 28;
            this.ButtonProcessExcelVlan.Text = "Process excel Vlan";
            this.ButtonProcessExcelVlan.UseVisualStyleBackColor = true;
            this.ButtonProcessExcelVlan.Click += new System.EventHandler(this.ButtonProcesarExcelVlan_Click);
            // 
            // ButtonOpenExcelVlan
            // 
            this.ButtonOpenExcelVlan.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonOpenExcelVlan.Location = new System.Drawing.Point(49, 90);
            this.ButtonOpenExcelVlan.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonOpenExcelVlan.Name = "ButtonOpenExcelVlan";
            this.ButtonOpenExcelVlan.Size = new System.Drawing.Size(232, 30);
            this.ButtonOpenExcelVlan.TabIndex = 29;
            this.ButtonOpenExcelVlan.Text = "Open Excel Vlan";
            this.ButtonOpenExcelVlan.UseVisualStyleBackColor = true;
            this.ButtonOpenExcelVlan.Click += new System.EventHandler(this.ButtonAbrirExcelVlan_Click);
            // 
            // listBoxVlan
            // 
            this.listBoxVlan.AccessibleName = "";
            this.listBoxVlan.FormattingEnabled = true;
            this.listBoxVlan.ItemHeight = 17;
            this.listBoxVlan.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.listBoxVlan.Location = new System.Drawing.Point(319, 128);
            this.listBoxVlan.Name = "listBoxVlan";
            this.listBoxVlan.Size = new System.Drawing.Size(205, 38);
            this.listBoxVlan.TabIndex = 30;
            // 
            // listBoxIP
            // 
            this.listBoxIP.AccessibleName = "";
            this.listBoxIP.FormattingEnabled = true;
            this.listBoxIP.ItemHeight = 17;
            this.listBoxIP.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.listBoxIP.Location = new System.Drawing.Point(248, 165);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(185, 38);
            this.listBoxIP.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Import VLANs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(643, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Import IPs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(643, 30);
            this.label3.TabIndex = 34;
            this.label3.Text = "Import Inventory";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonOpenExcelInventory
            // 
            this.ButtonOpenExcelInventory.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonOpenExcelInventory.Location = new System.Drawing.Point(29, 72);
            this.ButtonOpenExcelInventory.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonOpenExcelInventory.Name = "ButtonOpenExcelInventory";
            this.ButtonOpenExcelInventory.Size = new System.Drawing.Size(232, 30);
            this.ButtonOpenExcelInventory.TabIndex = 35;
            this.ButtonOpenExcelInventory.Text = "Open Excel Inventory";
            this.ButtonOpenExcelInventory.UseVisualStyleBackColor = true;
            this.ButtonOpenExcelInventory.Click += new System.EventHandler(this.ButtonOpenExcelInventory_Click);
            // 
            // ButtonProcessExcelInventory
            // 
            this.ButtonProcessExcelInventory.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonProcessExcelInventory.Location = new System.Drawing.Point(29, 112);
            this.ButtonProcessExcelInventory.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonProcessExcelInventory.Name = "ButtonProcessExcelInventory";
            this.ButtonProcessExcelInventory.Size = new System.Drawing.Size(232, 30);
            this.ButtonProcessExcelInventory.TabIndex = 36;
            this.ButtonProcessExcelInventory.Text = "Process excel Inventory";
            this.ButtonProcessExcelInventory.UseVisualStyleBackColor = true;
            this.ButtonProcessExcelInventory.Click += new System.EventHandler(this.ButtonProcessExcelInventory_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 543);
            this.tabControl1.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.tabPage1.Controls.Add(this.labelCountVlan);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.labelVlan);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ButtonOpenExcelVlan);
            this.tabPage1.Controls.Add(this.ButtonProcessExcelVlan);
            this.tabPage1.Controls.Add(this.listBoxVlan);
            this.tabPage1.Controls.Add(this.labelExcelNameVlan);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vlan";
            // 
            // labelVlan
            // 
            this.labelVlan.AutoSize = true;
            this.labelVlan.Location = new System.Drawing.Point(307, 97);
            this.labelVlan.Name = "labelVlan";
            this.labelVlan.Size = new System.Drawing.Size(87, 17);
            this.labelVlan.TabIndex = 35;
            this.labelVlan.Text = "Excel Select";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.tabPage2.Controls.Add(this.labelIP);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ButtonOpenExcelIp);
            this.tabPage2.Controls.Add(this.ButtonProcessExcelIp);
            this.tabPage2.Controls.Add(this.labelVlanIdIp);
            this.tabPage2.Controls.Add(this.labelExcelNameIP);
            this.tabPage2.Controls.Add(this.listBoxIP);
            this.tabPage2.Controls.Add(this.textBoxIpId);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IP";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(249, 101);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(87, 17);
            this.labelIP.TabIndex = 34;
            this.labelIP.Text = "Excel Select";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.tabPage3.Controls.Add(this.labelCountInventory);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.labelInventory);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.ButtonProcessExcelInventory);
            this.tabPage3.Controls.Add(this.ButtonOpenExcelInventory);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(781, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventory";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(281, 79);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(87, 17);
            this.labelInventory.TabIndex = 37;
            this.labelInventory.Text = "Excel Select";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.labelCountPatching);
            this.tabPage4.Controls.Add(this.labelPatching);
            this.tabPage4.Controls.Add(this.ButtonProcessExcelPatching);
            this.tabPage4.Controls.Add(this.ButtonOpenExcelPatching);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(781, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Patching";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label6.Location = new System.Drawing.Point(19, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 39);
            this.label6.TabIndex = 41;
            this.label6.Text = "Import Rows";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountPatching
            // 
            this.labelCountPatching.AutoSize = true;
            this.labelCountPatching.Location = new System.Drawing.Point(182, 162);
            this.labelCountPatching.Name = "labelCountPatching";
            this.labelCountPatching.Size = new System.Drawing.Size(62, 17);
            this.labelCountPatching.TabIndex = 39;
            this.labelCountPatching.Text = "Nº Rows";
            // 
            // labelPatching
            // 
            this.labelPatching.AutoSize = true;
            this.labelPatching.Location = new System.Drawing.Point(258, 63);
            this.labelPatching.Name = "labelPatching";
            this.labelPatching.Size = new System.Drawing.Size(87, 17);
            this.labelPatching.TabIndex = 38;
            this.labelPatching.Text = "Excel Select";
            // 
            // ButtonProcessExcelPatching
            // 
            this.ButtonProcessExcelPatching.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonProcessExcelPatching.Location = new System.Drawing.Point(8, 96);
            this.ButtonProcessExcelPatching.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonProcessExcelPatching.Name = "ButtonProcessExcelPatching";
            this.ButtonProcessExcelPatching.Size = new System.Drawing.Size(232, 30);
            this.ButtonProcessExcelPatching.TabIndex = 37;
            this.ButtonProcessExcelPatching.Text = "Process excel Patching";
            this.ButtonProcessExcelPatching.UseVisualStyleBackColor = true;
            this.ButtonProcessExcelPatching.Click += new System.EventHandler(this.ButtonProcessExcelPatching_Click);
            // 
            // ButtonOpenExcelPatching
            // 
            this.ButtonOpenExcelPatching.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.ButtonOpenExcelPatching.Location = new System.Drawing.Point(8, 56);
            this.ButtonOpenExcelPatching.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonOpenExcelPatching.Name = "ButtonOpenExcelPatching";
            this.ButtonOpenExcelPatching.Size = new System.Drawing.Size(232, 30);
            this.ButtonOpenExcelPatching.TabIndex = 36;
            this.ButtonOpenExcelPatching.Text = "Open Excel Patching";
            this.ButtonOpenExcelPatching.UseVisualStyleBackColor = true;
            this.ButtonOpenExcelPatching.Click += new System.EventHandler(this.ButtonOpenExcelPatching_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label4.Location = new System.Drawing.Point(8, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(643, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Import Patching";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 39);
            this.label5.TabIndex = 42;
            this.label5.Text = "Import Rows";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountInventory
            // 
            this.labelCountInventory.AutoSize = true;
            this.labelCountInventory.Location = new System.Drawing.Point(181, 158);
            this.labelCountInventory.Name = "labelCountInventory";
            this.labelCountInventory.Size = new System.Drawing.Size(62, 17);
            this.labelCountInventory.TabIndex = 43;
            this.labelCountInventory.Text = "Nº Rows";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label7.Location = new System.Drawing.Point(49, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 39);
            this.label7.TabIndex = 43;
            this.label7.Text = "Import Rows";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCountVlan
            // 
            this.labelCountVlan.AutoSize = true;
            this.labelCountVlan.Location = new System.Drawing.Point(182, 198);
            this.labelCountVlan.Name = "labelCountVlan";
            this.labelCountVlan.Size = new System.Drawing.Size(62, 17);
            this.labelCountVlan.TabIndex = 44;
            this.labelCountVlan.Text = "Nº Rows";
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(803, 557);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportData";
            this.Text = "Import Data";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelExcelNameVlan;
        private System.Windows.Forms.Button ButtonOpenExcelIp;
        private System.Windows.Forms.Button ButtonProcessExcelIp;
        private System.Windows.Forms.Label labelExcelNameIP;
        private System.Windows.Forms.Label labelVlanIdIp;
        private System.Windows.Forms.TextBox textBoxIpId;
        private System.Windows.Forms.Button ButtonProcessExcelVlan;
        private System.Windows.Forms.Button ButtonOpenExcelVlan;
        private System.Windows.Forms.ListBox listBoxVlan;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonOpenExcelInventory;
        private System.Windows.Forms.Button ButtonProcessExcelInventory;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ButtonProcessExcelPatching;
        private System.Windows.Forms.Button ButtonOpenExcelPatching;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelVlan;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelPatching;
        private System.Windows.Forms.Label labelCountPatching;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCountInventory;
        private System.Windows.Forms.Label labelCountVlan;
        private System.Windows.Forms.Label label7;
    }
}