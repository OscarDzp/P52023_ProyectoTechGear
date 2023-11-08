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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace P52023_ProyectoTechGear.Formularios
{
    public partial class FrmGarantiaGestion : Form
    {
        private Logica.Models.Garantias MiGarantiaLocal { get; set; }

        public FrmGarantiaGestion()
        {
            InitializeComponent();
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmGarantiaGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaGarantia();
            CargarListaProducto();
        }

      

            private void CargarListaProducto()
            {
            Logica.Models.Productos MiProducto = new Logica.Models.Productos();

            DataTable dtProductos = new DataTable();

            dtProductos = MiProducto.Listar();

            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                CboxGarantiaProducto.ValueMember = "ProductoID";
                CboxGarantiaProducto.DisplayMember = "Nombre";

                CboxGarantiaProducto.DataSource = dtProductos;
                CboxGarantiaProducto.SelectedIndex = -1;
            }
        }

        private void CargarListaGarantia(string FiltroBusqueda = "")
            {

            Logica.Models.Garantias MiGarantia = new Logica.Models.Garantias();
            DataTable lista = new DataTable();
            lista = MiGarantia.Listar(FiltroBusqueda);
            DgvListaGarantias.DataSource = lista;


        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtGarantiaTiempo.Text.Trim()) &&
                !string.IsNullOrEmpty(DtpFechaInicio.Text.Trim()) &&
                !string.IsNullOrEmpty(DtpFechaFinalizacion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtGarantiaDetalle.Text.Trim())&&
               CboxGarantiaProducto.SelectedIndex > -1)
                              
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtGarantiaTiempo.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar el periodo de tiempo de la garantia");
                    return false;
                }
                if (string.IsNullOrEmpty(DtpFechaInicio.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una fecha de inicio de garantia");
                    return false;
                }
                if (string.IsNullOrEmpty(DtpFechaFinalizacion.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una fecha de finalizacion de garantia");
                    return false;
                }
                if (CboxGarantiaProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe ingresar el Producto");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtGarantiaDetalle.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar algun tipo de descripcion");
                    return false;
                }
            }

            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiGarantiaLocal = new Logica.Models.Garantias();



                MiGarantiaLocal.Tiempogarantia = TxtGarantiaTiempo.Text.Trim();
                MiGarantiaLocal.Fechainicio = DateTime.Parse(DtpFechaInicio.Text.Trim());
                MiGarantiaLocal.Fechafinalizacion = DateTime.Parse(DtpFechaFinalizacion.Text.Trim());
                MiGarantiaLocal.Detalle = TxtGarantiaDetalle.Text.Trim();
                MiGarantiaLocal.MiProducto.ProductoID = Convert.ToInt32(CboxGarantiaProducto.SelectedValue);
         
                bool IdValido = MiGarantiaLocal.ConsultarPorTiempoGarantia(MiGarantiaLocal.Tiempogarantia);

                if (IdValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar esta Garantia {0}?", MiGarantiaLocal.GarantiaID);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiGarantiaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Garantia agregada correctamente", "Agregado", MessageBoxButtons.OK);
                            LimpiarForm();

                        }
                        else
                        {
                            MessageBox.Show("La Garantia no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                        LimpiarForm();
                        CargarListaGarantia();
                    }
                }
            }
        }

        private void LimpiarForm()
        {

            TxtGarantiaTiempo.Clear();
            DtpFechaInicio.ResetText();
            DtpFechaFinalizacion.ResetText();
            TxtGarantiaDetalle.Clear();
            CboxGarantiaProducto.SelectedIndex = -1;
        }

        private void DgvListaGarantias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaGarantias.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaGarantias.SelectedRows[0];
                int IdGarantia = Convert.ToInt32(MiDgvFila.Cells["ColGarantiaID"].Value);
                MiGarantiaLocal = new Logica.Models.Garantias();
                MiGarantiaLocal = MiGarantiaLocal.ConsultarPorID(IdGarantia);
                if (MiGarantiaLocal != null && MiGarantiaLocal.GarantiaID > 0)
                {
                    TxtGarantiaCodigo.Text = MiGarantiaLocal.GarantiaID.ToString();
                    TxtGarantiaTiempo.Text = MiGarantiaLocal.Tiempogarantia;
                    DtpFechaInicio.Value = MiGarantiaLocal.Fechainicio;
                    DtpFechaFinalizacion.Value = MiGarantiaLocal.Fechafinalizacion;
                    CboxGarantiaProducto.SelectedValue = MiGarantiaLocal.MiProducto.ProductoID;
                    TxtGarantiaDetalle.Text = MiGarantiaLocal.Detalle;
 
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

        private void DgvListaGarantias_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaGarantias.ClearSelection();

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {
                MiGarantiaLocal.Tiempogarantia = TxtGarantiaTiempo.Text.Trim();
                MiGarantiaLocal.Fechainicio = DateTime.Parse(DtpFechaInicio.Text.Trim());
                MiGarantiaLocal.Fechafinalizacion = DateTime.Parse(DtpFechaFinalizacion.Text.Trim());
   
                MiGarantiaLocal.MiProducto.ProductoID = Convert.ToInt32(CboxGarantiaProducto.SelectedValue);
                MiGarantiaLocal.Detalle = TxtGarantiaDetalle.Text.Trim();

                if (MiGarantiaLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar la Garantia?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiGarantiaLocal.Actualizar())
                        {
                            MessageBox.Show("Garantia modificado correctamenete!!", ":)", MessageBoxButtons.OK);
                            LimpiarForm();
                            CargarListaGarantia();
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
            if (MiGarantiaLocal.GarantiaID > 0)
            {
                string msg = string.Format("Esta seguro de eliminar la Garantia {0}?", MiGarantiaLocal.Detalle);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes && MiGarantiaLocal.Eliminar())
                {
                    MessageBox.Show("La Garantia ha sido eliminado", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaGarantia();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaGarantia(TxtBuscar.Text.Trim());
            }
            
        }

        private void TxtGarantiaDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }
    }
}
