namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmClienteGestion
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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtClienteCedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtClienteDireccion = new System.Windows.Forms.TextBox();
            this.TxtClienteTelefono = new System.Windows.Forms.TextBox();
            this.TxtClienteCorreoElectronico = new System.Windows.Forms.TextBox();
            this.TxtClienteNombre = new System.Windows.Forms.TextBox();
            this.TxtClienteCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaClientes = new System.Windows.Forms.DataGridView();
            this.ColClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(690, 469);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.BtnLimpiar.TabIndex = 26;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(766, 469);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 28);
            this.BtnCerrar.TabIndex = 27;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(313, 465);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(141, 37);
            this.BtnEliminar.TabIndex = 25;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(169, 465);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(141, 37);
            this.BtnModificar.TabIndex = 24;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(23, 465);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(141, 37);
            this.BtnAgregar.TabIndex = 23;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TxtClienteCedula);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtClienteDireccion);
            this.groupBox1.Controls.Add(this.TxtClienteTelefono);
            this.groupBox1.Controls.Add(this.TxtClienteCorreoElectronico);
            this.groupBox1.Controls.Add(this.TxtClienteNombre);
            this.groupBox1.Controls.Add(this.TxtClienteCodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 221);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Categoria...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(418, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 18);
            this.label12.TabIndex = 34;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(418, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(59, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 18);
            this.label10.TabIndex = 32;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(109, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(109, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(709, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Datos Requeridos.....";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(688, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "*";
            // 
            // TxtClienteCedula
            // 
            this.TxtClienteCedula.Location = new System.Drawing.Point(22, 189);
            this.TxtClienteCedula.Name = "TxtClienteCedula";
            this.TxtClienteCedula.Size = new System.Drawing.Size(254, 20);
            this.TxtClienteCedula.TabIndex = 11;
            this.TxtClienteCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClienteCedula_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cedula";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtClienteDireccion
            // 
            this.TxtClienteDireccion.Location = new System.Drawing.Point(374, 45);
            this.TxtClienteDireccion.Multiline = true;
            this.TxtClienteDireccion.Name = "TxtClienteDireccion";
            this.TxtClienteDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtClienteDireccion.Size = new System.Drawing.Size(257, 82);
            this.TxtClienteDireccion.TabIndex = 9;
            this.TxtClienteDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClienteDireccion_KeyPress);
            // 
            // TxtClienteTelefono
            // 
            this.TxtClienteTelefono.Location = new System.Drawing.Point(374, 151);
            this.TxtClienteTelefono.Name = "TxtClienteTelefono";
            this.TxtClienteTelefono.Size = new System.Drawing.Size(257, 20);
            this.TxtClienteTelefono.TabIndex = 8;
            this.TxtClienteTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClienteTelefono_KeyPress);
            // 
            // TxtClienteCorreoElectronico
            // 
            this.TxtClienteCorreoElectronico.Location = new System.Drawing.Point(22, 145);
            this.TxtClienteCorreoElectronico.Name = "TxtClienteCorreoElectronico";
            this.TxtClienteCorreoElectronico.Size = new System.Drawing.Size(257, 20);
            this.TxtClienteCorreoElectronico.TabIndex = 7;
            this.TxtClienteCorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClienteCorreoElectronico_KeyPress);
            // 
            // TxtClienteNombre
            // 
            this.TxtClienteNombre.Location = new System.Drawing.Point(22, 96);
            this.TxtClienteNombre.Name = "TxtClienteNombre";
            this.TxtClienteNombre.Size = new System.Drawing.Size(257, 20);
            this.TxtClienteNombre.TabIndex = 6;
            this.TxtClienteNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClienteNombre_KeyPress);
            // 
            // TxtClienteCodigo
            // 
            this.TxtClienteCodigo.Enabled = false;
            this.TxtClienteCodigo.Location = new System.Drawing.Point(22, 40);
            this.TxtClienteCodigo.Name = "TxtClienteCodigo";
            this.TxtClienteCodigo.Size = new System.Drawing.Size(257, 20);
            this.TxtClienteCodigo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Cliente";
            // 
            // DgvListaClientes
            // 
            this.DgvListaClientes.AllowUserToAddRows = false;
            this.DgvListaClientes.AllowUserToDeleteRows = false;
            this.DgvListaClientes.AllowUserToOrderColumns = true;
            this.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColClienteID,
            this.ColNombre,
            this.ColCorreoElectronico,
            this.ColDireccion,
            this.ColTelefono,
            this.ColCedula});
            this.DgvListaClientes.Location = new System.Drawing.Point(12, 67);
            this.DgvListaClientes.MultiSelect = false;
            this.DgvListaClientes.Name = "DgvListaClientes";
            this.DgvListaClientes.ReadOnly = true;
            this.DgvListaClientes.RowHeadersVisible = false;
            this.DgvListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaClientes.Size = new System.Drawing.Size(822, 165);
            this.DgvListaClientes.TabIndex = 21;
            this.DgvListaClientes.VirtualMode = true;
            this.DgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClientes_CellClick);
            this.DgvListaClientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaClientes_DataBindingComplete);
            // 
            // ColClienteID
            // 
            this.ColClienteID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColClienteID.DataPropertyName = "ClienteID";
            this.ColClienteID.HeaderText = "CODIGO CLIENTE";
            this.ColClienteID.Name = "ColClienteID";
            this.ColClienteID.ReadOnly = true;
            this.ColClienteID.Width = 80;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "NOMBRE CLIENTE";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCorreoElectronico
            // 
            this.ColCorreoElectronico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCorreoElectronico.DataPropertyName = "CorreoElectronico";
            this.ColCorreoElectronico.HeaderText = "CORREO ELECTRONICO";
            this.ColCorreoElectronico.Name = "ColCorreoElectronico";
            this.ColCorreoElectronico.ReadOnly = true;
            // 
            // ColDireccion
            // 
            this.ColDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDireccion.DataPropertyName = "Direccion";
            this.ColDireccion.HeaderText = "DIRECCION";
            this.ColDireccion.Name = "ColDireccion";
            this.ColDireccion.ReadOnly = true;
            // 
            // ColTelefono
            // 
            this.ColTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTelefono.DataPropertyName = "Telefono";
            this.ColTelefono.HeaderText = "TELEFONO";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // ColCedula
            // 
            this.ColCedula.DataPropertyName = "Cedula";
            this.ColCedula.HeaderText = "CEDULA";
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(230, 9);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(316, 20);
            this.TxtBuscar.TabIndex = 20;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar";
            // 
            // FrmClienteGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 514);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaClientes);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmClienteGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimento de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvListaClientes;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtClienteCodigo;
        private System.Windows.Forms.TextBox TxtClienteCorreoElectronico;
        private System.Windows.Forms.TextBox TxtClienteNombre;
        private System.Windows.Forms.TextBox TxtClienteDireccion;
        private System.Windows.Forms.TextBox TxtClienteTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtClienteCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
    }
}