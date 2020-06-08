namespace ChapeauModel.Models {
    public class User {
        // Properties
        public int EmployeeID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int employeeID, string email, string password) {
            EmployeeID = employeeID;
            Email = email;
            Password = password;
        }
    }
}
