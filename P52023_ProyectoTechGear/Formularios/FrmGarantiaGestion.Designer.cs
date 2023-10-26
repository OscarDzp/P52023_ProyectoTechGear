namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmGarantiaGestion
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
            this.DgvListaGarantias = new System.Windows.Forms.DataGridView();
            this.ColGarantiaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiempogarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechafinalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtProductoCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGarantiaDetalle = new System.Windows.Forms.TextBox();
            this.DtpFechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGarantiaTiempo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtGarantiaCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaGarantias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaGarantias
            // 
            this.DgvListaGarantias.AllowUserToAddRows = false;
            this.DgvListaGarantias.AllowUserToDeleteRows = false;
            this.DgvListaGarantias.AllowUserToOrderColumns = true;
            this.DgvListaGarantias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaGarantias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGarantiaID,
            this.ColTiempogarantia,
            this.ColFechainicio,
            this.ColFechafinalizacion,
            this.ColDetalle,
            this.ColProductoID});
            this.DgvListaGarantias.Location = new System.Drawing.Point(12, 36);
            this.DgvListaGarantias.MultiSelect = false;
            this.DgvListaGarantias.Name = "DgvListaGarantias";
            this.DgvListaGarantias.ReadOnly = true;
            this.DgvListaGarantias.RowHeadersVisible = false;
            this.DgvListaGarantias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaGarantias.Size = new System.Drawing.Size(973, 227);
            this.DgvListaGarantias.TabIndex = 0;
            this.DgvListaGarantias.VirtualMode = true;
            // 
            // ColGarantiaID
            // 
            this.ColGarantiaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColGarantiaID.DataPropertyName = "GarantiaID";
            this.ColGarantiaID.HeaderText = "CÓDIGO";
            this.ColGarantiaID.Name = "ColGarantiaID";
            this.ColGarantiaID.ReadOnly = true;
            this.ColGarantiaID.Width = 60;
            // 
            // ColTiempogarantia
            // 
            this.ColTiempogarantia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTiempogarantia.DataPropertyName = "Tiempogarantia";
            this.ColTiempogarantia.HeaderText = "PERÍODO DE TIEMPO";
            this.ColTiempogarantia.Name = "ColTiempogarantia";
            this.ColTiempogarantia.ReadOnly = true;
            this.ColTiempogarantia.Width = 150;
            // 
            // ColFechainicio
            // 
            this.ColFechainicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColFechainicio.DataPropertyName = "Fechainicio";
            this.ColFechainicio.HeaderText = "FECHA DE INICIO";
            this.ColFechainicio.Name = "ColFechainicio";
            this.ColFechainicio.ReadOnly = true;
            this.ColFechainicio.Width = 170;
            // 
            // ColFechafinalizacion
            // 
            this.ColFechafinalizacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColFechafinalizacion.DataPropertyName = "Fechafinalizacion";
            this.ColFechafinalizacion.HeaderText = "FECHA DE FINALIZACIÓN";
            this.ColFechafinalizacion.Name = "ColFechafinalizacion";
            this.ColFechafinalizacion.ReadOnly = true;
            this.ColFechafinalizacion.Width = 170;
            // 
            // ColDetalle
            // 
            this.ColDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDetalle.DataPropertyName = "Detalle";
            this.ColDetalle.HeaderText = "DESCRIPCION";
            this.ColDetalle.Name = "ColDetalle";
            this.ColDetalle.ReadOnly = true;
            // 
            // ColProductoID
            // 
            this.ColProductoID.DataPropertyName = "ProductoID";
            this.ColProductoID.HeaderText = "CÓDIGO PRODUCTO";
            this.ColProductoID.Name = "ColProductoID";
            this.ColProductoID.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtProductoCodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtGarantiaDetalle);
            this.groupBox1.Controls.Add(this.DtpFechaFinalizacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DtpFechaInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtGarantiaTiempo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtGarantiaCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Detalle de la Garantía";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtProductoCodigo
            // 
            this.TxtProductoCodigo.Location = new System.Drawing.Point(593, 20);
            this.TxtProductoCodigo.Name = "TxtProductoCodigo";
            this.TxtProductoCodigo.Size = new System.Drawing.Size(351, 20);
            this.TxtProductoCodigo.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Código de Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Detalle";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtGarantiaDetalle
            // 
            this.TxtGarantiaDetalle.Location = new System.Drawing.Point(592, 46);
            this.TxtGarantiaDetalle.Multiline = true;
            this.TxtGarantiaDetalle.Name = "TxtGarantiaDetalle";
            this.TxtGarantiaDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtGarantiaDetalle.Size = new System.Drawing.Size(352, 82);
            this.TxtGarantiaDetalle.TabIndex = 15;
            // 
            // DtpFechaFinalizacion
            // 
            this.DtpFechaFinalizacion.Location = new System.Drawing.Point(123, 105);
            this.DtpFechaFinalizacion.Name = "DtpFechaFinalizacion";
            this.DtpFechaFinalizacion.Size = new System.Drawing.Size(238, 20);
            this.DtpFechaFinalizacion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de Finalización";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Location = new System.Drawing.Point(123, 70);
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.Size = new System.Drawing.Size(238, 20);
            this.DtpFechaInicio.TabIndex = 7;
            this.DtpFechaInicio.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Inicio";
            // 
            // TxtGarantiaTiempo
            // 
            this.TxtGarantiaTiempo.Location = new System.Drawing.Point(123, 41);
            this.TxtGarantiaTiempo.Name = "TxtGarantiaTiempo";
            this.TxtGarantiaTiempo.Size = new System.Drawing.Size(238, 20);
            this.TxtGarantiaTiempo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo de Garantía";
            // 
            // TxtGarantiaCodigo
            // 
            this.TxtGarantiaCodigo.Enabled = false;
            this.TxtGarantiaCodigo.Location = new System.Drawing.Point(123, 16);
            this.TxtGarantiaCodigo.Name = "TxtGarantiaCodigo";
            this.TxtGarantiaCodigo.Size = new System.Drawing.Size(238, 20);
            this.TxtGarantiaCodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Garantía";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Buscar...";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(392, 10);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(223, 20);
            this.TxtBuscar.TabIndex = 3;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 429);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(141, 37);
            this.BtnAgregar.TabIndex = 5;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(159, 429);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(141, 37);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(306, 429);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(141, 37);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(839, 438);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(915, 438);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 28);
            this.BtnCerrar.TabIndex = 14;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // FrmGarantiaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 473);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaGarantias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmGarantiaGestion";
            this.Text = "Mantenimiento de Garantía";
            this.Load += new System.EventHandler(this.FrmGarantiaGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaGarantias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaGarantias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGarantiaTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtGarantiaCodigo;
        private System.Windows.Forms.DateTimePicker DtpFechaInicio;
        private System.Windows.Forms.DateTimePicker DtpFechaFinalizacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtGarantiaDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TextBox TxtProductoCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGarantiaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempogarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechafinalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProductoID;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
    }
}