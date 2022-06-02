using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class E_usuario
    {
        public String usuario { get; set; }

        public String clave { get; set; }
    }

    public class AddUsuario
    {
        public int IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
    }

}
