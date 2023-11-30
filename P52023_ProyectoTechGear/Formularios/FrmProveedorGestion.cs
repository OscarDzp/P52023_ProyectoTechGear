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
    public partial class FrmProveedorGestion : Form
    {
        private Logica.Models.Proveedores MiProveedorLocal { get; set; }

        public FrmProveedorGestion()
        {
            InitializeComponent();
            MiProveedorLocal = new Logica.Models.Proveedores();
        }

        private void FrmProveedorGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaProveedor();
        }

        private void CargarListaProveedor(string FiltroBusqueda = "")
        {
            Logica.Models.Proveedores MiProveedorLocal = new Logica.Models.Proveedores();

            DataTable lista = new DataTable();

            lista = MiProveedorLocal.Listar(FiltroBusqueda);

            DgvListaProveedores.DataSource = lista;
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorContacto.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorCorreoElectronico.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nombre al proveedor");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProveedorContacto.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un Contacto");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProveedorTelefono.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un número telefónico");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProveedorCorreoElectronico.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un correo electrónico");
                    return false;
                }
            }

            return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiProveedorLocal = new Logica.Models.Proveedores();

                MiProveedorLocal.Nombre = TxtProveedorNombre.Text.Trim();
                MiProveedorLocal.Contacto = TxtProveedorContacto.Text.Trim();
                MiProveedorLocal.Telefono = TxtProveedorTelefono.Text.Trim();
                MiProveedorLocal.CorreoElectronico = TxtProveedorCorreoElectronico.Text.Trim();

                bool CedulaValida = MiProveedorLocal.ConsultarPorNombre(MiProveedorLocal.Contacto);
                bool CorreoValido = MiProveedorLocal.ConsultarPorCorreo(MiProveedorLocal.CorreoElectronico);

                if (CedulaValida == false && CorreoValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar el proveedor {0}?", MiProveedorLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiProveedorLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Proveedor agregado correctamente", "Agregado", MessageBoxButtons.OK);


                        }
                        else
                        {
                            MessageBox.Show("El proveedor  no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }

                        CargarListaProveedor();
                        LimpiarForm();
                    }
                }
            }


        }

        private void LimpiarForm()
        {
            TxtProveedorNombre.Clear();
            TxtProveedorContacto.Clear();
            TxtProveedorTelefono.Clear();
            TxtProveedorCorreoElectronico.Clear();
        }

        private void DgvListaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaProveedores.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaProveedores.SelectedRows[0];
                int IDProveedor = Convert.ToInt32(MiDgvFila.Cells["ColProveedorID"].Value);
                MiProveedorLocal = new Logica.Models.Proveedores();
                MiProveedorLocal = MiProveedorLocal.ConsultarPorID(IDProveedor);
                if (MiProveedorLocal != null && MiProveedorLocal.ProveedorID > 0)
                {
                    TxtProveedorCodigo.Text = MiProveedorLocal.ProveedorID.ToString();
                    TxtProveedorNombre.Text = MiProveedorLocal.Nombre;
                    TxtProveedorContacto.Text = MiProveedorLocal.Contacto;
                    TxtProveedorTelefono.Text = MiProveedorLocal.Telefono;
                    TxtProveedorCorreoElectronico.Text = MiProveedorLocal.CorreoElectronico;


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

        private void DgvListaProveedores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaProveedores.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            MiProveedorLocal.Nombre = TxtProveedorNombre.Text.Trim();
            MiProveedorLocal.Contacto = TxtProveedorContacto.Text.Trim();
            MiProveedorLocal.Telefono = TxtProveedorTelefono.Text.Trim();
            MiProveedorLocal.CorreoElectronico = TxtProveedorCorreoElectronico.Text.Trim();


            if (MiProveedorLocal.ConsultarPorID())
            {
                DialogResult Resp = MessageBox.Show("Desea modificar el Proveedor?", "???", MessageBoxButtons.YesNo);
                if (Resp == DialogResult.Yes)
                {
                    if (MiProveedorLocal.Actualizar())
                    {
                        MessageBox.Show("Empleado modificado correctamenete!!", ":)", MessageBoxButtons.OK);
                        LimpiarForm();
                        CargarListaProveedor();
                        ActivarBotonAgregar();
                    }

                }

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiProveedorLocal.ProveedorID > 0)
            {
                string msg = string.Format("Esta seguro de eliminar al proveedor {0}?", MiProveedorLocal.Nombre);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes && MiProveedorLocal.Eliminar())
                {
                    MessageBox.Show("El proveedor ha sido eliminado", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaProveedor();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtProveedorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtProveedorContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtProveedorTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtProveedorCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e, false, true);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
                {
                    CargarListaProveedor(TxtBuscar.Text.Trim());
                }
                CargarListaProveedor(TxtBuscar.Text.Trim());
            }
        }
    }
}





    