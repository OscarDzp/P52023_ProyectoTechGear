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
    public partial class FrmFacturas : Form
    {
        private Logica.Models.Facturas MiFacturaLocal { get; set; }
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaFacturas();
            CargarListaSucursal();
            CargarListaEmpleado();
            CargarListaCliente();
            CargarListaProductos();

        }

        private void CargarListaFacturas(string FiltroBusqueda = "")
        {
            Logica.Models.Facturas MiFacturas = new Logica.Models.Facturas();
            DataTable lista = new DataTable();
            lista = MiFacturas.Listar(FiltroBusqueda);
            DgvListaFactura.DataSource = lista;

        }

        private void CargarListaSucursal()
        {
            Logica.Models.Sucursales MiSucursal = new Logica.Models.Sucursales();

            DataTable dtSucursales = new DataTable();

            dtSucursales = MiSucursal.Listar();

            if (dtSucursales != null && dtSucursales.Rows.Count > 0)
            {
                CboxFacturaSucursal.ValueMember = "SucursalID";
                CboxFacturaSucursal.DisplayMember = "Nombre";

                CboxFacturaSucursal.DataSource = dtSucursales;
                CboxFacturaSucursal.SelectedIndex = -1;
            }
        }

        private void CargarListaEmpleado()
        {
            Logica.Models.Empleados MiEmpleado = new Logica.Models.Empleados();

            DataTable dtEmpleados = new DataTable();

            dtEmpleados = MiEmpleado.Listar();

            if (dtEmpleados != null && dtEmpleados.Rows.Count > 0)
            {
                CboxFacturaEmpleado.ValueMember = "EmpleadoID";
                CboxFacturaEmpleado.DisplayMember = "Nombre";

                CboxFacturaEmpleado.DataSource = dtEmpleados;
                CboxFacturaEmpleado.SelectedIndex = -1;
            }
        }

        private void CargarListaCliente()
        {
            Logica.Models.Clientes MiCliente = new Logica.Models.Clientes();

            DataTable dtClientes = new DataTable();

            dtClientes = MiCliente.Listar();

            if (dtClientes != null && dtClientes.Rows.Count > 0)
            {
                CboxFacturaCliente.ValueMember = "ClienteID";
                CboxFacturaCliente.DisplayMember = "Nombre";

                CboxFacturaCliente.DataSource = dtClientes;
                CboxFacturaCliente.SelectedIndex = -1;
            }
        }
        private void CargarListaProductos()
        {
            Logica.Models.Productos MiProdcuto = new Logica.Models.Productos();

            DataTable dtProducto = new DataTable();

            dtProducto = MiProdcuto.Listar();

            if (dtProducto != null && dtProducto.Rows.Count > 0)
            {
                CboxFacturaProducto.ValueMember = "ProductoID";
                CboxFacturaProducto.DisplayMember = "Nombre";

                CboxFacturaProducto.DataSource = dtProducto;
                CboxFacturaProducto.SelectedIndex = -1;
            }
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (
                !string.IsNullOrEmpty(TxtFacturaTotalFactura.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtFacturaDetalleVenta.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtFacturaImpuesto.Text.Trim()) &&
                !string.IsNullOrEmpty(DtFacturaFecha.Text.Trim()) &&  // fecha
                CboxFacturaSucursal.SelectedIndex > -1 &&
                CboxFacturaEmpleado.SelectedIndex > -1 &&
                CboxFacturaCliente.SelectedIndex > -1 &&
                CboxFacturaProducto.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {

                if (string.IsNullOrEmpty(TxtFacturaTotalFactura.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar Total de la Factura");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtFacturaDetalleVenta.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un Detalle de Venta");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtFacturaImpuesto.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar el impuesto");
                    return false;
                }
                if (string.IsNullOrEmpty(DtFacturaFecha.Text.Trim()))  //fecha
                {
                    MessageBox.Show("Se debe asignar una fecha a la factura");
                    return false;
                }
                if (CboxFacturaSucursal.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir una Sucursal", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxFacturaEmpleado.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir un Empleado", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxFacturaCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir un Cliente", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxFacturaProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir un producto", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {
                MiFacturaLocal = new Logica.Models.Facturas();

                MiFacturaLocal.TotalFactura = TxtFacturaTotalFactura.Text.Trim();
                MiFacturaLocal.Detalledeventa = TxtFacturaDetalleVenta.Text.Trim();
                MiFacturaLocal.Impuestos = TxtFacturaImpuesto.Text.Trim();
                MiFacturaLocal.FechaFactura = DateTime.Parse(DtFacturaFecha.Text.Trim());
                MiFacturaLocal.MiSucursal.SucursalID = Convert.ToInt32(CboxFacturaSucursal.SelectedValue);
                MiFacturaLocal.MiEmpleado.EmpleadoID = Convert.ToInt32(CboxFacturaEmpleado.SelectedValue);
                MiFacturaLocal.MiCliente.ClienteID = Convert.ToInt32(CboxFacturaCliente.SelectedValue);
                MiFacturaLocal.MiProducto.ProductoID = Convert.ToInt32(CboxFacturaProducto.SelectedValue);

                bool IDValida = MiFacturaLocal.ConsultarPorTotalFactura(MiFacturaLocal.TotalFactura.ToString()); // linea de dudosa procedencia 


                if (IDValida == false)
                {
                    //Confirmacion

                    string Pregunta = string.Format("¿Está seguro que quiere agregar la Factura {0}?", MiFacturaLocal.TotalFactura);
                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiFacturaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Factura agregada correctamente!", "Factura agregado", MessageBoxButtons.OK);



                        }
                        else
                        {
                            MessageBox.Show("La Factura no pudo ser agregado...", "Factura no agregado", MessageBoxButtons.OK);

                        }
                    }
                    LimpiarForm();
                    CargarListaFacturas();
                }

            }
        }
        private void LimpiarForm()
        {
            TxtFacturaID.Clear();
            TxtFacturaTotalFactura.Clear();
            TxtFacturaDetalleVenta.Clear();
            TxtFacturaImpuesto.Clear();
            // DtFacturaFecha.Clear(); 
            CboxFacturaSucursal.SelectedIndex = -1;
            CboxFacturaEmpleado.SelectedIndex = -1;
            CboxFacturaCliente.SelectedIndex = -1;
            CboxFacturaProducto.SelectedIndex = -1;
        }

        private void DgvListaFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaFactura.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaFactura.SelectedRows[0];
                int IDEmpleado = Convert.ToInt32(MiDgvFila.Cells["ColFacturaID"].Value);
                MiFacturaLocal = new Logica.Models.Facturas();
                MiFacturaLocal = MiFacturaLocal.ConsultarPorID(IDEmpleado);
                if (MiFacturaLocal != null && MiFacturaLocal.FacturaID > 0)
                {
                    TxtFacturaID.Text = MiFacturaLocal.FacturaID.ToString();
                    TxtFacturaTotalFactura.Text = MiFacturaLocal.TotalFactura;
                    TxtFacturaDetalleVenta.Text = MiFacturaLocal.Detalledeventa;
                    TxtFacturaImpuesto.Text = MiFacturaLocal.Impuestos;
                    DtFacturaFecha.Value = MiFacturaLocal.FechaFactura;
                    CboxFacturaSucursal.SelectedValue = MiFacturaLocal.MiSucursal.SucursalID;
                    CboxFacturaEmpleado.SelectedValue = MiFacturaLocal.MiEmpleado.EmpleadoID;
                    CboxFacturaCliente.SelectedValue = MiFacturaLocal.MiCliente.ClienteID;
                    CboxFacturaProducto.SelectedValue = MiFacturaLocal.MiProducto.ProductoID;
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

        private void DgvListaFactura_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaFactura.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {
                MiFacturaLocal.TotalFactura = TxtFacturaTotalFactura.Text.Trim();
                MiFacturaLocal.Detalledeventa = TxtFacturaDetalleVenta.Text.Trim();
                MiFacturaLocal.Impuestos = TxtFacturaImpuesto.Text.Trim();
                MiFacturaLocal.FechaFactura = DateTime.Parse(DtFacturaFecha.Text.Trim());
                MiFacturaLocal.MiSucursal.SucursalID = Convert.ToInt32(CboxFacturaSucursal.SelectedValue);
                MiFacturaLocal.MiEmpleado.EmpleadoID = Convert.ToInt32(CboxFacturaEmpleado.SelectedValue);
                MiFacturaLocal.MiCliente.ClienteID = Convert.ToInt32(CboxFacturaCliente.SelectedValue);
                MiFacturaLocal.MiProducto.ProductoID = Convert.ToInt32(CboxFacturaProducto.SelectedValue);


                if (MiFacturaLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar la factura?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiFacturaLocal.Actualizar())
                        {
                            MessageBox.Show("Factura modificado correctamenete!!", ":)", MessageBoxButtons.OK);
                            LimpiarForm();
                            CargarListaFacturas();
                            ActivarBotonAgregar();
                        }

                    }

                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiFacturaLocal.FacturaID > 0)
            {
                string msg = string.Format("Esta seguro de eliminar la Factura {0}?", MiFacturaLocal.TotalFactura);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes && MiFacturaLocal.Eliminar())
                {
                    MessageBox.Show("La Factura ha sido eliminado", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaFacturas();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e) /// CONSULTAR LA OTRA CLASE
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaFacturas(TxtBuscar.Text.Trim());
            }

        }

        private void TxtFacturaTotalFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtFacturaDetalleVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtFacturaImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }
    }
}


