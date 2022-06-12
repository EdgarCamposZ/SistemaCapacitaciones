using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importamos lib FontAwesome.Sharp
using FontAwesome.Sharp;
using SistemaCapacitaciones.Forms;

namespace SistemaCapacitaciones
{
    public partial class Principal : Form
    {
        //campos
        private IconButton actualBtn;
        private Panel izqBorderBtn;
        private Form formHijoActual;

        //constructor
        public Principal()
        {
            InitializeComponent();

            izqBorderBtn = new Panel();
            izqBorderBtn.Size = new Size(8, 47);
            Menu.Controls.Add(izqBorderBtn);
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //estructura

        //metodos
        private void Activarboton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                desactivarboton();
                //boton
                actualBtn = (IconButton)senderBtn;
                actualBtn.BackColor = Color.FromArgb(37, 36, 81);
                actualBtn.ForeColor = color;
                actualBtn.TextAlign = ContentAlignment.MiddleCenter;
                actualBtn.IconColor = color;
                actualBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                actualBtn.ImageAlign = ContentAlignment.MiddleRight;
                //borde izquierdo del boton
                izqBorderBtn.BackColor = color;
                izqBorderBtn.Location = new Point(0, actualBtn.Location.Y);
                izqBorderBtn.Visible = true;
                izqBorderBtn.BringToFront();

                //icono actual de la barra
                iconFormActual.IconChar = actualBtn.IconChar;
                iconFormActual.IconColor = color;
            }
        }

        private void desactivarboton()
        {
            if (actualBtn != null)
            {
                actualBtn.BackColor = Color.FromArgb(21, 90, 123);
                actualBtn.ForeColor = Color.White;
                actualBtn.TextAlign = ContentAlignment.MiddleLeft;
                actualBtn.IconColor = Color.White;
                actualBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                actualBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //formulario hijo
        private void AbrirFormHijo(Form FormHijo)
        {
            if (formHijoActual != null)
            {
                //Abrimos un solo formulario
                formHijoActual.Close();
            }
            formHijoActual = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(FormHijo);
            PanelEscritorio.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            lblTitulo.Text = FormHijo.Text;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Activarboton(sender, Color.FromArgb(184, 197, 245));
            AbrirFormHijo(new FormUsuario());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Activarboton(sender, Color.FromArgb(233, 177, 240));
            AbrirFormHijo(new FormEmpleadoss());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Activarboton(sender, Color.FromArgb(222, 166, 155));
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Activarboton(sender, Color.FromArgb(27, 181, 242));
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            formHijoActual.Close();
            Reset();
        }

        private void Reset()
        {
            desactivarboton();
            izqBorderBtn.Visible = false;
            iconFormActual.IconChar = IconChar.Home;
            iconFormActual.IconColor = Color.FromArgb(192, 255, 255);
            lblTitulo.Text = "Inicio";
        }

        //arrastrar formulario
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarraT_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelEscritorio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //admin
            if (Login.area == "1")

            {
                btnUsuarios.Enabled = true;
                btnEmpleados.Enabled = true;
                btnMisiones.Enabled = true;
                btnCapacitacion.Enabled = true;

                lblcargo.Text = "Administrador";
            }

            //Misiones
            else if (Login.area == "2")

            {
                btnUsuarios.Enabled = false;
                btnEmpleados.Enabled = false;
                btnMisiones.Enabled = true;
                btnCapacitacion.Enabled = false;

                lblcargo.Text = "Misiones";
            }
            //Capacitaciones
            else if (Login.area == "3")

            {
                btnUsuarios.Enabled = false;
                btnEmpleados.Enabled = false;
                btnMisiones.Enabled = false;
                btnCapacitacion.Enabled = true;

                lblcargo.Text = "Capacitaciones";
            }

            lblnombre.Text = Login.usuario_nombre;
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblnombre_Click(object sender, EventArgs e)
        {

        }
    }
}
