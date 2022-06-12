using capaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class D_usuario
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_user(E_usuario obje)
        {

            SqlCommand cmd = new SqlCommand("logueo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@clave", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarIdEmpleado()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarIdEmpleado";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.AbrirConexion();
            return Tabla;
        }

        public void AgregarUsuario(int IdEmpleado, string Usuario, string Pass)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AddUsuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            Comando.Parameters.AddWithValue("@Usuario", Usuario);
            Comando.Parameters.AddWithValue("@Pass", Pass);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public DataTable ListarUsuario()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarUsuarios";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.AbrirConexion();
            return Tabla;
        }
        public void EditarUsuario(int IdUsuario, int IdEmpleado, string Usuario, string Pass)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "UpUsuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            Comando.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
            Comando.Parameters.AddWithValue("@Usuario", Usuario);
            Comando.Parameters.AddWithValue("@Pass", Pass);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
            Comando.Parameters.Clear();
        }

        public void EliminarUsuario(int IdUsuario)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "KillUsuario";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
            Comando.Parameters.Clear();
        }

        public DataTable ListarFinanciacion()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarFinanciacion";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.AbrirConexion();
            return Tabla;
        }

        public DataTable ListarModalidad()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarModalidad";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.AbrirConexion();
            return Tabla;
        }

        public void AgregarCapacitacion(int IdUsuario, int IdFinanciacion, int IdModalidad, string Capacitacion, string Descripcion, string EnteFormador, string Estado, string FechaInicio, string FechaFinal, string CantHoras)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AddCapacitacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            Comando.Parameters.AddWithValue("@IdFinanciacion", IdFinanciacion);
            Comando.Parameters.AddWithValue("@IdModalidad", IdModalidad);
            Comando.Parameters.AddWithValue("@Capacitacion", Capacitacion);
            Comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            Comando.Parameters.AddWithValue("@EnteFormador", EnteFormador);
            Comando.Parameters.AddWithValue("@Estado", Estado);
            Comando.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            Comando.Parameters.AddWithValue("@FechaFinal", FechaFinal);
            Comando.Parameters.AddWithValue("@CantHoras", CantHoras);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public DataTable ListarCapacitaciones()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCapacitaciones";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.AbrirConexion();
            return Tabla;
        }

        public void EditarCapacitacion(int IdCapacitacion, int IdUsuario, int IdFinanciacion, int IdModalidad, string Capacitacion, string Descripcion, string EnteFormador, string Estado, string FechaInicio, string FechaFinal, string CantHoras)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "EditarCapacitacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IdCapacitacion", IdCapacitacion);
            Comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            Comando.Parameters.AddWithValue("@IdFinanciacion", IdFinanciacion);
            Comando.Parameters.AddWithValue("@IdModalidad", IdModalidad);
            Comando.Parameters.AddWithValue("@Capacitacion", Capacitacion);
            Comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            Comando.Parameters.AddWithValue("@EnteFormador", EnteFormador);
            Comando.Parameters.AddWithValue("@Estado", Estado);
            Comando.Parameters.AddWithValue("@FechaInicio", FechaInicio);
            Comando.Parameters.AddWithValue("@FechaFinal", FechaFinal);
            Comando.Parameters.AddWithValue("@CantHoras", CantHoras);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public void EliminarCapacitacion(int IdCapacitacion)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "KillCapacitacion";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IdCapacitacion", IdCapacitacion);
            Comando.ExecuteNonQuery();
            Conexion.CerrarConexion();
            Comando.Parameters.Clear();
        }
    }
    
}
