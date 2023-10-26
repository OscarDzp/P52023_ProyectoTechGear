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
    
        public bool Eliminar() //Todavia no
        {
            bool R = false;
            return R;
        }
        public bool Actualizar()//Todavia no
        {
            bool R = false;
            return R;
        }

        public bool ConsultarPorID(int pGarantiaID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@GarantiaID", pGarantiaID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPGarantiaConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPGarantiaListar");

            return R;
        }
    }
}
