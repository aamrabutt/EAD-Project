using Entities;
using DAL;
using System.Collections.Generic;

namespace BAL
{
    public class UserBO
    {
        public static int insert(UserDTO user)
        {
           return DAL.UserDAO.insertUser(user);
        }
        public static int update(UserDTO user)
        {
            return DAL.UserDAO.updateUser(user);
        }
        public static int delete(string email)
        {
            return DAL.UserDAO.deleteUser(email);
        }
        public static UserDTO getByEmail(string email)
        {
            return DAL.UserDAO.getUserByEmail(email);
        }
        public static List<UserDTO> getAll()
        {
            return DAL.UserDAO.getAllUsers();
        }
        public static UserDTO getById(int id)
        {
            return DAL.UserDAO.getUserById(id);
        }
    }
}
