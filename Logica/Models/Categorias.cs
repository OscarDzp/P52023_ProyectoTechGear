using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Categorias
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }

     

        //Listar para Categorias
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

            int resultado = MiCnn.EjecutarDML("SPCategoriasAgregar");

            if (resultado > 0) R = true;


            return R;
        }
        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CategoriaID));
            int resultado = MiCnn.EjecutarDML("SPCategoriasEliminar");
            if (resultado > 0) R = true;
            return R;
        }
        public bool Actualizar()
        {

            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CategoriaID));
            int resultado = MiCnn.EjecutarDML("SPCategoriasActualizar");

            if (resultado > 0) R = true;

            return R;

        }
        public bool ConsultarPorNombre(string pNombre)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", pNombre));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPCategoriasConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.CategoriaID));
            DataTable DatosCategoria = new DataTable();
            DatosCategoria = MyCnn.EjecutarSelect("SPCategoriasConsultarPorID");
            if (DatosCategoria != null && DatosCategoria.Rows.Count > 0)
            {
                
                R = true;
            }

            return R;
        }

        public Categorias ConsultarPorID(int IdCategoria)
        {
            Categorias R = new Categorias();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", IdCategoria));
            DataTable DatosCategoria = new DataTable();
            DatosCategoria = MyCnn.EjecutarSelect("SPCategoriasConsultarPorID");
            if (DatosCategoria != null && DatosCategoria.Rows.Count > 0)
            {
                DataRow MiFila = DatosCategoria.Rows[0];

                R.CategoriaID = Convert.ToInt32(MiFila["CategoriaID"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
             
            }
            return R;

        }

        public DataTable Listar(string pFiltro = "")
        {
            DataTable R = new DataTable();
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));
            R = MiCnn.EjecutarSelect("SPCategoriasListar");
            return R;
        }
    }

}
