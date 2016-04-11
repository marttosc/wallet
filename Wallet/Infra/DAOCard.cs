using Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Infra
{
    public class DAOCard : DALWallet
    {
        public DAOCard() : base()
        {
        }

        public List<Card> ListCardsByUser(User user)
        {
            List<Card> cards = new List<Card>();

            var sql = "SELECT * FROM Cards WHERE Owner = @Owner";

            SqlDataReader rdr = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);
                cmd.Parameters.AddWithValue("@Owner", user.Id);

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cards.Add(
                        new Card
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Owner = user,
                            Flag = new DAOFlag().Find(rdr["Flag"]),
                            Number = rdr["Number"].ToString(),
                            ExpireMonth = Convert.ToInt32(rdr["ExpireMonth"]),
                            ExpireYear = Convert.ToInt32(rdr["ExpireYear"]),
                            Cvc = rdr["Cvc"].ToString(),
                            Limit = Convert.ToDouble(rdr["Limit"]),
                            CreatedAt = Convert.ToDateTime(rdr["CreatedAt"])
                        }
                    );
                }
            }
            catch (SqlException e)
            {
                throw new NullReferenceException("Erro ao consultar tabela: " + e.Message);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }

            return cards;
        }

        public List<Card> FilterCardsByUser(User user, String column, Object value)
        {
            List<Card> cards = new List<Card>();

            var sql = "SELECT * FROM Cards WHERE Owner = @Owner AND " + column + " LIKE @Value";

            SqlDataReader rdr = null;

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);
                cmd.Parameters.AddWithValue("@Owner", user.Id);
                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cards.Add(
                        new Card
                        {
                            Id = Convert.ToInt32(rdr["Id"]),
                            Owner = user,
                            Flag = new DAOFlag().Find(rdr["Flag"]),
                            Number = rdr["Number"].ToString(),
                            ExpireMonth = Convert.ToInt32(rdr["ExpireMonth"]),
                            ExpireYear = Convert.ToInt32(rdr["ExpireYear"]),
                            Cvc = rdr["Cvc"].ToString(),
                            Limit = Convert.ToDouble(rdr["Limit"]),
                            CreatedAt = Convert.ToDateTime(rdr["CreatedAt"])
                        }
                    );
                }
            }
            catch (SqlException e)
            {
                throw new NullReferenceException("Erro ao consultar tabela: " + e.Message);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
            }

            return cards;
        }

        public Boolean Save(Card card)
        {
            String sql = "INSERT INTO Cards (Owner, Flag, Number, ExpireMonth, ExpireYear, " +
                            "Cvc, Limit, CreatedAt) VALUES (" +
                            "@Owner, @Flag, @Number, @ExpireMonth, @ExpireYear, @Cvc, @Limit, " +
                            "@CreatedAt); SELECT SCOPE_IDENTITY()";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);

                cmd.Parameters.AddWithValue("@Owner", card.Owner.Id);
                cmd.Parameters.AddWithValue("@Flag", card.Flag.Id);
                cmd.Parameters.AddWithValue("@Number", card.Number);
                cmd.Parameters.AddWithValue("@ExpireMonth", card.ExpireMonth);
                cmd.Parameters.AddWithValue("@ExpireYear", card.ExpireYear);
                cmd.Parameters.AddWithValue("@Cvc", card.Cvc);
                cmd.Parameters.AddWithValue("@Limit", card.Limit);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                card.Id = Decimal.ToInt32((Decimal)cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }

            return true;
        }

        public Boolean Update(Card card)
        {
            String sql = "UPDATE Cards SET Flag = @Flag, ExpireMonth = @ExpireMonth, " +
                            "ExpireYear = @ExpireYear, Cvc = @Cvc, Limit = @Limit WHERE Id = @Id";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, base.SqlConn);

                cmd.Parameters.AddWithValue("@Flag", card.Flag.Id);
                cmd.Parameters.AddWithValue("@ExpireMonth", card.ExpireMonth);
                cmd.Parameters.AddWithValue("@ExpireYear", card.ExpireYear);
                cmd.Parameters.AddWithValue("@Cvc", card.Cvc);
                cmd.Parameters.AddWithValue("@Limit", card.Limit);
                cmd.Parameters.AddWithValue("@Id", card.Id);

                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }
    }
}
