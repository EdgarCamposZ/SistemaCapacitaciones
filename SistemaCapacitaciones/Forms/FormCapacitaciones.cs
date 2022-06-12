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
                ListarCapacitaciones();
            }
            /*else if (Operacion == "Editar")
            {
                objUsuario.EditarUsuario(Convert.ToInt32(IdUsuario),
                    Convert.ToInt32(cmbIdEmpleado.SelectedValue),
                    txtUsuario.Text,
                    txtPass.Text);
                MessageBox.Show("Se edito Correctamente");
                Operacion = "Insertar";
                txtUsuario.Clear();
                txtPass.Clear();
            } */
            //ListarCapacitacion();
        }

        private void ListarCapacitaciones()
        {
            dataGridView1.DataSource = objUsuario.ListarCapacitaciones();
        }
    }
    
}
