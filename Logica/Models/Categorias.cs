using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Categorias
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }

        //Listar para Categorias
        public DataTable Listar()
        {
            DataTable R = new DataTable();
            return R;
        }
        public DataTable Agregar()
        {
            DataTable R = new DataTable();
            return R;
        }
    }
}
