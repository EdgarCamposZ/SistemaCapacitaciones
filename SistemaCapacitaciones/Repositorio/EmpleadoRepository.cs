using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaCapacitaciones.Models;

namespace SistemaCapacitaciones.Repositorio
{
    public class EmpleadoRepository : BaseRepository, EmpleadoRepositorio
    {
        // contrutor
        public EmpleadoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Empleado> GetAll()
        {
            var emplList = new List<Empleado>();
            using (var connetion = new SqlConnection(connectionString))
            using (var comand = new SqlCommand())
            {
                connetion.Open();
                comand.Connection = connetion;
                comand.CommandText = "Select * from Empleado order by idEmpleado";
                using (var reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var EmpleadoModelo = new Empleado();

                        EmpleadoModelo.IdEmpleado = (int)reader[0];
                        EmpleadoModelo.IdArea = (int)reader[1];
                        EmpleadoModelo.IdCargo = (int)reader[2];
                        EmpleadoModelo.Nombre = reader[3].ToString();
                        EmpleadoModelo.Apellido = reader[4].ToString();
                        EmpleadoModelo.Direccion = reader[5].ToString();
                        EmpleadoModelo.FechaNacimiento = (int)reader[6];
                        EmpleadoModelo.NumCelular = (int)reader[7];
                        EmpleadoModelo._DUI = (int)reader[8];
                        EmpleadoModelo._NIT = (int)reader[9];
                        emplList.Add(EmpleadoModelo);
                        
                        
                    }
                  
                }


            }
            return emplList;
        }
    

            public IEnumerable<Empleado> GetByValue(string value)
        {
            var emplList = new List<Empleado>();

            int emplId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string emplName = value;
            
            using (var connetion = new SqlConnection(connectionString))
            using (var comand = new SqlCommand())
            {
                connetion.Open();
                comand.Connection = connetion;
                comand.CommandText = "Select * from Empleado where idEmpleado=@id or Nombre like @name+'% order by idEmpleado desc";

                comand.Parameters.Add("@id", SqlDbType.Int).Value = emplId;
                comand.Parameters.Add("@name", SqlDbType.Int).Value = emplName;

                using (var reader = comand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var EmpleadoModelo = new Empleado();

                        EmpleadoModelo.IdEmpleado = (int)reader[0];
                        EmpleadoModelo.IdArea = (int)reader[1];
                        EmpleadoModelo.IdCargo = (int)reader[2];
                        EmpleadoModelo.Nombre = reader[3].ToString();
                        EmpleadoModelo.Apellido = reader[4].ToString();
                        EmpleadoModelo.Direccion = reader[5].ToString();
                        EmpleadoModelo.FechaNacimiento = (int)reader[6];
                        EmpleadoModelo.NumCelular = (int)reader[7];
                        EmpleadoModelo._DUI = (int)reader[8];
                        EmpleadoModelo._NIT = (int)reader[9];
                        emplList.Add(EmpleadoModelo);


                    }

                }


            }
            return emplList;
        }
        }


    }

