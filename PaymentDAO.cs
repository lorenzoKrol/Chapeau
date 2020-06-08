using ChapeauModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ChapeauDAL.DAOs {
    public class PaymentDAO : Base {
        public void InsertPayment(Payment payment) {
            string query = "INSERT INTO [PAYMENT] " +
                $"VALUES ({(int)payment.Method}, '{payment.Tip}', '{payment.Price}', '{payment.DateTime.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {payment.EmployeeID}, {payment.OrderID})";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}
