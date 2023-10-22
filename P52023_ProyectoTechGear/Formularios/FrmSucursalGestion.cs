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
                    MessageBox.Show("Se debe asignar una descripcion");
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
                bool IDValido = MiSucursalLocal.ConsultarPorID(MiSucursalLocal.SucursalID);

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
                    }
                }
            }


        }

        private void LimpiarForm()
        {
            TxtSucursalNombre.Clear();
            TxtSucursalDescripcion.Clear();
        }

    }
}
