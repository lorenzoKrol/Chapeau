using ChapeauModel.Models;
using ChapeauDAL.DAOs;
using System;

namespace ChapeauLogic.Services {
    public class UserService {
        private UserDAO userDAO = new UserDAO();

        public User GetUser(string email) {
            return userDAO.GetUser(email);
        }

        public void AddUser(User user) {
            userDAO.AddUser(user);
        }

        public void RemoveUser(Employee employee) {
            userDAO.RemoveUser(employee);
        }
    }
}
