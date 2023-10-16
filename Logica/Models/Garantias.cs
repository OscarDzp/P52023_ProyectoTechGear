using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Garantias
    {
        public Garantias()
        {
            MiGarantia = new Garantias();
        }
        public int GarantiaID { get; set; }
        public string Tiempogarantia { get; set; } // Es una fecha
        public string Fechainicio { get; set; } // Es una fecha
        public string Fechafinalizacion { get; set; } // Es una fecha
        public string Detalle { get; set; }
        public int ProductoID { get; set; }
        public Garantias MiGarantia { get; set; }

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
