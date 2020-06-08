using ChapeauModel.Models;
using ChapeauDAL.DAOs;
using System;
using System.Collections.Generic;

namespace ChapeauLogic.Services {
    public class EmployeeService {
        EmployeeDAO employeeDAO = new EmployeeDAO();

        public Employee GetEmployee(int employeeID) {
            return employeeDAO.GetEmployee(employeeID);
        }

        public void AddEmployee(Employee employee) {
            employeeDAO.AddEmployee(employee);
        }

        public List<Employee> GetAllEmployees() {
            return employeeDAO.GetAllEmployees();
        }

        public void RemoveEmployee(Employee employee) {
            employeeDAO.RemoveEmployee(employee);
        }
    }
}
