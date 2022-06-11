using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCapacitaciones.Vistas
{
    public interface EmpleadoVista
    {

        //Propiedades
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Direccion { get; set; }
        int FechaNacimiento { get; set; }
        int NumCelular { get; set; }
        int DUI { get; set; }
        int NIT { get; set; }
        int IdEmpleado { get; set; }
        int IdArea { get; set; }
        int IdCargo { get; set; }

        string BuscarValue { get; set; }
        bool IsEdictar { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }


        //Eventos

        event EventHandler BuscarEvebt;
        event EventHandler NuevoEvent;
        event EventHandler EditarEvent;
        event EventHandler EliminarEvent;
        event EventHandler GuardarEvent;
        event EventHandler CancelarEvent;

        //Metodos

        void setEmpleadoListBindingSource(BindingSource empleadoList);
        void Show();





    }
}
