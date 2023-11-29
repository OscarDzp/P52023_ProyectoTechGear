using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Sucursales
    {
   
        public int SucursalID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));

            int resultado = MiCnn.EjecutarDML("SPSucursalesAgregar");

            if (resultado > 0) R = true;


            return R;

        }
        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.SucursalID));

            int resultado = MiCnn.EjecutarDML("SPSucursalesEliminar");

            if (resultado > 0) R = true;

            return R;
        }
        public bool Actualizar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.SucursalID));

            int resultado = MiCnn.EjecutarDML("SPSucursalesActualizar");

            if (resultado > 0) R = true;

            return R;
        }
        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.SucursalID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPSucursalesConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;
        }

        public Sucursales ConsultarPorID (int pSucursalID)
        {
            Sucursales R = new Sucursales();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", pSucursalID));

            DataTable DatosSucursal = new DataTable();

            DatosSucursal = MiCnn.EjecutarSelect("SPSucursalesConsultarPorID");

            if (DatosSucursal != null && DatosSucursal.Rows.Count > 0)
            {

                DataRow MiFila = DatosSucursal.Rows[0];

                R.SucursalID = Convert.ToInt32(MiFila["SucursalID"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
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

            dt = MiCnn.EjecutarSelect("SPSucursalesConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }


        public DataTable Listar(string pFiltro = "")
        {

            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("SPSucursalListar");

            return R;
        }
    }
}