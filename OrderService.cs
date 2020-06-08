using ChapeauModel.Models;
using ChapeauDAL.DAOs;
using System;

namespace ChapeauLogic.Services {
    public class OrderService {
        private OrderDAO orderDAO = new OrderDAO();
        private OrderItemDAO orderItemDAO = new OrderItemDAO();

        public Order CreateOrder(Table table, Employee employee) {
            return orderDAO.CreateOrder(table, employee);
        }

        public Order GetOrder(Table table) {
            return orderDAO.GetOrder(table);
        }

        public void RemoveOrder(Order order) {
            orderDAO.RemoveOrder(order);
        }

        private int GetOrderID(Table table) {
            return orderDAO.GetOrderID(table);
        }

        public bool NoItems(Table table) {
            int orderID = GetOrderID(table);
            return orderItemDAO.NoItems(orderID);
        }

        public void AddFeedback(Order order) {
            orderDAO.AddFeedback(order);
        }
    }
}
