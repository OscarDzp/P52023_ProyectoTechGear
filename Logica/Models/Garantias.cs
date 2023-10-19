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
