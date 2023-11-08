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
                    MessageBox.Show("Se debe asignar el tipo de Transaccion que se va realizar");
                    return false;
                }
                if (CboxTransaccionFactura.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir la factura", "Error de validación", MessageBoxButtons.OK);
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


                MiTransaccionLocal.FechaTransaccion = DateTime.Parse(DtTransaccionFecha.Text.Trim());
                MiTransaccionLocal.Cantidad = int.Parse(TxtTransaccionCantidad.Text.Trim());
                MiTransaccionLocal.TipoTransaccion = TxtTransaccionTipo.Text.Trim();
                MiTransaccionLocal.MiFactura.FacturaID = Convert.ToInt32(CboxTransaccionFactura.SelectedValue);
           

                bool IdValido = MiTransaccionLocal.ConsultarPorTipoTransaccion(MiTransaccionLocal.TipoTransaccion);

                if (IdValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar esta transaccion {0}?", MiTransaccionLocal.TipoTransaccion);

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

        private void DgvListaTransaccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaTransaccion.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaTransaccion.SelectedRows[0];
                int IdTransaccion = Convert.ToInt32(MiDgvFila.Cells["ColTransaccionID"].Value);
                MiTransaccionLocal = new Logica.Models.Transacciones();
                MiTransaccionLocal = MiTransaccionLocal.ConsultarPorID(IdTransaccion);
                if (MiTransaccionLocal != null && MiTransaccionLocal.TransaccionID > 0)
                {
                    TxtTransaccionCodigo.Text = MiTransaccionLocal.TransaccionID.ToString();
                    DtTransaccionFecha.Value = MiTransaccionLocal.FechaTransaccion;
                    TxtTransaccionCantidad.Text = MiTransaccionLocal.Cantidad.ToString();
                    TxtTransaccionTipo.Text = MiTransaccionLocal.TipoTransaccion;
                    CboxTransaccionFactura.SelectedValue = MiTransaccionLocal.MiFactura.FacturaID;
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

        private void DgvListaTransaccion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaTransaccion.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            MiTransaccionLocal.FechaTransaccion = DateTime.Parse(DtTransaccionFecha.Text.Trim());
            MiTransaccionLocal.Cantidad = Convert.ToInt32(TxtTransaccionCantidad.Text.Trim());
            MiTransaccionLocal.TipoTransaccion = TxtTransaccionTipo.Text.Trim();
            MiTransaccionLocal.MiFactura.FacturaID = Convert.ToInt32(CboxTransaccionFactura.SelectedValue);

            if (MiTransaccionLocal.ConsultarPorID())
            {
                DialogResult Resp = MessageBox.Show("Desea modificar la transaccion?", "???", MessageBoxButtons.YesNo);
                if (Resp == DialogResult.Yes)
                {
                    if (MiTransaccionLocal.Actualizar())
                    {
                        MessageBox.Show("Transaccion modificado correctamenete!!", ":)", MessageBoxButtons.OK);
                        LimpiarForm();
                        CargarListaTransaccion();
                        ActivarBotonAgregar();
                    }

                }

            }
        }
    }
    }


