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
                    MessageBox.Show("Se debe asignar un nombre la categoría");
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


                MiEmpleadoRolLocal.Nombre = TxtEmpleadoRolNombre.Text.Trim();

                bool NombreValido = MiEmpleadoRolLocal.ConsultarPorNombre(MiEmpleadoRolLocal.Nombre);

                if (NombreValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar el rol {0}?", MiEmpleadoRolLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiEmpleadoRolLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Rol agregado correctamente", "Agregado", MessageBoxButtons.OK);
                            Limpiarform();
                            //CargarListaRoles();
                        }
                        else
                        {
                            MessageBox.Show("El rol no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                    }
                }
            }

        }

        private void Limpiarform()
        {
            TxtEmpleadoRolNombre.Clear();
        }


    }
}
