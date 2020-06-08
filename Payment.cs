using System;

namespace ChapeauModel.Models {
    public class Payment {
        // Properties
        public decimal Tip { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeID { get; set; }
        public int OrderID { get; set; }
        public PaymentMethod Method { get; set; }

        public Payment(decimal tip, decimal price, DateTime dateTime, int employeeID, int orderID, PaymentMethod method) {
            Tip = tip;
            Price = price;
            DateTime = dateTime;
            EmployeeID = employeeID;
            OrderID = orderID;
            Method = method;
        }
    }
}
