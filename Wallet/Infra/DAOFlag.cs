using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Infra
{
    public class DAOFlag : DALWallet
    {
        public DAOFlag() : base()
        {
        }

        public Flag Find(object value)
        {
            return Find("Id", value);
        }

        public Flag Find(String field, object value)
        {
            var sql = "SELECT * FROM Flags WHERE " + field + " = @Value";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);

                cmd.Parameters.AddWithValue("@Value", value);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    return new Flag
                    {
                        Id = Convert.ToInt32(rdr["Id"].ToString()),
                        Name = rdr["Name"].ToString()
                    };
                }
            }
            catch (SqlException e)
            {
                throw new NullReferenceException("Erro ao consultar tabela: " + e.Message);
            }

            return null;
        }
        
        public List<Flag> ListFlags()
        {
            var sql = "SELECT * FROM Flags";

            var flags = new List<Flag>();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    flags.Add(
                        new Flag
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Name = rdr["Name"].ToString()
                        }
                    );
                }
            }
            catch (SqlException e)
            {
                throw new NullReferenceException("Erro ao consultar tabela: " + e.Message);
            }

            return flags;
        }
    }
}
