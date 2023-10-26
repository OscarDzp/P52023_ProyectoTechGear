namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmSoporteGestion
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
            this.CboxSoporteGarantia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSoporteDisponibilidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSoporteCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSoporteNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoporteEspecialidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSoporteCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaSoporteTecnico = new System.Windows.Forms.DataGridView();
            this.ColTecnicoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDisponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaSoporteTecnico)).BeginInit();
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
            this.BtnLimpiar.TabIndex = 21;
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
            this.BtnCerrar.TabIndex = 22;
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
            this.BtnEliminar.TabIndex = 20;
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
            this.BtnModificar.TabIndex = 19;
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
            this.BtnAgregar.TabIndex = 18;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboxSoporteGarantia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtSoporteDisponibilidad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtSoporteCorreo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtSoporteNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtSoporteEspecialidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSoporteCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 320);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Soporte Tecnico";
            // 
            // CboxSoporteGarantia
            // 
            this.CboxSoporteGarantia.FormattingEnabled = true;
            this.CboxSoporteGarantia.Location = new System.Drawing.Point(484, 176);
            this.CboxSoporteGarantia.Name = "CboxSoporteGarantia";
            this.CboxSoporteGarantia.Size = new System.Drawing.Size(238, 21);
            this.CboxSoporteGarantia.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Garantia";
            // 
            // TxtSoporteDisponibilidad
            // 
            this.TxtSoporteDisponibilidad.Location = new System.Drawing.Point(135, 176);
            this.TxtSoporteDisponibilidad.Name = "TxtSoporteDisponibilidad";
            this.TxtSoporteDisponibilidad.Size = new System.Drawing.Size(238, 20);
            this.TxtSoporteDisponibilidad.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Correo:";
            // 
            // TxtSoporteCorreo
            // 
            this.TxtSoporteCorreo.Location = new System.Drawing.Point(482, 58);
            this.TxtSoporteCorreo.Name = "TxtSoporteCorreo";
            this.TxtSoporteCorreo.Size = new System.Drawing.Size(240, 20);
            this.TxtSoporteCorreo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Disponibilidad:";
            // 
            // TxtSoporteNombre
            // 
            this.TxtSoporteNombre.Location = new System.Drawing.Point(135, 109);
            this.TxtSoporteNombre.Name = "TxtSoporteNombre";
            this.TxtSoporteNombre.Size = new System.Drawing.Size(238, 20);
            this.TxtSoporteNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // TxtSoporteEspecialidad
            // 
            this.TxtSoporteEspecialidad.Location = new System.Drawing.Point(484, 109);
            this.TxtSoporteEspecialidad.Name = "TxtSoporteEspecialidad";
            this.TxtSoporteEspecialidad.Size = new System.Drawing.Size(238, 20);
            this.TxtSoporteEspecialidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Especialidad:";
            // 
            // TxtSoporteCodigo
            // 
            this.TxtSoporteCodigo.Enabled = false;
            this.TxtSoporteCodigo.Location = new System.Drawing.Point(135, 54);
            this.TxtSoporteCodigo.Name = "TxtSoporteCodigo";
            this.TxtSoporteCodigo.Size = new System.Drawing.Size(238, 20);
            this.TxtSoporteCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Tecnico:";
            // 
            // DgvListaSoporteTecnico
            // 
            this.DgvListaSoporteTecnico.AllowUserToAddRows = false;
            this.DgvListaSoporteTecnico.AllowUserToDeleteRows = false;
            this.DgvListaSoporteTecnico.AllowUserToOrderColumns = true;
            this.DgvListaSoporteTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaSoporteTecnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTecnicoID,
            this.ColNombre,
            this.ColCorreo,
            this.ColEspecialidad,
            this.ColDisponibilidad});
            this.DgvListaSoporteTecnico.Location = new System.Drawing.Point(13, 41);
            this.DgvListaSoporteTecnico.MultiSelect = false;
            this.DgvListaSoporteTecnico.Name = "DgvListaSoporteTecnico";
            this.DgvListaSoporteTecnico.ReadOnly = true;
            this.DgvListaSoporteTecnico.RowHeadersVisible = false;
            this.DgvListaSoporteTecnico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaSoporteTecnico.Size = new System.Drawing.Size(767, 229);
            this.DgvListaSoporteTecnico.TabIndex = 16;
            this.DgvListaSoporteTecnico.VirtualMode = true;
            // 
            // ColTecnicoID
            // 
            this.ColTecnicoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColTecnicoID.DataPropertyName = "TecnicoID";
            this.ColTecnicoID.HeaderText = "CÓDIGO";
            this.ColTecnicoID.Name = "ColTecnicoID";
            this.ColTecnicoID.ReadOnly = true;
            this.ColTecnicoID.Width = 80;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "NOMBRE";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColCorreo
            // 
            this.ColCorreo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCorreo.DataPropertyName = "Correo";
            this.ColCorreo.HeaderText = "CORREO";
            this.ColCorreo.Name = "ColCorreo";
            this.ColCorreo.ReadOnly = true;
            // 
            // ColEspecialidad
            // 
            this.ColEspecialidad.DataPropertyName = "Especialidad";
            this.ColEspecialidad.HeaderText = "ESPECIALIDAD";
            this.ColEspecialidad.Name = "ColEspecialidad";
            this.ColEspecialidad.ReadOnly = true;
            // 
            // ColDisponibilidad
            // 
            this.ColDisponibilidad.DataPropertyName = "Disponibilidad";
            this.ColDisponibilidad.HeaderText = "DISPONIBILIDAD";
            this.ColDisponibilidad.Name = "ColDisponibilidad";
            this.ColDisponibilidad.ReadOnly = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(264, 9);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(316, 20);
            this.TxtBuscar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar";
            // 
            // FrmSoporteGestion
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
            this.Controls.Add(this.DgvListaSoporteTecnico);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSoporteGestion";
            this.Text = "Mantenimiento en Soporte Tecnico";
            this.Load += new System.EventHandler(this.FrmSoporteGestion_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaSoporteTecnico)).EndInit();
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
        private System.Windows.Forms.TextBox TxtSoporteCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtSoporteNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoporteEspecialidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSoporteCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvListaSoporteTecnico;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTecnicoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDisponibilidad;
        private System.Windows.Forms.TextBox TxtSoporteDisponibilidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboxSoporteGarantia;
    }
}