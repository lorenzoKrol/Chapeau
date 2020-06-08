using ChapeauModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ChapeauDAL.DAOs {
    public class OrderDAO : Base {
        TableDAO tableDAO = new TableDAO();
        EmployeeDAO employeeDAO = new EmployeeDAO();
        OrderItemDAO orderItemDAO = new OrderItemDAO();

        public Order CreateOrder(Table table, Employee employee) {
            string query = "INSERT INTO [ORDER] " +
                $"VALUES ({table.TableID}, {employee.EmployeeID}, NULL)";
            int orderID = ExecuteEditIdentityQuery(query, new SqlParameter[0]);
            return new Order(orderID, table, employee);
        }

        public Order GetOrder(Table table) {
            string query = "SELECT order_id, table_id, employee_id " +
                "FROM [ORDER]" +
                $"WHERE table_id = {table.TableID} " +
                "ORDER BY order_id DESC";
            return ReadOrder(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public void AddFeedback(Order order) {
            string query = "UPDATE [ORDER] " +
                $"SET feedback = '{order.Feedback}' " +
                $"WHERE order_id = {order.OrderID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public int GetOrderID(Table table) {
            string query = "SELECT order_id " +
                "FROM [ORDER]" +
                $"WHERE table_id = {table.TableID} " +
                "ORDER BY order_id DESC";
            return ExecuteSelectQuery(query, new SqlParameter[0]).Rows[0].Field<int>("order_id");
        }

        private Order ReadOrder(DataTable dataTable) {
            DataRow row = dataTable.Rows[0];
            return new Order(
                orderID: (int)row["order_id"],
                table: tableDAO.GetTable((int)row["table_id"]),
                employee: employeeDAO.GetEmployee((int)row["employee_id"])
            );
        }

        private List<Order> ReadOrders(DataTable dataTable) {
            return (from row in dataTable.AsEnumerable()
                    select new Order(
                        orderID: (int)row["order_id"],
                        table: tableDAO.GetTable((int)row["table_id"]),
                        employee: employeeDAO.GetEmployee((int)row["employee_id"])
                    )).ToList();
        }

        public void RemoveOrder(Order order) {
            string query = "DELETE FROM [ORDER] " +
                $"WHERE order_id = {order.OrderID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}

