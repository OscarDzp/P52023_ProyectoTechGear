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

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.MarcaID));

            int resultado = MiCnn.EjecutarDML("SPMarcasEliminar");

            if (resultado > 0) R = true;

            return R;
        }
        public bool Actualizar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@PaisOrigen", this.PaisOrigen));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.MarcaID));

            int resultado = MiCnn.EjecutarDML("SPMarcasActualizar");

            if (resultado > 0) R = true;

            return R;
        }

        public bool ConsultarPorID( )
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.MarcaID));

            DataTable DatosMarca = new DataTable();

            DatosMarca = MiCnn.EjecutarSelect("SPMarcasConsultarPorID");

            if (DatosMarca != null && DatosMarca.Rows.Count > 0)
            {

                R = true;

            }



            return R;

        }

        public Marcas ConsultarPorID (int IdMarca)
        {
            Marcas R = new Marcas();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", IdMarca));

            DataTable DatosMarca = new DataTable();

            DatosMarca = MiCnn.EjecutarSelect("SPMarcasConsultarPorID");

            if (DatosMarca != null && DatosMarca.Rows.Count > 0)
            {

                DataRow MiFila = DatosMarca.Rows[0];

                R.MarcaID = Convert.ToInt32(MiFila["MarcaID"]);
                R.PaisOrigen = Convert.ToString(MiFila["PaisOrigen"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);

            }



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

        public DataTable Listar(string pFiltro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("SPMarcasListar");

            return R;
        }


    }
}
