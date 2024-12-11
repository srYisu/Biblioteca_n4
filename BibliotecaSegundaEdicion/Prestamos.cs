using Org.BouncyCastle.X509;
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
        private List<GestionPrestamos> prestamos;
        private ConsultaPrestamos consultaPrestamos;
        private GestionPrestamos gestionPrestamos;
        private List<GestionUsuarios> usuariosP;
        
        public Prestamos()
        {
            libros = new List<GestionLibros>();
            consulta = new ConsultaLibros();
            usuarios = new List<GestionUsuarios>();
            consultaUsuarios = new ConsultaUsuarios();
            librosDisponibles = new List<GestionLibros>();
            prestamos = new List<GestionPrestamos>();
            consultaPrestamos = new ConsultaPrestamos();
            gestionPrestamos = new GestionPrestamos();
            usuariosP = new List<GestionUsuarios>();
            InitializeComponent();
            ConfigurarTabla();
            CargarPrestamos();
            ObtenerLibros();
            ObtenerUsuarios();
            LLenarComboBoxLibros();
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
                    usuariosP.Add(usuarios);
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

        private void cmbTipoDeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoDeUsuario.SelectedItem.ToString();
            LlenarComboBoxUsuario(tipo);
        }
        private void CargarPrestamos(string filtro = "")
        {
            dgvPrestamos.Rows.Clear();
            dgvPrestamos.Refresh();
            prestamos.Clear();
            prestamos = consultaPrestamos.GetPrestamos(filtro);

            foreach (var pre in prestamos)
            {
                dgvPrestamos.Rows.Add(pre.usuario, pre.id, pre.titulo, pre.autor,
                    pre.ISBN, pre.estado);
            }

        }
        private void CargarDatos()
        {
            foreach (var usu in usuariosP)
            {
                foreach (var dis in librosDisponibles)
                {
                    if (usu.nombre.ToString() == cbmUsuario.SelectedItem.ToString() && dis.titulo.ToString() == cbmLibro.SelectedItem.ToString())
                    {
                        gestionPrestamos.usuario = usu.nombre;
                        gestionPrestamos.id = usu.id;
                        gestionPrestamos.titulo = dis.titulo;
                        gestionPrestamos.autor = dis.autor;
                        gestionPrestamos.ISBN = dis.ISBN;
                        gestionPrestamos.estado = "Prestamo";
                    }
                }
            }
        }
        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            CargarDatos();
            if (consultaPrestamos.AddPrestamo(gestionPrestamos))
            {
                consulta.EditLibroEstado(gestionPrestamos);
                MessageBox.Show("Productos agregados correctamente");
                CargarPrestamos();
                LLenarComboBoxLibros();
            }
            LLenarComboBoxLibros();
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvPrestamos.Columns["btnFinalizar"].Index)
                {
                    CargarDatos();
                    
                    string titulo = Convert.ToString(dgvPrestamos.Rows[e.RowIndex].Cells["titulo"].Value);
                    string autor = Convert.ToString(dgvPrestamos.Rows[e.RowIndex].Cells["autor"].Value);
                    int ISbn = Convert.ToInt32(dgvPrestamos.Rows[e.RowIndex].Cells["ISBN"].Value);
                    consulta.EditLibroDisponible(titulo, autor, ISbn);
                    consultaPrestamos.finalizarPrestamo(ISbn);
                    CargarPrestamos();
                    LLenarComboBoxLibros();
                }
            }
        }
    }
}
