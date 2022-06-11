using SistemaCapacitaciones.Models;
using SistemaCapacitaciones.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCapacitaciones.Presentador
{
    public class EmpleadoPresentacion
    {
        // Campos 

        private EmpleadoVista vistas;
        private EmpleadoRepositorio repositorio_empleado;

        private BindingSource EmpBindingSource;
        private IEnumerable<Empleado> lista_empleados;
        
        // Contrutor
        public EmpleadoPresentacion(EmpleadoVista vistas, EmpleadoRepositorio repositorio_empleado)
            
        {
            this.EmpBindingSource = new BindingSource();
            this.vistas = vistas;
            this.repositorio_empleado = repositorio_empleado;

            // Subcribe los elmentos del metodo 

            this.vistas.BuscarEvebt += BuscarEmpleado;
            this.vistas.NuevoEvent += NuevoEmpleado;
            this.vistas.EditarEvent += EdictarEmpleado;
            this.vistas.EliminarEvent += EleminarEmpleado;
            this.vistas.GuardarEvent += GuardarEmpleado;
            this.vistas.CancelarEvent += CancelarAccion;

            // Establecer la fuente de enlace de empleado

            this.vistas.setEmpleadoListBindingSource(EmpBindingSource);

            // Cargar la lista de Empleado

            CargarListaEmpleado();
            // Show vista

            this.vistas.Show();
            
        }
        // Metodos
        private void CargarListaEmpleado()
        {
            lista_empleados = repositorio_empleado.GetAll();
            EmpBindingSource.DataSource = lista_empleados;
            
           
        }

        private void CancelarAccion(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GuardarEmpleado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EleminarEmpleado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EdictarEmpleado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NuevoEmpleado(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BuscarEmpleado(object sender, EventArgs e)
        {
            bool emtyVaLue = string.IsNullOrEmpty(vistas.BuscarValue);
            if (emtyVaLue == false)
            {
                CargarListaEmpleado();
            }
            else
            {
                lista_empleados = repositorio_empleado.GetByValue(vistas.BuscarValue);
                EmpBindingSource.DataSource = lista_empleados;
            }
        }
    }
}
