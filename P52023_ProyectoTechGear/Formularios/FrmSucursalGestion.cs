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
    public partial class FrmSucursalGestion : Form
    {
        private Logica.Models.Sucursales MiSucursalLocal = new Sucursales();
        public FrmSucursalGestion()
        {
            InitializeComponent();

            MiSucursalLocal = new Logica.Models.Sucursales();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmSucursalGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaSucursal();
            ActivarBotonAgregar();
        }

        private void CargarListaSucursal(string FiltroBusqueda = "") 
        {
            Logica.Models.Sucursales MiSucursal = new Logica.Models.Sucursales();

            DataTable lista = new DataTable();

            lista = MiSucursal.Listar(FiltroBusqueda);

            DgvListaSucursal.DataSource = lista;
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtSucursalNombre.Text.Trim())&&
                !string.IsNullOrEmpty(TxtSucursalDescripcion.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtSucursalNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nombre la sucursal");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSucursalDescripcion.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una descripcion a la sucursal");
                    return false;
                }
            }

            return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiSucursalLocal = new Logica.Models.Sucursales();


                MiSucursalLocal.Nombre = TxtSucursalNombre.Text.Trim();
                MiSucursalLocal.Descripcion = TxtSucursalDescripcion.Text.Trim();

                bool NombreValido = MiSucursalLocal.ConsultarPorNombre(MiSucursalLocal.Nombre);
                bool IDValido = MiSucursalLocal.ConsultarPorID();

                if (NombreValido == false && IDValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar la sucursal {0}?", MiSucursalLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiSucursalLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Sucursal agregada correctamente", "Agregado", MessageBoxButtons.OK);
                            LimpiarForm();
                            
                        }
                        else
                        {
                            MessageBox.Show("La sucursal no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                        LimpiarForm();
                        CargarListaSucursal();
                    }
                }
            }


        }

        private void LimpiarForm()
        {
            TxtSucursalCodigo.Clear();
            TxtSucursalNombre.Clear();
            TxtSucursalDescripcion.Clear();
        }

        private void DgvListaSucursal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validamos que se haya seleccionado una linea en la tabla 
            if (DgvListaSucursal.SelectedRows.Count == 1)
            {
                LimpiarForm();

                DataGridViewRow MiDvgFila = DgvListaSucursal.SelectedRows[0];
                int IDsucursal = Convert.ToInt32(MiDvgFila.Cells["ColSucursalID"].Value);

                MiSucursalLocal = new Logica.Models.Sucursales();
                MiSucursalLocal = MiSucursalLocal.ConsultarPorID(IDsucursal);

                if (MiSucursalLocal != null && MiSucursalLocal.SucursalID > 0)
                {
                    TxtSucursalCodigo.Text = MiSucursalLocal.SucursalID.ToString();
                    TxtSucursalNombre.Text = MiSucursalLocal.Nombre;
                    TxtSucursalDescripcion.Text = MiSucursalLocal.Descripcion;


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

        private void DgvListaSucursal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaSucursal.ClearSelection();
        }

        private void DgvListaSucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {
                MiSucursalLocal.Nombre = TxtSucursalNombre.Text.Trim();
                MiSucursalLocal.Descripcion = TxtSucursalDescripcion.Text.Trim();

                if (MiSucursalLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea modificar la Sucursal", "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiSucursalLocal.Actualizar())
                        {
                            MessageBox.Show("Sucursal actualizada correctamente", "Actualizada", MessageBoxButtons.OK);

                            LimpiarForm();

                            CargarListaSucursal();

                            ActivarBotonAgregar();


                        }
                    }
                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiSucursalLocal.SucursalID > 0)
            {

                string Msg = string.Format("¿Esta seguro de eliminar la sucursal {0}?", MiSucursalLocal.Nombre);
                DialogResult respuresta = MessageBox.Show(Msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuresta == DialogResult.Yes && MiSucursalLocal.Eliminar())
                {
                    MessageBox.Show("La sucursal ha sido eliminada", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaSucursal();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtSucursalNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtSucursalDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaSucursal(TxtBuscar.Text.Trim());
            }
            CargarListaSucursal(TxtBuscar.Text.Trim());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
