﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Clientes
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Cedula { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoElectronico", this.CorreoElectronico));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            int resultado = MiCnn.EjecutarDML("SPClientesAgregar");

            if (resultado > 0) R = true;

            return R;

        }
        public DataTable Listar(string pFiltro = "")
        {

            DataTable R = new DataTable();

            //hay que hacer instancia de la clase conexion

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("[SPClientesListar]");

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ClienteID));

            int resultado = MiCnn.EjecutarDML("SPClientesEliminar");
            if (resultado > 0) R = true;
            return R;
        }

        public bool Actualizar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoElectronico", this.CorreoElectronico));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.Direccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.Cedula));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ClienteID));
            int resultado = MiCnn.EjecutarDML("SPClientesActualizar");

            if (resultado > 0) R = true;
            return R;
        }
        public bool ConsultarPorCedula(int pCedula)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", pCedula));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPClientesConsultarPorCedula");

            if (dt != null && dt.Rows.Count > 0) R = true;


            return R;

        }

        public bool ConsultarPorCorreo(string pCorreoElectronico)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@CorreoElectronico", pCorreoElectronico));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPClientesConsultarPorCorreo");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;

        }
        //Esto es obligatorio

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.ClienteID));
            DataTable DatosCliente = new DataTable();
            DatosCliente = MyCnn.EjecutarSelect("SPClientesConsultarPorID");
            if (DatosCliente != null && DatosCliente.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public Clientes ConsultarPorID(int ClienteID)
        {
            Clientes R = new Clientes();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", ClienteID));
            DataTable DatosCliente = new DataTable();
            DatosCliente = MyCnn.EjecutarSelect("SPClientesConsultarPorID");
            if (DatosCliente != null && DatosCliente.Rows.Count > 0)
            {
                DataRow MiFila = DatosCliente.Rows[0];

                R.ClienteID = Convert.ToInt32(MiFila["ClienteID"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.CorreoElectronico = Convert.ToString(MiFila["CorreoElectronico"]);
                R.Direccion = Convert.ToString(MiFila["Direccion"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Cedula = Convert.ToInt32(MiFila["Cedula"]);

            }
            return R;

        }


    }
}
