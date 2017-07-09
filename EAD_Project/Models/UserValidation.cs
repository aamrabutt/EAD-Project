using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace EAD_Project.Models
{
    public class UserValidation
    {
        public static void VerifyAndReturnData(string email,string pass)
        {
            /*SqlConnection con = DBConnection.getConeection();
            if (con == null)
                return "No Connection";
            else
            {
                try
                {
                    String query = "Select * from Users where User_Email = '" + email + "' and UserPass = '" + pass + "'";
                    SqlCommand com = new SqlCommand(query, con);
                    SqlDataReader de = com.ExecuteReader();
                    if(de.Read())
                    {
                        return de["User_Name"].ToString().Trim()+"User Validated";
                    }
                    else
                    {
                        return "Not Valid User";
                    }
                }
                catch(Exception ex)
                {
                    return ex.Message+"Exception in query run";
                }
            }*/
        }
    }
}