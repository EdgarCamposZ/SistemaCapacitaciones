
namespace SistemaCapacitaciones
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.Menu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnCapacitacion = new FontAwesome.Sharp.IconButton();
            this.btnMisiones = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.logo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnInicio = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelBarraT = new Guna.UI2.WinForms.Guna2Panel();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.iconFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.PanelSombra = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelEscritorio = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelBarraT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormActual)).BeginInit();
            this.PanelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(123)))));
            this.Menu.Controls.Add(this.btnCerrar);
            this.Menu.Controls.Add(this.btnCapacitacion);
            this.Menu.Controls.Add(this.btnMisiones);
            this.Menu.Controls.Add(this.btnEmpleados);
            this.Menu.Controls.Add(this.btnUsuarios);
            this.Menu.Controls.Add(this.logo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(203, 450);
            this.Menu.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCerrar.IconColor = System.Drawing.Color.Lavender;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(0, 306);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCerrar.Size = new System.Drawing.Size(203, 47);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar sesión";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // btnCapacitacion
            // 
            this.btnCapacitacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCapacitacion.FlatAppearance.BorderSize = 0;
            this.btnCapacitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacitacion.ForeColor = System.Drawing.Color.White;
            this.btnCapacitacion.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnCapacitacion.IconColor = System.Drawing.Color.Lavender;
            this.btnCapacitacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapacitacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapacitacion.Location = new System.Drawing.Point(0, 259);
            this.btnCapacitacion.Name = "btnCapacitacion";
            this.btnCapacitacion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCapacitacion.Size = new System.Drawing.Size(203, 47);
            this.btnCapacitacion.TabIndex = 4;
            this.btnCapacitacion.Text = "Capacitaciones";
            this.btnCapacitacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapacitacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapacitacion.UseVisualStyleBackColor = true;
            this.btnCapacitacion.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnMisiones
            // 
            this.btnMisiones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisiones.FlatAppearance.BorderSize = 0;
            this.btnMisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisiones.ForeColor = System.Drawing.Color.White;
            this.btnMisiones.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnMisiones.IconColor = System.Drawing.Color.Lavender;
            this.btnMisiones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisiones.Location = new System.Drawing.Point(0, 212);
            this.btnMisiones.Name = "btnMisiones";
            this.btnMisiones.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMisiones.Size = new System.Drawing.Size(203, 47);
            this.btnMisiones.TabIndex = 3;
            this.btnMisiones.Text = "Misiones";
            this.btnMisiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMisiones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMisiones.UseVisualStyleBackColor = true;
            this.btnMisiones.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmpleados.IconColor = System.Drawing.Color.Lavender;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 165);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(203, 47);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUsuarios.IconColor = System.Drawing.Color.Lavender;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 118);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(203, 47);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // logo
            // 
            this.logo.Controls.Add(this.btnInicio);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(203, 118);
            this.logo.TabIndex = 1;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::SistemaCapacitaciones.Properties.Resources.Logo;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(203, 129);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // panelBarraT
            // 
            this.panelBarraT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(123)))));
            this.panelBarraT.Controls.Add(this.lblcargo);
            this.panelBarraT.Controls.Add(this.lblnombre);
            this.panelBarraT.Controls.Add(this.lblTitulo);
            this.panelBarraT.Controls.Add(this.iconFormActual);
            this.panelBarraT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraT.Location = new System.Drawing.Point(203, 0);
            this.panelBarraT.Name = "panelBarraT";
            this.panelBarraT.Size = new System.Drawing.Size(597, 75);
            this.panelBarraT.TabIndex = 1;
            this.panelBarraT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraT_MouseDown);
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargo.ForeColor = System.Drawing.Color.White;
            this.lblcargo.Location = new System.Drawing.Point(429, 41);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(64, 24);
            this.lblcargo.TabIndex = 3;
            this.lblcargo.Text = "Cargo";
            this.lblcargo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Location = new System.Drawing.Point(427, 9);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(82, 24);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Location = new System.Drawing.Point(70, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Inicio";
            // 
            // iconFormActual
            // 
            this.iconFormActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(123)))));
            this.iconFormActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconFormActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormActual.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormActual.IconSize = 47;
            this.iconFormActual.Location = new System.Drawing.Point(17, 14);
            this.iconFormActual.Name = "iconFormActual";
            this.iconFormActual.Size = new System.Drawing.Size(47, 51);
            this.iconFormActual.TabIndex = 0;
            this.iconFormActual.TabStop = false;
            // 
            // PanelSombra
            // 
            this.PanelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(90)))), ((int)(((byte)(123)))));
            this.PanelSombra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSombra.Location = new System.Drawing.Point(203, 75);
            this.PanelSombra.Name = "PanelSombra";
            this.PanelSombra.Size = new System.Drawing.Size(597, 9);
            this.PanelSombra.TabIndex = 2;
            // 
            // PanelEscritorio
            // 
            this.PanelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(83)))), ((int)(((byte)(105)))));
            this.PanelEscritorio.Controls.Add(this.lblFecha);
            this.PanelEscritorio.Controls.Add(this.lblHora);
            this.PanelEscritorio.Controls.Add(this.gunaPictureBox1);
            this.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEscritorio.Location = new System.Drawing.Point(203, 84);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Size = new System.Drawing.Size(597, 366);
            this.PanelEscritorio.TabIndex = 3;
            this.PanelEscritorio.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelEscritorio_Paint);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(278, 314);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 24);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(278, 290);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(56, 24);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox1.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::SistemaCapacitaciones.Properties.Resources.Logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(155, 65);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(314, 211);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelEscritorio);
            this.Controls.Add(this.PanelSombra);
            this.Controls.Add(this.panelBarraT);
            this.Controls.Add(this.Menu);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Menu.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelBarraT.ResumeLayout(false);
            this.panelBarraT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormActual)).EndInit();
            this.PanelEscritorio.ResumeLayout(false);
            this.PanelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Menu;
        private Guna.UI2.WinForms.Guna2Panel logo;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnCapacitacion;
        private FontAwesome.Sharp.IconButton btnMisiones;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private Guna.UI2.WinForms.Guna2PictureBox btnInicio;
        private Guna.UI2.WinForms.Guna2Panel panelBarraT;
        private System.Windows.Forms.Label lblTitulo;
        private FontAwesome.Sharp.IconPictureBox iconFormActual;
        private Guna.UI2.WinForms.Guna2Panel PanelSombra;
        private Guna.UI2.WinForms.Guna2Panel PanelEscritorio;
        private Guna.UI2.WinForms.Guna2PictureBox gunaPictureBox1;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}