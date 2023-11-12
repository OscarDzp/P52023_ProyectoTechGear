
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
             MiGarantia = new Garantias();
            
        }

        public int TecnicoID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
        public string Disponibilidad { get; set; }
        public Garantias MiGarantia { get; set; }


        //Metodods 

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Especialidad", this.Especialidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Disponibilidad", this.Disponibilidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@GarantiaID", this.MiGarantia.GarantiaID));

            int resultado = MiCnn.EjecutarDML("SPSoporteTecnicoAgregar");

            if (resultado > 0) R = true;


            return R;

        }
        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.TecnicoID));
            int resultado = MiCnn.EjecutarDML("SPSoporteTecnicoEliminar");
            if (resultado > 0) R = true;
            return R;
        }
        public bool Actualizar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.Correo));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Especialidad", this.Especialidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Disponibilidad", this.Disponibilidad));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@GarantiaID", this.MiGarantia.GarantiaID));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.TecnicoID));
            int resultado = MiCnn.EjecutarDML("SPSoporteTecnicoActualizar");

            if (resultado > 0) R = true;
            return R;
        }
        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.TecnicoID));
            DataTable DatosTecnico = new DataTable();
            DatosTecnico = MyCnn.EjecutarSelect("SPSoporteTecnicoConsultarPorID");
            if (DatosTecnico != null && DatosTecnico.Rows.Count > 0)
            {

                R = true;
            }

            return R;

        }

        public SoporteTecnico ConsultarPorID(int IdTecnico)
        {
            SoporteTecnico R = new SoporteTecnico();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", IdTecnico));
            DataTable DatosTecnico = new DataTable();
            DatosTecnico = MyCnn.EjecutarSelect("SPSoporteTecnicoConsultarPorID");
            if (DatosTecnico != null && DatosTecnico.Rows.Count > 0)
            {

                DataRow MiFila = DatosTecnico.Rows[0];
                R.TecnicoID = Convert.ToInt32(MiFila["TecnicoID"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Correo = Convert.ToString(MiFila["Correo"]);
                R.Especialidad = Convert.ToString(MiFila["Especialidad"]);
                R.Disponibilidad = Convert.ToString(MiFila["Disponibilidad"]);
                R.MiGarantia.GarantiaID = Convert.ToInt32(MiFila["GarantiaID"]);
            }

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

        public DataTable Listar(string pFiltro = "")
        {
            DataTable R = new DataTable();



            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("SPSoportetecnicoListar");

            return R;
        }

    }
}
