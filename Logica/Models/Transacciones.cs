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
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaTransaccion", this.FechaTransaccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cantidad", this.Cantidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoTransaccion", this.TipoTransaccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FacturaID", this.MiFactura.FacturaID));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.TransaccionID));
            int resultado = MiCnn.EjecutarDML("SPTransaccionesActualizar");

            if (resultado > 0) R = true;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.TransaccionID));
            DataTable DatosTransacciones = new DataTable();
            DatosTransacciones = MyCnn.EjecutarSelect("SPTransaccionesConsultarPorID");
            if (DatosTransacciones != null && DatosTransacciones.Rows.Count > 0)
            {

                R = true;
            }

            return R;

        }

        public Transacciones ConsultarPorID(int IdTransaccion) 
        {
            Transacciones R = new Transacciones();
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", IdTransaccion));
            DataTable DatosTransacciones = new DataTable();
            DatosTransacciones = MyCnn.EjecutarSelect("SPTransaccionesConsultarPorID");
            if (DatosTransacciones != null && DatosTransacciones.Rows.Count > 0)
            {
                DataRow MiFila = DatosTransacciones.Rows[0];
                R.TransaccionID = Convert.ToInt32(MiFila["TransaccionID"]);
                R.FechaTransaccion = Convert.ToDateTime(MiFila["FechaTransaccion"]);
                R.Cantidad = Convert.ToString(MiFila["Cantidad"]);
                R.TipoTransaccion = Convert.ToString(MiFila["TipoTransaccion"]);
                R.MiFactura.FacturaID = Convert.ToInt32(MiFila["FacturaID"]);

            }

            return R;
        }

        public bool ConsultarPorTipoTransaccion(String pTipoTransaccion)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TipoTransaccion", pTipoTransaccion));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPTransaccionesConsultarPorTipoTransaccion");

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