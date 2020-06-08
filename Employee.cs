namespace ChapeauModel.Models {
    public class Employee {
        // Properties
        public int EmployeeID { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }

        public Employee(int employeeID, string firstName, string lastName, Position position) {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }
    }
}
