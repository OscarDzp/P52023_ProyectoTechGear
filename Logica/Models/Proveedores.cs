using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedores
    {
        public Proveedores ()
        {
            MiProveedor = new Proveedores();
        }
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public Proveedores MiProveedor { get; set; }

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
