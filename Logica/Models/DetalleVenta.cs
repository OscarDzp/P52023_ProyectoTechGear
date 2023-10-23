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
            MiDetalleVenta = new DetalleVenta();
        }
        public int DetalleVentaID { get; set; }
        public string Subtotal { get; set; }
        public string PrecioUnitario { get; set; }
        public string Cantidad { get; set; }
        public Productos MiProducto { get; set; }
        public DetalleVenta MiDetalleVenta { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@DetalleVentaID", this.DetalleVentaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Subtotal", this.Subtotal));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PrecioUnitario", this.PrecioUnitario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", this.MiProducto.ProductoID));
           

            int resultado = MiCnn.EjecutarDML("SPFacturasAgregar");

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
            return R;
        }
        public bool ConsultarPorID(int pID )
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", pID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPDetalleVentasConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;


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
