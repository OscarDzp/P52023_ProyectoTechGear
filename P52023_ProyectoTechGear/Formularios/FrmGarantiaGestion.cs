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
    public partial class FrmGarantiaGestion : Form
    {
        public FrmGarantiaGestion()
        {
            InitializeComponent();
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmGarantiaGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaGarantia();
        }

        private void CargarListaGarantia() {

            Logica.Models.Garantias MiGarantia = new Logica.Models.Garantias();
            DataTable lista = new DataTable();
            lista = MiGarantia.Listar();
            DgvListaGarantias.DataSource = lista;


        }
    }
}
