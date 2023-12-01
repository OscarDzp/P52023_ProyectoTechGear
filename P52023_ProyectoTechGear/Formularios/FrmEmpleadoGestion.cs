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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
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
                CboxEmpleadoRol.ValueMember = "EmpleadoRolID";
                CboxEmpleadoRol.DisplayMember = "Rol";

                CboxEmpleadoRol.DataSource = dtRoles;
                CboxEmpleadoRol.SelectedIndex = -1;
            }
        }


        private void CargarListaEmpleados(string FiltroBusqueda = "")

        {
            Logica.Models.Empleados MiEmpleado = new Logica.Models.Empleados();

            DataTable lista = new DataTable();

            lista = MiEmpleado.Listar(FiltroBusqueda);

            DgvListaEmpleados.DataSource = lista;
        }

        private bool ValidarDatos(bool OmitirContrasenia = false)

        //validation of minimun values required
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtEmpleadoCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoCorreoElectronico.Text.Trim()) &&
         
                !string.IsNullOrEmpty(TxtEmpleadoTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtEmpleadoCargo.Text.Trim()) &&
                CboxEmpleadoRol.SelectedIndex > -1
                )
            {
                if (OmitirContrasenia)
                {
                    R = true;
                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtEmpleadoContrasennia.Text.Trim()))
                    {
                        R = true;

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(TxtEmpleadoContrasennia.Text.Trim()))
                        {

                            MessageBox.Show("Debe digitar la contraseña", "Error de validacion", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
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
                    MessageBox.Show("Se debe digitar el Nombre", "Error de validación", MessageBoxButtons.OK);
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

                    string Pregunta = string.Format("¿Está seguro que quiere agregar al empleado {0}?", MiEmpleadoLocal.Nombre);
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

        private void DgvListaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaEmpleados.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaEmpleados.SelectedRows[0];
                int IDEmpleado = Convert.ToInt32(MiDgvFila.Cells["ColEmpleadoID"].Value);
                MiEmpleadoLocal = new Logica.Models.Empleados();
                MiEmpleadoLocal = MiEmpleadoLocal.ConsultarPorID(IDEmpleado);
                if (MiEmpleadoLocal != null && MiEmpleadoLocal.EmpleadoID > 0)
                {
                TxtEmpleadoCodigo.Text = MiEmpleadoLocal.EmpleadoID.ToString();
                    TxtEmpleadoCedula.Text = MiEmpleadoLocal.Cedula;
                    TxtEmpleadoNombre.Text = MiEmpleadoLocal.Nombre;
                    TxtEmpleadoCorreoElectronico.Text = MiEmpleadoLocal.CorreoElectronico;
                    TxtEmpleadoTelefono.Text = MiEmpleadoLocal.Telefono;
                    CboxEmpleadoRol.SelectedValue = MiEmpleadoLocal.MiEmpleadoRol.EmpleadoRolID;
                    TxtEmpleadoCargo.Text = MiEmpleadoLocal.Cargo;

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

        private void DgvListaEmpleados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaEmpleados.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos(true))
            {
                MiEmpleadoLocal.Cedula = TxtEmpleadoCedula.Text.Trim();
                MiEmpleadoLocal.Nombre = TxtEmpleadoNombre.Text.Trim();
                MiEmpleadoLocal.CorreoElectronico = TxtEmpleadoCorreoElectronico.Text.Trim();
                MiEmpleadoLocal.Telefono = TxtEmpleadoTelefono.Text.Trim();
                MiEmpleadoLocal.MiEmpleadoRol.EmpleadoRolID = Convert.ToInt32(CboxEmpleadoRol.SelectedValue);
                MiEmpleadoLocal.Cargo = TxtEmpleadoCargo.Text.Trim();

                MiEmpleadoLocal.Contrasennia = TxtEmpleadoContrasennia.Text.Trim();

                if (MiEmpleadoLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar el Empleado?", "???", MessageBoxButtons.YesNo);
                    if(Resp == DialogResult.Yes) 
                    {
                    if(MiEmpleadoLocal.Actualizar())
                        {
                            MessageBox.Show("Empleado modificado correctamenete!!" , ":)", MessageBoxButtons.OK);
                            LimpiarForm();
                            CargarListaEmpleados();
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
            if (MiEmpleadoLocal.EmpleadoID > 0)
            {
                string msg = string.Format("Esta seguro de eliminar al Empleado {0}?", MiEmpleadoLocal.Nombre);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes && MiEmpleadoLocal.Eliminar())
                {
                    MessageBox.Show("El Empleado ha sido eliminado", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaEmpleados();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaEmpleados(TxtBuscar.Text.Trim());
            }
            CargarListaEmpleados(TxtBuscar.Text.Trim());
        }

        private void TxtEmpleadoCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtEmpleadoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtEmpleadoCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtEmpleadoContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtEmpleadoTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtEmpleadoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void DgvListaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
