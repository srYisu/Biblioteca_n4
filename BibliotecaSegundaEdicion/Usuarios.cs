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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvUsuarios.AllowUserToAddRows = false;

            dgvUsuarios.Columns.Add("nombre" , "Nombre");
            dgvUsuarios.Columns.Add("id", "Identificacion");
            dgvUsuarios.Columns.Add("tipo", "Tipo");

            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.HeaderText = "Editar";
            btnEditar.Name = "btnEditar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvUsuarios.Columns.Add(btnEditar);

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvUsuarios.Columns.Add(btnEliminar);
        }
    }
}
