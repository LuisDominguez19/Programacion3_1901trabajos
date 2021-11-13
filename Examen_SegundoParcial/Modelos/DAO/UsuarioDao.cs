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
                sql.Append(" INSERT INTO TIPOM");
                sql.Append(" VALUES (@Tipos,@Precio,@Nombre, @Telefono )");
                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Tipo_Soporte", SqlDbType.NVarChar, 50).Value = user.TipoMantenimiento;
                comando.Parameters.Add("@Nombre", SqlDbType.Int).Value = user.Nombre;
                comando.Parameters.Add("@Precio", SqlDbType.NVarChar, 50).Value = user.Precio;
                comando.Parameters.Add("@Telefono", SqlDbType.Int).Value = user.Telefono;
                comando.ExecuteNonQuery();
                return true;
                MiConexion.Close();
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}