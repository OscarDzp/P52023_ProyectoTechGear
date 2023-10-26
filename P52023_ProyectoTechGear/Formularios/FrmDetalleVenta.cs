using Logica.Models;
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
    public partial class FrmDetalleVenta : Form
    {
        private Logica.Models.DetalleVenta MiDetalleVentaLocal { get; set; }
        public FrmDetalleVenta()
        {
            InitializeComponent();
            MiDetalleVentaLocal = new Logica.Models.DetalleVenta();
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaDetalleVenta();
            CargarListaProducto();
        }
        private void CargarListaDetalleVenta() {
            Logica.Models.DetalleVenta MiDetalleVenta = new Logica.Models.DetalleVenta();
            DataTable lista = new DataTable();
            lista = MiDetalleVenta.Listar();
            DgvListaDetalleVenta.DataSource = lista;
        }
        private void CargarListaProducto()
        {
            Logica.Models.Productos MiProducto = new Logica.Models.Productos();

            DataTable dtProductos = new DataTable();

            dtProductos = MiProducto.Listar();

            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                CboxDetalleVentasProducto.ValueMember = "ProductoID";
                CboxDetalleVentasProducto.DisplayMember = "Nombre";

                CboxDetalleVentasProducto.DataSource = dtProductos;
                CboxDetalleVentasProducto.SelectedIndex = -1;
            }
        }

        private bool ValidarDatos()

        //validation of minimun values required
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtDetalleVentaSutotal.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDetalleVentaPrecioUnitario.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtDetalleVentaCantidad.Text.Trim()) &&
                CboxDetalleVentasProducto.SelectedIndex > -1
                )
            {
                R = true;

            }
            else
            {
                //validacion faltante
                if (string.IsNullOrEmpty(TxtDetalleVentaSutotal.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar el nombre", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtDetalleVentaPrecioUnitario.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar el correo electrónico", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtDetalleVentaCantidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar la contraseña", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxDetalleVentasProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir un rol de empleado", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(CboxDetalleVentasProducto.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar eL cargo del empleado", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {

                MiDetalleVentaLocal = new Logica.Models.DetalleVenta();

                MiDetalleVentaLocal.Subtotal = TxtDetalleVentaSutotal.Text.Trim();
                MiDetalleVentaLocal.PrecioUnitario = TxtDetalleVentaPrecioUnitario.Text.Trim();
                MiDetalleVentaLocal.Cantidad = TxtDetalleVentaCantidad.Text.Trim();
                MiDetalleVentaLocal.MiProducto.ProductoID = Convert.ToInt32(CboxDetalleVentasProducto.SelectedValue);

                bool IDValida = MiDetalleVentaLocal.ConsultarPorID(MiDetalleVentaLocal.DetalleVentaID);

                if (IDValida == false)
                {
                    //Confirmacion

                    string Pregunta = string.Format("¿Está seguro que queire agregar al empleado {0}?", MiDetalleVentaLocal.Subtotal);
                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiDetalleVentaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Empleado agregado correctamente!", "Empleado agregado", MessageBoxButtons.OK);

                         

                        }
                        else
                        {
                            MessageBox.Show("El empleado no pudo ser agregado...", "Empleado no agregado", MessageBoxButtons.OK);

                        }
                    }
                    LimpiarForm();
                    CargarListaDetalleVenta();
                }

            }
        }
        private void LimpiarForm()
        {
            TxtDetalleVentaSutotal.Clear();
            TxtDetalleVentaPrecioUnitario.Clear();
            TxtDetalleVentaCantidad.Clear();
            CboxDetalleVentasProducto.SelectedIndex = -1;
        }
    }
}
