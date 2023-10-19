using System;
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
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeGarantia.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeGarantia = new FrmGarantiaGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeGarantia.Show();
            }
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

        private void mARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeMarca.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeMarca = new FrmMarcaGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeMarca.Show();
            }
        }

        private void mODELOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeModelo.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeModelo = new FrmModeloGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeModelo.Show();
            }
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeProductos.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeProductos = new FrmProductoGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeProductos.Show();
            }
        }
    }
}
