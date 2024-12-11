using Mysqlx;
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
        Errores errores = new Errores();
        string contra = "Contraseña";
        string us = "Usuario";
        public Form1()
        {
            InitializeComponent();
            pnlBase.Dock = DockStyle.Fill;

            pnlInvisible.Size = new Size(0,0);

            picLogoCentrado.Visible= true;
            btnLibro.Visible = false;
            btnPrestamo.Visible = false;
            btnReportes.Visible = false;
            btnUsuarios.Visible = false;
            picLogo.Visible = false;

            txtContrasena.Text = contra;
            txtUsuario.Text = us;

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
            try
            {
                string usuarioIngresado = txtUsuario.Text;
                string contrasenaIngresada = txtContrasena.Text;

                // Validar credenciales
                if (contrasena == contrasenaIngresada && usuario == usuarioIngresado)
                {
                    picLogoCentrado.Visible = false;
                    btnLibro.Visible = true;
                    btnPrestamo.Visible = true;
                    btnReportes.Visible = true;
                    btnUsuarios.Visible = true;
                    picLogo.Visible = true;
                    btnIniciarSesion.Visible = false;
                    tgsMostrarContraseña.Visible = false;

                    txtContrasena.Visible = false;
                    txtUsuario.Visible = false;
                    picInicioSesionFoto.Visible = false;

                    MessageBox.Show("Inicio de sesión exitoso.");
                }
                else
                {
                    MessageBox.Show("Datos incorrectos.");
                }
            }
            catch (ArgumentException ex) // Excepción específica para campos vacíos
            {
                errores.RegistrarError("Error inesperado en btnIniciarSesion_Click: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) // Captura de cualquier otro error inesperado
            {
                errores.RegistrarError("Error inesperado en btnIniciarSesion_Click: " + ex.Message);
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == us)
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = us;
                txtUsuario.ForeColor= Color.Gray;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == contra)
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.PasswordChar = '•';
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                txtContrasena.Text = contra;
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.PasswordChar = '\0';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pnlInvisible;
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (tgsMostrarContraseña.Checked)
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar= '•';
            }
        }
    }
}
