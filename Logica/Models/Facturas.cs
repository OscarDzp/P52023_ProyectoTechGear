using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Facturas
    {
        public Facturas()
        {
            MiFactura = new Facturas();
        }
        public int FacturaID { get; set; }
        public string TotalFactura { get; set; }
        public string Detalledeventa { get; set; }
        public string Impuestos { get; set; }
        public string FechaFactura { get; set; } // fecha
        public int SucursalID { get; set; }
        public int EmpleadoID { get; set; }
        public int ClienteID { get; set; }
        public Facturas MiFactura { get; set; }

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
