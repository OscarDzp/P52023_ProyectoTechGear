﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_ProyectoTechGear.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gARANTIAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeEmpleados.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeEmpleados = new FrmEmpleadoGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeEmpleados.Show();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
