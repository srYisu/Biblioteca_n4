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
    public partial class Libros : Form
    {
        private List<GestionLibros> libros;
        private ConsultaLibros consulta;
        private GestionLibros gestionLibros;
        public Libros()
        {
            InitializeComponent();
            configurarTabla();
            libros = new List<GestionLibros>();
            consulta = new ConsultaLibros();
            gestionLibros = new GestionLibros();
            //CargarProdutos();

            // Deshabilitar la capacidad de mover el formulario
            this.FormBorderStyle = FormBorderStyle.None; // Sin borde
            this.TopLevel = false; // Importante para ser embebido en el Panel
            this.Dock = DockStyle.Fill; // Ajustar al contenedor
            this.AutoScaleMode = AutoScaleMode.None;
        }
        private void CargarProductos(string filtro = "")
        {
            dgvLibros.Rows.Clear();
            dgvLibros.Refresh();
            libros.Clear();
            libros = consulta.getLibro(filtro);

            for (int i =0; i<libros.Count; i++)
            {
                dgvLibros.RowTemplate.Height = 50;
                dgvLibros.Rows.Add(
                    libros[i].titulo,
                    libros[i].autor,
                    libros[i].ISBN,
                    libros[i].disponibilidad);
            }
        }
        private void configurarTabla()
        {
            dgvLibros.AllowUserToAddRows = false;

            dgvLibros.Columns.Add("titulo" ,"Titulo");
            dgvLibros.Columns.Add("autor", "Autor");
            dgvLibros.Columns.Add("ISBN", "ISBN");
            dgvLibros.Columns.Add("estado", "Estado");

            dgvLibros.Columns["titulo"].ReadOnly = true;
            dgvLibros.Columns["autor"].ReadOnly=true;
            dgvLibros.Columns["ISBN"].ReadOnly = true;
            dgvLibros.Columns["estado"].ReadOnly = true;

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvLibros.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvLibros.Columns.Add(btnEliminar);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;
            }

            cargarDatosLibros();
            if (consulta.AddLibro(gestionLibros))
            {
                MessageBox.Show("Productos agregados correctamente");
                CargarProductos();
            }
        }
        private void cargarDatosLibros()
        {
            gestionLibros.titulo = txtTitulo.Text.Trim();
            gestionLibros.autor = txtAutor.Text.Trim();
            gestionLibros.ISBN = Convert.ToInt32(txtISBN.Text.Trim());
            gestionLibros.disponibilidad = cmbEstado.SelectedItem.ToString();
        }
        private bool DatosCorrectos()
        {
            if (txtTitulo.Text.Trim().Equals("") || txtAutor.Text.Trim().Equals("") || txtISBN.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese Todos los datos");
                return false;
            }
            return true;
        }
    }
}
