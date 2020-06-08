using ChapeauModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace ChapeauDAL.DAOs {
    public class MenuItemDAO : Base {
        public List<MenuItem> GetMenuItems(Category category) {
            string query = "SELECT item_id, item_name, in_stock, price, category, VAT " +
                "FROM [MENU_ITEM] " +
                $"WHERE category = {(int)category}";
            return ReadMenuItems(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public List<MenuItem> GetAllMenuItems() {
            string query = "SELECT item_id, item_name, in_stock, price, category, VAT " +
                 "FROM [MENU_ITEM] ";
            return ReadMenuItems(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        public void ChangeStock(MenuItem menuItem) {
            string query = "UPDATE [MENU_ITEM] " +
                $"SET in_stock = '{menuItem.InStock}' " +
                $"WHERE item_id = {menuItem.ItemID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void ChangeName(MenuItem menuItem) {
            string query = "UPDATE [MENU_ITEM] " +
                $"SET item_name = '{menuItem.ItemName}' " +
                $"WHERE item_id = {menuItem.ItemID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public void UpdateStock(MenuItem item) {
            string query = "UPDATE [MENU_ITEM] " +
                $"SET in_stock = {item.InStock} " +
                $"WHERE item_id = {item.ItemID}";
            ExecuteEditQuery(query, new SqlParameter[0]);
        }

        public MenuItem GetMenuItem(int menuItemID) {
            string query = "SELECT item_id, item_name, in_stock, price, category, VAT " +
                "FROM [MENU_ITEM] " +
                $"WHERE item_id = {menuItemID}";
            return ReadMenuItem(ExecuteSelectQuery(query, new SqlParameter[0]));
        }

        private MenuItem ReadMenuItem(DataTable dataTable) {
            DataRow row = dataTable.Rows[0];
            return new MenuItem(
                itemID: (int)row["item_id"],
                itemName: (string)(row["item_name"] ?? string.Empty),
                inStock: (int)row["in_stock"],
                price: (decimal)row["price"],
                category: (Category)row["category"],
                VAT: (int)row["VAT"]
            );
        }

        private List<MenuItem> ReadMenuItems(DataTable dataTable) {
            return (from row in dataTable.AsEnumerable()
                    select new MenuItem(
                        itemID: (int)row["item_id"],
                        itemName: (string)(row["item_name"] ?? string.Empty),
                        inStock: (int)row["in_stock"],
                        price: (decimal)row["price"],
                        category: (Category)row["category"],
                        VAT: (int)row["VAT"]
                    )).ToList();
        }
    }
}
