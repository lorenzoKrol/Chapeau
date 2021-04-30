using ChapeauLogic.Services;
using ChapeauModel.Models;
using ChapeauStyle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MenuItem = ChapeauModel.Models.MenuItem;

namespace ChapeauUI {
    public partial class OrderForm : BaseForm {
        private const int size = 120;
        private const int padding = 18;

        private TableService tableService = new TableService();
        private MenuItemService menuItemService = new MenuItemService();
        private OrderItemService orderItemService = new OrderItemService();
        private OrderService orderService = new OrderService();

        private Order Order { get; set; }

        public OrderForm(Employee employee)
            : base(employee) {
            InitializeComponent();
        }

        private void OrderForm_Shown(object sender, EventArgs e) {
            DisplayTables();
            InitializeItemOverview();
        }

        private void DisplayTables() {
            List<Table> oldTables = new List<Table>();
            List<Table> newTables = tableService.GetAllTables();

            foreach (Control control in fpnlTables.Controls.OfType<Control>())
                oldTables.Add(control.Tag as Table);

            if (!TablesChanged(oldTables, newTables))
                return;

            fpnlTables.Controls.Clear();

            foreach (Table table in newTables) {
                FlatButton button = new FlatButton {
                    Size = new Size(size, size),
                    Margin = new Padding(padding, padding, padding, padding),
                    Text = $"Table {table.TableID}",
                    Tag = table
                };

                if (table.Occupied && orderService.NoItems(table))
                    button.Text += "  *";

                // Display table colour based on status
                button.BackColor = table.Occupied ?
                    Color.FromArgb(255, 104, 107) : Color.FromArgb(132, 220, 198);

                button.Click += new EventHandler(Table_Click);
                fpnlTables.Controls.Add(button);
            }
        }

        private void Table_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            Table table = (Table)button.Tag;

            if (!table.Occupied)
                tableService.ChangeOccupation(table, true);

            DisplayMenuPanel(table);
        }

        private bool TablesChanged(List<Table> oldTables, List<Table> newTables) {
            if (oldTables.Count != newTables.Count)
                return true;

            for (int index = 0; index < newTables.Count; index++)
                if (!oldTables[index].Equals(newTables[index]))
                    return true;

            return false;
        }

        private void tmrReloadTables_Tick(object sender, EventArgs e) {
            DisplayTables();
        }

        private void DisplayMenuPanel(Table table) {
            pnlTableOverview.Hide();
            pnlMenuOverview.Show();

            lblCurrentTable.Text = $"Table {table.TableID}";

            DisplayCategories();
            DisplayMenuItems(Category.Lunch_main);

            if (!table.Occupied) {
                Order = orderService.CreateOrder(table, Employee);
            }
            else {
                Order = orderService.GetOrder(table);
                Order.OrderItems = orderItemService.GetOrderItems(Order);
                DisplayItemOverview();
            }
        }

        private void InitializeItemOverview() {
            lvwItemOverview.Clear();
            lvwItemOverview.View = View.Details;

            lvwItemOverview.Font = new Font(lvwItemOverview.Font, FontStyle.Bold);

            lvwItemOverview.Columns.Add("#", 25);
            lvwItemOverview.Columns.Add("Name", 190);
            lvwItemOverview.Columns.Add("Price", 60);
            lvwItemOverview.Columns.Add("Status", 70);
            lvwItemOverview.Columns.Add("Comments", 100);
        }

        private void DisplayCategories() {
            foreach (Category category in Enum.GetValues(typeof(Category))) {
                FlatButton button = new FlatButton {
                    Size = new Size((int)(1.2f * size), (int)(0.7f * size)),
                    Text = category.ToString().Replace('_', ' '),
                    Tag = category
                };

                // Different colours for food items and drinks
                button.BackColor = category >= Category.Soft_drinks ?
                    Color.FromArgb(245, 203, 92) : Color.FromArgb(143, 222, 193);

                button.Click += new EventHandler(Category_Click);
                fpnlCategories.Controls.Add(button);
            }
        }

        private void Category_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            Category category = (Category)button.Tag;

