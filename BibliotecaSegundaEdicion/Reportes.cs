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
    public partial class Reportes : Form
    {
        private List<GestionLibros> libros;
        private ConsultaLibros consulta;
        private GestionLibros gestionLibros;
        public Reportes()
        {
            InitializeComponent();

            libros = new List<GestionLibros>();
            consulta = new ConsultaLibros();
            gestionLibros = new GestionLibros();

            pnlPrestamosActivos.Visible = false;
            pnlUsuariosPrestamo.Visible = false;
            pnlLibrosDisponibles.Visible = false;

            TablaLibrosDisponibles();
            TablaPrestamosActivos();
            TablaUsuariosPrestamos();

            ReporteLibrosDisponibles();

            rbtnLibrosDispoibles.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbtnPrestamosActivos.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbtnUsuariosPrestamo.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            
        }

        private void TablaPrestamosActivos()
        {
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToResizeColumns = false;
            dgvPrestamos.AllowUserToResizeRows = false;
            dgvPrestamos.AllowUserToOrderColumns = false;

            dgvPrestamos.Columns.Add("titulo", "Titulo");
            dgvPrestamos.Columns.Add("autor", "Autor");
            dgvPrestamos.Columns.Add("ISBN", "ISBN");
            dgvPrestamos.Columns.Add("estado", "Estado");
        }

        private void TablaUsuariosPrestamos()
        {
            dgvUsuariosPrestamo.AllowUserToAddRows = false;
            dgvUsuariosPrestamo.AllowUserToResizeColumns = false;
            dgvUsuariosPrestamo.AllowUserToResizeRows = false;
            dgvUsuariosPrestamo.AllowUserToOrderColumns = false;

            dgvUsuariosPrestamo.Columns.Add("ID", "Identificación");
            dgvUsuariosPrestamo.Columns.Add("nombre", "Nombre");
            dgvUsuariosPrestamo.Columns.Add("tipoUsuario", "Tipo de usuario");
            dgvUsuariosPrestamo.Columns.Add("libro","Libro");
        }
        private void TablaLibrosDisponibles()
        {
            dgvLibrosDisponibles.AllowUserToAddRows = false;
            dgvLibrosDisponibles.AllowUserToResizeColumns = false;
            dgvLibrosDisponibles.AllowUserToResizeRows = false;
            dgvLibrosDisponibles.AllowUserToOrderColumns = false;
            
            dgvLibrosDisponibles.Columns.Add("ISBN", "ISBN");
            dgvLibrosDisponibles.Columns.Add("titulo","Titulo");
            dgvLibrosDisponibles.Columns.Add("autor", "Autor");         
            dgvLibrosDisponibles.Columns.Add("estado", "Estado");
        }
        private void MostrarPanelSeleccionado()
        {
            pnlLibrosDisponibles.Visible = rbtnLibrosDispoibles.Checked;
            pnlPrestamosActivos.Visible = rbtnPrestamosActivos.Checked;
            pnlUsuariosPrestamo.Visible = rbtnUsuariosPrestamo.Checked;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPanelSeleccionado();
        }
        private void ReporteLibrosDisponibles(string filtro = "")
        {
            dgvLibrosDisponibles.Rows.Clear();
            dgvLibrosDisponibles.Refresh();
            libros.Clear();
            libros = consulta.getLibro(filtro);

            foreach (var libro in libros)
            {
                if (libro.disponibilidad.ToString() == "Disponible")
                {
                    dgvLibrosDisponibles.Rows.Add(
                    libro.ISBN,
                    libro.titulo,
                    libro.autor,
                    libro.disponibilidad);
                }
            }
        }
    }
}
