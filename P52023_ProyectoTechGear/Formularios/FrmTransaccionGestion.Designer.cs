namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmTransaccionGestion
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
            this.DtTransaccionCodigo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTransaccionCantidad = new System.Windows.Forms.TextBox();
            this.CboxTransaccionTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTransaccionCodigoFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTransaccionCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.ColTransaccionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(634, 602);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.BtnLimpiar.TabIndex = 30;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(710, 602);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 28);
            this.BtnCerrar.TabIndex = 31;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(303, 598);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(141, 37);
            this.BtnEliminar.TabIndex = 29;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(159, 598);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(141, 37);
            this.BtnModificar.TabIndex = 28;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(13, 598);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(141, 37);
            this.BtnAgregar.TabIndex = 27;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtTransaccionCodigo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtTransaccionCantidad);
            this.groupBox1.Controls.Add(this.CboxTransaccionTipo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtTransaccionCodigoFactura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtTransaccionCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 320);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Soporte Tecnico";
            // 
            // DtTransaccionCodigo
            // 
            this.DtTransaccionCodigo.Location = new System.Drawing.Point(158, 110);
            this.DtTransaccionCodigo.Name = "DtTransaccionCodigo";
            this.DtTransaccionCodigo.Size = new System.Drawing.Size(200, 20);
            this.DtTransaccionCodigo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad:";
            // 
            // TxtTransaccionCantidad
            // 
            this.TxtTransaccionCantidad.Location = new System.Drawing.Point(482, 58);
            this.TxtTransaccionCantidad.Name = "TxtTransaccionCantidad";
            this.TxtTransaccionCantidad.Size = new System.Drawing.Size(240, 20);
            this.TxtTransaccionCantidad.TabIndex = 16;
            // 
            // CboxTransaccionTipo
            // 
            this.CboxTransaccionTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxTransaccionTipo.FormattingEnabled = true;
            this.CboxTransaccionTipo.Location = new System.Drawing.Point(482, 108);
            this.CboxTransaccionTipo.Name = "CboxTransaccionTipo";
            this.CboxTransaccionTipo.Size = new System.Drawing.Size(237, 21);
            this.CboxTransaccionTipo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "TipoTransaccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FechaTransaccion:";
            // 
            // TxtTransaccionCodigoFactura
            // 
            this.TxtTransaccionCodigoFactura.Location = new System.Drawing.Point(330, 185);
            this.TxtTransaccionCodigoFactura.Name = "TxtTransaccionCodigoFactura";
            this.TxtTransaccionCodigoFactura.Size = new System.Drawing.Size(238, 20);
            this.TxtTransaccionCodigoFactura.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código Factura:";
            // 
            // TxtTransaccionCodigo
            // 
            this.TxtTransaccionCodigo.Enabled = false;
            this.TxtTransaccionCodigo.Location = new System.Drawing.Point(158, 54);
            this.TxtTransaccionCodigo.Name = "TxtTransaccionCodigo";
            this.TxtTransaccionCodigo.Size = new System.Drawing.Size(200, 20);
            this.TxtTransaccionCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Transaccion:";
            // 
            // DgvListaEmpleados
            // 
            this.DgvListaEmpleados.AllowUserToAddRows = false;
            this.DgvListaEmpleados.AllowUserToDeleteRows = false;
            this.DgvListaEmpleados.AllowUserToOrderColumns = true;
            this.DgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTransaccionID,
            this.ColFecha,
            this.ColCantidad,
            this.ColTipo,
            this.ColFactura});
            this.DgvListaEmpleados.Location = new System.Drawing.Point(13, 41);
            this.DgvListaEmpleados.MultiSelect = false;
            this.DgvListaEmpleados.Name = "DgvListaEmpleados";
            this.DgvListaEmpleados.ReadOnly = true;
            this.DgvListaEmpleados.RowHeadersVisible = false;
            this.DgvListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaEmpleados.Size = new System.Drawing.Size(767, 229);
            this.DgvListaEmpleados.TabIndex = 25;
            this.DgvListaEmpleados.VirtualMode = true;
            // 
            // ColTransaccionID
            // 
            this.ColTransaccionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTransaccionID.DataPropertyName = "TransaccionID";
            this.ColTransaccionID.HeaderText = "CÓDIGO";
            this.ColTransaccionID.Name = "ColTransaccionID";
            this.ColTransaccionID.ReadOnly = true;
            this.ColTransaccionID.Width = 80;
            // 
            // ColFecha
            // 
            this.ColFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFecha.DataPropertyName = "Fecha";
            this.ColFecha.HeaderText = "FECHA";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.DataPropertyName = "Cantidad";
            this.ColCantidad.HeaderText = "CANTIDAD";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColTipo
            // 
            this.ColTipo.DataPropertyName = "Tipo";
            this.ColTipo.HeaderText = "TIPO ";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // ColFactura
            // 
            this.ColFactura.DataPropertyName = "Factura";
            this.ColFactura.HeaderText = "FACTURA";
            this.ColFactura.Name = "ColFactura";
            this.ColFactura.ReadOnly = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(264, 9);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(316, 20);
            this.TxtBuscar.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Buscar";
            // 
            // FrmTransaccionGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 644);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaEmpleados);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FrmTransaccionGestion";
            this.Text = "Mantenimiento Transaccion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEmpleados)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTransaccionCantidad;
        private System.Windows.Forms.ComboBox CboxTransaccionTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTransaccionCodigoFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTransaccionCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListaEmpleados;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtTransaccionCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransaccionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFactura;
    }
}