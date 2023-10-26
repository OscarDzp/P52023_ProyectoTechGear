using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logica.Models
{
    public class Facturas
    {
        public Facturas()
        {
            MiSucursal = new Sucursales();

            MiEmpleado = new Empleados();

            MiCliente = new Clientes();
        }
        public int FacturaID { get; set; }
        public string TotalFactura { get; set; }
        public string Detalledeventa { get; set; }
        public string Impuestos { get; set; }
        public DateTime FechaFactura { get; set; } // fecha
        public Sucursales MiSucursal { get; set; }
        public Empleados MiEmpleado { get; set; }
        public Clientes MiCliente { get; set; }



        public bool Agregar()
        {
            bool R = false;

             Conexion MiCnn = new Conexion();

       
            MiCnn.ListaDeParametros.Add(new SqlParameter("@TotalFactura", this.TotalFactura));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Detalledeventa", this.Detalledeventa));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Impuestos", this.Impuestos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FechaFactura", this.FechaFactura));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@SucursalID", this.MiSucursal.SucursalID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@EmpleadoID", this.MiEmpleado.EmpleadoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ClienteID", this.MiCliente.ClienteID));

            int resultado = MiCnn.EjecutarDML("SPFacturasAgregar");

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
        public bool ConsultarPorID(string pFacturaID)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@FacturaID", pFacturaID));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPFacturasConsultarPorID");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable Listar()
        {
            DataTable R = new DataTable();



            Conexion MiCnn = new Conexion();
            

            R = MiCnn.EjecutarSelect("SPFacturasListar");

            return R;
        }
    }
}
