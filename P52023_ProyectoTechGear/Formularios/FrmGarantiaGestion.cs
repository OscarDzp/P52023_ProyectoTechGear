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
        private Logica.Models.Garantias MiGarantia { get; set; }

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
        }

        private void CargarListaGarantia() {

            Logica.Models.Garantias MiGarantia = new Logica.Models.Garantias();
            DataTable lista = new DataTable();
            lista = MiGarantia.Listar();
            DgvListaGarantias.DataSource = lista;


        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtGarantiaTiempo.Text.Trim()) &&
                !string.IsNullOrEmpty(DtpFechaInicio.Text.Trim()) &&
                !string.IsNullOrEmpty(DtpFechaFinalizacion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtGarantiaDetalle.Text.Trim())&&
                !string.IsNullOrEmpty(TxtProductoCodigo.Text.Trim())
                )              
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
                if (string.IsNullOrEmpty(TxtGarantiaDetalle.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar algun tipo de descripcion");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoCodigo.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar el codigo del producto");
                    return false;
                }
            }

            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiGarantia = new Logica.Models.Garantias();



                MiGarantia.Tiempogarantia = TxtGarantiaTiempo.Text.Trim();
                MiGarantia.Fechainicio = DtpFechaInicio.Text.Trim();
                MiGarantia.Fechafinalizacion = DtpFechaFinalizacion.Text.Trim();
                MiGarantia.Detalle = TxtGarantiaDetalle.Text.Trim();
                MiGarantia.MiProducto.ProductoID = Convert.ToInt32(TxtProductoCodigo.Text.Trim());

                bool IdValido = MiGarantia.ConsultarPorID(MiGarantia.GarantiaID);

                if (IdValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar esta transaccion {0}?", MiGarantia.GarantiaID);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiGarantia.Agregar();

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
            TxtProductoCodigo.Clear();
        }
    }
}
