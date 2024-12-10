﻿using System;
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
        private List<GestionUsuarios> usuarios;
        private ConsultaUsuarios consulta;
        private GestionUsuarios gestionUsuarios;
        public Usuarios()
        {
            usuarios = new List<GestionUsuarios>();
            consulta = new ConsultaUsuarios();
            gestionUsuarios = new GestionUsuarios();
            InitializeComponent();
            CargarTabla();
            CargarUsuarios();
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
        private void CargarUsuarios(string filtro = "")
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Refresh();
            usuarios.Clear();
            usuarios = consulta.GetUsuario(filtro);

            for (int i =0; i<usuarios.Count; i++)
            {
                dgvUsuarios.RowTemplate.Height = 50;
                dgvUsuarios.Rows.Add(
                    usuarios[i].nombre,
                    usuarios[i].id,
                    usuarios[i].tipoUsuario);
                Console.WriteLine("Esta fucnionanado el for");
            }
            Console.WriteLine("Ni idea");
        }
        private void CargarDatosUsuarios()
        {
            gestionUsuarios.nombre = txtNombre.Text;
            gestionUsuarios.id = int.Parse(txtIdentificación.Text);
            gestionUsuarios.tipoUsuario = cmbTipoUsuario.SelectedItem.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarDatosUsuarios();
            if (consulta.AddUsuario(gestionUsuarios))
            {
                MessageBox.Show("Ecsito");
                CargarUsuarios();
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvUsuarios.Columns["btnEditar"].Index)
                {

                }
                if (e.ColumnIndex == dgvUsuarios.Columns["btnEliminar"].Index)
                {
                    int id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["id"].Value);

                    consulta.DeleteUsuario(id);
                    CargarUsuarios();
                }
            }
        }
    }
}
