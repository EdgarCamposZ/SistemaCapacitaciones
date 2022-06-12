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

namespace SistemaCapacitaciones.Forms
{
    public partial class FormCapacitaciones : Form
    {
        D_usuario objUsuario = new D_usuario();
        string Operacion = "Insertar";
        string IdCapacitacion;
        public FormCapacitaciones()
        {
            InitializeComponent();
        }

        private void FormCapacitaciones_Load(object sender, EventArgs e)
        {
            ListarUsuario();
            ListarFinanciacion();
            ListarModalidad();
            ListarCapacitaciones();
        }

        private void ListarUsuario()
        {
            D_usuario objprod = new D_usuario();
            cmbIdUsuario.DataSource = objprod.ListarUsuario();
            cmbIdUsuario.DisplayMember = "Usuario";
            cmbIdUsuario.ValueMember = "IdUsuario";
        }

        private void ListarFinanciacion()
        {
            D_usuario objprod = new D_usuario();
            cmbIdFinanciacion.DataSource = objprod.ListarFinanciacion();
            cmbIdFinanciacion.DisplayMember = "Financiacion";
            cmbIdFinanciacion.ValueMember = "IdFinanciacion";
        }

        private void ListarModalidad()
        {
            D_usuario objprod = new D_usuario();
            cmbIdModalidad.DataSource = objprod.ListarModalidad();
            cmbIdModalidad.DisplayMember = "Modalidad";
            cmbIdModalidad.ValueMember = "IdModalidad";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Operacion == "Insertar")
            {
                objUsuario.AgregarCapacitacion(
                    Convert.ToInt32(cmbIdUsuario.SelectedValue),
                    Convert.ToInt32(cmbIdFinanciacion.SelectedValue),
                    Convert.ToInt32(cmbIdModalidad.SelectedValue),
                    txtCapacitacion.Text,
                    txtDescripcion.Text,
                    txtEnte.Text,
                    txtEstado.Text,
                    dtInicio.Value.ToString("yyyyMMdd"),
                    dtFinal.Value.ToString("yyyyMMdd"),
                    txtHoras.Text);
                MessageBox.Show("Insertado Correctamente");
                Operacion = "Insertar";
                txtCapacitacion.Clear();
                txtDescripcion.Clear();
                txtEnte.Clear();
                txtEstado.Clear();
                txtHoras.Clear();
            }
            else if (Operacion == "Editar")
            {
                objUsuario.EditarCapacitacion(
                    Convert.ToInt32(IdCapacitacion),
                    Convert.ToInt32(cmbIdUsuario.SelectedValue),
                    Convert.ToInt32(cmbIdFinanciacion.SelectedValue),
                    Convert.ToInt32(cmbIdModalidad.SelectedValue),
                    txtCapacitacion.Text,
                    txtDescripcion.Text,
                    txtEnte.Text,
                    txtEstado.Text,
                    dtInicio.Value.ToString("yyyyMMdd"),
                    dtFinal.Value.ToString("yyyyMMdd"),
                    txtHoras.Text);
                MessageBox.Show("Editado satisfactoriamente");
                Operacion = "Insertar";
                txtCapacitacion.Clear();
                txtDescripcion.Clear();
                txtEnte.Clear();
                txtEstado.Clear();
                txtHoras.Clear();
            } 
            ListarCapacitaciones();
        }

        private void ListarCapacitaciones()
        {
            dataGridView1.DataSource = objUsuario.ListarCapacitaciones();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operacion = "Editar";
                cmbIdUsuario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmbIdFinanciacion.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbIdModalidad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtCapacitacion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtEnte.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtEstado.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                dtInicio.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                dtFinal.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                txtHoras.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                IdCapacitacion = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else
                MessageBox.Show("Debe seleccionar una fila");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objUsuario.EliminarCapacitacion(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                MessageBox.Show("Se elimino satisfactoriamente");
                ListarCapacitaciones();
                Operacion = "Insertar";
                txtCapacitacion.Clear();
                txtDescripcion.Clear();
                txtEnte.Clear();
                txtEstado.Clear();
                txtHoras.Clear();
            }
            else
                MessageBox.Show("Selecciones una fila");
        }
    }
    
}
