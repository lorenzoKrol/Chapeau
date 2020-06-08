using System;
using System.Windows.Forms;
using ChapeauModel.Models;

namespace ChapeauUI {
    public partial class BaseForm : Form {
        protected PopupBox errorBox = new PopupBox(MessageBoxButtons.OK);
        protected PopupBox confirmationBox = new PopupBox(MessageBoxButtons.OKCancel);

        protected Employee Employee { get; set; }

        private BaseForm() {
            InitializeComponent();
        }

        public BaseForm(Employee employee) {
            Employee = employee;
            InitializeComponent();

            lblUser.Text = Employee.FirstName;
            lblCurrentTable.Text = string.Empty;
        }

        private void BaseForm_Load(object sender, EventArgs e) {
            tmrDate_Tick(null, null);
        }

        private void tmrDate_Tick(object sender, EventArgs e) {
            DateTime date = DateTime.Now;
            lblDate.Text = $"{date.DayOfWeek} {date.ToString("dd MMMM")} {date.ToShortTimeString()}";
        }

        private void btnExit_Click(object sender, EventArgs e) {
            string text = "Are you sure you want to log off?";
            DialogResult result = confirmationBox.Show(text);

            if (result == DialogResult.Cancel)
                return;

            Close();
            new LoginForm().Show();
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (DialogResult != DialogResult.Ignore)
                Application.Exit();
        }
    }
}
