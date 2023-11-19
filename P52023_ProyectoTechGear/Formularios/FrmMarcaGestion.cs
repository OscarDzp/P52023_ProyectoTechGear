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
            ActivarBotonAgregar();
        }

        private void CargarListaMarcas(string FiltroBusqueda = "")
        {
            Logica.Models.Marcas MiMarcas = new Logica.Models.Marcas();

            DataTable lista = new DataTable();

            lista = MiMarcas.Listar(FiltroBusqueda);

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

                bool IDValido = MiMarcaLocal.ConsultarPorID();

                if (IDValido == false)
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
            TxtMarcaCodigo.Clear();
            TxtMarcaNombre.Clear();
            TxtMarcaPaisOrigen.Clear();
        }

        private void DgvListaMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validamos que se haya seleccionado una linea en la tabla 
            if (DgvListaMarcas.SelectedRows.Count == 1)
            {
                LimpiarForm();

                DataGridViewRow MiDvgFila = DgvListaMarcas.SelectedRows[0];
                int IDMarca = Convert.ToInt32(MiDvgFila.Cells["ColMarcaID"].Value);

                MiMarcaLocal = new Logica.Models.Marcas();
                MiMarcaLocal = MiMarcaLocal.ConsultarPorID(IDMarca);

                if (MiMarcaLocal != null && MiMarcaLocal.MarcaID > 0)
                {
                    TxtMarcaCodigo.Text = MiMarcaLocal.MarcaID.ToString();
                    TxtMarcaPaisOrigen.Text = MiMarcaLocal.PaisOrigen;
                    TxtMarcaNombre.Text = MiMarcaLocal.Nombre;


                    ActivarBotonModificarEliminar();
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

        private void ActivarBotonModificarEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgvListaMarcas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaMarcas.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {
                MiMarcaLocal.PaisOrigen = TxtMarcaPaisOrigen.Text.Trim();
                MiMarcaLocal.Nombre = TxtMarcaNombre.Text.Trim();

                if (MiMarcaLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea modificar la Marca", "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiMarcaLocal.Actualizar())
                        {
                            MessageBox.Show("Marca actualizada correctamente", "Actualizada", MessageBoxButtons.OK);

                            LimpiarForm();

                            CargarListaMarcas();

                            ActivarBotonAgregar();


                        }
                    }
                }

            }
        }

        private void DgvListaMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiMarcaLocal.MarcaID > 0)
            {

                string Msg = string.Format("¿Esta seguro de eliminar la marca {0}?", MiMarcaLocal.Nombre);
                DialogResult respuresta = MessageBox.Show(Msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuresta == DialogResult.Yes && MiMarcaLocal.Eliminar())
                {
                    MessageBox.Show("La marca ha sido eliminada", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaMarcas();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtMarcaPaisOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtMarcaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaMarcas(TxtBuscar.Text.Trim());
            }
            CargarListaMarcas(TxtBuscar.Text.Trim());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
