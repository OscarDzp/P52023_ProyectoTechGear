using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class EmpleadoRol
    {

        public int EmpleadoRolID { get; set; }

        public string Rol { get; set; }





        public DataTable Listar(string pFiltro = "")
        {

            DataTable R = new DataTable();

            //hay que hacer instancia de la clase conexion

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("SPEmpleadoRolListar");

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.EmpleadoRolID));

            int resultado = MiCnn.EjecutarDML("SPEmpleadoRolEliminar");
            if (resultado > 0) R = true;
            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.EmpleadoRolID));
            DataTable DatosEmpleadoRol = new DataTable();
            DatosEmpleadoRol = MyCnn.EjecutarSelect("SPEmpleadoRolesConsultarPorID");
            if (DatosEmpleadoRol != null && DatosEmpleadoRol.Rows.Count > 0)
            {              
                R = true;
            }

            return R;
        }

        public EmpleadoRol ConsultarPorID(int IdEmpleadoRol)
        {
            EmpleadoRol R = new EmpleadoRol();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", IdEmpleadoRol));
            DataTable DatosEmpleadoRol = new DataTable();
            DatosEmpleadoRol = MyCnn.EjecutarSelect("SPEmpleadoRolesConsultarPorID");

            if (DatosEmpleadoRol != null && DatosEmpleadoRol.Rows.Count > 0)
            {
                DataRow MiFila = DatosEmpleadoRol.Rows[0];

                R.EmpleadoRolID = Convert.ToInt32(MiFila["EmpleadoRolID"]);
                R.Rol = Convert.ToString(MiFila["Rol"]);

            }
            return R;

        }

        //Esto es obligatorio

        public bool ConsultarPorRol(string pRol)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Rol", pRol));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPEmpleadoRolesConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public bool Actualizar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Rol", this.Rol));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.EmpleadoRolID));
            int resultado = MiCnn.EjecutarDML("SPEmpleadoRolesActualizar");

            if (resultado > 0) R = true;
            return R;
        }

    public bool Agregar()
       {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Rol", this.Rol));

            int resultado = MiCnn.EjecutarDML("SPEmpleadoRolesAgregar");

            if (resultado > 0) R = true;

            return R;
        }

    }

}
