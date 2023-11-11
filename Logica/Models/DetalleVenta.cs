using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class DetalleVenta
    {
        public DetalleVenta()
        {
            MiProducto = new Productos();
        }
        public int DetalleVentaID { get; set; }
        public int Subtotal { get; set; }
        public int PrecioUnitario { get; set; }
        public decimal Cantidad { get; set; }
        public Productos MiProducto { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

     
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Subtotal", this.Subtotal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", this.MiProducto.ProductoID));
           

            int resultado = MiCnn.EjecutarDML("SPDetalleVentasAgregar");

            if (resultado > 0) R = true;

            return R;
        }
        public bool Eliminar()
        {
            bool R = false;
            return R;
        }
        public bool Actualizar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Subtotal", this.Subtotal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", this.MiProducto.ProductoID));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.DetalleVentaID));
            int resultado = MiCnn.EjecutarDML("SPDetalleVentaActualizar");

            if (resultado > 0) R = true;
            return R;
        }

        public bool ConsultarPorCantidad(string pCantidad)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cantidad", pCantidad));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPDetalleVentaPorCantidad");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.DetalleVentaID));
            DataTable DatosDetalleVenta = new DataTable();
            DatosDetalleVenta = MyCnn.EjecutarSelect("SPDetalleVentasConsultarPorID");
            if (DatosDetalleVenta != null && DatosDetalleVenta.Rows.Count > 0)
            {

                R = true;
            }

            return R;

        }

        public DetalleVenta ConsultarPorID(int IdDetalleVenta)
        {
            DetalleVenta R = new DetalleVenta();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", IdDetalleVenta));
            DataTable DatosDetalleVenta = new DataTable();
            DatosDetalleVenta = MyCnn.EjecutarSelect("SPDetalleVentasConsultarPorID");
            if (DatosDetalleVenta != null && DatosDetalleVenta.Rows.Count > 0)
            {

                DataRow MiFila = DatosDetalleVenta.Rows[0];
                R.DetalleVentaID = Convert.ToInt32(MiFila["DetalleVentaID"]);
                R.Subtotal = Convert.ToInt32(MiFila["Subtotal"]);
                R.PrecioUnitario = Convert.ToInt32(MiFila["PrecioUnitario"]);
                R.Cantidad = Convert.ToInt32(MiFila["Cantidad"]);
                R.MiProducto.ProductoID = Convert.ToInt32(MiFila["ProductoID"]);

            }

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();


            R = MiCnn.EjecutarSelect("SPDetalleVentaListar");

            return R;
        }
    }
}
