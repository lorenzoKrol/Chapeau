using ChapeauModel.Models;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic;
using ChapeauLogic.Services;
using System;


namespace ChapeauUI {
    public partial class PaymentForm : BaseForm {
        public Order Order { get; set; }
        public Payment Payment { get; set; }

        private PaymentService paymentService = new PaymentService();
        private OrderService orderService = new OrderService();
        private TableService tableService = new TableService();

        public PaymentForm(Order order)
            : base(order.Employee) {
            Order = order;
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e) {
            InitializeItemOverview();
            DisplayItemOverview();

            lblTip.Text = $"0.00";
            DisplayAmount();

            HideTipBox();
            HideFeedbackBox();
        }

        private void HideFeedbackBox() {
            txbFeedback.Text = string.Empty;

            txbFeedback.Hide();
            btnSubmit.Hide();
        }

        private void HideTipBox() {
            txbTipBox.Text = string.Empty;

            txbTipBox.Hide();
            btnEnter.Hide();
        }

        private void InitializeItemOverview() {
            lvwItemOverview.Clear();
            lvwItemOverview.View = View.Details;

            lvwItemOverview.Font = new Font(lvwItemOverview.Font, FontStyle.Bold);

            lvwItemOverview.Columns.Add("Amount", 75);
            lvwItemOverview.Columns.Add("Name", 200);
            lvwItemOverview.Columns.Add("Price ($)", 75);
        }

        private void DisplayItemOverview() {
            lvwItemOverview.Items.Clear();

            foreach (OrderItem item in Order.OrderItems) {
                ListViewItem lvwItem = new ListViewItem(new[] {
                    item.Quantity.ToString(),
                    item.MenuItem.ItemName,
                    item.MenuItem.Price.ToString("C")
                }) {
                    Font = new Font(lvwItemOverview.Font, FontStyle.Regular),
                    Tag = item
                };
                lvwItemOverview.Items.Add(lvwItem);
            }
        }

        private void DisplayAmount() {
            decimal subTotal = 0;
            decimal VATTotal = 0;

            foreach (OrderItem item in Order.OrderItems) {
                decimal price = item.MenuItem.Price;
                VATTotal += price * ((decimal)item.MenuItem.VAT / 100);
                subTotal += price;
            }

            decimal tip = decimal.Parse(lblTip.Text);
            decimal total = subTotal + tip + VATTotal;

            lblSubTotal.Text = subTotal.ToString("0.00");
            lblVAT.Text = VATTotal.ToString("0.00");
            lblTotal.Text = total.ToString("C");

            lblPay.Text = $"{total:C}";
        }

        private void btnTip_Click(object sender, EventArgs e) {
            txbTipBox.Show();
            btnEnter.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            if (txbTipBox.Text != string.Empty) {
                decimal tip = decimal.Parse(txbTipBox.Text);
                lblTip.Text = tip.ToString("0.00");

                DisplayAmount();
                HideTipBox();
            }
            else
                errorBox.Show("No tip entered!");
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (txbFeedback.Text != string.Empty) {
                Order.Feedback = txbFeedback.Text;
                orderService.AddFeedback(Order);
                HideFeedbackBox();
            }
            else
                errorBox.Show("No feedback entered");
        }

        private void btnPay_Click(object sender, EventArgs e) {
            decimal tip = decimal.Parse(lblTip.Text);
            decimal price = decimal.Parse(lblSubTotal.Text) + decimal.Parse(lblSubTotal.Text);
            int employeeID = Order.Employee.EmployeeID;
            int orderID = Order.OrderID;

            PaymentMethod method;

            try {
                if (rbnCash.Checked)
                    method = PaymentMethod.Cash;
                else if (rbnDebitCard.Checked)
                    method = PaymentMethod.CreditCard;
                else if (rbnIDeal.Checked)
                    method = PaymentMethod.Pin;
                else
                    throw new Exception("No payment method selected!");
            }
            catch (Exception exception) {
                errorBox.Show(exception.Message);
                return;
            }
            Payment = new Payment(tip, price, DateTime.Now, employeeID, orderID, method);

            paymentService.InsertPayment(Payment);
            tableService.ChangeOccupation(Order.Table, false);

            errorBox.Show("Payment successful!");

            Hide();
            new OrderForm(Order.Employee).Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e) {
            txbFeedback.Show();
            btnSubmit.Show();
        }
    }
}
