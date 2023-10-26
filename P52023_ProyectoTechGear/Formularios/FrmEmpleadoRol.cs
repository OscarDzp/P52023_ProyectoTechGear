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

        private void CargarListaEmpleadoRol() 
        {
            Logica.Models.EmpleadoRol MiEmpleadoRol = new Logica.Models.EmpleadoRol();
            DataTable lista = new DataTable();
            lista = MiEmpleadoRol.Listar();
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


                MiEmpleadoRolLocal.Rol = TxtEmpleadoRolNombre.Text.Trim();

                bool NombreValido = MiEmpleadoRolLocal.ConsultarPorNombre(MiEmpleadoRolLocal.Rol);

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


    }
}
