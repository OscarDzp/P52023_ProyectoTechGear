using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Transacciones
    {
        public Transacciones()
        {
            MiTransaccion = new Transacciones();
        }
        public int TransaccionID { get; set; }
        public string FechaTransaccion { get; set; } // pensable
        public string Cantidad { get; set; }
        public string TipoTransaccion { get; set; }
        public int FacturaID { get; set; }
        public Transacciones MiTransaccion { get; set; }

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