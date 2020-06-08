using ChapeauModel.Models;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL.DAOs {
    public class UserDAO : Base {
        public User GetUser(string email) {
            string query = "SELECT email, user_password, employee_id " +
                "FROM [USER] " +
                $"WHERE email LIKE '{email}'";
            return ReadUser(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public void RemoveUser(Employee employee) {
            string query = "DELETE FROM [USER] " +
                $"WHERE employee_id = {employee.EmployeeID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void AddUser(User user) {
            string query = "INSERT INTO [USER] " +
                $"VALUES('{user.Email}', '{user.Password}', {user.EmployeeID})";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        private User ReadUser(DataTable dataTable) {
            DataRow row = dataTable.Rows[0];
            return new User(
                employeeID: (int)row["employee_id"],
                email: (string)row["email"],
                password: (string)row["user_password"]
            );
        }
    }
}
