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
        //Esto es solo para la tabla de libros disponibles
        private List<GestionLibros> libros;
        private ConsultaLibros consulta;
        private GestionLibros gestionLibros;

        //pa las otras 2 :D
        private List<GestionPrestamos> prestamos;
        private ConsultaPrestamos consultaPrestamos;
        private GestionPrestamos gestionPrestamos;

        //asereje
        private List<GestionPrestamos> prestamos2;
        private ConsultaPrestamos consultaPrestamos2;
        private GestionPrestamos gestionPrestamos2;

        public Reportes()
        {
            InitializeComponent();

            libros = new List<GestionLibros>();
            consulta = new ConsultaLibros();
            gestionLibros = new GestionLibros();

            prestamos = new List<GestionPrestamos>();
            consultaPrestamos = new ConsultaPrestamos();
            gestionPrestamos = new GestionPrestamos();

            prestamos2 = new List<GestionPrestamos>();
            consultaPrestamos2 = new ConsultaPrestamos();
            gestionPrestamos2 = new GestionPrestamos();

            pnlPrestamosActivos.Visible = false;
            pnlUsuariosPrestamo.Visible = false;
            pnlLibrosDisponibles.Visible = false;

            TablaLibrosDisponibles();
            TablaPrestamosActivos();
            TablaUsuariosPrestamos();

            ReportePrestamosActivos();
            ReporteLibrosDisponibles();
            ReporteUsuariosPrestamos();


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
        private void ReportePrestamosActivos(string filtro = "")
        {
            dgvPrestamos.Rows.Clear();
            dgvPrestamos.Refresh();
            prestamos.Clear();
            prestamos = consultaPrestamos.GetPrestamos(filtro);

            foreach (var pre in prestamos)
            {
                dgvPrestamos.Rows.Add(pre.titulo, pre.autor, pre.ISBN, pre.estado);
            }
        }
        private void ReporteUsuariosPrestamos(string filtro = "")
        {
            dgvUsuariosPrestamo.Rows.Clear();
            dgvUsuariosPrestamo.Refresh();
            prestamos2.Clear();
            prestamos2 = consultaPrestamos2.GetPrestamos(filtro);

            foreach (var pre in prestamos2)
            {
                dgvUsuariosPrestamo.Rows.Add(pre.id, pre.usuario, pre.titulo);
            }
        }
    }
}
