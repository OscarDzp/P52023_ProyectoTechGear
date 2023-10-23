
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
    public class SoporteTecnico
    {
        public SoporteTecnico()
        {
             MiGarantiaID = new Garantias();
            
        }

        public int TecnicoID { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Especialidad { get; set; }
        public int Disponibilidad { get; set; }
        public Garantias MiGarantiaID { get; set; }


        //Metodods 

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.CorreoElectronico));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Especialidad", this.Especialidad));
            //Disponibilidad
            //Garantias

            int resultado = MiCnn.EjecutarDML("SPSoporteTecnicoAgregar");

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
        public bool ConsultarPorID(int pID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", pID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPSoporteTecnicoConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }

        public bool ConsultarPorCorreo(string pCorreo)
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", pCorreo));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPSoporteTecnicoConsultarPorCorreo");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPSoportetecnicoListar");

            return R;
        }

    }
}
