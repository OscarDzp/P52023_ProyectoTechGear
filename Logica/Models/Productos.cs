using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Productos
    {
        public Productos()
        {
            MiProducto = new Productos();
        }
        public int ProductoID { get; set; }
        public string Nombre { get; set; } 
        public string Descripcion { get; set; }
        public string Categorias { get; set; } 
        public string StockActual { get; set; }
        public string Precio { get; set; }
        public int ModeloID { get; set; }
        public int MarcaID { get; set; }
        public Productos MiProducto { get; set; }

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
