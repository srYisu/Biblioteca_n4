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
        public Prestamos()
        {
            InitializeComponent();
            ConfigurarTabla();
        }

        private void Prestamos_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarTabla()
        {
            dgvPrestamos.AllowUserToAddRows = false;

            dgvPrestamos.Columns.Add("usuario", "Usuario");
            dgvPrestamos.Columns.Add("titulo", "Titulo");
            dgvPrestamos.Columns.Add("autor", "Autor");
            dgvPrestamos.Columns.Add("ISBN", "ISBN");
            dgvPrestamos.Columns.Add("estado", "Estado");

            dgvPrestamos.Columns["usuario"].ReadOnly = true;
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
    }
}
