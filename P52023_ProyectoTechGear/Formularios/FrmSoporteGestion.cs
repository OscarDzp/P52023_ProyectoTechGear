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
    public partial class FrmSoporteGestion : Form
    {
        private Logica.Models.SoporteTecnico MiSoporteLocal { get; set; }

        public FrmSoporteGestion()
        {
            InitializeComponent();
            MiSoporteLocal = new Logica.Models.SoporteTecnico();
            
        }

        private void FrmSoporteGestion_Load_1(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaSoporteTecnico();
            CargarListaSoporteGarantia();
        }

        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtSoporteNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSoporteCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSoporteEspecialidad.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtSoporteDisponibilidad.Text.Trim()) &&
                  CboxSoporteGarantia.SelectedIndex > -1 )
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtSoporteNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nombre al tecnico ");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteDisponibilidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un horario de disponibilidad", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteCorreo.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un correo electrónico");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteEspecialidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar una especialidad");
                    return false;
                }
                if (CboxSoporteGarantia.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir una garantia a trabajar", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }

        private void CargarListaSoporteGarantia()
        {
            Logica.Models.Garantias MiGarantia = new Logica.Models.Garantias();

            DataTable dtSoporteGarantia = new DataTable();

            dtSoporteGarantia = MiGarantia.Listar();

            if (dtSoporteGarantia != null && dtSoporteGarantia.Rows.Count > 0)
            {
                CboxSoporteGarantia.ValueMember = "GarantiaID";
                CboxSoporteGarantia.DisplayMember = "Detalle";

                CboxSoporteGarantia.DataSource = dtSoporteGarantia;
                CboxSoporteGarantia.SelectedIndex = -1;
            }
        }

        private bool ValidarDatos()

        //validation of minimun values required
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtSoporteNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSoporteCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSoporteEspecialidad.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtSoporteDisponibilidad.Text.Trim()) &&
                CboxSoporteGarantia.SelectedIndex > -1
                )
            {
                R = true;

            }
            else
            {
                //validacion faltante
                if (string.IsNullOrEmpty(TxtSoporteNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar el SubTotal", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteCorreo.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar el Precio Unitario", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteEspecialidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar la Cantidad", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtSoporteDisponibilidad.Text.Trim()))
                {
                    MessageBox.Show("Se debe digitar la Cantidad", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxSoporteGarantia.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir el Producto", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {

                MiSoporteLocal = new Logica.Models.SoporteTecnico();


                MiSoporteLocal.Nombre = TxtSoporteNombre.Text.Trim();
                MiSoporteLocal.Correo = TxtSoporteCorreo.Text.Trim();
                MiSoporteLocal.Especialidad = TxtSoporteEspecialidad.Text.Trim();
                MiSoporteLocal.Disponibilidad = TxtSoporteEspecialidad.Text.Trim();
                MiSoporteLocal.MiGarantia.GarantiaID = Convert.ToInt32(CboxSoporteGarantia.SelectedValue);

                bool CantidadValida = MiSoporteLocal.ConsultarPorCorreo(MiSoporteLocal.Correo);

                if (CantidadValida == false)
                {
                    //Confirmacion

                    string Pregunta = string.Format("¿Está seguro que quiere agregar el detalle de venta {0}?", MiSoporteLocal.Nombre);
                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiSoporteLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Detalle de venta agregado correctamente!", "Detalle de venta agregado", MessageBoxButtons.OK);



                        }
                        else
                        {
                            MessageBox.Show("El detalle de venta no pudo ser agregado...", "Detalle de venta no agregado", MessageBoxButtons.OK);

                        }
                    }
                    LimpiarForm();
                    CargarListaSoporteTecnico();
                }

            }

        }

        private void LimpiarForm()
        {
            TxtSoporteNombre.Clear();
            TxtSoporteCorreo.Clear();
            TxtSoporteEspecialidad.Clear();
            TxtSoporteDisponibilidad.Clear();
            CboxSoporteGarantia.SelectedIndex = -1;
        }

        

        private void CargarListaSoporteTecnico(string FiltroBusqueda = "") 
        {
            Logica.Models.SoporteTecnico MiTecnico = new Logica.Models.SoporteTecnico();
            DataTable lista = new DataTable();
            lista = MiTecnico.Listar(FiltroBusqueda);
            DgvListaSoporteTecnico.DataSource = lista;

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {

                MiSoporteLocal = new Logica.Models.SoporteTecnico();


                MiSoporteLocal.Nombre = TxtSoporteNombre.Text.Trim();
                MiSoporteLocal.Correo = TxtSoporteCorreo.Text.Trim();
                MiSoporteLocal.Especialidad = TxtSoporteEspecialidad.Text.Trim();
                MiSoporteLocal.Disponibilidad = TxtSoporteDisponibilidad.Text.Trim();
                MiSoporteLocal.MiGarantia.GarantiaID = Convert.ToInt32(CboxSoporteGarantia.SelectedValue);

                bool CorreoValido = MiSoporteLocal.ConsultarPorCorreo(MiSoporteLocal.Correo);

                if (CorreoValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar al técnico {0}?", MiSoporteLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiSoporteLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Técnico agregado correctamente", "Agregado", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("El técnico no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }

                    }
                    LimpiarForm();
                    CargarListaSoporteTecnico();
                }
            }

        }

        private void DgvListaSoporteTecnico_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvListaSoporteTecnico.SelectedRows.Count == 1)
            {
                LimpiarForm();
                DataGridViewRow MiDgvFila = DgvListaSoporteTecnico.SelectedRows[0];
                int IdTecnico = Convert.ToInt32(MiDgvFila.Cells["ColTecnicoID"].Value);
                MiSoporteLocal = new Logica.Models.SoporteTecnico();
                MiSoporteLocal = MiSoporteLocal.ConsultarPorID(IdTecnico);
                if (MiSoporteLocal != null && MiSoporteLocal.TecnicoID > 0)
                {
                    TxtSoporteCodigo.Text = MiSoporteLocal.TecnicoID.ToString();
                    TxtSoporteNombre.Text = MiSoporteLocal.Nombre;
                    TxtSoporteCorreo.Text = MiSoporteLocal.Correo;
                    TxtSoporteEspecialidad.Text = MiSoporteLocal.Especialidad;
                    TxtSoporteDisponibilidad.Text = MiSoporteLocal.Disponibilidad;
                    CboxSoporteGarantia.SelectedValue = MiSoporteLocal.MiGarantia.GarantiaID;
                    ActivarBotonesModificarYEliminar();
                }


            }

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

        private void DgvListaSoporteTecnico_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaSoporteTecnico.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

                MiSoporteLocal.Nombre = TxtSoporteNombre.Text.Trim();
                MiSoporteLocal.Correo = TxtSoporteCorreo.Text.Trim();
                MiSoporteLocal.Especialidad = TxtSoporteEspecialidad.Text.Trim();
                MiSoporteLocal.Disponibilidad = TxtSoporteDisponibilidad.Text.Trim();
                MiSoporteLocal.MiGarantia.GarantiaID = Convert.ToInt32(CboxSoporteGarantia.SelectedValue);


                if (MiSoporteLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("Desea modificar la factura?", "???", MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        if (MiSoporteLocal.Actualizar())
                        {
                            MessageBox.Show("Factura modificado correctamenete!!", ":)", MessageBoxButtons.OK);
                            LimpiarForm();
                            CargarListaSoporteTecnico();
                            ActivarBotonAgregar();
                        }
                    }
                }          
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiSoporteLocal.TecnicoID > 0)
            {
                string msg = string.Format("Esta seguro de eliminar la Factura {0}?", MiSoporteLocal.Nombre);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes && MiSoporteLocal.Eliminar())
                {
                    MessageBox.Show("La Factura ha sido eliminado", "!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaSoporteTecnico();
                    ActivarBotonAgregar();
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaSoporteTecnico(TxtBuscar.Text.Trim());
            }
        }
    }
}
