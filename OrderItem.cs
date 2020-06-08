namespace ChapeauModel.Models {
    public class OrderItem {
        // Identity 
        public int OrderItemID { get; set; }
        // Properties
        public int Quantity { get; set; }
        public MenuItem MenuItem { get; set; }
        public int OrderID { get; set; }
        public OrderState OrderState { get; set; }
        public string Comments { get; set; }

        public OrderItem(int orderItemID, int quantity, MenuItem menuItem, int orderID, OrderState orderState, string comments) {
            OrderItemID = orderItemID;
            Quantity = quantity;
            MenuItem = menuItem;
            OrderID = orderID;
            OrderState = orderState;
            Comments = comments;
        }
    }
}
