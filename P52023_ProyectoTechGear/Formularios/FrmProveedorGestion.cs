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

        private void CargarListaProveedor() 
        {
            Logica.Models.Proveedores MiProveedor = new Logica.Models.Proveedores();
            DataTable lista = new DataTable();
            lista = MiProveedor.Listar();
            DgvListaProveedores.DataSource = lista;

        }
        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim())&&
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
                    MessageBox.Show("Se debe asignar un cédula");
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

                if (CedulaValida == false && CorreoValido ==  false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar el proveedor {0}?", MiProveedorLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiProveedorLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Proveedor agregadO correctamente", "Agregado", MessageBoxButtons.OK);
                          
 
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

    }
}
