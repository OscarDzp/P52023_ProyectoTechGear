﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Productos
    {
        public Productos()
        {
            MiModeloID = new Modelos();
            MiMarcaID = new Marcas();
            MiCategoriaID = new Categorias();
            MiProveedorID = new Proveedores();
        }
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string StockActual { get; set; }//decimal 
        public string Precio { get; set; }//Decimal
        public Modelos MiModeloID { get; set; }
        public Marcas MiMarcaID { get; set; }
        public Categorias MiCategoriaID { get; set; }

        public Proveedores MiProveedorID { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Descripcion", this.Descripcion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CategoriaID", this.MiCategoriaID.CategoriaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@StockActual", this.StockActual));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Precio", this.Precio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@MarcaID", this.MiMarcaID.MarcaID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ModeloID", this.MiModeloID.ModeloID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProveedorID", this.MiProveedorID.ProveedorID));
            int resultado = MiCnn.EjecutarDML("SPProductosAgregar");

            if (resultado > 0) R = true;

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
        public bool ConsultarPorID(int pProductoID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", pProductoID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProductosConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }

        public bool ConsultarPorNombre(int pNombre)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", pNombre));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPProductosConsultarPorNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }


        public DataTable Listar()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSelect("SPProductosListar");

            return R;
        }
    }
}
