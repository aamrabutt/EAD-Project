using System;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnection
    {
        public static SqlConnection getConnection()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["myString"].ToString();
            SqlConnection con = new SqlConnection(s);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception)
            {

            }
            return null;
        }
    }
}
