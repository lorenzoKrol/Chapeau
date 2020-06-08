using ChapeauModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ChapeauDAL.DAOs {
    public class EmployeeDAO : Base {
        public Employee GetEmployee(int employeeID) {
            string query = "SELECT employee_id, first_name, last_name, position " +
                "FROM [EMPLOYEE] " +
                $"WHERE employee_id = {employeeID}";
            return ReadEmployee(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public void AddEmployee(Employee employee) {
            string query = "INSERT INTO [EMPLOYEE] " +
                $"VALUES({employee.EmployeeID}, '{employee.FirstName}', '{employee.LastName}', {(int)employee.Position})";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void RemoveEmployee(Employee employee) {
            string query = "DELETE FROM [EMPLOYEE] " +
                $"WHERE employee_id = {employee.EmployeeID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public List<Employee> GetAllEmployees() {
            string query = "SELECT employee_id, first_name, last_name, position " +
                "FROM [EMPLOYEE]";
            return ReadEmployees(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        private List<Employee> ReadEmployees(DataTable dataTable) {
            return (from row in dataTable.AsEnumerable()
                    select new Employee(
                        employeeID: (int)row["employee_id"],
                        firstName: (string)row["first_name"],
                        lastName: (string)row["last_name"],
                        position: (Position)row["position"]
                    )).ToList();
        }

        private Employee ReadEmployee(DataTable dataTable) {
            DataRow row = dataTable.Rows[0];
            return new Employee(
                employeeID: (int)row["employee_id"],
                firstName: (string)row["first_name"],
                lastName: (string)row["last_name"],
                position: (Position)row["position"]
            );
        }
    }
}
