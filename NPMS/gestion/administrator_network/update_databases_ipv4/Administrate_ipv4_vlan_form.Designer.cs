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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Vlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vsys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rango_ip_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rango_ip_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mascara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gateway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firewall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entorno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Normativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_de_red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ipv4_vlan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.95652F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.78261F));
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 165);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // textBox_Ip
            // 
            this.textBox_Ip.Location = new System.Drawing.Point(249, 43);
            this.textBox_Ip.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ip.MaxLength = 20;
            this.textBox_Ip.Name = "textBox_Ip";
            this.textBox_Ip.Size = new System.Drawing.Size(153, 28);
            this.textBox_Ip.TabIndex = 4;
            // 
            // label_Ip_octets
            // 
            this.label_Ip_octets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Ip_octets.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_Ip_octets.Location = new System.Drawing.Point(249, 0);
            this.label_Ip_octets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Ip_octets.Name = "label_Ip_octets";
            this.label_Ip_octets.Size = new System.Drawing.Size(153, 39);
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
            // label_Vlan
            // 
            this.label_Vlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Vlan.Image = global::NPMS.Properties.Resources.botonNaranja;
            this.label_Vlan.Location = new System.Drawing.Point(410, 0);
            this.label_Vlan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Vlan.Name = "label_Vlan";
            this.label_Vlan.Size = new System.Drawing.Size(188, 39);
            this.label_Vlan.TabIndex = 2;
            this.label_Vlan.Text = "Vlan";
            this.label_Vlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Vlan
            // 
            this.textBox_Vlan.Location = new System.Drawing.Point(410, 43);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ipv4_vlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_ipv4_vlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vlan,
            this.Nombre,
            this.Ubicacion,
            this.Vsys,
            this.Descripcion,
            this.Direccion_red,
            this.Rango_ip_inicio,
            this.Rango_ip_fin,
            this.Mascara,
            this.Gateway,
            this.Observaciones,
            this.Dispositivo,
            this.Firewall,
            this.Entorno,
            this.Normativa,
            this.Estado,
            this.tipo_de_red,
            this.Equipos,
            this.Clasificacion,
            this.Tarea,
            this.Usuario,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(243)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_ipv4_vlan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_ipv4_vlan.EnableHeadersVisualStyles = false;
            this.dataGridView_ipv4_vlan.GridColor = System.Drawing.Color.Tan;
            this.dataGridView_ipv4_vlan.Location = new System.Drawing.Point(2, 202);
            this.dataGridView_ipv4_vlan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ipv4_vlan.Name = "dataGridView_ipv4_vlan";
            this.dataGridView_ipv4_vlan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_ipv4_vlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_ipv4_vlan.Size = new System.Drawing.Size(751, 332);
            this.dataGridView_ipv4_vlan.TabIndex = 11;
            // 
            // Vlan
            // 
            this.Vlan.DataPropertyName = "Vlan";
            this.Vlan.HeaderText = "Vlan";
            this.Vlan.Name = "Vlan";
            this.Vlan.ReadOnly = true;
            this.Vlan.Width = 62;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Name";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 71;
            // 
            // Ubicacion
            // 
            this.Ubicacion.DataPropertyName = "Ubicacion";
            this.Ubicacion.HeaderText = "Location";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 89;
            // 
            // Vsys
            // 
            this.Vsys.DataPropertyName = "Vsys/balanceador/otro";
            this.Vsys.HeaderText = "Vsys";
            this.Vsys.Name = "Vsys";
            this.Vsys.ReadOnly = true;
            this.Vsys.Width = 63;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Description";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 107;
            // 
            // Direccion_red
            // 
            this.Direccion_red.DataPropertyName = "Direccion_red";
            this.Direccion_red.HeaderText = "Network";
            this.Direccion_red.Name = "Direccion_red";
            this.Direccion_red.ReadOnly = true;
            this.Direccion_red.Width = 87;
            // 
            // Rango_ip_inicio
            // 
            this.Rango_ip_inicio.DataPropertyName = "Rango_ip_inicio";
            this.Rango_ip_inicio.HeaderText = "Initial Range";
            this.Rango_ip_inicio.Name = "Rango_ip_inicio";
            this.Rango_ip_inicio.ReadOnly = true;
            this.Rango_ip_inicio.Width = 115;
            // 
            // Rango_ip_fin
            // 
            this.Rango_ip_fin.DataPropertyName = "Rango_ip_fin";
            this.Rango_ip_fin.HeaderText = "Finish Range";
            this.Rango_ip_fin.Name = "Rango_ip_fin";
            this.Rango_ip_fin.ReadOnly = true;
            this.Rango_ip_fin.Width = 117;
            // 
            // Mascara
            // 
            this.Mascara.DataPropertyName = "Mascara";
            this.Mascara.HeaderText = "Mask";
            this.Mascara.Name = "Mascara";
            this.Mascara.ReadOnly = true;
            this.Mascara.Width = 67;
            // 
            // Gateway
            // 
            this.Gateway.DataPropertyName = "Gateway";
            this.Gateway.HeaderText = "Gateway";
            this.Gateway.Name = "Gateway";
            this.Gateway.ReadOnly = true;
            this.Gateway.Width = 90;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observations";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 118;
            // 
            // Dispositivo
            // 
            this.Dispositivo.DataPropertyName = "Dispositivo";
            this.Dispositivo.HeaderText = "Device";
            this.Dispositivo.Name = "Dispositivo";
            this.Dispositivo.ReadOnly = true;
            this.Dispositivo.Width = 77;
            // 
            // Firewall
            // 
            this.Firewall.DataPropertyName = "Firewall";
            this.Firewall.HeaderText = "Firewall";
            this.Firewall.Name = "Firewall";
            this.Firewall.ReadOnly = true;
            this.Firewall.Width = 85;
            // 
            // Entorno
            // 
            this.Entorno.DataPropertyName = "Entorno";
            this.Entorno.HeaderText = "Environment";
            this.Entorno.Name = "Entorno";
            this.Entorno.ReadOnly = true;
            this.Entorno.Width = 114;
            // 
            // Normativa
            // 
            this.Normativa.DataPropertyName = "Normativa";
            this.Normativa.HeaderText = "Normative";
            this.Normativa.Name = "Normativa";
            this.Normativa.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "State";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 68;
            // 
            // tipo_de_red
            // 
            this.tipo_de_red.DataPropertyName = "Tipo_de_red";
            this.tipo_de_red.HeaderText = "Network Type";
            this.tipo_de_red.Name = "tipo_de_red";
            this.tipo_de_red.ReadOnly = true;
            this.tipo_de_red.Width = 122;
            // 
            // Equipos
            // 
            this.Equipos.DataPropertyName = "Equipos";
            this.Equipos.HeaderText = "Equipment";
            this.Equipos.Name = "Equipos";
            this.Equipos.ReadOnly = true;
            this.Equipos.Width = 102;
            // 
            // Clasificacion
            // 
            this.Clasificacion.DataPropertyName = "Clasificacion";
            this.Clasificacion.HeaderText = "Classification";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            this.Clasificacion.Width = 121;
            // 
            // Tarea
            // 
            this.Tarea.DataPropertyName = "Tarea";
            this.Tarea.HeaderText = "Work Order";
            this.Tarea.Name = "Tarea";
            this.Tarea.ReadOnly = true;
            this.Tarea.Width = 105;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "User";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 63;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Date";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 64;
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
        private System.Windows.Forms.TextBox textBox_Ip;
        private System.Windows.Forms.Label label_Ip_octets;
        private System.Windows.Forms.Label label_Vlan;
        private System.Windows.Forms.TextBox textBox_Vlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Update_IP_Data;
        private System.Windows.Forms.Button buttonDeleteVlan;
        private System.Windows.Forms.DataGridView dataGridView_ipv4_vlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vsys;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rango_ip_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rango_ip_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mascara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gateway;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firewall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Normativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_de_red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}