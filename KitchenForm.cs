using ChapeauModel.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChapeauLogic.Services;

namespace ChapeauUI {
    public partial class KitchenForm : BaseForm {
        OrderItemService orderItemService = new OrderItemService();

        public KitchenForm(Employee employee)
            : base(employee) {
            InitializeComponent();
        }

        private void KitchenForm_Load(object sender, System.EventArgs e) {
            InitializeItemOverview();
        }

        private void KitchenForm_Shown(object sender, System.EventArgs e) {
            DisplayItemOverview();
        }

        private void InitializeItemOverview() {
            lvwItemOverview.Clear();
            lvwItemOverview.View = View.Details;

            lvwItemOverview.Font = new Font(lvwItemOverview.Font, FontStyle.Bold);

            lvwItemOverview.Columns.Add("Quantity", 75);
            lvwItemOverview.Columns.Add("Name", 150);
            lvwItemOverview.Columns.Add("Order state", 100);
            lvwItemOverview.Columns.Add("Order", 60);
            lvwItemOverview.Columns.Add("Comments", 250);
        }

        private void DisplayItemOverview() {
            List<OrderItem> items = orderItemService.GetOrderItems(Employee);
            lvwItemOverview.Items.Clear();

            foreach (OrderItem item in items) {
                ListViewItem lvwItem = new ListViewItem(new[] {
                    item.Quantity.ToString(),
                    item.MenuItem.ItemName,
                    item.OrderState.ToString(),
                    item.OrderID.ToString(),
                    item.Comments
                }) {
                    Font = new Font(lvwItemOverview.Font, FontStyle.Regular),
                    Tag = item
                };
                lvwItemOverview.Items.Add(lvwItem);
            }
        }

        private void btnReady_Click(object sender, System.EventArgs e) {
            if (lvwItemOverview.SelectedItems.Count > 0) {
                OrderItem item = (OrderItem)lvwItemOverview.SelectedItems[0].Tag;
                orderItemService.UpdateOrderStatus(item, OrderState.ready);
                DisplayItemOverview();
            }
            else {
                errorBox.Show("Please select an item!");
            }
        }

        private void btnUpdate_Click(object sender, System.EventArgs e) {
            DisplayItemOverview();
        }
    }
}
