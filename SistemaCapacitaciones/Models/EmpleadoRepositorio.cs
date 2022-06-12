using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCapacitaciones.Models
{
    public interface EmpleadoRepositorio
    {
        void Add(Empleado empleado);
        void Edit(Empleado empleado);
        void Delete(int id);

        IEnumerable<Empleado> GetAll();
        IEnumerable<Empleado> GetByValue(string value);



    }
}
