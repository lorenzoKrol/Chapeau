using System.Collections.Generic;
using ChapeauModel.Models;
using ChapeauDAL.DAOs;
using System;

namespace ChapeauLogic.Services {
    public class MenuItemService {
        private MenuItemDAO menuItemDAO = new MenuItemDAO();

        public List<MenuItem> GetMenuItems(Category category) {
            return menuItemDAO.GetMenuItems(category);
        }

        public void UpdateStock(MenuItem item) {
            menuItemDAO.UpdateStock(item);
        }

        public List<MenuItem> GetAllMenuItems() {
            return menuItemDAO.GetAllMenuItems();
        }

        public void ChangeName(MenuItem menuItem) {
            menuItemDAO.ChangeName(menuItem);
        }

        public void ChangeStock(MenuItem menuItem) {
            menuItemDAO.ChangeStock(menuItem);
        }
    }
}