            DisplayMenuItems(category);
        }

        private void DisplayMenuItems(Category category) {
            fpnlMenuItems.Controls.Clear();

            List<MenuItem> menuItems = menuItemService.GetMenuItems(category);

            foreach (MenuItem menuItem in menuItems) {
                FlatButton button = new FlatButton {
                    Size = new Size((int)(1.1f * size), (int)(0.6f * size)),
                    Text = menuItem.ItemName,
                    BackColor = Color.FromArgb(157, 105, 163),
                    Tag = menuItem
                };
                button.Click += new EventHandler(MenuItem_Click);
                fpnlMenuItems.Controls.Add(button);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            MenuItem menuItem = (MenuItem)button.Tag;

            if (menuItem.InStock > 0) {
                AddOrderItem(menuItem);
                menuItem.InStock--;
                menuItemService.UpdateStock(menuItem);
            }
            else
                errorBox.Show($"'{menuItem.ItemName}' is out of stock!");
        }

        private void AddOrderItem(MenuItem menuItem) {
            // Check if menu item is in the order list
            int index = Order.OrderItems.FindIndex(orderItem =>
                orderItem.MenuItem.ItemID == menuItem.ItemID);

            if (index < 0) {
                OrderItem orderItem = orderItemService.CreateOrderItem(1, menuItem, Order.OrderID, OrderState.unready);
                Order.OrderItems.Add(orderItem);
            }
            else {
                Order.OrderItems[index].Quantity++;
                orderItemService.UpdateQuantity(Order.OrderItems[index]);
            }

            DisplayItemOverview();
        }

        private void DisplayItemOverview() {
            lvwItemOverview.Items.Clear();

            foreach (OrderItem item in Order.OrderItems) {
                ListViewItem lvwItem = new ListViewItem(new[] {
                    item.Quantity.ToString(),
                    item.MenuItem.ItemName,
                    item.MenuItem.Price.ToString("C"),
                    item.OrderState.ToString(),
                    item.Comments
                }) {
                    Font = new Font(lvwItemOverview.Font, FontStyle.Regular),
                    Tag = item
                };
                lvwItemOverview.Items.Add(lvwItem);
            }
        }


        private void btnIncrement_Click(object sender, EventArgs e) {
            if (lvwItemOverview.SelectedItems.Count > 0) {
                OrderItem item = (OrderItem)lvwItemOverview.SelectedItems[0].Tag;
                int index = Order.OrderItems.IndexOf(item);

                if (item.MenuItem.InStock > 0) {
                    Order.OrderItems[index].Quantity++;
                    orderItemService.UpdateQuantity(Order.OrderItems[index]);

                    item.MenuItem.InStock--;
                    menuItemService.UpdateStock(item.MenuItem);

                    DisplayItemOverview();
                }
                else
                    errorBox.Show($"'{item.MenuItem.ItemName}' is out of stock!");
            }
            else {
                errorBox.Show("Please select an item!");
            }
        }

        private void btnDecrement_Click(object sender, EventArgs e) {
            if (lvwItemOverview.SelectedItems.Count > 0) {
                OrderItem item = (OrderItem)lvwItemOverview.SelectedItems[0].Tag;
                int index = Order.OrderItems.IndexOf(item);

                Order.OrderItems[index].Quantity--;

                if (Order.OrderItems[index].Quantity <= 0) {
                    orderItemService.RemoveOrderItem(Order.OrderItems[index].OrderItemID);
                    Order.OrderItems.RemoveAt(index);
                }
                else
                    orderItemService.UpdateQuantity(Order.OrderItems[index]);

                item.MenuItem.InStock++;
                menuItemService.UpdateStock(item.MenuItem);

                DisplayItemOverview();
            }
            else {
                errorBox.Show("Please select an item!");
            }
        }

        private void btnComment_Click(object sender, EventArgs e) {
            if (lvwItemOverview.SelectedItems.Count > 0) {
                tblOptions.Hide();
                txbComment.Text = string.Empty;
            }
            else
                errorBox.Show("Please select an item!");
        }

        private void btnPayment_Click(object sender, EventArgs e) {
            Hide();
            new PaymentForm(Order).Show();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            string text = "Are you sure you want to cancel the order?";
            DialogResult result = confirmationBox.Show(text);

            if (result == DialogResult.Cancel)
                return;
            if (!Order.OrderItems.Any()) {
                tableService.ChangeOccupation(Order.Table, false);
                orderService.RemoveOrder(Order);
                ReturnToTableOverview();
            }
            else
                errorBox.Show("Please remove all items first!");
        }

        private void btnSend_Click(object sender, EventArgs e) {
            ReturnToTableOverview();
        }

        private void ReturnToTableOverview() {
            lvwItemOverview.Clear();
            fpnlCategories.Controls.Clear();
            InitializeItemOverview();

            lblCurrentTable.Text = string.Empty;
            DisplayTables();

            pnlMenuOverview.Hide();
            pnlTableOverview.Show();
        }

        private void btnCancelComment_Click(object sender, EventArgs e) {
            tblOptions.Show();
        }

        private void btnAddComment_Click(object sender, EventArgs e) {
            string text = txbComment.Text;

            OrderItem item = (OrderItem)lvwItemOverview.SelectedItems[0].Tag;
            int index = Order.OrderItems.IndexOf(item);

            Order.OrderItems[index].Comments = text;
            orderItemService.SetComments(Order.OrderItems[index]);

            tblOptions.Show();
            DisplayItemOverview();
        }
    }
}
