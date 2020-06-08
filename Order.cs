using System.Collections.Generic;

namespace ChapeauModel.Models {
    public class Order {
        // Identity 
        public int OrderID { get; set; }
        // Properties   
        public Table Table { get; set; }
        public Employee Employee { get; set; }
        public string Feedback { get; set; }
        // Order items
        public List<OrderItem> OrderItems { get; set; }

        public Order(int orderID, Table table, Employee employee) {
            OrderID = orderID;  
            Table = table;
            Employee = employee;

            OrderItems = new List<OrderItem>();
        }
    }
}
