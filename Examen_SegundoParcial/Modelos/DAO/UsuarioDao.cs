using Examen_SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examen_SegundoParcial.Modelos.DAO
{
    public class UsuarioDao : Conexion
    {
        SqlCommand comando = new SqlCommand();

        //public SqlConnection MiConexion { get; private set; }

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT 1 FROM USUARIO WHERE EMAIL= @Email and CLAVE= @Clave;");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = user.EMAIL;
                comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 80).Value = user.CLAVE;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
                MiConexion.Close();

            }
            catch (Exception)
            {

            }
            return valido;
        }
        public bool RegistrarNuevoUsuario(Usuario user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TIPOS");
                // sql.Append(" SET Tipo_soporte= (@Tipo_soporte,NOMBRE= @NOMBRE, Precio= @Precio, telefono = @Telefono )");
                sql.Append(" VALUES (@Tipo_soporte, @Nombre, @Precio, @Telefono )");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Tipo_soporte", SqlDbType.NVarChar, 50).Value = user.TipoMantenimiento;
                comando.Parameters.Add("@Nombre", SqlDbType.Int).Value = user.Nombre;
                comando.Parameters.Add("@Precio", SqlDbType.NVarChar, 50).Value = user.Precio;
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = user.Telefono;
                comando.ExecuteNonQuery();
                MiConexion.Close();
                return true;
            }
              
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable GetTipos()

        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TipoSoporte");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public bool AgregarEstado(Usuario user)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO USUARIO");
                // sql.Append(" SET Tipo_soporte= (@Tipo_soporte,NOMBRE= @NOMBRE, Precio= @Precio, telefono = @Telefono )");
                sql.Append(" VALUES ( @ID, @NOMBRE, @ESTADO)");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@ID", SqlDbType.NVarChar, 50).Value = user.ID;
                comando.Parameters.Add("@Nombre", SqlDbType.Int).Value = user.Nombre;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 50).Value = user.Estado;
                 
                comando.ExecuteNonQuery();
                MiConexion.Close();
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }


        public DataTable GetEstado()

        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM USUARIO");
                sql.Append(" VALUES ( @ID, @NOMBRE, @ESTADO)");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public DataTable Estado()
        {
            DataTable op = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT *  FROM ESTADO");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                SqlDataReader dr = comando.ExecuteReader();
                op.Load(dr);
            }
            catch (Exception)
            {
            }

            return op;
        }
        public DataTable Detalle()
        {
            DataTable ld = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT *  FROM ESTADO");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();

                SqlDataReader dr = comando.ExecuteReader();
                ld.Load(dr);
            }
            catch (Exception)
            {
            }

            return ld;
        }
    }

}
