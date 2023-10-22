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
                            MessageBox.Show("Categoría agregada correctamente", "Agregado", MessageBoxButtons.OK);
                            Limpiarform();
                            //CargarListaCategorias();
                        }
                        else
                        {
                            MessageBox.Show("La categoría no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }


        private void Limpiarform()
        {
            TxtCategoriaNombre.Clear();
        }








    }
}
