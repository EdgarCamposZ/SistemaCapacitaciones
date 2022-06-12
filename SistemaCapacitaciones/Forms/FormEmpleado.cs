using SistemaCapacitaciones.Vistas;
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
    public partial class FormEmpleado : Form, EmpleadoVista
    {
        private string message;
        private bool isSuccesful;
        private bool isEdictar;

        //Propiedades
        public string Nombre { get { return txtNombre.Text; } set { txtNombre.Text = value; } }
        public string Apellido { get { return txtApellido.Text; } set { txtApellido.Text = value; } }
        public string Direccion { get { return ComboBoxDepartamento.Text; } set { ComboBoxDepartamento.Text = value; } }
        public int FechaNacimiento { get { return Convert.ToInt32(txtNacimento.Text); } set { txtNacimento.Text = value.ToString(); } }
        public int NumCelular { get { return Convert.ToInt32(txtCelular.Text); } set { txtCelular.Text = value.ToString(); } }
        public int DUI { get { return Convert.ToInt32(txtDUI.Text); } set { txtDUI.Text = value.ToString(); } }
        public int NIT { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public int IdEmpleado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IdArea { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IdCargo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public string BuscarValue
        {
            get { return txtBusqueda.Text; }
            set { txtBusqueda.Text = value; }

        }
        public bool IsEdictar
        {
            get { return isEdictar; }
            set { isEdictar = value; }

        }
        public bool IsSuccesful
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public FormEmpleado()
        {
            InitializeComponent();

            AsociarEventosVistas();
            TabControl2.TabPages.Remove(tabPage2);
        }

        private void AsociarEventosVistas()
        {
            bntBusqueda.Click += delegate { BuscarEvebt?.Invoke(this, EventArgs.Empty); };
            txtBusqueda.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter)
                    BuscarEvebt?.Invoke(this, EventArgs.Empty);
            };

        }

        // falta implementar los eventos

        //Eveto
        public event EventHandler BuscarEvebt;
        public event EventHandler NuevoEvent;
        public event EventHandler EditarEvent;
        public event EventHandler EliminarEvent;
        public event EventHandler GuardarEvent;
        public event EventHandler CancelarEvent;




        //Metodos
        public void setEmpleadoListBindingSource(BindingSource empleadoList)
        {
           guna2DataGridView1.DataSource = empleadoList;
        }
    }
}