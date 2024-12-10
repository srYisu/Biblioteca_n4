using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace BibliotecaSegundaEdicion
{
    public partial class Form1 : Form
    {
        AbrirForms open = new AbrirForms();
        public Form1()
        {
            InitializeComponent();
            pnlBase.Dock = DockStyle.Fill;

            picLogoCentrado.Visible= true;
            btnLibro.Visible = false;
            btnPrestamo.Visible = false;
            btnReportes.Visible = false;
            btnUsuarios.Visible = false;
            picLogo.Visible = false;

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
        string usuario = "123";
        string contrasena = "111";
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;

            if (contrasena == contrasenaIngresada && usuario == usuarioIngresado)
            {
                picLogoCentrado.Visible = false;
                btnLibro.Visible = true;
                btnPrestamo.Visible = true;
                btnReportes.Visible = true;
                btnUsuarios.Visible = true;
                picLogo.Visible = true;
                btnIniciarSesion.Visible = false;

                txtContrasena.Visible = false;
                txtUsuario.Visible = false;
                picInicioSesionFoto.Visible = false;
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
