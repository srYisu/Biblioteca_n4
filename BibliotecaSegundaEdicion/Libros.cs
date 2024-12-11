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
        string buscador = "Buscador";

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
            CargarProductos();

            txtBuscador.Text = buscador;
            
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

            for (int i = 0; i < libros.Count; i++)
            {
                dgvLibros.RowTemplate.Height = 50;
                dgvLibros.Rows.Add(
                    libros[i].ISBN,
                    libros[i].titulo,
                    libros[i].autor,
                    libros[i].disponibilidad);
            }
        }
        private void configurarTabla()
        {
            dgvLibros.AllowUserToAddRows = false;

            dgvLibros.Columns.Add("ISBN", "ISBN");
            dgvLibros.Columns.Add("titulo", "Titulo");
            dgvLibros.Columns.Add("autor", "Autor");
            dgvLibros.Columns.Add("estado", "Estado");

            dgvLibros.Columns["ISBN"].ReadOnly = true;
            dgvLibros.Columns["titulo"].ReadOnly = true;
            dgvLibros.Columns["autor"].ReadOnly = true;
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
            gestionLibros.ISBN = getISBNIfExist();
            gestionLibros.titulo = txtTitulo.Text.Trim();
            gestionLibros.autor = txtAutor.Text.Trim();
            gestionLibros.disponibilidad = cmbEstado.SelectedItem.ToString();
        }
        private int getISBNIfExist()
        {
            if (!txtISBN.Text.Trim().Equals(""))
            {
                if (int.TryParse(txtISBN.Text, out int ISBN))
                {
                    return ISBN;
                }
                else return -1;
            }
            return -1;
        }
        private bool DatosCorrectos()
        {
            if (txtTitulo.Text.Trim().Equals("") || txtAutor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese Todos los datos");
                return false;
            }
            return true;
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvLibros.Columns["btnEditar"].Index)
                {
                    DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                    txtISBN.Text = Convert.ToString(fila.Cells["ISBN"].Value);
                    txtTitulo.Text = Convert.ToString(fila.Cells["titulo"].Value);
                    txtAutor.Text = Convert.ToString(fila.Cells["autor"].Value);
                    cmbEstado.SelectedItem = Convert.ToString(fila.Cells["estado"].Value);
                }
                if (e.ColumnIndex == dgvLibros.Columns["btnEliminar"].Index)
                {
                    int ISBN = Convert.ToInt32(dgvLibros.Rows[e.RowIndex].Cells["ISBN"].Value);

                    consulta.eliminarLibro(ISBN);
                    CargarProductos();
                }
            }
        }
        private void limpiarcampos()
        {
            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            cmbEstado.SelectedItem = "";
        }
        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (!DatosCorrectos())
            {
                return;
            }
            cargarDatosLibros();
            if (consulta.EditLibro(gestionLibros))
            {
                CargarProductos();
            }
        }

        private void Libros_Load(object sender, EventArgs e)
        {

        }

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscador_Enter(object sender, EventArgs e)
        {
            if (txtBuscador.Text == buscador)
            {
                txtBuscador.Text = "";
            }
        }

        private void txtBuscador_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                txtBuscador.Text = buscador;
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscador.Text.Trim());
        }
    }
}

