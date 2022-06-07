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
        D_usuario objUsuario = new D_usuario();
        string Operacion = "Insertar";
        string IdUsuario;

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

        private void ListarUsuarios()
        {
            dataGridView1.DataSource = objUsuario.ListarUsuario();
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
            ListarUsuarios();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objUsuario.AgregarUsuario(
                    Convert.ToInt32(cmbIdEmpleado.SelectedValue),
                    txtUsuario.Text,
                    txtPass.Text);
                MessageBox.Show("Insertado Correctamente");
                Operacion = "Insertar";
                txtUsuario.Clear();
                txtPass.Clear();
            }
            else if (Operacion == "Editar")
            {
                objUsuario.EditarUsuario(Convert.ToInt32(IdUsuario),
                    Convert.ToInt32(cmbIdEmpleado.SelectedValue),
                    txtUsuario.Text,
                    txtPass.Text);
                MessageBox.Show("Se edito Correctamente");
                Operacion = "Insertar";
                txtUsuario.Clear();
                txtPass.Clear();
            }
            ListarUsuarios();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                cmbIdEmpleado.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtUsuario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtPass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                IdUsuario = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("Debe seleccionar una fila");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objUsuario.EliminarUsuario(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarUsuarios();
                Operacion = "Insertar";
                txtUsuario.Clear();
                txtPass.Clear();
            }
            else
                MessageBox.Show("Selecciones una fila");
        }
    }
}
