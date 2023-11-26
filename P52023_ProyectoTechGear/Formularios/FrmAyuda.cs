using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_ProyectoTechGear.Formularios
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            LinkLabel.Link WhatsappLink = new LinkLabel.Link();
            WhatsappLink.LinkData = "https://wa.me/+50689863224";
            linkLabel1.Links.Add(WhatsappLink);

            LinkLabel.Link WhatsappLink2 = new LinkLabel.Link();
            WhatsappLink2.LinkData = "https://wa.me/+50685499768";
            linkLabel2.Links.Add(WhatsappLink2);

            LinkLabel.Link WhatsappLink3 = new LinkLabel.Link();
            WhatsappLink3.LinkData = "https://wa.me/+50660818916";
            linkLabel3.Links.Add(WhatsappLink3);

            LinkLabel.Link WhatsappLink4 = new LinkLabel.Link();
            WhatsappLink4.LinkData = "https://wa.me/+50661303487";
            linkLabel4.Links.Add(WhatsappLink4);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData != null)
            {
                try
                {
                    Process.Start(e.Link.LinkData as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el enlace: " + ex.Message);
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData != null)
            {
                try
                {
                    Process.Start(e.Link.LinkData as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el enlace: " + ex.Message);
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData != null)
            {
                try
                {
                    Process.Start(e.Link.LinkData as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el enlace: " + ex.Message);
                }
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData != null)
            {
                try
                {
                    Process.Start(e.Link.LinkData as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el enlace: " + ex.Message);
                }
            }
        }
    
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
