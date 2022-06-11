using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SistemaCapacitaciones.Models
{


    public class Empleado
    {



        public int idEmpleado;
        private int idArea;
        private int idCargo;
        private string nombre;
        private string apellido;
        private string direccion;
        private int fechaNacimiento;
        private int numCelular;
        private int DUI;
        private int NIT;


        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public int IdArea
        {
            get { return idArea; }
            set { idArea = value; }
        }

        public int IdCargo
        {
            get { return idCargo; }
            set { idCargo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        [DisplayName("Nombre del empleado")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " El nombre debe tener entre 3 y 50 caracteres")]


        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        [DisplayName("Apellido del empleado")]
        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " El apellido debe tener entre 3 y 50 caracteres")]

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        [DisplayName("Dirección del empleado")]
        [Required(ErrorMessage = "La dirección es requerida")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " La dirección debe tener entre 3 y 50 caracteres")]


        public int FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        [DisplayName("Fecha de nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public int NumCelular
        {
            get { return numCelular; }
            set { numCelular = value; }
        }
        [DisplayName("Número de celular")]
        [Required(ErrorMessage = "El número de celular es requerido")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El número de celular debe tener 10 dígitos")]

        public int _DUI
        {
            get { return DUI; }
            set { DUI = value; }
        }
        [DisplayName("Número de DUI")]
        [Required(ErrorMessage = "El número de DUI es requerido")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El número de DUI debe tener 10 dígitos")]
        public int _NIT
        {
            get { return NIT; }
            set { NIT = value; }
        }
        [DisplayName("Número de NIT")]
        [Required(ErrorMessage = "El número de NIT es requerido")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "El número de NIT debe tener 10 dígitos")]







    }

}


