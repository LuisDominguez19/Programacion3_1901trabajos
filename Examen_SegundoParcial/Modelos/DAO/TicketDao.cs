using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen_SegundoParcial.Entidades;

namespace Examen_SegundoParcial.Modelos.DAO
{
    public class TicketDao : Conexion
    {
        SqlCommand comando = new SqlCommand();
        public Ticket GetTicket(string codigo)
        {
            Ticket ticket = new Ticket();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT ID FROM TICKET");
                sql.Append("WHERE ID = @id");

                using (MiConexion)
                {
                    MiConexion.Open();
                    using (comando)
                    {
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = sql.ToString();
                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            ticket.ID = (int)dr["ID"];

                        }

                    }

                }
            }
            catch (Exception)
            {
            }
            return ticket;
        }
    
    }
}
