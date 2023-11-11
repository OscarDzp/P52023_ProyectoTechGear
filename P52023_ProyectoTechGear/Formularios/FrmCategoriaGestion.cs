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
    public partial class FrmCategoriaGestion : Form
    {

        private Logica.Models.Categorias MiCategoriaLocal { get; set; }

        public FrmCategoriaGestion()
        {
            InitializeComponent();

            MiCategoriaLocal = new Logica.Models.Categorias();

        }

        private void FrmCategoriaGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaCategorias();
        }

        private void CargarListaCategorias()
        {
            Logica.Models.Categorias MiEmpleado = new Logica.Models.Categorias();

            DataTable lista = new DataTable();

            lista = MiCategoriaLocal.Listar();

            DgvListaCategorias.DataSource = lista;
        }

      


        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtCategoriaNombre.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtCategoriaNombre.Text.Trim()))
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

                MiCategoriaLocal = new Logica.Models.Categorias();


                MiCategoriaLocal.Nombre = TxtCategoriaNombre.Text.Trim();

                bool NombreCategoriaValido = MiCategoriaLocal.ConsultarPorNombre(MiCategoriaLocal.Nombre);

                if (NombreCategoriaValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar la categoría {0}?", MiCategoriaLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);


                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiCategoriaLocal.Agregar();
                        if (ok)
                        {
                            MessageBox.Show("La categoria ingresado correctamente!!", ":)", MessageBoxButtons.OK);

                        }
                        else
                        {
                            MessageBox.Show("La categoria no se pudo agregar", ":(", MessageBoxButtons.OK);
                        }

                        Limpiarform();
                        CargarListaCategorias();

                    }
                }
            }
        }

        private void Limpiarform()
        {
            TxtCategoriaCodigo.Clear();
            TxtCategoriaNombre.Clear();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
                MiCategoriaLocal.Nombre = TxtCategoriaNombre.Text.Trim();
                
                if (MiCategoriaLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar la Categoria?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiCategoriaLocal.Actualizar())
                        {
                            MessageBox.Show("Categoria modificada correctamenete!!", ":)", MessageBoxButtons.OK);
                            Limpiarform();
                            CargarListaCategorias();
                            ActivarBotonAgregar();
                        }

                    }

                }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiarform();
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

        private void DgvListaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvListaCategorias.SelectedRows.Count == 1)
            {
                Limpiarform();
                DataGridViewRow MiDgvFila = DgvListaCategorias.SelectedRows[0];
                int IdCategoria = Convert.ToInt32(MiDgvFila.Cells["ColCategoriaID"].Value);
                MiCategoriaLocal = new Logica.Models.Categorias();
                MiCategoriaLocal = MiCategoriaLocal.ConsultarPorID(IdCategoria);
                if (MiCategoriaLocal != null && MiCategoriaLocal.CategoriaID > 0)
                {
                    TxtCategoriaCodigo.Text = MiCategoriaLocal.CategoriaID.ToString();
                    TxtCategoriaNombre.Text = MiCategoriaLocal.Nombre;
                    ActivarBotonesModificarYEliminar();
                }
            }
        }

        private void DgvListaCategorias_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaCategorias.ClearSelection();
        }
    }
}
