namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmFacturas
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtFacturaDetalleVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CboxFacturaCliente = new System.Windows.Forms.ComboBox();
            this.CboxFacturaEmpleado = new System.Windows.Forms.ComboBox();
            this.CboxFacturaSucursal = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtFacturaFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFacturaImpuesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFacturaTotalFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFacturaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaFactura = new System.Windows.Forms.DataGridView();
            this.ColFacturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetalledeventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImpuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(690, 526);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.BtnLimpiar.TabIndex = 26;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(766, 526);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 28);
            this.BtnCerrar.TabIndex = 27;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(313, 522);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(141, 37);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(169, 522);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(141, 37);
            this.BtnModificar.TabIndex = 24;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(23, 522);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(141, 37);
            this.BtnAgregar.TabIndex = 23;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtFacturaDetalleVenta);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CboxFacturaCliente);
            this.groupBox1.Controls.Add(this.CboxFacturaEmpleado);
            this.groupBox1.Controls.Add(this.CboxFacturaSucursal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DtFacturaFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtFacturaImpuesto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtFacturaTotalFactura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFacturaID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 239);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Factura...";
            // 
            // TxtFacturaDetalleVenta
            // 
            this.TxtFacturaDetalleVenta.Location = new System.Drawing.Point(17, 158);
            this.TxtFacturaDetalleVenta.Name = "TxtFacturaDetalleVenta";
            this.TxtFacturaDetalleVenta.Size = new System.Drawing.Size(208, 20);
            this.TxtFacturaDetalleVenta.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Detalle de venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cliente";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Empleado ";
            // 
            // CboxFacturaCliente
            // 
            this.CboxFacturaCliente.FormattingEnabled = true;
            this.CboxFacturaCliente.Location = new System.Drawing.Point(346, 201);
            this.CboxFacturaCliente.Name = "CboxFacturaCliente";
            this.CboxFacturaCliente.Size = new System.Drawing.Size(200, 21);
            this.CboxFacturaCliente.TabIndex = 15;
            // 
            // CboxFacturaEmpleado
            // 
            this.CboxFacturaEmpleado.FormattingEnabled = true;
            this.CboxFacturaEmpleado.Location = new System.Drawing.Point(346, 157);
            this.CboxFacturaEmpleado.Name = "CboxFacturaEmpleado";
            this.CboxFacturaEmpleado.Size = new System.Drawing.Size(200, 21);
            this.CboxFacturaEmpleado.TabIndex = 14;
            // 
            // CboxFacturaSucursal
            // 
            this.CboxFacturaSucursal.FormattingEnabled = true;
            this.CboxFacturaSucursal.Location = new System.Drawing.Point(346, 108);
            this.CboxFacturaSucursal.Name = "CboxFacturaSucursal";
            this.CboxFacturaSucursal.Size = new System.Drawing.Size(200, 21);
            this.CboxFacturaSucursal.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sucursal";
            // 
            // DtFacturaFecha
            // 
            this.DtFacturaFecha.Location = new System.Drawing.Point(346, 55);
            this.DtFacturaFecha.Name = "DtFacturaFecha";
            this.DtFacturaFecha.Size = new System.Drawing.Size(200, 20);
            this.DtFacturaFecha.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Factura";
            // 
            // TxtFacturaImpuesto
            // 
            this.TxtFacturaImpuesto.Location = new System.Drawing.Point(17, 201);
            this.TxtFacturaImpuesto.Name = "TxtFacturaImpuesto";
            this.TxtFacturaImpuesto.Size = new System.Drawing.Size(208, 20);
            this.TxtFacturaImpuesto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Impuestos";
            // 
            // TxtFacturaTotalFactura
            // 
            this.TxtFacturaTotalFactura.Location = new System.Drawing.Point(17, 109);
            this.TxtFacturaTotalFactura.Name = "TxtFacturaTotalFactura";
            this.TxtFacturaTotalFactura.Size = new System.Drawing.Size(208, 20);
            this.TxtFacturaTotalFactura.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total de la Factura";
            // 
            // TxtFacturaID
            // 
            this.TxtFacturaID.Enabled = false;
            this.TxtFacturaID.Location = new System.Drawing.Point(17, 55);
            this.TxtFacturaID.Name = "TxtFacturaID";
            this.TxtFacturaID.Size = new System.Drawing.Size(208, 20);
            this.TxtFacturaID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código de Factura";
            // 
            // DgvListaFactura
            // 
            this.DgvListaFactura.AllowUserToAddRows = false;
            this.DgvListaFactura.AllowUserToDeleteRows = false;
            this.DgvListaFactura.AllowUserToOrderColumns = true;
            this.DgvListaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFacturaID,
            this.ColTotalFactura,
            this.ColDetalledeventa,
            this.ColImpuestos,
            this.ColFechaFactura,
            this.ColNombreS,
            this.ColNombreE,
            this.ColNombreC});
            this.DgvListaFactura.Location = new System.Drawing.Point(23, 62);
            this.DgvListaFactura.MultiSelect = false;
            this.DgvListaFactura.Name = "DgvListaFactura";
            this.DgvListaFactura.ReadOnly = true;
            this.DgvListaFactura.RowHeadersVisible = false;
            this.DgvListaFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaFactura.Size = new System.Drawing.Size(813, 165);
            this.DgvListaFactura.TabIndex = 21;
            this.DgvListaFactura.VirtualMode = true;
            // 
            // ColFacturaID
            // 
            this.ColFacturaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColFacturaID.DataPropertyName = "FacturaID";
            this.ColFacturaID.HeaderText = "FACTURA CODIGO";
            this.ColFacturaID.Name = "ColFacturaID";
            this.ColFacturaID.ReadOnly = true;
            this.ColFacturaID.Width = 80;
            // 
            // ColTotalFactura
            // 
            this.ColTotalFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTotalFactura.DataPropertyName = "TotalFactura";
            this.ColTotalFactura.HeaderText = "TOTAL FACTURA";
            this.ColTotalFactura.Name = "ColTotalFactura";
            this.ColTotalFactura.ReadOnly = true;
            // 
            // ColDetalledeventa
            // 
            this.ColDetalledeventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDetalledeventa.DataPropertyName = "Detalledeventa";
            this.ColDetalledeventa.HeaderText = "DETALLE DE VENTA";
            this.ColDetalledeventa.Name = "ColDetalledeventa";
            this.ColDetalledeventa.ReadOnly = true;
            // 
            // ColImpuestos
            // 
            this.ColImpuestos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColImpuestos.DataPropertyName = "Impuestos";
            this.ColImpuestos.HeaderText = "IMPUESTOS";
            this.ColImpuestos.Name = "ColImpuestos";
            this.ColImpuestos.ReadOnly = true;
            // 
            // ColFechaFactura
            // 
            this.ColFechaFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFechaFactura.DataPropertyName = "FechaFactura";
            this.ColFechaFactura.HeaderText = "FECHA FACTURA";
            this.ColFechaFactura.Name = "ColFechaFactura";
            this.ColFechaFactura.ReadOnly = true;
            // 
            // ColNombreS
            // 
            this.ColNombreS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreS.DataPropertyName = "Nombre";
            this.ColNombreS.HeaderText = "SUCURSAL";
            this.ColNombreS.Name = "ColNombreS";
            this.ColNombreS.ReadOnly = true;
            // 
            // ColNombreE
            // 
            this.ColNombreE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreE.DataPropertyName = "Nombre";
            this.ColNombreE.HeaderText = "EMPLEADO";
            this.ColNombreE.Name = "ColNombreE";
            this.ColNombreE.ReadOnly = true;
            // 
            // ColNombreC
            // 
            this.ColNombreC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombreC.DataPropertyName = "Nombre";
            this.ColNombreC.HeaderText = "CLIENTE";
            this.ColNombreC.Name = "ColNombreC";
            this.ColNombreC.ReadOnly = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(300, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(316, 20);
            this.TxtBuscar.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar";
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 571);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaFactura);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Facturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvListaFactura;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFacturaTotalFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFacturaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtFacturaFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFacturaImpuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboxFacturaCliente;
        private System.Windows.Forms.ComboBox CboxFacturaEmpleado;
        private System.Windows.Forms.ComboBox CboxFacturaSucursal;
        private System.Windows.Forms.TextBox TxtFacturaDetalleVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFacturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDetalledeventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreC;
    }
}