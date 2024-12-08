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
        public Libros()
        {
            InitializeComponent();
            configurarTabla();
            // Deshabilitar la capacidad de mover el formulario
            this.FormBorderStyle = FormBorderStyle.None; // Sin borde
            this.TopLevel = false; // Importante para ser embebido en el Panel
            this.Dock = DockStyle.Fill; // Ajustar al contenedor
            this.AutoScaleMode = AutoScaleMode.None;
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
    }
}
