using System;
using System.Data.SqlClient;

namespace Infra
{
    public class DALWallet
    {
        protected String StrConn { get; set; }
        protected SqlConnection SqlConn { get; set; }

        public DALWallet()
        {
            StrConn = Properties.Default.DB;

            try
            {
                SqlConn = new SqlConnection(StrConn);

                SqlConn.Open();
            }
            catch (SqlException e)
            {
                throw new NullReferenceException("Banco de dados não encontrado: " + e.Message);
            }
        }
    }
}
