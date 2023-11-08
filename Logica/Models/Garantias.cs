using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Garantias
    {
        public Garantias()
        {
            MiProducto = new Productos();
        }
        public int GarantiaID { get; set; }
        public string Tiempogarantia { get; set; } // Es una fecha
        public DateTime Fechainicio { get; set; } // Es una fecha
        public DateTime Fechafinalizacion { get; set; } // Es una fecha
        public string Detalle { get; set; }
        public Productos MiProducto { get; set; }

     

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TiempoGarantia", this.Tiempogarantia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaInicio", this.Fechainicio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaFinalizacion", this.Fechafinalizacion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Detalle", this.Detalle));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", this.MiProducto.ProductoID));

            int resultado = MiCnn.EjecutarDML("SPGarantiasAgregar");

            if (resultado > 0) R = true;

            return R;
        }
    
        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.GarantiaID));

            int resultado = MiCnn.EjecutarDML("SPGarantiasEliminar");
            if (resultado > 0) R = true;
            return R;
        }
        public bool Actualizar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TiempoGarantia", this.Tiempogarantia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaInicio", this.Fechainicio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaFinalizacion", this.Fechafinalizacion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Detalle", this.Detalle));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", this.MiProducto.ProductoID));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.GarantiaID));
            int resultado = MiCnn.EjecutarDML("SPGarantiasActualizar");

            if (resultado > 0) R = true;
            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.GarantiaID));
            DataTable DatosGarantia = new DataTable();
            DatosGarantia = MyCnn.EjecutarSelect("SPGarantiaConsultarPorID");
            if (DatosGarantia != null && DatosGarantia.Rows.Count > 0)
            {
                R = true;
            }

            return R;

        }

        public Garantias ConsultarPorID(int IdGarantia)
        { 
            Garantias R = new Garantias();

            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID",IdGarantia));
            DataTable DatosGarantia = new DataTable();
            DatosGarantia = MyCnn.EjecutarSelect("SPGarantiaConsultarPorID");
            if (DatosGarantia != null && DatosGarantia.Rows.Count > 0) 
            {
                DataRow MiFila = DatosGarantia.Rows[0];
                R.GarantiaID = Convert.ToInt32(MiFila["GarantiaID"]);
                R.Tiempogarantia = Convert.ToString(MiFila["Tiempogarantia"]);
                R.Fechainicio = Convert.ToDateTime(MiFila["Fechainicio"]);
                R.Fechafinalizacion = Convert.ToDateTime(MiFila["Fechafinalizacion"]);
                R.Detalle = Convert.ToString(MiFila["Detalle"]);
             
                R.MiProducto.ProductoID = Convert.ToInt32(MiFila["ProductoID"]);
                R.MiProducto.Nombre = Convert.ToString(MiFila["Nombre"]);

            }

            return R;
        }

            public bool ConsultarPorTiempoGarantia(String pTiempoGarantia)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TiempoGarantia", pTiempoGarantia));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPGarantiaConsultarPorTiempoGarantia");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;
        }

        public DataTable Listar(string pFiltro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));
            R = MiCnn.EjecutarSelect("SPGarantiaListar");

            return R;
        }
    }
}
