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
