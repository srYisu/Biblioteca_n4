using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaSegundaEdicion
{
    public partial class Form1 : Form
    {
        AbrirForms open = new AbrirForms();
        public Form1()
        {
            InitializeComponent();
            pnlBase.Dock = DockStyle.Fill;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Libros libro = new Libros();
            open.AbrirFormPanel(this.pnlBase, libro);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            open.AbrirFormPanel(this.pnlBase , usuarios);
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            Prestamos pres = new Prestamos();
            open.AbrirFormPanel(this.pnlBase, pres);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes rep = new Reportes();
            open.AbrirFormPanel (this.pnlBase, rep);
        }
    }
}
