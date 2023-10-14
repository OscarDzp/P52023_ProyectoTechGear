using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Empleado
    {
        public Empleado() 
        {
            MiEmpleadoRol = new EmpleadoRol();
        
        }   
      
        //Propiedades de la clase

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
        public DataTable Agregar()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable Eliminar()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable Actualizar()
        {
            DataTable R = new DataTable();

            return R;
        }

        public DataTable ConsultarPorID()
        {
            DataTable R = new DataTable();

            return R;
        }
        public DataTable ConsultarPorCorreoElectronico(string CorreoElectronico)
        {
            DataTable R = new DataTable();

            return R;
        }
    }
}