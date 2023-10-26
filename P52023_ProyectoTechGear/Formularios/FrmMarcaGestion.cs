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
    public partial class FrmMarcaGestion : Form
    {
        private Logica.Models.Marcas MiMarcaLocal { get; set; }

        public FrmMarcaGestion()
        {
            InitializeComponent();
            MiMarcaLocal = new Logica.Models.Marcas();
        }

        private void FrmMarcaGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaMarcas();
        }

        private void CargarListaMarcas()
        {
            Logica.Models.Marcas MiMarcas = new Logica.Models.Marcas();
            DataTable lista = new DataTable();
            lista = MiMarcas.Listar();
            DgvListaMarcas.DataSource = lista;

        }
        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtMarcaNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtMarcaPaisOrigen.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtMarcaPaisOrigen.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un país de origen");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtMarcaNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nombre de marca");
                    return false;
                }
              
            }

            return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiMarcaLocal = new Logica.Models.Marcas();


                MiMarcaLocal.Nombre = TxtMarcaNombre.Text.Trim();
                MiMarcaLocal.PaisOrigen = TxtMarcaPaisOrigen.Text.Trim();

                bool NombreValido = MiMarcaLocal.ConsultarPorNombre(MiMarcaLocal.Nombre);

                if (NombreValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar la Marca {0}?", MiMarcaLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiMarcaLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Marca agregada correctamente", "Agregado", MessageBoxButtons.OK);
                        
                        }
                        else
                        {
                            MessageBox.Show("La marca no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                        LimpiarForm();
                        CargarListaMarcas();
                    }
                }
            }


        }

        private void LimpiarForm()
        {
            TxtMarcaNombre.Clear();
            TxtMarcaPaisOrigen.Clear();
        }

    }
}
