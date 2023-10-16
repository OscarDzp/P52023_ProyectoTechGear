using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Modelos
    {
        public Modelos()
        {
            MiModelo = new Modelos();
        }
        public int ModeloID { get; set; }
        public string AnioLanzamiento { get; set; }
        public string Nombre { get; set; }
        public int MarcaID { get; set; }
        public Modelos MiModelo { get; set; }

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
    }
}
