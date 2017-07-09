using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using System;

namespace DAL
{
    public static class UserDAO
    {
        public static int insertUser(UserDTO user)
        {
            string query = "Insert into Shopify_Users (First_Name,Last_Name,Email,Phone,Password,Address,Gender,Country,IsActive,Picture) Values ('" + user.fName + "','" + user.lName + "','" + user.email + "','" + user.phone + "','" + user.password + "','" + user.address + "','" + user.gender + "','" + user.country + "'," + 1 + ", 'admin.png' )";
            int res = DAL.DBHelper.NonQuery(query);
            if (res > 0)
                return getUserByEmail(user.email).Id;
            return res;
        }
        public static int updateUser(UserDTO user)
        {
            string query = "Update Shopify_Users set First_Name='" + user.fName + "',Last_Name='" + user.lName + "',Phone='" + user.phone + "',Password='" + user.password + "',Address='" + user.address + "',Country='" + user.country + "',IsActive=" + 1 + ",Picture='" + user.pic + "' where email= '" + user.email + "'";
            int res = DAL.DBHelper.NonQuery(query);
            return res;
        }
        public static int deleteUser(string email)
        {
            string query = "Update Shopify_Users set IsActive=" + 0 + " where email= '" + email + "'";
            int res = DAL.DBHelper.NonQuery(query);
            return 0;
        }
        public static List<UserDTO> getAllUsers()
        {
            List<UserDTO> u = new List<UserDTO>();
            string query = "Select * from Shopify_Users where IsActive = " + 1;
            SqlDataReader res = DAL.DBHelper.ReaderQuery(query);
            while (res.Read())
            {
                UserDTO user = new UserDTO();
                user.Id = Convert.ToInt32(res["User_Id"].ToString().Trim());
                user.fName = res["First_Name"].ToString().Trim();
                user.lName = res["Last_Name"].ToString().Trim();
                user.email = res["Email"].ToString().Trim();
                user.phone = res["Phone"].ToString().Trim();
                user.password = res["Password"].ToString().Trim();
                user.address = res["Address"].ToString().Trim();
                user.gender = res["Gender"].ToString().Trim();
                user.country = res["Country"].ToString().Trim();
                user.pic = res["Picture"].ToString().Trim();
                u.Add(user);
            }
            return u;
        }
        public static UserDTO getUserByEmail(string email)
        {
            UserDTO u = new UserDTO();
            string query = "Select * from Shopify_Users where Email = '" + email + "'";
            SqlDataReader res = DAL.DBHelper.ReaderQuery(query);
            if (res.Read())
            {
                u.Id = Convert.ToInt32(res["User_Id"].ToString().Trim());
                u.fName = res["First_Name"].ToString().Trim();
                u.lName = res["Last_Name"].ToString().Trim();
                u.email = res["Email"].ToString().Trim();
                u.phone = res["Phone"].ToString().Trim();
                u.password = res["Password"].ToString().Trim();
                u.address = res["Address"].ToString().Trim();
                u.gender = res["Gender"].ToString().Trim();
                u.country = res["Country"].ToString().Trim();
                u.pic = res["Picture"].ToString().Trim();
                return u;
            }
            return null;
        }
        public static UserDTO getUserById(int id)
        {
            UserDTO u = new UserDTO();
            string query = "Select * from Shopify_Users where User_Id = '" + id + "'";
            SqlDataReader res = DAL.DBHelper.ReaderQuery(query);
            if (res.Read())
            {
                u.Id = Convert.ToInt32(res["User_Id"].ToString().Trim());
                u.fName = res["First_Name"].ToString().Trim();
                u.lName = res["Last_Name"].ToString().Trim();
                u.email = res["Email"].ToString().Trim();
                u.phone = res["Phone"].ToString().Trim();
                u.password = res["Password"].ToString().Trim();
                u.address = res["Address"].ToString().Trim();
                u.gender = res["Gender"].ToString().Trim();
                u.country = res["Country"].ToString().Trim();
                u.pic = res["Picture"].ToString().Trim();
                return u;
            }
            return null;
        }
    }
}
