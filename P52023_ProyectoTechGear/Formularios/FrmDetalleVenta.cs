using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_ProyectoTechGear.Formularios
{
    public partial class FrmDetalleVenta : Form
    {
        private Logica.Models.DetalleVenta MiDetalleVentaLocal { get; set; }
        public FrmDetalleVenta()
        {
            InitializeComponent();
            MiDetalleVentaLocal = new Logica.Models.DetalleVenta();
        }

        private void FrmDetalleVenta_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaDetalleVenta();
        }
        private void CargarListaDetalleVenta() {
            Logica.Models.DetalleVenta MiDetalleVenta = new Logica.Models.DetalleVenta();
            DataTable lista = new DataTable();
            lista = MiDetalleVenta.Listar();
            DgvListaDetalleVenta.DataSource = lista;

        }


    }
}
