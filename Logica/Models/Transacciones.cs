using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Transacciones
    {
        public Transacciones()
        {
            MiFactura = new Facturas();
      
        }

        public int TransaccionID { get; set; }
        public DateTime FechaTransaccion { get; set; } 
        public string Cantidad { get; set; }
        public string TipoTransaccion { get; set; }
        public int FacturaID { get; set; }

        public Facturas MiFactura { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaTransaccion", this.FechaTransaccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoTransaccion", this.TipoTransaccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FacturaID", this.MiFactura.FacturaID));


            int resultado = MiCnn.EjecutarDML("SPTransaccionesAgregar");

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

        public bool ConsultarPorID(int pTransaccionID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TransaccionID", pTransaccionID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPTransaccionesConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPTransaccionesListar");

            return R;
        }
    }
}