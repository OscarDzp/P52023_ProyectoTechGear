using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Productos
    {
        public Productos()
        {
            MiModeloID = new Modelos();
            MiMarcaID = new Marcas();
            MiCategoriaID = new Categorias();
            MiProveedorID = new Proveedores();
        }
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int StockActual { get; set; }//decimal 
        public decimal Precio { get; set; }//Decimal
        public Modelos MiModeloID { get; set; }
        public Marcas MiMarcaID { get; set; }
        public Categorias MiCategoriaID { get; set; }

        public Proveedores MiProveedorID { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CategoriaID", this.MiCategoriaID.CategoriaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@StockActual", this.StockActual));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Precio", this.Precio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@MarcaID", this.MiMarcaID.MarcaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ModeloID", this.MiModeloID.ModeloID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProveedorID", this.MiProveedorID.ProveedorID)); // Agregar este parámetro

            int resultado = MiCnn.EjecutarDML("SPProductosAgregar");


            if (resultado > 0) R = true;

            return R;

        }
        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            int resultado = MiCnn.EjecutarDML("SPProductosEliminar");

            if (resultado > 0) R = true;

            return R;
        }
        public bool Actualizar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CategoriaID", this.MiCategoriaID.CategoriaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@StockActual", this.StockActual));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Precio", this.Precio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@MarcaID", this.MiMarcaID.MarcaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ModeloID", this.MiModeloID.ModeloID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProveedorID", this.MiProveedorID.ProveedorID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));
            int resultado = MiCnn.EjecutarDML("SPProductosActualizar");

            if (resultado > 0) R = true;

            return R;
        }
        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProductoID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProductosConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;
            {

                return R;
            }
        }

        public Productos ConsultarPorID(int IDproducto)
        {
            Productos R = new Productos();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", IDproducto));

            DataTable DatosProducto = new DataTable();

            DatosProducto = MiCnn.EjecutarSelect("SPProductosConsultarPorID");

            if (DatosProducto != null && DatosProducto.Rows.Count > 0)

            {

                DataRow MiFila = DatosProducto.Rows[0];

                R.ProductoID = Convert.ToInt32(MiFila["ProductoID"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.MiCategoriaID.CategoriaID = Convert.ToInt32(MiFila["CategoriaID"]);
                R.StockActual = Convert.ToInt32(MiFila["StockActual"]);//TODO
                R.Precio = Convert.ToDecimal(MiFila["Precio"]);//TODO
                R.MiMarcaID.MarcaID = Convert.ToInt32(MiFila["MarcaID"]);
                R.MiModeloID.ModeloID = Convert.ToInt32(MiFila["ModeloID"]);
                R.MiProveedorID.ProveedorID = Convert.ToInt32(MiFila["ProveedorID"]);
                R.Descripcion = Convert.ToString(MiFila["Descripcion"]);

            }

            return R;
        }

        public bool ConsultarPorNombre(string pNombre)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", pNombre));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProductosConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }



        public DataTable Listar(string pFiltro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("SPProductosListar");

            return R;
        }
    }
}
