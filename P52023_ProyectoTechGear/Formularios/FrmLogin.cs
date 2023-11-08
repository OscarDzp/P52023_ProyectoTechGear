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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                // si hay valores en los cuadros de teto se procede a validarlos
                string usuario = TxtUsuario.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

              //  int idUsuario = Globales.ObjectosGlobales.MiEmpleadoGlobal.Validar
            }



            Globales.ObjectosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.ObjectosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.Control & e.KeyCode == Keys.A)
            {
                BtnIngresoDirecto.Visible = true;
            }
        }
    }
}
