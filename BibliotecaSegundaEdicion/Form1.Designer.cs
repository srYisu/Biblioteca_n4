namespace BibliotecaSegundaEdicion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlLateral = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlBase = new Guna.UI2.WinForms.Guna2Panel();
            this.pcbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnReportes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPrestamo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLibro = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.pnlLateral.Controls.Add(this.guna2Separator1);
            this.pnlLateral.Controls.Add(this.pcbLogo);
            this.pnlLateral.Controls.Add(this.btnReportes);
            this.pnlLateral.Controls.Add(this.btnPrestamo);
            this.pnlLateral.Controls.Add(this.btnUsuarios);
            this.pnlLateral.Controls.Add(this.btnLibro);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(240, 659);
            this.pnlLateral.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 481);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(216, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // pnlBase
            // 
            this.pnlBase.Location = new System.Drawing.Point(241, 2);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(894, 657);
            this.pnlBase.TabIndex = 1;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.ImageRotate = 0F;
            this.pcbLogo.Location = new System.Drawing.Point(44, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(138, 159);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 4;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.UseTransparentBackground = true;
            this.pcbLogo.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportes.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReportes.FillColor = System.Drawing.Color.Empty;
            this.btnReportes.FillColor2 = System.Drawing.Color.Empty;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnReportes.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnReportes.Image = global::BibliotecaSegundaEdicion.Properties.Resources.carpeta_abierta;
            this.btnReportes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReportes.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReportes.Location = new System.Drawing.Point(0, 401);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(228, 63);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrestamo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrestamo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrestamo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrestamo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrestamo.FillColor = System.Drawing.Color.Empty;
            this.btnPrestamo.FillColor2 = System.Drawing.Color.Empty;
            this.btnPrestamo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnPrestamo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnPrestamo.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnPrestamo.Image = global::BibliotecaSegundaEdicion.Properties.Resources.image__6_;
            this.btnPrestamo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPrestamo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrestamo.Location = new System.Drawing.Point(0, 332);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(228, 63);
            this.btnPrestamo.TabIndex = 2;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.Empty;
            this.btnUsuarios.FillColor2 = System.Drawing.Color.Empty;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnUsuarios.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnUsuarios.Image = global::BibliotecaSegundaEdicion.Properties.Resources.lapiz_de_usuario;
            this.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarios.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsuarios.Location = new System.Drawing.Point(0, 263);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(228, 63);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLibro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLibro.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLibro.FillColor = System.Drawing.Color.Empty;
            this.btnLibro.FillColor2 = System.Drawing.Color.Empty;
            this.btnLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnLibro.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnLibro.Image = global::BibliotecaSegundaEdicion.Properties.Resources.libro_marcador__2_;
            this.btnLibro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLibro.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLibro.Location = new System.Drawing.Point(0, 194);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(228, 63);
            this.btnLibro.TabIndex = 0;
            this.btnLibro.Text = "Libros";
            this.btnLibro.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(1134, 659);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlLateral);
            this.Name = "Form1";
            this.Text = "Biblioteca n4";
            this.pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLateral;
        private Guna.UI2.WinForms.Guna2GradientButton btnLibro;
        private Guna.UI2.WinForms.Guna2GradientButton btnReportes;
        private Guna.UI2.WinForms.Guna2GradientButton btnPrestamo;
        private Guna.UI2.WinForms.Guna2GradientButton btnUsuarios;
        private Guna.UI2.WinForms.Guna2PictureBox pcbLogo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel pnlBase;
    }
}

