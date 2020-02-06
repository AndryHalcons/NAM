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
            this.buttonAbrirExcelIp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelExcelNameIP = new System.Windows.Forms.Label();
            this.labelVlanIdIp = new System.Windows.Forms.Label();
            this.textBoxIpId = new System.Windows.Forms.TextBox();
            this.buttonProcesarExcelVlan = new System.Windows.Forms.Button();
            this.buttonAbrirExcelVlan = new System.Windows.Forms.Button();
            this.listBoxVlan = new System.Windows.Forms.ListBox();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelExcelNameVlan
            // 
            this.labelExcelNameVlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExcelNameVlan.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelExcelNameVlan.Location = new System.Drawing.Point(256, 19);
            this.labelExcelNameVlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExcelNameVlan.Name = "labelExcelNameVlan";
            this.labelExcelNameVlan.Size = new System.Drawing.Size(400, 30);
            this.labelExcelNameVlan.TabIndex = 19;
            this.labelExcelNameVlan.Text = "Excel selected";
            this.labelExcelNameVlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAbrirExcelIp
            // 
            this.buttonAbrirExcelIp.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonAbrirExcelIp.Location = new System.Drawing.Point(5, 128);
            this.buttonAbrirExcelIp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAbrirExcelIp.Name = "buttonAbrirExcelIp";
            this.buttonAbrirExcelIp.Size = new System.Drawing.Size(232, 30);
            this.buttonAbrirExcelIp.TabIndex = 22;
            this.buttonAbrirExcelIp.Text = "Open Excel IP";
            this.buttonAbrirExcelIp.UseVisualStyleBackColor = true;
            this.buttonAbrirExcelIp.Click += new System.EventHandler(this.ButtonAbrirExcelIp_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.button2.Location = new System.Drawing.Point(5, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Process excel IP";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labelExcelNameIP
            // 
            this.labelExcelNameIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExcelNameIP.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelExcelNameIP.Location = new System.Drawing.Point(267, 128);
            this.labelExcelNameIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExcelNameIP.Name = "labelExcelNameIP";
            this.labelExcelNameIP.Size = new System.Drawing.Size(389, 30);
            this.labelExcelNameIP.TabIndex = 24;
            this.labelExcelNameIP.Text = "Excel selected";
            this.labelExcelNameIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVlanIdIp
            // 
            this.labelVlanIdIp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVlanIdIp.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.labelVlanIdIp.Location = new System.Drawing.Point(267, 168);
            this.labelVlanIdIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVlanIdIp.Name = "labelVlanIdIp";
            this.labelVlanIdIp.Size = new System.Drawing.Size(87, 28);
            this.labelVlanIdIp.TabIndex = 25;
            this.labelVlanIdIp.Text = "Vlan ID";
            this.labelVlanIdIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIpId
            // 
            this.textBoxIpId.Location = new System.Drawing.Point(371, 168);
            this.textBoxIpId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIpId.MaxLength = 30;
            this.textBoxIpId.Name = "textBoxIpId";
            this.textBoxIpId.Size = new System.Drawing.Size(93, 28);
            this.textBoxIpId.TabIndex = 26;
            // 
            // buttonProcesarExcelVlan
            // 
            this.buttonProcesarExcelVlan.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonProcesarExcelVlan.Location = new System.Drawing.Point(5, 54);
            this.buttonProcesarExcelVlan.Margin = new System.Windows.Forms.Padding(5);
            this.buttonProcesarExcelVlan.Name = "buttonProcesarExcelVlan";
            this.buttonProcesarExcelVlan.Size = new System.Drawing.Size(232, 30);
            this.buttonProcesarExcelVlan.TabIndex = 28;
            this.buttonProcesarExcelVlan.Text = "Process excel Vlan";
            this.buttonProcesarExcelVlan.UseVisualStyleBackColor = true;
            this.buttonProcesarExcelVlan.Click += new System.EventHandler(this.ButtonProcesarExcelVlan_Click);
            // 
            // buttonAbrirExcelVlan
            // 
            this.buttonAbrirExcelVlan.BackgroundImage = global::NPMS.Properties.Resources.botonVerde;
            this.buttonAbrirExcelVlan.Location = new System.Drawing.Point(5, 19);
            this.buttonAbrirExcelVlan.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAbrirExcelVlan.Name = "buttonAbrirExcelVlan";
            this.buttonAbrirExcelVlan.Size = new System.Drawing.Size(232, 30);
            this.buttonAbrirExcelVlan.TabIndex = 29;
            this.buttonAbrirExcelVlan.Text = "Open Excel Vlan";
            this.buttonAbrirExcelVlan.UseVisualStyleBackColor = true;
            this.buttonAbrirExcelVlan.Click += new System.EventHandler(this.ButtonAbrirExcelVlan_Click);
            // 
            // listBoxVlan
            // 
            this.listBoxVlan.AccessibleName = "";
            this.listBoxVlan.FormattingEnabled = true;
            this.listBoxVlan.ItemHeight = 17;
            this.listBoxVlan.Items.AddRange(new object[] {
            "IPv4",
            "IPv6"});
            this.listBoxVlan.Location = new System.Drawing.Point(256, 54);
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
            this.listBoxIP.Location = new System.Drawing.Point(471, 168);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(185, 38);
            this.listBoxIP.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 140);
            this.label1.TabIndex = 32;
            this.label1.Text = "Functional in the following versions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(706, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxIP);
            this.Controls.Add(this.listBoxVlan);
            this.Controls.Add(this.buttonAbrirExcelVlan);
            this.Controls.Add(this.buttonProcesarExcelVlan);
            this.Controls.Add(this.textBoxIpId);
            this.Controls.Add(this.labelVlanIdIp);
            this.Controls.Add(this.labelExcelNameIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAbrirExcelIp);
            this.Controls.Add(this.labelExcelNameVlan);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportData";
            this.Text = "Import Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelExcelNameVlan;
        private System.Windows.Forms.Button buttonAbrirExcelIp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelExcelNameIP;
        private System.Windows.Forms.Label labelVlanIdIp;
        private System.Windows.Forms.TextBox textBoxIpId;
        private System.Windows.Forms.Button buttonProcesarExcelVlan;
        private System.Windows.Forms.Button buttonAbrirExcelVlan;
        private System.Windows.Forms.ListBox listBoxVlan;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.Label label1;
    }
}