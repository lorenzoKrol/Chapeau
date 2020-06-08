using System.Collections.Generic;
using ChapeauModel.Models;
using ChapeauDAL.DAOs;
using System;

namespace ChapeauLogic.Services {
    public class OrderItemService {
        private OrderItemDAO orderItemDAO = new OrderItemDAO();

        public List<OrderItem> GetOrderItems(Order order) {
            return orderItemDAO.GetOrderItems(order);
        }

        public List<OrderItem> GetOrderItems(Employee employee) {
            return employee.Position == Position.Bartender ?
                orderItemDAO.GetDrinkItems() : orderItemDAO.GetFoodItems();
        }

        public OrderItem CreateOrderItem(int quantity, MenuItem menuItem, int orderID, OrderState orderState) {
            return orderItemDAO.CreateOrderItem(quantity, menuItem, orderID, orderState);
        }

        public void UpdateQuantity(OrderItem orderItem) {
            orderItemDAO.UpdateQuantity(orderItem);
        }

        public void RemoveOrderItem(int orderID) {
            orderItemDAO.RemoveOrderItem(orderID);
        }

        public void UpdateOrderStatus(OrderItem item, OrderState orderState) {
            orderItemDAO.UpdateOrderStatus(item, orderState);
        }

        public void SetComments(OrderItem orderItem) {
            orderItemDAO.SetComments(orderItem);
        }
    }
}
