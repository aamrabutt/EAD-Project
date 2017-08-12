using System;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {

        public static SqlDataReader ReaderQuery(string query)
        {
            try
            {
                SqlConnection c = DBConnection.getConnection();
                SqlCommand com = new SqlCommand(query, c);
                SqlDataReader dr = com.ExecuteReader();
                //c.Close();
                return dr;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static int NonQuery(string query)
        {
            try
            {
                SqlConnection c = DBConnection.getConnection();
                 SqlCommand com = new SqlCommand(query, c);
                
                int res= com.ExecuteNonQuery();
                c.Close();
                if (res > 0)
                    return res;
                else
                    return -1;
                
            }
            catch (Exception ex)
            {
                return -999;
            }
        }
        public static object ScalarQuery(string query)
        {
            try
            {
                SqlConnection c = DBConnection.getConnection();
                SqlCommand com = new SqlCommand(query, c);
                c.Close();
                return com.ExecuteScalar();
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
