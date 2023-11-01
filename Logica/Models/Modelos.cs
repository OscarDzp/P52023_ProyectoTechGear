using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Modelos
    {
        public Modelos()
        {
            MiMarcaID = new Marcas();
        }
        public int ModeloID { get; set; }
        public DateTime AnioLanzamiento { get; set; }
        public string Nombre { get; set; }
        public Marcas MiMarcaID { get; set; }
        

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@AnioLanzamiento", this.AnioLanzamiento));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@MarcaID", this.MiMarcaID.MarcaID));
            //TODO FECHA CALENDARIO EN VEZ DE CBOX

            int resultado = MiCnn.EjecutarDML("SPModelosAgregar");

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
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@AnioLanzamiento", this.AnioLanzamiento));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@MarcaID", this.MiMarcaID.MarcaID));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ModeloID));
            int resultado = MiCnn.EjecutarDML("SPModelosActualizar");

            if (resultado > 0) R = true;
            return R;
        }
        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ModeloID));
            DataTable DatosModelo = new DataTable();
            DatosModelo = MyCnn.EjecutarSelect("SPModelosConsultarPorID");
            if (DatosModelo != null && DatosModelo.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Modelos ConsultarPorID(int IdModelos) 
        {
            Modelos R = new Modelos();
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID",IdModelos));
            DataTable DatosModelo = new DataTable();
            DatosModelo = MyCnn.EjecutarSelect("SPModelosConsultarPorID");
            if (DatosModelo != null && DatosModelo.Rows.Count > 0)
            {
                DataRow MiFila = DatosModelo.Rows[0];

                R.ModeloID = Convert.ToInt32(MiFila["ModeloID"]);
                R.AnioLanzamiento = Convert.ToDateTime(MiFila["AnioLanzamiento"]);
                R.Nombre = Convert.ToString(MiFila["MNombre"]);
                R.MiMarcaID.MarcaID = Convert.ToInt32(MiFila["MarcaID"]);
                R.MiMarcaID.Nombre = Convert.ToString(MiFila["Nombre"]);
            }

            return R;

        }

            public bool ConsultarPorNombre(String pNombre)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", pNombre));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPModelosConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPModelosListar");

            return R;
        }
    }
}
