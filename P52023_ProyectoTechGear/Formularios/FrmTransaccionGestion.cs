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
    public partial class FrmTransaccionGestion : Form
    {
        private Logica.Models.Transacciones MiTransaccionLocal { get; set; }

        public FrmTransaccionGestion()
        {
            InitializeComponent();
        }

        private void FrmTransaccionGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaTransaccion();
            CargarListaFactura();
        }

        private void CargarListaFactura()
        {
            Logica.Models.Facturas MiFactura = new Logica.Models.Facturas();

            DataTable dtFacturas = new DataTable();

            dtFacturas = MiFactura.Listar();

            if (dtFacturas != null && dtFacturas.Rows.Count > 0)
            {
                CboxTransaccionFactura.ValueMember = "FacturaID";
                CboxTransaccionFactura.DisplayMember = "Detalledeventa";

                CboxTransaccionFactura.DataSource = dtFacturas;
                CboxTransaccionFactura.SelectedIndex = -1;
            }
        }

        private void CargarListaTransaccion()
        {
            Logica.Models.Transacciones MiTransaccion = new Logica.Models.Transacciones();
            DataTable lista = new DataTable();
            lista = MiTransaccion.Listar();
            DgvListaTransaccion.DataSource = lista;
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (
                !string.IsNullOrEmpty(TxtTransaccionTipo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtTransaccionCantidad.Text.Trim()) &&
                CboxTransaccionFactura.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtTransaccionCantidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar la cantidad");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtTransaccionTipo.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un numero de factura");
                    return false;
                }
                if (CboxTransaccionFactura.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir el tipo de transaccion", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiTransaccionLocal = new Logica.Models.Transacciones();


                MiTransaccionLocal.FechaTransaccion = DateTime.Parse(DtTransaccionCodigo.Text.Trim());
                MiTransaccionLocal.Cantidad = TxtTransaccionCantidad.Text.Trim();
                MiTransaccionLocal.TipoTransaccion = TxtTransaccionTipo.Text.Trim();
                MiTransaccionLocal.MiFactura.FacturaID = Convert.ToInt32(CboxTransaccionFactura.SelectedValue);
           

                bool IdValido = MiTransaccionLocal.ConsultarPorID(MiTransaccionLocal.TransaccionID);

                if (IdValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar esta transaccion {0}?", MiTransaccionLocal.TransaccionID);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiTransaccionLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Transaccion agregada correctamente", "Agregado", MessageBoxButtons.OK);
                            LimpiarForm();

                        }
                        else
                        {
                            MessageBox.Show("La Transaccion no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                        LimpiarForm();
                        CargarListaTransaccion();
                    }
                }
            }
        }

        private void LimpiarForm()
        {
            //DtTransaccionCodigo.SelectedIndex = -1;//
            TxtTransaccionCantidad.Clear();
            CboxTransaccionFactura.SelectedIndex = -1;
            TxtTransaccionTipo.Clear();
        }
    }
}

