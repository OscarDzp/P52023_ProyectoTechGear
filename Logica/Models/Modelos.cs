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
            return R;
        }
        public bool ConsultarPorID(int pModeloID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ModeloID", pModeloID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPModelosConsultarPorID");

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
