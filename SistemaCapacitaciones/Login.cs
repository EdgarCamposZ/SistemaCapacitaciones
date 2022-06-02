using capaEntidad;
using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCapacitaciones
{
    public partial class Login : Form
    {

        E_usuario objeuser = new E_usuario();
        N_usuario objnuser = new N_usuario();
        Principal frm1 = new Principal();

        public static string usuario_nombre;
        public static string area;

        void p_logueo() 
        {

            DataTable dt = new DataTable();
            objeuser.usuario = txtUsuario.Text;
            objeuser.clave = txtPass.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();
                this.Hide();
                frm1.ShowDialog();
                
                Login login = new Login();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());

                txtUsuario.Clear();
                txtPass.Clear();
                


            }
            else 
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Clear();
                txtPass.Clear();
            }

        }

        public Login()
        {
            InitializeComponent();

            //Formulario
            this.Text = string.Empty;
            this.ControlBox = true;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            p_logueo();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
