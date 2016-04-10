using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public class DAOUser : DALWallet
    {
        public DAOUser() : base()
        {
        }

        public User Find(String value)
        {
            return Find("Cpf", value);
        }

        public User Find(String field, String value)
        {
            var sql = "SELECT * FROM Users WHERE " + field + " = @Value";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);

                cmd.Parameters.AddWithValue("@Value", value);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   return new User
                    {
                        Id = Convert.ToInt32(rdr["Id"].ToString()),
                        Name = rdr["Name"].ToString(),
                        Cpf = rdr["Cpf"].ToString(),
                        Birthdate = Convert.ToDateTime(rdr["Birthdate"]),
                        Email = rdr["Email"].ToString(),
                        Income = Convert.ToDouble(rdr["Income"]),
                        Address = rdr["Address"].ToString(),
                        CreatedAt = Convert.ToDateTime(rdr["CreatedAt"])
                    };
                }
            }
            catch (SqlException e)
            {
                throw new NullReferenceException("Erro ao consultar tabela: " + e.Message);
            }
            finally
            {
                base.SqlConn.Close();
            }

            return null;
        }

        public User DoLogin(String cpf, String password)
        {
            password = Helper.Encrypt(password);

            var sql = "SELECT Password FROM Users WHERE Cpf = @Cpf";

            try
            {
                bool find = false;

                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);

                cmd.Parameters.AddWithValue("@Cpf", cpf);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (password.Equals(rdr["Password"].ToString())) {
                        find = true;
                        break;
                    }
                }

                if (find)
                {
                    rdr.Close();

                    return Find(cpf);
                }
            }
            catch (SqlException e)
            {
                throw new NullReferenceException("Erro ao consultar tabela: " + e.Message);
            }
            finally
            {
                base.SqlConn.Close();
            }

            return null;
        }

        public Boolean Save(User user)
        {
            String sql = "INSERT INTO Users (Name, Cpf, Birthdate, Email, " +
                            "Password, Income, Address, CreatedAt) VALUES (" +
                            "@Name, @Cpf, @Birthdate, @Email, @Password, @Income, @Address, " +
                            "@CreatedAt); SELECT SCOPE_IDENTITY()";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);

                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Cpf", user.Cpf);
                cmd.Parameters.AddWithValue("@Birthdate", user.Birthdate);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", Helper.Encrypt(user.Password));
                cmd.Parameters.AddWithValue("@Income", user.Income);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                user.Id = Decimal.ToInt32((Decimal)cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
            finally
            {
                base.SqlConn.Close();
            }

            return true;
        }
    }
}
