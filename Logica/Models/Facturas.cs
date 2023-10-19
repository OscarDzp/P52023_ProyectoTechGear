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
