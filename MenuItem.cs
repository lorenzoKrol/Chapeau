namespace ChapeauModel.Models {
    public class MenuItem {
        // Properties
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int VAT { get; set; }
        public Category Category { get; set; }

        public MenuItem(int itemID, string itemName, int inStock, decimal price, Category category, int VAT) {
            ItemID = itemID;
            ItemName = itemName;
            InStock = inStock;
            Price = price;
            Category = category;
            this.VAT = VAT;
        }
    }
}
