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
              

                bool NombreValido = MiModeloLocal.ConsultarPorNombre(MiModeloLocal.Nombre);

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

        private void DgvListaModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaModelos.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaModelos.SelectedRows[0];
                int IdModelos = Convert.ToInt32(MiDgvFila.Cells["ColModeloID"].Value);
                MiModeloLocal = new Logica.Models.Modelos();
                MiModeloLocal = MiModeloLocal.ConsultarPorID(IdModelos);
                if (MiModeloLocal != null && MiModeloLocal.ModeloID > 0)
                {
                    TxtModeloCodigo.Text = MiModeloLocal.ModeloID.ToString();
                    DtpModeloAnioLanzamiento.Value = MiModeloLocal.AnioLanzamiento;
                    TxtModeloNombre.Text = MiModeloLocal.Nombre;
        
                    CboxModelosMarca.SelectedValue = MiModeloLocal.MiMarcaID.MarcaID;


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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {
                MiModeloLocal.AnioLanzamiento = DateTime.Parse(DtpModeloAnioLanzamiento.Text.Trim());
                MiModeloLocal.Nombre = TxtModeloNombre.Text.Trim();
                MiModeloLocal.MiMarcaID.MarcaID = Convert.ToInt32(CboxModelosMarca.SelectedValue);

             

                if (MiModeloLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar el modelo?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiModeloLocal.Actualizar())
                        {
                            MessageBox.Show("Modelos modificado correctamenete!!", ":)", MessageBoxButtons.OK);
                            LimpiarForm();
                            CargarListaModelos();
                            ActivarBotonAgregar();
                        }

                    }

                }
            }
        }

        private void DgvListaModelos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaModelos.ClearSelection();

        }
    }
}
