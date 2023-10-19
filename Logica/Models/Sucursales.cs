using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Sucursales
    {
        public Sucursales()
        {
            MiSucursal = new Sucursales();
        }
        public int SucursalID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Sucursales MiSucursal { get; set; }

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

        public bool ConsultarPorNombre()
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