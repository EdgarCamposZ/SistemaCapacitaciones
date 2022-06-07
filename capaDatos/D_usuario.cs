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
    }
    
}
