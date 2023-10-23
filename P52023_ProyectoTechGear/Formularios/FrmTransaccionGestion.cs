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
    public partial class FrmTransaccionGestion : Form
    {
        public FrmTransaccionGestion()
        {
            InitializeComponent();
        }

        private void FrmTransaccionGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjectosGlobales.MiFormularioPrincipal;
            CargarListaTransaccion();
        }


        private void CargarListaTransaccion() 
        {
            Logica.Models.Transacciones MiTransaccion = new Logica.Models.Transacciones();
            DataTable lista = new DataTable();
            lista = MiTransaccion.Listar();
            DgvListaTransaccion.DataSource = lista;
        }

    }
    }

