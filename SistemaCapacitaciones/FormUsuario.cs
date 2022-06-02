using capaDatos;
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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void ListarIdEmpleado()
        {
            D_usuario objprod = new D_usuario();
            cmbIdEmpleado.DataSource = objprod.ListarIdEmpleado();
            cmbIdEmpleado.DisplayMember = "IdEmpleado";
            cmbIdEmpleado.ValueMember = "IdEmpleado";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            ListarIdEmpleado();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
