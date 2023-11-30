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
    public partial class FrmEmpleadoRol : Form
    {
        private Logica.Models.EmpleadoRol MiEmpleadoRolLocal { get; set; }
        public FrmEmpleadoRol()
        {
            InitializeComponent();
            MiEmpleadoRolLocal = new Logica.Models.EmpleadoRol();
        }

        private void FrmEmpleadoRol_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaEmpleadoRol();
        }

        private void CargarListaEmpleadoRol(string FiltroBusqueda = "")
        {
            Logica.Models.EmpleadoRol MiEmpleadoRolLocal = new Logica.Models.EmpleadoRol();

            DataTable lista = new DataTable();

            lista = MiEmpleadoRolLocal.Listar(FiltroBusqueda);

            DgvListaEmpleadoRol.DataSource = lista;
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtEmpleadoRolNombre.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtEmpleadoRolNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nuevo Rol");
                    return false;
                }
            }

            return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiEmpleadoRolLocal = new Logica.Models.EmpleadoRol();

                MiEmpleadoRolLocal.Rol = TxtEmpleadoRolNombre.Text.Trim();

                bool NombreValido = MiEmpleadoRolLocal.ConsultarPorRol(MiEmpleadoRolLocal.Rol);

                if (NombreValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar el rol {0}?", MiEmpleadoRolLocal.Rol);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiEmpleadoRolLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Rol agregado correctamente", "Agregado", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("El rol no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                        Limpiarform();
                        CargarListaEmpleadoRol();
                    }
                }
            }

        }

        private void Limpiarform()
        {
            TxtEmpleadoRolNombre.Clear();
        }

        private void DgvListaEmpleadoRol_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaEmpleadoRol.SelectedRows.Count == 1)
            {
                Limpiarform();
                DataGridViewRow MiDgvFila = DgvListaEmpleadoRol.SelectedRows[0];
                int IdEmpleadoRol = Convert.ToInt32(MiDgvFila.Cells["ColEmpleadoRolID"].Value);
                MiEmpleadoRolLocal = new Logica.Models.EmpleadoRol();
                MiEmpleadoRolLocal = MiEmpleadoRolLocal.ConsultarPorID(IdEmpleadoRol);
                if (MiEmpleadoRolLocal != null && MiEmpleadoRolLocal.EmpleadoRolID > 0)
                {
                    TxtEmpleadoRolCodigo.Text = MiEmpleadoRolLocal.EmpleadoRolID.ToString();
                    TxtEmpleadoRolNombre.Text = MiEmpleadoRolLocal.Rol;

                    ActivarBotonesModificarYEliminar();
                }

            }
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiarform();
            ActivarBotonAgregar();
        }

        private void DgvListaEmpleadoRol_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaEmpleadoRol.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
                     
                MiEmpleadoRolLocal.Rol = TxtEmpleadoRolNombre.Text.Trim();

                if (MiEmpleadoRolLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar el rol?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiEmpleadoRolLocal.Actualizar())
                        {
                            MessageBox.Show("Rol modificado correctamenete!!", ":)", MessageBoxButtons.OK);
                            Limpiarform();
                            CargarListaEmpleadoRol();
                            ActivarBotonAgregar();
                        }
                    }
                }
            }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiEmpleadoRolLocal.EmpleadoRolID > 0)
            {
                string msg = string.Format("Esta seguro de eliminar el rol del empleado {0}?", MiEmpleadoRolLocal.Rol);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes && MiEmpleadoRolLocal.Eliminar())
                {
                    MessageBox.Show("El rol de empleado ha sido eliminado", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpiarform();
                    CargarListaEmpleadoRol();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtEmpleadoRolNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaEmpleadoRol(TxtBuscar.Text.Trim());
            }
            CargarListaEmpleadoRol(TxtBuscar.Text.Trim());
        }
    }
    }
