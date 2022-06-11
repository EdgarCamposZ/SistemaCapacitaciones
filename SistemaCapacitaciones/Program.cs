using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaCapacitaciones.Models;
using SistemaCapacitaciones.Presentador;
using SistemaCapacitaciones.Repositorio;
using SistemaCapacitaciones.Vistas;
using System.Configuration;


namespace SistemaCapacitaciones
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            // Inicializar Empleado
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            EmpleadoVista vistas = new EmpleadoVista();

            EmpleadoRepository repository = new EmpleadoRepository(sqlConnectionString);
            new EmpleadoPresentacion(vistas, repository);
            
            
            

        }
    }
}
