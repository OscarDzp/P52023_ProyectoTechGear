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
                    MessageBox.Show("Se debe digitar el SubTotal", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtDetalleVentaPrecioUnitario.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar el Precio Unitario", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtDetalleVentaCantidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar la Cantidad", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxDetalleVentasProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir el Producto", "Error de validación", MessageBoxButtons.OK);
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


                MiDetalleVentaLocal.Subtotal = Convert.ToInt32(TxtDetalleVentaSutotal.Text.Trim());
                MiDetalleVentaLocal.PrecioUnitario = Convert.ToInt32(TxtDetalleVentaPrecioUnitario.Text.Trim());
                MiDetalleVentaLocal.Cantidad = Convert.ToInt32(TxtDetalleVentaCantidad.Text.Trim());
                MiDetalleVentaLocal.MiProducto.ProductoID = Convert.ToInt32(CboxDetalleVentasProducto.SelectedValue);

                bool CantidadValida = MiDetalleVentaLocal.ConsultarPorCantidad(MiDetalleVentaLocal.Cantidad.ToString());

                if (CantidadValida == false)
                {
                    //Confirmacion

                    string Pregunta = string.Format("¿Está seguro que quiere agregar el detalle de venta {0}?", MiDetalleVentaLocal.Subtotal);
                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiDetalleVentaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Detalle de venta agregado correctamente!", "Detalle de venta agregado", MessageBoxButtons.OK);

                         

                        }
                        else
                        {
                            MessageBox.Show("El detalle de venta no pudo ser agregado...", "Detalle de venta no agregado", MessageBoxButtons.OK);

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

        private void DgvListaDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaDetalleVenta.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaDetalleVenta.SelectedRows[0];
                int IDDetalleVenta = Convert.ToInt32(MiDgvFila.Cells["ColDetalleVentaID"].Value);
                MiDetalleVentaLocal = new Logica.Models.DetalleVenta();
                MiDetalleVentaLocal = MiDetalleVentaLocal.ConsultarPorID(IDDetalleVenta);
                if (MiDetalleVentaLocal != null && MiDetalleVentaLocal.DetalleVentaID > 0)
                {
                    TxtCodigoDetalleVenta.Text = MiDetalleVentaLocal.DetalleVentaID.ToString();
                    TxtDetalleVentaSutotal.Text = MiDetalleVentaLocal.Subtotal.ToString();
                    TxtDetalleVentaPrecioUnitario.Text = MiDetalleVentaLocal.PrecioUnitario.ToString();
                    TxtDetalleVentaCantidad.Text = MiDetalleVentaLocal.Cantidad.ToString();
                    CboxDetalleVentasProducto.SelectedValue = MiDetalleVentaLocal.MiProducto.ProductoID;
                    ActivarBotonesModificarYEliminar();
                }


            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();

        }
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarBotonesModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;

        }

        private void DgvListaDetalleVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaDetalleVenta.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MiDetalleVentaLocal.Subtotal = Convert.ToInt32(TxtDetalleVentaSutotal.Text.Trim());
            MiDetalleVentaLocal.PrecioUnitario = Convert.ToInt32(TxtDetalleVentaPrecioUnitario.Text.Trim());
            MiDetalleVentaLocal.Cantidad = Convert.ToInt32(TxtDetalleVentaCantidad.Text.Trim());
            MiDetalleVentaLocal.MiProducto.ProductoID = Convert.ToInt32(CboxDetalleVentasProducto.SelectedValue);


                if (MiDetalleVentaLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar el detalle de venta?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiDetalleVentaLocal.Actualizar())
                        {
                            MessageBox.Show("Detalle de Venta modificado correctamente!!", ":)", MessageBoxButtons.OK);
                            LimpiarForm();
                            CargarListaDetalleVenta();
                            ActivarBotonAgregar();
                        }

                    }

                }
            
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
