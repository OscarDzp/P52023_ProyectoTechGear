using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class DetalleVenta
    {
        public DetalleVenta()
        {
            MiDetalleVenta = new DetalleVenta();
        }
        public int DetalleVentaID { get; set; }
        public string Subtotal { get; set; }
        public string PrecioUnitario { get; set; }
        public string Cantidad { get; set; }
        public int PrdoductoID { get; set; }
        public DetalleVenta MiDetalleVenta { get; set; }

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
    }
}
