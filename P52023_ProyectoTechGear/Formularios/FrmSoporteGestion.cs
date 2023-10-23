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

            if (!string.IsNullOrEmpty(TxtSoporteNombre.Text.Trim())&&
                !string.IsNullOrEmpty(TxtSoporteCorreo.Text.Trim())&&
                !string.IsNullOrEmpty(TxtSoporteEspecialidad.Text.Trim())&&
                CboxSoporteDisponibilidad.SelectedIndex > -1)
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
                if (CboxSoporteDisponibilidad.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe asignar un horario de disponibilidad", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }

            return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiSoporteLocal = new Logica.Models.SoporteTecnico();


                MiSoporteLocal.Nombre = TxtSoporteNombre.Text.Trim();
                MiSoporteLocal.CorreoElectronico = TxtSoporteCorreo.Text.Trim();
                MiSoporteLocal.Especialidad = TxtSoporteEspecialidad.Text.Trim();
                //MiSoporteLocal.Disponibilidad = Convert.ToInt32(CboxSoporteDisponibilidad.SelectedValue);


                bool CorreoValido = MiSoporteLocal.ConsultarPorCorreo(MiSoporteLocal.CorreoElectronico);

                bool IDValido = MiSoporteLocal.ConsultarPorID(MiSoporteLocal.TecnicoID);


                if (CorreoValido == false && IDValido == false )
                {
                    string Pregunta = string.Format("Esta seguro de agregar al técnico {0}?", MiSoporteLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiSoporteLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Técnico agregado correctamente", "Agregado", MessageBoxButtons.OK);
                            LimpiarForm();
                            
                        }
                        else
                        {
                            MessageBox.Show("El técnico no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                    }
                }
            }

        }

        private void LimpiarForm()
        {
            TxtSoporteNombre.Clear();
            TxtSoporteCorreo.Clear();
            TxtSoporteEspecialidad.Clear();
            CboxSoporteDisponibilidad.SelectedIndex = -1;
        }

        private void FrmSoporteGestion_Load_1(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaSoporteTecnico();
        }

        private void CargarListaSoporteTecnico() 
        {
            Logica.Models.SoporteTecnico MiSoporteTecnico = new Logica.Models.SoporteTecnico();
            DataTable lista = new DataTable();
            lista = MiSoporteTecnico.Listar();
            DgvListaSoporteTecnico.DataSource = lista;

        }
    }
}
