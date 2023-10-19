﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_ProyectoTechGear.Globales
{
    public static class ObjectosGlobales
    {
        // se define un objecto globla para el form principal.
        public static Form MiFormularioPrincipal = new Formularios.FrmPrincipal();

        public static Formularios.FrmEmpleadoGestion MiFormularioDeGestionDeEmpleados = new Formularios.FrmEmpleadoGestion();

        public static Formularios.FrmGarantiaGestion MiFormularioDeGestionDeGarantia = new Formularios.FrmGarantiaGestion();

        public static Formularios.FrmMarcaGestion MiFormularioDeGestionDeMarca = new Formularios.FrmMarcaGestion();

        public static Formularios.FrmModeloGestion MiFormularioDeGestionDeModelo = new Formularios.FrmModeloGestion();

        public static Formularios.FrmProductoGestion MiFormularioDeGestionDeProductos = new Formularios.FrmProductoGestion();

    }
}
