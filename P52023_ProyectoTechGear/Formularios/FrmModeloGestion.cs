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
    public partial class FrmModeloGestion : Form
    {
        private Logica.Models.Modelos MiModeloLocal { get; set; }
        public FrmModeloGestion()
        {
            InitializeComponent();
            MiModeloLocal = new Logica.Models.Modelos();    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmModeloGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaModelos();
            CargarListaMarcas();
        }
        private void CargarListaModelos() 
        {
            Logica.Models.Modelos MiModelo = new Logica.Models.Modelos();
            DataTable lista = new DataTable();
            lista = MiModelo.Listar();
            DgvListaModelos.DataSource = lista;

        }

        private void CargarListaMarcas()
        {
            Logica.Models.Marcas MiMarcas = new Logica.Models.Marcas();

            DataTable dtMarcas = new DataTable();

            dtMarcas = MiMarcas.Listar();

            if (dtMarcas != null && dtMarcas.Rows.Count > 0)
            {
                CboxModelosMarca.ValueMember = "MarcaID";
                CboxModelosMarca.DisplayMember = "Nombre";

                CboxModelosMarca.DataSource = dtMarcas;
                CboxModelosMarca.SelectedIndex = -1;
            }
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtModeloNombre.Text.Trim()) &&
                //fecha 
                CboxModelosMarca.SelectedIndex > -1)
            {
                R = true;
            }
            else
            {
                //Fecha
                if (string.IsNullOrEmpty(TxtModeloNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nombre al modelo");
                    return false;
                }
                if (CboxModelosMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir una marca", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                
            }

            return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiModeloLocal = new Logica.Models.Modelos();


                MiModeloLocal.Nombre = TxtModeloNombre.Text.Trim();
                MiModeloLocal.AnioLanzamiento = DateTime.Parse(DtpModeloAnioLanzamiento.Text.Trim());
                MiModeloLocal.MiMarcaID.MarcaID = Convert.ToInt32(CboxModelosMarca.SelectedValue);
              

                bool NombreValido = MiModeloLocal.ConsultarPorID(MiModeloLocal.ModeloID);

                if (NombreValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar el modelo {0}?", MiModeloLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiModeloLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Modelo agregado correctamente", "Agregado", MessageBoxButtons.OK);
                          
                        }
                        else
                        {
                            MessageBox.Show("El modelo no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }                
                    }
                    LimpiarForm();
                    CargarListaModelos();
                    CargarListaMarcas();
                }
            }


        }

        private void LimpiarForm()
        {
            TxtModeloNombre.Clear();
            CboxModelosMarca.SelectedIndex = -1;
            //Fecha
        }

    }
}
