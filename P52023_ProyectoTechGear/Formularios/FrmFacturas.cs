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
            CargarListaCliente ();
        }

        private void CargarListaFacturas() 
        {
            Logica.Models.Facturas MiFacturas = new Logica.Models.Facturas();
            DataTable lista = new DataTable();
            lista = MiFacturas.Listar();
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
                CboxFacturaCliente.SelectedIndex > -1
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

                bool IDValida = MiFacturaLocal.ConsultarPorID(MiFacturaLocal.FacturaID.ToString()); // linea de dudosa procedencia 


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
        }

    }
}
