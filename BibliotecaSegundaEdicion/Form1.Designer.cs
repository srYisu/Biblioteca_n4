﻿namespace BibliotecaSegundaEdicion
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
            this.pnlInvisible = new System.Windows.Forms.Panel();
            this.separatorUp = new Guna.UI2.WinForms.Guna2Separator();
            this.picLogoCentrado = new Guna.UI2.WinForms.Guna2PictureBox();
            this.separatorBajo = new Guna.UI2.WinForms.Guna2Separator();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnReportes = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnPrestamo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLibro = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlBase = new Guna.UI2.WinForms.Guna2Panel();
            this.tgsMostrarContraseña = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.txtContrasena = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.picInicioSesionFoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCentrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInicioSesionFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.pnlLateral.Controls.Add(this.pnlInvisible);
            this.pnlLateral.Controls.Add(this.separatorUp);
            this.pnlLateral.Controls.Add(this.picLogoCentrado);
            this.pnlLateral.Controls.Add(this.separatorBajo);
            this.pnlLateral.Controls.Add(this.picLogo);
            this.pnlLateral.Controls.Add(this.btnReportes);
            this.pnlLateral.Controls.Add(this.btnPrestamo);
            this.pnlLateral.Controls.Add(this.btnUsuarios);
            this.pnlLateral.Controls.Add(this.btnLibro);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(180, 535);
            this.pnlLateral.TabIndex = 0;
            // 
            // pnlInvisible
            // 
            this.pnlInvisible.Location = new System.Drawing.Point(33, 483);
            this.pnlInvisible.Name = "pnlInvisible";
            this.pnlInvisible.Size = new System.Drawing.Size(29, 40);
            this.pnlInvisible.TabIndex = 8;
            // 
            // separatorUp
            // 
            this.separatorUp.Location = new System.Drawing.Point(9, 135);
            this.separatorUp.Margin = new System.Windows.Forms.Padding(2);
            this.separatorUp.Name = "separatorUp";
            this.separatorUp.Size = new System.Drawing.Size(162, 8);
            this.separatorUp.TabIndex = 7;
            // 
            // picLogoCentrado
            // 
            this.picLogoCentrado.BackColor = System.Drawing.Color.Transparent;
            this.picLogoCentrado.Image = global::BibliotecaSegundaEdicion.Properties.Resources.image__3_;
            this.picLogoCentrado.ImageRotate = 0F;
            this.picLogoCentrado.Location = new System.Drawing.Point(33, 203);
            this.picLogoCentrado.Margin = new System.Windows.Forms.Padding(2);
            this.picLogoCentrado.Name = "picLogoCentrado";
            this.picLogoCentrado.Size = new System.Drawing.Size(104, 129);
            this.picLogoCentrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoCentrado.TabIndex = 6;
            this.picLogoCentrado.TabStop = false;
            this.picLogoCentrado.UseTransparentBackground = true;
            // 
            // separatorBajo
            // 
            this.separatorBajo.Location = new System.Drawing.Point(9, 391);
            this.separatorBajo.Margin = new System.Windows.Forms.Padding(2);
            this.separatorBajo.Name = "separatorBajo";
            this.separatorBajo.Size = new System.Drawing.Size(162, 8);
            this.separatorBajo.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::BibliotecaSegundaEdicion.Properties.Resources.image__3_;
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(33, 2);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(104, 129);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 4;
            this.picLogo.TabStop = false;
            this.picLogo.UseTransparentBackground = true;
            this.picLogo.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Animated = true;
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
            this.btnReportes.Location = new System.Drawing.Point(0, 326);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(171, 51);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Animated = true;
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
            this.btnPrestamo.Location = new System.Drawing.Point(0, 270);
            this.btnPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(171, 51);
            this.btnPrestamo.TabIndex = 2;
            this.btnPrestamo.Text = "Prestamo";
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Animated = true;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.Empty;
            this.btnUsuarios.FillColor2 = System.Drawing.Color.Empty;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnUsuarios.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnUsuarios.Image = global::BibliotecaSegundaEdicion.Properties.Resources.lapiz_de_usuario;
            this.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsuarios.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsuarios.Location = new System.Drawing.Point(0, 214);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(171, 51);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Animated = true;
            this.btnLibro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLibro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLibro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLibro.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLibro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLibro.FillColor = System.Drawing.Color.Empty;
            this.btnLibro.FillColor2 = System.Drawing.Color.Empty;
            this.btnLibro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLibro.ForeColor = System.Drawing.Color.White;
            this.btnLibro.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnLibro.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.btnLibro.Image = global::BibliotecaSegundaEdicion.Properties.Resources.libro_marcador__2_;
            this.btnLibro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLibro.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLibro.Location = new System.Drawing.Point(0, 158);
            this.btnLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(171, 51);
            this.btnLibro.TabIndex = 0;
            this.btnLibro.Text = "Libros";
            this.btnLibro.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // pnlBase
            // 
            this.pnlBase.Controls.Add(this.tgsMostrarContraseña);
            this.pnlBase.Controls.Add(this.btnIniciarSesion);
            this.pnlBase.Controls.Add(this.txtContrasena);
            this.pnlBase.Controls.Add(this.txtUsuario);
            this.pnlBase.Controls.Add(this.picInicioSesionFoto);
            this.pnlBase.Location = new System.Drawing.Point(183, 2);
            this.pnlBase.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(796, 534);
            this.pnlBase.TabIndex = 1;
            // 
            // tgsMostrarContraseña
            // 
            this.tgsMostrarContraseña.Animated = true;
            this.tgsMostrarContraseña.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.tgsMostrarContraseña.CheckedState.BorderRadius = 11;
            this.tgsMostrarContraseña.CheckedState.BorderThickness = 2;
            this.tgsMostrarContraseña.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.tgsMostrarContraseña.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgsMostrarContraseña.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgsMostrarContraseña.Location = new System.Drawing.Point(470, 340);
            this.tgsMostrarContraseña.Name = "tgsMostrarContraseña";
            this.tgsMostrarContraseña.Size = new System.Drawing.Size(53, 24);
            this.tgsMostrarContraseña.TabIndex = 8;
            this.tgsMostrarContraseña.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.tgsMostrarContraseña.UncheckedState.BorderRadius = 11;
            this.tgsMostrarContraseña.UncheckedState.BorderThickness = 2;
            this.tgsMostrarContraseña.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgsMostrarContraseña.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgsMostrarContraseña.UncheckedState.InnerBorderRadius = 7;
            this.tgsMostrarContraseña.UncheckedState.InnerBorderThickness = 2;
            this.tgsMostrarContraseña.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tgsMostrarContraseña.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Animated = true;
            this.btnIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniciarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(133)))), ((int)(((byte)(48)))));
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(322, 389);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(201, 45);
            this.btnIniciarSesion.TabIndex = 7;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContrasena.DefaultText = "";
            this.txtContrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtContrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContrasena.Location = new System.Drawing.Point(322, 287);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(7);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '\0';
            this.txtContrasena.PlaceholderText = "";
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.Size = new System.Drawing.Size(201, 43);
            this.txtContrasena.TabIndex = 6;
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.Location = new System.Drawing.Point(322, 232);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(201, 43);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // picInicioSesionFoto
            // 
            this.picInicioSesionFoto.Image = ((System.Drawing.Image)(resources.GetObject("picInicioSesionFoto.Image")));
            this.picInicioSesionFoto.ImageRotate = 0F;
            this.picInicioSesionFoto.Location = new System.Drawing.Point(271, 29);
            this.picInicioSesionFoto.Name = "picInicioSesionFoto";
            this.picInicioSesionFoto.Size = new System.Drawing.Size(313, 195);
            this.picInicioSesionFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInicioSesionFoto.TabIndex = 4;
            this.picInicioSesionFoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(979, 535);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Biblioteca n4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCentrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInicioSesionFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLateral;
        private Guna.UI2.WinForms.Guna2GradientButton btnLibro;
        private Guna.UI2.WinForms.Guna2GradientButton btnReportes;
        private Guna.UI2.WinForms.Guna2GradientButton btnPrestamo;
        private Guna.UI2.WinForms.Guna2GradientButton btnUsuarios;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Separator separatorBajo;
        private Guna.UI2.WinForms.Guna2Panel pnlBase;
        private Guna.UI2.WinForms.Guna2PictureBox picLogoCentrado;
        private Guna.UI2.WinForms.Guna2Separator separatorUp;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2TextBox txtContrasena;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2PictureBox picInicioSesionFoto;
        private System.Windows.Forms.Panel pnlInvisible;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgsMostrarContraseña;
    }
}

