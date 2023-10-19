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
    public partial class FrmEmpleadoGestion : Form

    {
        private Logica.Models.Empleados MiEmpleadoLocal { get; set; }


        public FrmEmpleadoGestion()
        {
            InitializeComponent();

            MiEmpleadoLocal = new Logica.Models.Empleados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtEmpleadoCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmpleadoCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmpleadoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmpleadoCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmpleadoContrasennia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtEmpleadoCargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEmpleadoGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaRoles();
            CargarListaEmpleados();

        }

        private void CargarListaRoles()
        {
            Logica.Models.EmpleadoRol MiRol = new Logica.Models.EmpleadoRol();

            DataTable dtRoles = new DataTable();

            dtRoles = MiRol.Listar();

            if (dtRoles != null && dtRoles.Rows.Count > 0)
            {
                CboxEmpleadoRol.ValueMember = "ID";
                CboxEmpleadoRol.DisplayMember = "Rol";

                CboxEmpleadoRol.DataSource = dtRoles;
                CboxEmpleadoRol.SelectedIndex = -1;
            }
        }


        private void CargarListaEmpleados()

        {
            Logica.Models.Empleados MiEmpleado = new Logica.Models.Empleados();

            DataTable lista = new DataTable();

            lista = MiEmpleado.Listar();

            DgvListaEmpleados.DataSource = lista;
        }

        private bool ValidarDatos()

        //validation of minimun values required
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtEmpleadoCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoCorreoElectronico.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoContrasennia.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoCargo.Text.Trim()) &&
                CboxEmpleadoRol.SelectedIndex > -1
                )
            {
                R = true;

            }
            else
            {
                //validacion faltante
                if (string.IsNullOrEmpty(TxtEmpleadoCedula.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar la cédula", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmpleadoNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar el nombre", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmpleadoCorreoElectronico.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar el correo electrónico", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmpleadoContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar la contraseña", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmpleadoTelefono.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar en número telefónico", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxEmpleadoRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir un rol de empleado", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtEmpleadoCargo.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar eL cargo del empleado", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }




        private void BtnAgregar_Click(object sender, EventArgs e)
        {


            //Validation 

            if (ValidarDatos())
            {

                MiEmpleadoLocal = new Logica.Models.Empleados();

                MiEmpleadoLocal.Cedula = TxtEmpleadoCedula.Text.Trim();
                MiEmpleadoLocal.Nombre = TxtEmpleadoNombre.Text.Trim();
                MiEmpleadoLocal.CorreoElectronico = TxtEmpleadoCorreoElectronico.Text.Trim();
                MiEmpleadoLocal.Contrasennia = TxtEmpleadoContrasennia.Text.Trim();
                MiEmpleadoLocal.Telefono = TxtEmpleadoTelefono.Text.Trim();
                MiEmpleadoLocal.MiEmpleadoRol.EmpleadoRolID = Convert.ToInt32(CboxEmpleadoRol.SelectedValue);
                MiEmpleadoLocal.Cargo = TxtEmpleadoCargo.Text.Trim();

                bool CedulaValida = MiEmpleadoLocal.ConsultarPorCedula(MiEmpleadoLocal.Cedula);

                bool CorreoValido = MiEmpleadoLocal.ConsultarPorCorreoElectronico(MiEmpleadoLocal.CorreoElectronico);

                if (CedulaValida == false && CorreoValido == false)
                {
                    //Confirmacion

                    string Pregunta = string.Format("¿Está seguro que queire agregar al empleado {0}?", MiEmpleadoLocal.Nombre);
                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiEmpleadoLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Empleado agregado correctamente!", "Empleado agregado", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaEmpleados();

                        }
                        else
                        {
                            MessageBox.Show("El empleado no pudo ser agregado...", "Empleado no agregado", MessageBoxButtons.OK);

                        }
                    }
                }

            }

        }


        private void LimpiarForm()
        {
            TxtEmpleadoCodigo.Clear();
            TxtEmpleadoCedula.Clear();
            TxtEmpleadoNombre.Clear();
            TxtEmpleadoCorreoElectronico.Clear();
            TxtEmpleadoContrasennia.Clear();
            TxtEmpleadoTelefono.Clear();
            TxtEmpleadoCargo.Clear();
            CboxEmpleadoRol.SelectedIndex = -1;
        }

        private void DgvListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
