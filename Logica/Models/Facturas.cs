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

            MiProducto = new Productos();
        }
        public int FacturaID { get; set; }
        public string TotalFactura { get; set; }
        public string Detalledeventa { get; set; }
        public string Impuestos { get; set; }
        public DateTime FechaFactura { get; set; } // fecha
        public Sucursales MiSucursal { get; set; }
        public Empleados MiEmpleado { get; set; }
        public Clientes MiCliente { get; set; }
        public Productos MiProducto { get; set; }

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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", this.MiProducto.ProductoID));

            int resultado = MiCnn.EjecutarDML("SPFacturasAgregar");

            if (resultado > 0) R = true;

            return R;
        }
        public bool Eliminar()
        {
            bool R = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.FacturaID));

            int resultado = MiCnn.EjecutarDML("SPFacturasEliminar");
            if (resultado > 0) R = true;
            return R;
        }
        public bool Actualizar()
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
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ProductoID", this.MiProducto.ProductoID));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.FacturaID));
            int resultado = MiCnn.EjecutarDML("SPFacturasActualizar");

            if (resultado > 0) R = true;
            return R;
        }
        public bool ConsultarPorTotalFactura(string pTotalFactura)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@TotalFactura", pTotalFactura));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSelect("SPFacturasConsultarPorTotalFactura");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;
            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.FacturaID));
            DataTable DatosFactura = new DataTable();
            DatosFactura = MyCnn.EjecutarSelect("SPFacturasConsultarPorID");
            if (DatosFactura != null && DatosFactura.Rows.Count > 0)
            {

                R = true;
            }

            return R;

        }

        public Facturas ConsultarPorID(int IdFactura)
        {
            Facturas R = new Facturas();
            Conexion MyCnn = new Conexion();
            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID", IdFactura));
            DataTable DatosFactura = new DataTable();
            DatosFactura = MyCnn.EjecutarSelect("SPFacturasConsultarPorID");
            if (DatosFactura != null && DatosFactura.Rows.Count > 0)
            {

                DataRow MiFila = DatosFactura.Rows[0];
                R.FacturaID = Convert.ToInt32(MiFila["FacturaID"]);
                R.TotalFactura = Convert.ToString(MiFila["TotalFactura"]);
                R.Detalledeventa = Convert.ToString(MiFila["Detalledeventa"]);
                R.Impuestos = Convert.ToString(MiFila["Impuestos"]);
                R.FechaFactura = Convert.ToDateTime(MiFila["FechaFactura"]);
                R.MiSucursal.SucursalID = Convert.ToInt32(MiFila["SucursalID"]);
                R.MiSucursal.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.MiEmpleado.EmpleadoID = Convert.ToInt32(MiFila["EmpleadoID"]);
                R.MiEmpleado.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.MiCliente.ClienteID = Convert.ToInt32(MiFila["ClienteID"]);
                R.MiCliente.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.MiProducto.ProductoID = Convert.ToInt32(MiFila["ProductoID"]);
                R.MiProducto.Nombre = Convert.ToString(MiFila["Nombre"]);
            }

            return R;
        }

        public DataTable Listar(string pFiltro = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Filtro", pFiltro));

            R = MiCnn.EjecutarSelect("SPFacturasListar");

            return R;
        }
    }
}
