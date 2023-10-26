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
    public partial class FrmClienteGestion : Form
    {

        private Logica.Models.Clientes MiClienteLocal { get; set; }

        public FrmClienteGestion()
        {
            InitializeComponent();

            MiClienteLocal = new Logica.Models.Clientes();
        }

        private void FrmClienteGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaClientes();
        }

        private void CargarListaClientes() 
        {
            Logica.Models.Clientes MiCliente = new Logica.Models.Clientes();
            DataTable lista = new DataTable();
            lista = MiCliente.Listar();
            DgvListaClientes.DataSource = lista;

        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtClienteNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtClienteCorreoElectronico.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtClienteDireccion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtClienteCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtClienteTelefono.Text.Trim()))
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtClienteNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe ingresar un nombre al cliente");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtClienteCorreoElectronico.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un correo electrónico");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtClienteCedula.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un número de cédula");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtClienteDireccion.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una direción");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtClienteTelefono.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un número telefónico");
                    return false;
                }
            }

            return R;

        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiClienteLocal = new Logica.Models.Clientes();


                MiClienteLocal.Nombre = TxtClienteNombre.Text.Trim();
                MiClienteLocal.CorreoElectronico = TxtClienteCorreoElectronico.Text.Trim();
                MiClienteLocal.Direccion = TxtClienteDireccion.Text.Trim();
                MiClienteLocal.Telefono = TxtClienteTelefono.Text.Trim();
                MiClienteLocal.Cedula = int.Parse(TxtClienteCedula.Text.Trim());

                bool CedulaValida = MiClienteLocal.ConsultarPorCedula(MiClienteLocal.Cedula);

                bool CorreoElectronicoValido = MiClienteLocal.ConsultarPorCorreo(MiClienteLocal.CorreoElectronico);

                if (CedulaValida == false && CorreoElectronicoValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar el cliente {0}?", MiClienteLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiClienteLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("El Cliente agregado correctamente", "Agregado", MessageBoxButtons.OK);
                         
                        }
                        else
                        {
                            MessageBox.Show("El Cliente no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                        Limpiarform();
                        CargarListaClientes();
                    }
                }
            }


        }

        private void Limpiarform()
        {
            TxtClienteNombre.Clear();
            TxtClienteCorreoElectronico.Clear();
            TxtClienteDireccion.Clear();
            TxtClienteTelefono.Clear();
            TxtClienteCedula.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
