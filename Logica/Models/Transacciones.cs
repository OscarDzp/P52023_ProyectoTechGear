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
      
        public int TransaccionID { get; set; }
        public string FechaTransaccion { get; set; } // pensable
        public string Cantidad { get; set; }
        public string TipoTransaccion { get; set; }
        public int FacturaID { get; set; }
   

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

        public bool ConsultarPorFacturaID()
        {
            bool R = false;
            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPTransaccionesListar");

            return R;
        }
    }
}