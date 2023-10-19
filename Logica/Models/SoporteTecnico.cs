
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    internal class SoporteTecnico
    {
        public SoporteTecnico()
        {
             MiGarantiaID = new Garantias();
            
        }

        public int TecnicoID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
        public string Disponibilidad { get; set; }
        public Garantias MiGarantiaID { get; set; }


        //Metodods 

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

        public bool ConsultarPorCorreo()
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
