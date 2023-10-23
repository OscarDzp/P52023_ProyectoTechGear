﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TiempoGarantia", this.Tiempogarantia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaInicio", this.Fechainicio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaFinalizacion", this.Fechafinalizacion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Detalle", this.Detalle));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Producto", this.ProductoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Garantia", this.MiGarantia.GarantiaID));

            int resultado = MiCnn.EjecutarDML("SPGarantiasAgregar");

            if (resultado > 0) R = true;

            return R;
        }
    
        public bool Eliminar() //Todavia no
        {
            bool R = false;
            return R;
        }
        public bool Actualizar()//Todavia no
        {
            bool R = false;
            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPGarantiaListar");

            return R;
        }
    }
}
