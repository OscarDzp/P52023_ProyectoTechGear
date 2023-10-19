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

        public bool Agregar()
        {
            bool R = false;
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
        public bool ConsultarPorID()
        {
            bool R = false;
            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();
            return R;
        }
    }
}
