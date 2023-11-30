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
    public partial class FrmProductoGestion : Form
    {
        private Logica.Models.Productos MiProductoLocal { get; set; }

        public FrmProductoGestion()
        {
            InitializeComponent();
            MiProductoLocal = new Logica.Models.Productos();    
        }

        private void FrmProductoGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaProducto();
            CargarListaMarcas();
            CargarListaModelos();
            CargarListaCategorias();
            CargarListaProveedor();
            ActivarBotonAgregar();
        }

        private void CargarListaProducto(string FiltroBusqueda = "") 
        {
            Logica.Models.Productos MiProducto = new Logica.Models.Productos();

            DataTable lista = new DataTable();

            lista = MiProducto.Listar(FiltroBusqueda);

            DgvListaProductos.DataSource = lista;

        }


        private void CargarListaMarcas()
        {
            Logica.Models.Marcas MiMarca = new Logica.Models.Marcas();

            DataTable dtMarcas = new DataTable();

            dtMarcas = MiMarca.Listar();

            if (dtMarcas != null && dtMarcas.Rows.Count > 0)
            {
                CboxProductosMarca.ValueMember = "MarcaID";
                CboxProductosMarca.DisplayMember = "Nombre";

                CboxProductosMarca.DataSource = dtMarcas;
                CboxProductosMarca.SelectedIndex = -1;
            }
        }

        private void CargarListaModelos ()
        {
            Logica.Models.Modelos MiModelo = new Logica.Models.Modelos();

            DataTable dtModelos = new DataTable();

            dtModelos = MiModelo.Listar();

            if (dtModelos != null && dtModelos.Rows.Count > 0)
            {
                CboxProductosModelo.ValueMember = "ModeloID";
                CboxProductosModelo.DisplayMember = "Nombre";

                CboxProductosModelo.DataSource = dtModelos;
                CboxProductosModelo.SelectedIndex = -1;
            }
        }

        private void CargarListaCategorias()
        {
            Logica.Models.Categorias MiCategoria = new Logica.Models.Categorias();

            DataTable dtCategorias = new DataTable();

            dtCategorias = MiCategoria.Listar();

            if (dtCategorias != null && dtCategorias.Rows.Count > 0)
            {
                CboxProductosCategoria.ValueMember = "CategoriaID";
                CboxProductosCategoria.DisplayMember = "Nombre";

                CboxProductosCategoria.DataSource = dtCategorias;
                CboxProductosCategoria.SelectedIndex = -1;
            }
        }


        private void CargarListaProveedor()
        {
            Logica.Models.Proveedores MiProveedor = new Logica.Models.Proveedores();

            DataTable dtProveedor = new DataTable();

            dtProveedor = MiProveedor.Listar();

            if (dtProveedor != null && dtProveedor.Rows.Count > 0)
            {
                CboxProductosProveedor.ValueMember = "ProveedorID";
                CboxProductosProveedor.DisplayMember = "Nombre";

                CboxProductosProveedor.DataSource = dtProveedor;
                CboxProductosProveedor.SelectedIndex = -1;
            }
        }
        private bool ValidarValorRequerido()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxtProductoNombre.Text.Trim())&&
                !string.IsNullOrEmpty(TxtProductoDescripcion.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoPrecio.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProductoStockActual.Text.Trim()) &&
                CboxProductosCategoria.SelectedIndex > -1 &&
                CboxProductosMarca.SelectedIndex > -1 &&
                CboxProductosModelo.SelectedIndex > -1 &&
                 CboxProductosProveedor.SelectedIndex > -1
                )
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxtProductoNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un nombre al producto");
                    return false;
                }
                if (CboxProductosCategoria.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir una categoria", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoStockActual.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un stock");
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoPrecio.Text.Trim()))
                {
                    MessageBox.Show("Se debe asignar un precio");
                    return false;
                }
                if (CboxProductosMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir una marca", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxProductosModelo.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir un modelo", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (CboxProductosProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe elegir un proveedor", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
                if (string.IsNullOrEmpty(TxtProductoDescripcion.Text.Trim()))
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

                MiProductoLocal = new Logica.Models.Productos();


                MiProductoLocal.Nombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.MiCategoriaID.CategoriaID = Convert.ToInt32(CboxProductosCategoria.SelectedValue);
                MiProductoLocal.StockActual = int.Parse(TxtProductoStockActual.Text.Trim());
                MiProductoLocal.Precio = decimal.TryParse(TxtProductoPrecio.Text.Trim(), out decimal precio) ? precio : 0;
                MiProductoLocal.MiMarcaID.MarcaID = Convert.ToInt32(CboxProductosMarca.SelectedValue);
                MiProductoLocal.MiModeloID.ModeloID = Convert.ToInt32(CboxProductosModelo.SelectedValue);
                MiProductoLocal.MiProveedorID.ProveedorID = Convert.ToInt32(CboxProductosProveedor.SelectedValue);
                MiProductoLocal.Descripcion = TxtProductoDescripcion.Text.Trim();
                bool IDValido = MiProductoLocal.ConsultarPorID();

                bool NombreValido = MiProductoLocal.ConsultarPorNombre(MiProductoLocal.Nombre);
                if (IDValido == false  && NombreValido == false)
                {
                    string Pregunta = string.Format("Esta seguro de agregar el producto {0}?", MiProductoLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)

                    {
                        bool ok = MiProductoLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Producto agregada correctamente", "Agregado", MessageBoxButtons.OK);
                          
                        }
                        else
                        {
                            MessageBox.Show("El producto no se ha añadido", "Cancelado", MessageBoxButtons.OK);
                        }
                
                    }
                    LimpiarForm();
                    CargarListaProducto();
                    CargarListaMarcas();
                    CargarListaModelos();
                    CargarListaCategorias();
                    ActivarBotonAgregar();
                }
            }


        }

        private void LimpiarForm()
        {
            TxtProductoCodigo.Clear();
            TxtProductoNombre.Clear();
            TxtProductoStockActual.Clear();
            TxtProductoPrecio.Clear();
            TxtProductoDescripcion.Clear();
            CboxProductosCategoria.SelectedIndex = -1;
            CboxProductosMarca.SelectedIndex = -1;
            CboxProductosModelo.SelectedIndex = -1;
            CboxProductosProveedor.SelectedIndex = -1;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void DgvListaModelos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaProductos.SelectedRows.Count == 1)
            {
                LimpiarForm();

                DataGridViewRow MiDvgFila = DgvListaProductos.SelectedRows[0];
                int IDproducto = Convert.ToInt32(MiDvgFila.Cells["ColProductoID"].Value);

                MiProductoLocal = new Logica.Models.Productos();
                MiProductoLocal = MiProductoLocal.ConsultarPorID(IDproducto);

                if (MiProductoLocal != null && MiProductoLocal.ProductoID > 0)
                {
                    TxtProductoCodigo.Text = MiProductoLocal.ProductoID.ToString();
                    TxtProductoNombre.Text = MiProductoLocal.Nombre;
                    CboxProductosCategoria.SelectedValue = MiProductoLocal.MiCategoriaID.CategoriaID;
                    TxtProductoStockActual.Text = MiProductoLocal.StockActual.ToString();
                    TxtProductoPrecio.Text = MiProductoLocal.Precio.ToString();//TODO
                    CboxProductosMarca.SelectedValue = MiProductoLocal.MiMarcaID.MarcaID;
                    CboxProductosModelo.SelectedValue = MiProductoLocal.MiModeloID.ModeloID;
                    CboxProductosProveedor.SelectedValue = MiProductoLocal.MiProveedorID.ProveedorID;
                    TxtProductoDescripcion.Text = MiProductoLocal.Descripcion;


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

        private void DgvListaProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaProductos.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarValorRequerido())
            {
                MiProductoLocal.Nombre = TxtProductoNombre.Text.Trim();
                MiProductoLocal.MiCategoriaID.CategoriaID = Convert.ToInt32(CboxProductosCategoria.SelectedValue);
                MiProductoLocal.StockActual = int.Parse(TxtProductoStockActual.Text.Trim());
                MiProductoLocal.Precio = decimal.TryParse(TxtProductoPrecio.Text.Trim(), out decimal precio) ? precio : 0;
                MiProductoLocal.MiMarcaID.MarcaID = Convert.ToInt32(CboxProductosMarca.SelectedValue);
                MiProductoLocal.MiModeloID.ModeloID = Convert.ToInt32(CboxProductosModelo.SelectedValue);
                MiProductoLocal.MiProveedorID.ProveedorID = Convert.ToInt32(CboxProductosProveedor.SelectedValue);
                MiProductoLocal.Descripcion = TxtProductoDescripcion.Text.Trim();

                if (MiProductoLocal.ConsultarPorID())
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea modificar este prodcuto?", "Confirmación", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        if (MiProductoLocal.Actualizar())
                        {
                            MessageBox.Show("Producto actualizado correctamente", "Actualizada", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaProducto();
                            CargarListaProveedor();
                            CargarListaMarcas();
                            ActivarBotonAgregar();



                        }

                    

                    }
           
                }

            }
         
        }

        private void BtnEliminar_Click(object sender, EventArgs e)

        {
            if (MiProductoLocal.ProductoID > 0)
            {

                string Msg = string.Format("¿Esta seguro de eliminar el producto {0}?", MiProductoLocal.Nombre);
                DialogResult respuresta = MessageBox.Show(Msg, "Confirmacion Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuresta == DialogResult.Yes && MiProductoLocal.Eliminar())
                {
                    MessageBox.Show("El producto ha sido eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarForm();
                    CargarListaCategorias();
                    CargarListaMarcas();
                    CargarListaModelos();
                    CargarListaProducto();
                    CargarListaProveedor();
                    ActivarBotonAgregar();
                }
            }
        }

        private void TxtProductoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void CboxProductosCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtProductoStockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void TxtProductoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresNumeros(e);
        }

        private void CboxProductosMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CboxProductosModelo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtProductoDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Tools.Validaciones.CaracteresTexto(e);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                CargarListaProducto(TxtBuscar.Text.Trim());
            }
            CargarListaProducto(TxtBuscar.Text.Trim());
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
