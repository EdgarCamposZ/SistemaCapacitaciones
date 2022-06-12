
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Menu = new Guna.UI2.WinForms.Guna2Panel();
            this.logo = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBarraT = new Guna.UI2.WinForms.Guna2Panel();
            this.lblcargo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PanelSombra = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelEscritorio = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaPictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.iconFormActual = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnCapacitacion = new FontAwesome.Sharp.IconButton();
            this.btnMisiones = new FontAwesome.Sharp.IconButton();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Menu.SuspendLayout();
            this.logo.SuspendLayout();
            this.panelBarraT.SuspendLayout();
            this.PanelEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Menu.Controls.Add(this.btnCerrar);
            this.Menu.Controls.Add(this.btnCapacitacion);
            this.Menu.Controls.Add(this.btnMisiones);
            this.Menu.Controls.Add(this.btnEmpleados);
            this.Menu.Controls.Add(this.btnUsuarios);
            this.Menu.Controls.Add(this.logo);
            this.Menu.Name = "Menu";
            // 
            // logo
            // 
            resources.ApplyResources(this.logo, "logo");
            this.logo.Controls.Add(this.btnInicio);
            this.logo.Name = "logo";
            // 
            // panelBarraT
            // 
            resources.ApplyResources(this.panelBarraT, "panelBarraT");
            this.panelBarraT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.panelBarraT.Controls.Add(this.lblcargo);
            this.panelBarraT.Controls.Add(this.lblnombre);
            this.panelBarraT.Controls.Add(this.lblTitulo);
            this.panelBarraT.Controls.Add(this.iconFormActual);
            this.panelBarraT.Name = "panelBarraT";
            this.panelBarraT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraT_Paint);
            this.panelBarraT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraT_MouseDown);
            // 
            // lblcargo
            // 
            resources.ApplyResources(this.lblcargo, "lblcargo");
            this.lblcargo.ForeColor = System.Drawing.Color.White;
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Click += new System.EventHandler(this.lblcargo_Click);
            // 
            // lblnombre
            // 
            resources.ApplyResources(this.lblnombre, "lblnombre");
            this.lblnombre.ForeColor = System.Drawing.Color.White;
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // PanelSombra
            // 
            resources.ApplyResources(this.PanelSombra, "PanelSombra");
            this.PanelSombra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.PanelSombra.Name = "PanelSombra";
            // 
            // PanelEscritorio
            // 
            resources.ApplyResources(this.PanelEscritorio, "PanelEscritorio");
            this.PanelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.PanelEscritorio.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PanelEscritorio.Controls.Add(this.lblFecha);
            this.PanelEscritorio.Controls.Add(this.lblHora);
            this.PanelEscritorio.Controls.Add(this.gunaPictureBox1);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelEscritorio_Paint);
            // 
            // lblFecha
            // 
            resources.ApplyResources(this.lblFecha, "lblFecha");
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Name = "lblFecha";
            // 
            // lblHora
            // 
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Name = "lblHora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            // 
            // gunaPictureBox1
            // 
            resources.ApplyResources(this.gunaPictureBox1, "gunaPictureBox1");
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.Image = global::SistemaCapacitaciones.Properties.Resources.Logo__2_;
            this.gunaPictureBox1.ImageRotate = 0F;
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.UseTransparentBackground = true;
            // 
            // iconFormActual
            // 
            resources.ApplyResources(this.iconFormActual, "iconFormActual");
            this.iconFormActual.BackColor = System.Drawing.Color.Transparent;
            this.iconFormActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconFormActual.IconColor = System.Drawing.Color.White;
            this.iconFormActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconFormActual.IconSize = 47;
            this.iconFormActual.Name = "iconFormActual";
            this.iconFormActual.TabStop = false;
            this.iconFormActual.Click += new System.EventHandler(this.iconFormActual_Click);
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnCerrar.IconColor = System.Drawing.Color.Lavender;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // btnCapacitacion
            // 
            resources.ApplyResources(this.btnCapacitacion, "btnCapacitacion");
            this.btnCapacitacion.FlatAppearance.BorderSize = 0;
            this.btnCapacitacion.ForeColor = System.Drawing.Color.White;
            this.btnCapacitacion.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnCapacitacion.IconColor = System.Drawing.Color.Lavender;
            this.btnCapacitacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapacitacion.Name = "btnCapacitacion";
            this.btnCapacitacion.UseVisualStyleBackColor = true;
            this.btnCapacitacion.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnMisiones
            // 
            resources.ApplyResources(this.btnMisiones, "btnMisiones");
            this.btnMisiones.FlatAppearance.BorderSize = 0;
            this.btnMisiones.ForeColor = System.Drawing.Color.White;
            this.btnMisiones.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnMisiones.IconColor = System.Drawing.Color.Lavender;
            this.btnMisiones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMisiones.Name = "btnMisiones";
            this.btnMisiones.UseVisualStyleBackColor = true;
            this.btnMisiones.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnEmpleados
            // 
            resources.ApplyResources(this.btnEmpleados, "btnEmpleados");
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnEmpleados.IconColor = System.Drawing.Color.Lavender;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnUsuarios
            // 
            resources.ApplyResources(this.btnUsuarios, "btnUsuarios");
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnUsuarios.IconColor = System.Drawing.Color.Lavender;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnInicio
            // 
            resources.ApplyResources(this.btnInicio, "btnInicio");
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FillColor = System.Drawing.Color.Transparent;
            this.btnInicio.Image = global::SistemaCapacitaciones.Properties.Resources.Logo__2_;
            this.btnInicio.ImageRotate = 0F;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.TabStop = false;
            this.btnInicio.UseTransparentBackground = true;
            this.btnInicio.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelEscritorio);
            this.Controls.Add(this.PanelSombra);
            this.Controls.Add(this.panelBarraT);
            this.Controls.Add(this.Menu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Menu.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.panelBarraT.ResumeLayout(false);
            this.panelBarraT.PerformLayout();
            this.PanelEscritorio.ResumeLayout(false);
            this.PanelEscritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFormActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
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
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}