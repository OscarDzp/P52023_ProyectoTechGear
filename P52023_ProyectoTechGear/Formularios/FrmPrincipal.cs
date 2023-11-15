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

        private void cATEGORIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeCategorias.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeCategorias = new FrmCategoriaGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeCategorias.Show();
            }
        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeClientes.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeClientes = new FrmClienteGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeClientes.Show();
            }
        }

        private void dETALLEDEVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeDetalleVenta.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeDetalleVenta = new FrmDetalleVenta();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeDetalleVenta.Show();
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
           
        }

        private void eMPLEADOROLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeEmpleadoRol.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeEmpleadoRol = new FrmEmpleadoRol();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeEmpleadoRol.Show();
            }
        }

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeFactura.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeFactura = new FrmFacturas();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeFactura.Show();
            }
        }

        private void tRANSACCIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeTransaccion.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeTransaccion = new FrmTransaccionGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeTransaccion.Show();
            }
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeProveedor.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeProveedor = new FrmProveedorGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeProveedor.Show();
            }
        }

        private void sUCURSALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeSucursal.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeSucursal = new FrmSucursalGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeSucursal.Show();
            }
        }

        private void sOPORTETECNICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjectosGlobales.MiFormularioDeGestionDeSoporte.Visible)
            {
                Globales.ObjectosGlobales.MiFormularioDeGestionDeSoporte = new FrmSoporteGestion();
                Globales.ObjectosGlobales.MiFormularioDeGestionDeSoporte.Show();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LblEmpleado.Text = Globales.ObjectosGlobales.MiEmpleadoGlobal.Nombre + "(" +
                Globales.ObjectosGlobales.MiEmpleadoGlobal.MiEmpleadoRol.Rol + ")";
            //ahora se debe ajustar los permisos de menus para que se muestren o no, dependiendo
            //del tipo de rol
            switch (Globales.ObjectosGlobales.MiEmpleadoGlobal.MiEmpleadoRol.EmpleadoRolID)
            {
                //ADMIN
                case 1005:
                    //Como admin tiene acceso a todo, no es necesario ocultar opciones
                    break;

                //Usuario
                case 1006: // ese 1006 es el id de mi base de datos cada uno posiblemente le varie
                    //ocultan los menus correspodientes
                    MnuGestionEmpleados.Enabled = false;
                    MnuGestionEmpleadosRol.Enabled = false;

                    break;
                default:
                    break;

            }
        }
    }
}
