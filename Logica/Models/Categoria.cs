using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }


        public string Nombre { get;}

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
