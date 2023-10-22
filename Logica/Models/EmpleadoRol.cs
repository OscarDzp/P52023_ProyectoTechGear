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

        public string Nombre { get; set; }





        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPEmpleadoRolListar");

            return R;
        }

        public bool ConsultarPorNombre(string pNombre)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", pNombre));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPEmpleadoRolesConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;
        }

        

            public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));

            int resultado = MiCnn.EjecutarDML("SPEmpleadoRolesAgregar");

            if (resultado > 0) R = true;


            return R;
        }

    }



}
