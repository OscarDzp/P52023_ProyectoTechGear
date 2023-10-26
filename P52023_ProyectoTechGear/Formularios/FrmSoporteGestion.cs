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
    public partial class FrmSoporteGestion : Form
    {
        private Logica.Models.SoporteTecnico MiSoporteLocal { get; set; }

        public FrmSoporteGestion()
        {
            InitializeComponent();
            MiSoporteLocal = new Logica.Models.SoporteTecnico();
            
        }

        private void FrmSoporteGestion_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtSoporteNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSoporteCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSoporteEspecialidad.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtSoporteDisponibilidad.Text.Trim()) &&
                  CboxSoporteGarantia.SelectedIndex > -1 )
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtSoporteNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nombre ");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteCorreo.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un correo electrónico");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteEspecialidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una especialidad");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteDisponibilidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un horario de disponibilidad", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;

        }

        private void CargarListaSoporteGarantia()
        {
            Logica.Models.Garantias MiGarantiaID = new Logica.Models.Garantias();

            DataTable dtSoporteGarantia = new DataTable();

            dtSoporteGarantia = MiGarantiaID.Listar();

            if (dtSoporteGarantia != null && dtSoporteGarantia.Rows.Count > 0)
            {
                CboxSoporteGarantia.ValueMember = "GarantiaID";
                CboxSoporteGarantia.DisplayMember = "Detalle";

                CboxSoporteGarantia.DataSource = dtSoporteGarantia;
                CboxSoporteGarantia.SelectedIndex = -1;
            }
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
           

        }

        private void LimpiarForm()
        {
            TxtSoporteNombre.Clear();
            TxtSoporteCorreo.Clear();
            TxtSoporteEspecialidad.Clear();
            TxtSoporteDisponibilidad.Clear();
            CboxSoporteGarantia.SelectedIndex = -1;
        }

        private void FrmSoporteGestion_Load_1(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaSoporteTecnico();
            CargarListaSoporteGarantia();
        }

        private void CargarListaSoporteTecnico() 
        {
            Logica.Models.SoporteTecnico MiSoporteTecnico = new Logica.Models.SoporteTecnico();
            DataTable lista = new DataTable();
            lista = MiSoporteTecnico.Listar();
            DgvListaSoporteTecnico.DataSource = lista;

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiSoporteLocal = new Logica.Models.SoporteTecnico();


                MiSoporteLocal.Nombre = TxtSoporteNombre.Text.Trim();
                MiSoporteLocal.Correo = TxtSoporteCorreo.Text.Trim();
                MiSoporteLocal.Especialidad = TxtSoporteEspecialidad.Text.Trim();
                MiSoporteLocal.Disponibilidad = TxtSoporteDisponibilidad.Text.Trim();
                MiSoporteLocal.MiGarantiaID.GarantiaID = Convert.ToInt32(CboxSoporteGarantia.SelectedValue);

                bool CorreoValido = MiSoporteLocal.ConsultarPorCorreo(MiSoporteLocal.Correo);

                bool IDValido = MiSoporteLocal.ConsultarPorID(MiSoporteLocal.TecnicoID);


                if (CorreoValido == false && IDValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar al técnico {0}?", MiSoporteLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiSoporteLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Técnico agregado correctamente", "Agregado", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("El técnico no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }

                    }
                    LimpiarForm();
                    CargarListaSoporteTecnico();
                }
            }

        }
    }
}
