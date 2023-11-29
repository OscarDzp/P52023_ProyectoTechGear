namespace P52023_ProyectoTechGear.Formularios
{
    partial class FrmMarcaGestion
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
            this.DgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.ColMarcaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaisOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtMarcaNombre = new System.Windows.Forms.TextBox();
            this.TxtMarcaPaisOrigen = new System.Windows.Forms.TextBox();
            this.TxtMarcaCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMarcas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvListaMarcas
            // 
            this.DgvListaMarcas.AllowUserToAddRows = false;
            this.DgvListaMarcas.AllowUserToDeleteRows = false;
            this.DgvListaMarcas.AllowUserToOrderColumns = true;
            this.DgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMarcaID,
            this.ColPaisOrigen,
            this.ColNombre});
            this.DgvListaMarcas.Location = new System.Drawing.Point(6, 19);
            this.DgvListaMarcas.MultiSelect = false;
            this.DgvListaMarcas.Name = "DgvListaMarcas";
            this.DgvListaMarcas.ReadOnly = true;
            this.DgvListaMarcas.RowHeadersVisible = false;
            this.DgvListaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaMarcas.Size = new System.Drawing.Size(362, 267);
            this.DgvListaMarcas.TabIndex = 1;
            this.DgvListaMarcas.VirtualMode = true;
            this.DgvListaMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaMarcas_CellClick);
            this.DgvListaMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaMarcas_CellContentClick);
            this.DgvListaMarcas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaMarcas_DataBindingComplete);
            // 
            // ColMarcaID
            // 
            this.ColMarcaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColMarcaID.DataPropertyName = "MarcaID";
            this.ColMarcaID.HeaderText = "CÓDIGO";
            this.ColMarcaID.Name = "ColMarcaID";
            this.ColMarcaID.ReadOnly = true;
            this.ColMarcaID.Width = 80;
            // 
            // ColPaisOrigen
            // 
            this.ColPaisOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPaisOrigen.DataPropertyName = "PaisOrigen";
            this.ColPaisOrigen.HeaderText = "PAÍS DE ORIGEN";
            this.ColPaisOrigen.Name = "ColPaisOrigen";
            this.ColPaisOrigen.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "MARCA";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnCerrar);
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.TxtMarcaNombre);
            this.groupBox1.Controls.Add(this.TxtMarcaPaisOrigen);
            this.groupBox1.Controls.Add(this.TxtMarcaCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.BtnModificar);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.DgvListaMarcas);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 351);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Marcas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(375, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(409, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(662, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Datos Requeridos.....";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(641, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 18);
            this.label15.TabIndex = 38;
            this.label15.Text = "*";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(504, 16);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(180, 20);
            this.TxtBuscar.TabIndex = 17;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Buscar...";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCerrar.ForeColor = System.Drawing.Color.White;
            this.BtnCerrar.Location = new System.Drawing.Point(699, 317);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(70, 28);
            this.BtnCerrar.TabIndex = 15;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(623, 317);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(70, 28);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtMarcaNombre
            // 
            this.TxtMarcaNombre.Location = new System.Drawing.Point(480, 195);
            this.TxtMarcaNombre.Name = "TxtMarcaNombre";
            this.TxtMarcaNombre.Size = new System.Drawing.Size(238, 20);
            this.TxtMarcaNombre.TabIndex = 14;
            this.TxtMarcaNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarcaNombre_KeyPress);
            // 
            // TxtMarcaPaisOrigen
            // 
            this.TxtMarcaPaisOrigen.Location = new System.Drawing.Point(480, 146);
            this.TxtMarcaPaisOrigen.Name = "TxtMarcaPaisOrigen";
            this.TxtMarcaPaisOrigen.Size = new System.Drawing.Size(238, 20);
            this.TxtMarcaPaisOrigen.TabIndex = 13;
            this.TxtMarcaPaisOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMarcaPaisOrigen_KeyPress);
            // 
            // TxtMarcaCodigo
            // 
            this.TxtMarcaCodigo.Location = new System.Drawing.Point(480, 102);
            this.TxtMarcaCodigo.Name = "TxtMarcaCodigo";
            this.TxtMarcaCodigo.Size = new System.Drawing.Size(238, 20);
            this.TxtMarcaCodigo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "País de Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(256, 292);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(112, 37);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "ELIMINAR";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(137, 292);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(113, 37);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(6, 292);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(125, 37);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // FrmMarcaGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMarcaGestion";
            this.Text = "Mantenimiento de Marcas";
            this.Load += new System.EventHandler(this.FrmMarcaGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaMarcas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaMarcas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMarcaNombre;
        private System.Windows.Forms.TextBox TxtMarcaPaisOrigen;
        private System.Windows.Forms.TextBox TxtMarcaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarcaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaisOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}