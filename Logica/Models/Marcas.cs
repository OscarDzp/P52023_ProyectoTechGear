using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Marcas
    {
      
        public int MarcaID { get; set; }
        public string PaisOrigen { get; set; }
        public string Nombre { get; set; }
        

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PaisOrigen", this.PaisOrigen));

            int resultado = MiCnn.EjecutarDML("SPMarcasAgregar");

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
        public bool ConsultarPorNombre(string pNombre)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", pNombre));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPMarcasConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPMarcasListar");

            return R;
        }
    }
}
