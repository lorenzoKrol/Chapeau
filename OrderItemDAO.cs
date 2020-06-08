using ChapeauModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ChapeauDAL.DAOs {
    public class OrderItemDAO : Base {
        MenuItemDAO menuItemDAO = new MenuItemDAO();

        public List<OrderItem> GetAllOrderItems() {
            string query = "SELECT order_item_id, quantity, item_id, order_id, order_state, feedback " +
                "FROM [ORDER_ITEM]";
            return GetOrderItems(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public List<OrderItem> GetDrinkItems() {
            string query = GetOrderItemQuery() + "category >= 6";
            return GetOrderItems(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public List<OrderItem> GetFoodItems() {
            string query = GetOrderItemQuery() + "category < 6";
            return GetOrderItems(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public bool NoItems(int orderID) {
            string query = "SELECT order_item_id " +
                "FROM [ORDER_ITEM] " +
                $"WHERE order_id = {orderID}";
            return ExecuteSelectQuery(query, new SqlParameter[0]).Rows.Count < 1;
        }

        private string GetOrderItemQuery() {
            string query = "SELECT order_item_id, quantity, [ORDER_ITEM].item_id, order_id, order_state, feedback " +
                "FROM [ORDER_ITEM] JOIN [MENU_ITEM] " +
                    "ON [ORDER_ITEM].item_id = [MENU_ITEM].item_id " +
                    "WHERE order_state = 2 AND ";
            return query;
        }

        public void SetComments(OrderItem orderItem) {
            string query = "UPDATE [ORDER_ITEM] " +
                $"SET feedback = '{orderItem.Comments}' " +
                $"WHERE order_item_id = {orderItem.OrderItemID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void UpdateOrderStatus(OrderItem item, OrderState orderState) {
            string query = "UPDATE [ORDER_ITEM] " +
                $"SET order_state = {(int)orderState} " +
                $"WHERE order_item_id = {item.OrderItemID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public List<OrderItem> GetOrderItems(Order order) {
            string query = "SELECT order_item_id, quantity, item_id, order_id, order_state, feedback " +
                "FROM [ORDER_ITEM] " +
                $"WHERE order_id = {order.OrderID}";
            return GetOrderItems(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        private List<OrderItem> GetOrderItems(DataTable dataTable) {
            return (from row in dataTable.AsEnumerable()
                    select new OrderItem(
                        orderItemID: (int)row["order_item_id"],
                        quantity: (int)row["quantity"],
                        menuItem: menuItemDAO.GetMenuItem((int)row["item_id"]),
                        orderID: (int)row["order_id"],
                        orderState: (OrderState)row["order_state"],
                        comments: (row["feedback"] ?? string.Empty).ToString()
                    )).ToList();
        }

        public void RemoveOrderItem(int orderID) {
            string query = "DELETE FROM [ORDER_ITEM] " +
                $"WHERE order_item_id = {orderID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public OrderItem CreateOrderItem(int quantity, MenuItem menuItem, int orderID, OrderState orderState) {
            string query = "INSERT INTO [ORDER_ITEM] " +
                $"VALUES ({quantity}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}', {(int)orderState}, NULL, {menuItem.ItemID}, {orderID})";

            int orderItemID = ExecuteEditIdentityQuery(query, new SqlParameter[0]);
            return new OrderItem(orderItemID, quantity, menuItem, orderID, orderState, string.Empty);
        }

        public void UpdateQuantity(OrderItem orderItem) {
            string query = "UPDATE [ORDER_ITEM] " +
                $"SET quantity = {orderItem.Quantity} " +
                $"WHERE order_item_id = {orderItem.OrderItemID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}
