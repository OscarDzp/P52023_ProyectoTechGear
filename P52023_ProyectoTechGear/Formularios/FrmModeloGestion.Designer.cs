﻿namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmModeloGestion
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
            this.DgvListaModelos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.TxtModeloCodigo = new System.Windows.Forms.TextBox();
            this.TxtModeloNombre = new System.Windows.Forms.TextBox();
            this.TxtModeloMarcaID = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DtpModeloAnioLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.ColModeloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnioLanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarcaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaModelos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaModelos
            // 
            this.DgvListaModelos.AllowUserToAddRows = false;
            this.DgvListaModelos.AllowUserToDeleteRows = false;
            this.DgvListaModelos.AllowUserToOrderColumns = true;
            this.DgvListaModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColModeloID,
            this.ColAnioLanzamiento,
            this.ColNombre,
            this.ColMarcaID});
            this.DgvListaModelos.Location = new System.Drawing.Point(12, 36);
            this.DgvListaModelos.MultiSelect = false;
            this.DgvListaModelos.Name = "DgvListaModelos";
            this.DgvListaModelos.ReadOnly = true;
            this.DgvListaModelos.RowHeadersVisible = false;
            this.DgvListaModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaModelos.Size = new System.Drawing.Size(504, 267);
            this.DgvListaModelos.TabIndex = 2;
            this.DgvListaModelos.VirtualMode = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año de Lanzamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código Marca";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpModeloAnioLanzamiento);
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.TxtModeloMarcaID);
            this.groupBox1.Controls.Add(this.TxtModeloNombre);
            this.groupBox1.Controls.Add(this.TxtModeloCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 178);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar...";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(184, 6);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(180, 20);
            this.TxtBuscar.TabIndex = 18;
            // 
            // TxtModeloCodigo
            // 
            this.TxtModeloCodigo.Location = new System.Drawing.Point(119, 25);
            this.TxtModeloCodigo.Name = "TxtModeloCodigo";
            this.TxtModeloCodigo.Size = new System.Drawing.Size(238, 20);
            this.TxtModeloCodigo.TabIndex = 7;
            // 
            // TxtModeloNombre
            // 
            this.TxtModeloNombre.Location = new System.Drawing.Point(119, 81);
            this.TxtModeloNombre.Name = "TxtModeloNombre";
            this.TxtModeloNombre.Size = new System.Drawing.Size(238, 20);
            this.TxtModeloNombre.TabIndex = 9;
            // 
            // TxtModeloMarcaID
            // 
            this.TxtModeloMarcaID.Location = new System.Drawing.Point(119, 116);
            this.TxtModeloMarcaID.Name = "TxtModeloMarcaID";
            this.TxtModeloMarcaID.Size = new System.Drawing.Size(238, 20);
            this.TxtModeloMarcaID.TabIndex = 10;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(12, 493);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(141, 37);
            this.BtnAgregar.TabIndex = 19;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(159, 493);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(113, 37);
            this.BtnModificar.TabIndex = 20;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(278, 493);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 37);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(427, 144);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.BtnLimpiar.TabIndex = 22;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(440, 502);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 28);
            this.BtnCerrar.TabIndex = 23;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // DtpModeloAnioLanzamiento
            // 
            this.DtpModeloAnioLanzamiento.Location = new System.Drawing.Point(119, 52);
            this.DtpModeloAnioLanzamiento.Name = "DtpModeloAnioLanzamiento";
            this.DtpModeloAnioLanzamiento.Size = new System.Drawing.Size(238, 20);
            this.DtpModeloAnioLanzamiento.TabIndex = 24;
            // 
            // ColModeloID
            // 
            this.ColModeloID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColModeloID.DataPropertyName = "ModeloID";
            this.ColModeloID.HeaderText = "CÓDIGO";
            this.ColModeloID.Name = "ColModeloID";
            this.ColModeloID.ReadOnly = true;
            this.ColModeloID.Width = 80;
            // 
            // ColAnioLanzamiento
            // 
            this.ColAnioLanzamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColAnioLanzamiento.DataPropertyName = "AnioLanzamiento";
            this.ColAnioLanzamiento.HeaderText = "AÑO DE LANZAMIENTO";
            this.ColAnioLanzamiento.Name = "ColAnioLanzamiento";
            this.ColAnioLanzamiento.ReadOnly = true;
            this.ColAnioLanzamiento.Width = 200;
            // 
            // ColNombre
            // 
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "MODELO";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColMarcaID
            // 
            this.ColMarcaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColMarcaID.DataPropertyName = "MarcaID";
            this.ColMarcaID.HeaderText = "CÓDIGO MARCA";
            this.ColMarcaID.Name = "ColMarcaID";
            this.ColMarcaID.ReadOnly = true;
            this.ColMarcaID.Width = 120;
            // 
            // FrmModeloGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 540);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvListaModelos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmModeloGestion";
            this.Text = "Mantenimiento de Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaModelos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaModelos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TextBox TxtModeloMarcaID;
        private System.Windows.Forms.TextBox TxtModeloNombre;
        private System.Windows.Forms.TextBox TxtModeloCodigo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DateTimePicker DtpModeloAnioLanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColModeloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnioLanzamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarcaID;
    }
}