namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmEmpleadoGestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DgvListaEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboxEmpleadoCargo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEmpleadoContrasennia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEmpleadoCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEmpleadoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmpleadoCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmpleadoCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.ColEmpleadoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreoElectronico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEmpleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar...";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DgvListaEmpleados
            // 
            this.DgvListaEmpleados.AllowUserToAddRows = false;
            this.DgvListaEmpleados.AllowUserToDeleteRows = false;
            this.DgvListaEmpleados.AllowUserToOrderColumns = true;
            this.DgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpleadoID,
            this.ColCedula,
            this.ColNombre,
            this.ColTelefono,
            this.ColCorreoElectronico,
            this.ColCargo,
            this.ColRol});
            this.DgvListaEmpleados.Location = new System.Drawing.Point(12, 43);
            this.DgvListaEmpleados.MultiSelect = false;
            this.DgvListaEmpleados.Name = "DgvListaEmpleados";
            this.DgvListaEmpleados.ReadOnly = true;
            this.DgvListaEmpleados.RowHeadersVisible = false;
            this.DgvListaEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaEmpleados.Size = new System.Drawing.Size(629, 229);
            this.DgvListaEmpleados.TabIndex = 2;
            this.DgvListaEmpleados.VirtualMode = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxEmpleadoCargo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtEmpleadoContrasennia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtEmpleadoCorreoElectronico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtEmpleadoNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtEmpleadoCedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtEmpleadoCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CboxEmpleadoCargo
            // 
            this.CboxEmpleadoCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxEmpleadoCargo.FormattingEnabled = true;
            this.CboxEmpleadoCargo.Location = new System.Drawing.Point(195, 234);
            this.CboxEmpleadoCargo.Name = "CboxEmpleadoCargo";
            this.CboxEmpleadoCargo.Size = new System.Drawing.Size(128, 21);
            this.CboxEmpleadoCargo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cargo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtEmpleadoContrasennia
            // 
            this.TxtEmpleadoContrasennia.Location = new System.Drawing.Point(194, 188);
            this.TxtEmpleadoContrasennia.Name = "TxtEmpleadoContrasennia";
            this.TxtEmpleadoContrasennia.Size = new System.Drawing.Size(238, 20);
            this.TxtEmpleadoContrasennia.TabIndex = 9;
            this.TxtEmpleadoContrasennia.TextChanged += new System.EventHandler(this.TxtEmpleadoContrasennia_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Contraseña";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TxtEmpleadoCorreoElectronico
            // 
            this.TxtEmpleadoCorreoElectronico.Location = new System.Drawing.Point(194, 149);
            this.TxtEmpleadoCorreoElectronico.Name = "TxtEmpleadoCorreoElectronico";
            this.TxtEmpleadoCorreoElectronico.Size = new System.Drawing.Size(238, 20);
            this.TxtEmpleadoCorreoElectronico.TabIndex = 7;
            this.TxtEmpleadoCorreoElectronico.TextChanged += new System.EventHandler(this.TxtEmpleadoCorreoElectronico_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo Electrónico";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtEmpleadoNombre
            // 
            this.TxtEmpleadoNombre.Location = new System.Drawing.Point(194, 110);
            this.TxtEmpleadoNombre.Name = "TxtEmpleadoNombre";
            this.TxtEmpleadoNombre.Size = new System.Drawing.Size(238, 20);
            this.TxtEmpleadoNombre.TabIndex = 5;
            this.TxtEmpleadoNombre.TextChanged += new System.EventHandler(this.TxtEmpleadoNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtEmpleadoCedula
            // 
            this.TxtEmpleadoCedula.Location = new System.Drawing.Point(194, 71);
            this.TxtEmpleadoCedula.Name = "TxtEmpleadoCedula";
            this.TxtEmpleadoCedula.Size = new System.Drawing.Size(238, 20);
            this.TxtEmpleadoCedula.TabIndex = 3;
            this.TxtEmpleadoCedula.TextChanged += new System.EventHandler(this.TxtEmpleadoCedula_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtEmpleadoCodigo
            // 
            this.TxtEmpleadoCodigo.Location = new System.Drawing.Point(194, 32);
            this.TxtEmpleadoCodigo.Name = "TxtEmpleadoCodigo";
            this.TxtEmpleadoCodigo.Size = new System.Drawing.Size(238, 20);
            this.TxtEmpleadoCodigo.TabIndex = 1;
            this.TxtEmpleadoCodigo.TextChanged += new System.EventHandler(this.TxtEmpleadoCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código del Empleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(13, 564);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(141, 37);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(159, 564);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(141, 37);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(303, 564);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(141, 37);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(495, 568);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.BtnLimpiar.TabIndex = 7;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(571, 568);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 28);
            this.BtnCerrar.TabIndex = 13;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // ColEmpleadoID
            // 
            this.ColEmpleadoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColEmpleadoID.DataPropertyName = "EmpleadoID";
            this.ColEmpleadoID.HeaderText = "CÓDIGO";
            this.ColEmpleadoID.Name = "ColEmpleadoID";
            this.ColEmpleadoID.ReadOnly = true;
            // 
            // ColCedula
            // 
            this.ColCedula.DataPropertyName = "Cedula";
            this.ColCedula.HeaderText = "CÉDULA";
            this.ColCedula.Name = "ColCedula";
            this.ColCedula.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "NOMBRE";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 26;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "Telefono";
            this.ColTelefono.HeaderText = "TELÉFONO";
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            // 
            // ColCorreoElectronico
            // 
            this.ColCorreoElectronico.DataPropertyName = "CorreoElectronico";
            this.ColCorreoElectronico.HeaderText = "CORREO";
            this.ColCorreoElectronico.Name = "ColCorreoElectronico";
            this.ColCorreoElectronico.ReadOnly = true;
            // 
            // ColCargo
            // 
            this.ColCargo.DataPropertyName = "Cargo";
            this.ColCargo.HeaderText = "CARGO";
            this.ColCargo.Name = "ColCargo";
            this.ColCargo.ReadOnly = true;
            // 
            // ColRol
            // 
            this.ColRol.HeaderText = "ROL";
            this.ColRol.Name = "ColRol";
            this.ColRol.ReadOnly = true;
            // 
            // FrmEmpleadoGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 611);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaEmpleados);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleadoGestion";
            this.Text = "Mantenimiento de Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleadoGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaEmpleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DgvListaEmpleados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtEmpleadoCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmpleadoCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmpleadoContrasennia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEmpleadoCorreoElectronico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmpleadoNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboxEmpleadoCargo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpleadoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreoElectronico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRol;
    }
}