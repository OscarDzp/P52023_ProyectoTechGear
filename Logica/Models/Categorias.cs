﻿using System;
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
