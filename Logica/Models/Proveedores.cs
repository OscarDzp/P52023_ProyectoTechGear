using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedores
    {
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }


        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contacto", this.Contacto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoElectronico", this.CorreoElectronico));

            int resultado = MiCnn.EjecutarDML("SPProveedoresAgregar");

            if (resultado > 0) R = true;

            return R;
        }

        public DataTable Listar(string pFiltro = "")
        {

            DataTable R = new DataTable();

            //hay que hacer instancia de la clase conexion

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("SPProveedoresListar");

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProveedorID));

            int resultado = MiCnn.EjecutarDML("SPProveedorEliminar");
            if (resultado > 0) R = true;
            return R;
        }

        public bool Actualizar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contacto", this.Contacto));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoElectronico", this.CorreoElectronico));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProveedorID));
            int resultado = MiCnn.EjecutarDML("[SPProveedorActualizar]");

            if (resultado > 0) R = true;
            return R;
        }
        public bool ConsultarPorNombre(string pNombre)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", pNombre));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProveedoresConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;



            return R;
        }

        public bool ConsultarPorCorreo(string pCorreoElectronico)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoElectronico", pCorreoElectronico));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProveedoresConsultarPorCorreo");

            if (dt != null && dt.Rows.Count > 0) R = true;



            return R;
        }
        //Esto es obligatorio

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ProveedorID));
            DataTable DatosProveedor = new DataTable();
            DatosProveedor = MyCnn.EjecutarSelect("SPProveedoresConsultarPorID");
            if (DatosProveedor != null && DatosProveedor.Rows.Count > 0)
            {
                //el usuario existe
                R = true;
            }

            return R;
        }

        public Proveedores ConsultarPorID(int ProveedorID)
        {
            Proveedores R = new Proveedores();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", ProveedorID));
            DataTable DatosProveedor = new DataTable();
            DatosProveedor = MyCnn.EjecutarSelect("SPProveedoresConsultarPorID");
            if (DatosProveedor != null && DatosProveedor.Rows.Count > 0)
            {
                DataRow MiFila = DatosProveedor.Rows[0];

                R.ProveedorID = Convert.ToInt32(MiFila["ProveedorID"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Contacto = Convert.ToString(MiFila["Contacto"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.CorreoElectronico = Convert.ToString(MiFila["CorreoElectronico"]);

            }
            return R;

        }

    }
}
