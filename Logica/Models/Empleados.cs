using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Empleados
    {
        public Empleados() 
        {
            MiEmpleadoRol = new EmpleadoRol();
        }   
      
        //Propiedades de la claseee

        public int EmpleadoID { get; set; }

        public string Nombre { get; set;}

        public string Telefono { get; set;}

        public string CorreoElectronico { get; set;}

        public string Cargo { get; set;}

        public string Cedula { get; set; }

        public string Contrasennia { get; set;}

        public EmpleadoRol MiEmpleadoRol { get; set; }

        //comportamientos ,operaciones , funciones, metodos

        public DataTable Listar()
        {

            DataTable R = new DataTable();

            //hay que hacer instancia de la clase conexion

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPEmpleadosListar");

            return R;
        }
        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoElectronico", this.CorreoElectronico));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cargo", this.Cargo));    
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", this.Contrasennia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@EmpleadoRolID", this.MiEmpleadoRol.EmpleadoRolID));

            int resultado = MiCnn.EjecutarDML("SPEmpleadosAgregar");

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

        public bool ConsultarPorCedula(string pCedula)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", pCedula));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPEmpleadosConsultarPorCedula");

            if (dt != null && dt.Rows.Count > 0) R = true;
            
            return R;
        }
        public bool ConsultarPorCorreoElectronico(string pCorreoElectronico)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", pCorreoElectronico));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPEmpleadosConsultarPorCorreo");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }
    }
}