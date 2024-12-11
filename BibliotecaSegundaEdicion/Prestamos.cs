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
    public partial class Prestamos : Form
    {
        private List<GestionLibros> libros;
        private List<GestionUsuarios> usuarios;
        private ConsultaLibros consulta;
        private ConsultaUsuarios consultaUsuarios;
        private List<GestionLibros> librosDisponibles;
        private List<GestionLibros> librosPrestamo;
        private List<GestionUsuarios> usuariosPrestamo;
        private List<GestionPrestamos> prestamosActivos;
        public Prestamos()
        {
            libros = new List<GestionLibros>();
            consulta = new ConsultaLibros();
            usuarios = new List<GestionUsuarios>();
            consultaUsuarios = new ConsultaUsuarios();
            librosDisponibles = new List<GestionLibros>();
            librosPrestamo = new List<GestionLibros>();
            InitializeComponent();
            ConfigurarTabla();

            ObtenerLibros();
            ObtenerUsuarios();
            LLenarComboBoxLibros();
            PrestamosPendientes();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {

        }
        private void LlenarComboBoxUsuario(string tipoUsuario)
        {
            cbmUsuario.Items.Clear();

            foreach (var usuarios in usuarios)
            {
                if (usuarios.tipoUsuario.ToString() == tipoUsuario)
                {
                    cbmUsuario.Items.Add(usuarios.nombre);
                    usuariosPrestamo.Add(usuarios);
                }
            }
        }
        private void ObtenerUsuarios(string filtro = "")
        {
            usuarios.Clear();
            usuarios = consultaUsuarios.GetUsuario(filtro);
        }
        private void ObtenerLibros(string filtro = "")
        {
            libros.Clear();
            libros = consulta.getLibro(filtro);
        }
        private void LLenarComboBoxLibros()
        {
            string dis = "Disponible";
            cbmLibro.Items.Clear();
            foreach (var libro in libros)
            {
                if (libro.disponibilidad.ToString() == dis)
                {
                    cbmLibro.Items.Add(libro.titulo);
                    librosDisponibles.Add(libro);
                }
                else
                {
                    librosPrestamo.Add(libro);
                }
                
            }
        }

        private void ConfigurarTabla()
        {
            dgvPrestamos.AllowUserToAddRows = false;

            dgvPrestamos.Columns.Add("usuario", "Usuario");
            dgvPrestamos.Columns.Add("ID", "Identificacion");
            dgvPrestamos.Columns.Add("titulo", "Titulo");
            dgvPrestamos.Columns.Add("autor", "Autor");
            dgvPrestamos.Columns.Add("ISBN", "ISBN");
            dgvPrestamos.Columns.Add("estado", "Estado");
            
            dgvPrestamos.Columns["usuario"].ReadOnly = true;
            dgvPrestamos.Columns["ID"].ReadOnly = true;
            dgvPrestamos.Columns["titulo"].ReadOnly = true;
            dgvPrestamos.Columns["autor"].ReadOnly = true;
            dgvPrestamos.Columns["ISBN"].ReadOnly = true;
            dgvPrestamos.Columns["estado"].ReadOnly = true;

            DataGridViewButtonColumn btnFinalizar = new DataGridViewButtonColumn();
            btnFinalizar.HeaderText = "Prestamos";
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseColumnTextForButtonValue = true;
            dgvPrestamos.Columns.Add(btnFinalizar);
        }
        private void PrestamosPendientes()
        {
            dgvPrestamos.Rows.Clear();
            dgvPrestamos.Refresh();
            foreach (var li in librosPrestamo)
            {
                dgvPrestamos.Rows.Add(
                    li.ISBN,
                    li.titulo,
                    li.autor,
                    li.disponibilidad,
                    "a",
                    "6");
            }
        }
        private void cmbTipoDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoDeUsuario.SelectedItem.ToString();
            LlenarComboBoxUsuario(tipo);
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            string usuarioText = cbmUsuario.SelectedItem.ToString();
            string libroText = cbmLibro.SelectedItem.ToString();
        }
    }
}
