﻿namespace BibliotecaSegundaEdicion
{
    partial class Prestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbmUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbmLibro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvPrestamos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnGuardarPrestamo = new Guna.UI2.WinForms.Guna2Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblNombrePagina = new System.Windows.Forms.Label();
            this.picLogoPagina = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoDeUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmUsuario
            // 
            this.cbmUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cbmUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmUsuario.ItemHeight = 30;
            this.cbmUsuario.Location = new System.Drawing.Point(68, 163);
            this.cbmUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbmUsuario.Name = "cbmUsuario";
            this.cbmUsuario.Size = new System.Drawing.Size(173, 36);
            this.cbmUsuario.TabIndex = 1;
            // 
            // cbmLibro
            // 
            this.cbmLibro.BackColor = System.Drawing.Color.Transparent;
            this.cbmLibro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmLibro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmLibro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbmLibro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbmLibro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbmLibro.ItemHeight = 30;
            this.cbmLibro.Items.AddRange(new object[] {
            "Disponible",
            "Disponiblen\'t"});
            this.cbmLibro.Location = new System.Drawing.Point(331, 163);
            this.cbmLibro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbmLibro.Name = "cbmLibro";
            this.cbmLibro.Size = new System.Drawing.Size(173, 36);
            this.cbmLibro.TabIndex = 2;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(10)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrestamos.ColumnHeadersHeight = 24;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrestamos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.Location = new System.Drawing.Point(28, 218);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(737, 287);
            this.dgvPrestamos.TabIndex = 5;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPrestamos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPrestamos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrestamos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPrestamos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrestamos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPrestamos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPrestamos.ThemeStyle.HeaderStyle.Height = 24;
            this.dgvPrestamos.ThemeStyle.ReadOnly = true;
            this.dgvPrestamos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPrestamos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrestamos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPrestamos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPrestamos.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPrestamos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPrestamos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.Animated = true;
            this.btnGuardarPrestamo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarPrestamo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardarPrestamo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardarPrestamo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardarPrestamo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnGuardarPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(592, 163);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(173, 36);
            this.btnGuardarPrestamo.TabIndex = 6;
            this.btnGuardarPrestamo.Text = "Guardar";
            this.btnGuardarPrestamo.Click += new System.EventHandler(this.btnGuardarPrestamo_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(65, 129);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 21);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblLibro.Location = new System.Drawing.Point(327, 129);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(48, 21);
            this.lblLibro.TabIndex = 8;
            this.lblLibro.Text = "Libro";
            // 
            // lblNombrePagina
            // 
            this.lblNombrePagina.AutoSize = true;
            this.lblNombrePagina.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePagina.ForeColor = System.Drawing.Color.White;
            this.lblNombrePagina.Location = new System.Drawing.Point(324, 9);
            this.lblNombrePagina.Name = "lblNombrePagina";
            this.lblNombrePagina.Size = new System.Drawing.Size(152, 37);
            this.lblNombrePagina.TabIndex = 11;
            this.lblNombrePagina.Text = "Prestamos";
            // 
            // picLogoPagina
            // 
            this.picLogoPagina.BackColor = System.Drawing.Color.Transparent;
            this.picLogoPagina.Image = global::BibliotecaSegundaEdicion.Properties.Resources.image__6_;
            this.picLogoPagina.ImageRotate = 0F;
            this.picLogoPagina.Location = new System.Drawing.Point(680, 12);
            this.picLogoPagina.Name = "picLogoPagina";
            this.picLogoPagina.Size = new System.Drawing.Size(104, 57);
            this.picLogoPagina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoPagina.TabIndex = 13;
            this.picLogoPagina.TabStop = false;
            this.picLogoPagina.UseTransparentBackground = true;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipoUsuario.Location = new System.Drawing.Point(66, 43);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(123, 21);
            this.lblTipoUsuario.TabIndex = 15;
            this.lblTipoUsuario.Text = "Tipo de usuario";
            // 
            // cmbTipoDeUsuario
            // 
            this.cmbTipoDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoDeUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoDeUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoDeUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipoDeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTipoDeUsuario.ItemHeight = 30;
            this.cmbTipoDeUsuario.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor"});
            this.cmbTipoDeUsuario.Location = new System.Drawing.Point(69, 77);
            this.cmbTipoDeUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoDeUsuario.Name = "cmbTipoDeUsuario";
            this.cmbTipoDeUsuario.Size = new System.Drawing.Size(173, 36);
            this.cmbTipoDeUsuario.TabIndex = 14;
            this.cmbTipoDeUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDeUsuario_SelectedIndexChanged);
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(796, 534);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.cmbTipoDeUsuario);
            this.Controls.Add(this.picLogoPagina);
            this.Controls.Add(this.lblNombrePagina);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnGuardarPrestamo);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.cbmLibro);
            this.Controls.Add(this.cbmUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Prestamos";
            this.Text = "++";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoPagina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbmLibro;
        private Guna.UI2.WinForms.Guna2ComboBox cbmUsuario;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPrestamos;
        private Guna.UI2.WinForms.Guna2Button btnGuardarPrestamo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblNombrePagina;
        private Guna.UI2.WinForms.Guna2PictureBox picLogoPagina;
        private System.Windows.Forms.Label lblTipoUsuario;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoDeUsuario;
    }
}