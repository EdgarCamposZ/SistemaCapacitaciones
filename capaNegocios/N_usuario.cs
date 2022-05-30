using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class N_usuario
    {
        D_usuario objd = new D_usuario();

        public DataTable N_user(E_usuario obje)
        {
            return objd.D_user(obje);
        }
    }
}
