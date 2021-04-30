using ChapeauModel.Models;
using ChapeauLogic.Services;
using System.Windows.Forms;
using System;

namespace ChapeauUI {
    public partial class LoginForm : Form {
        private PopupBox errorBox = new PopupBox(MessageBoxButtons.OK);

        private UserService userService = new UserService();
        private EmployeeService employeeService = new EmployeeService();

        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e) {
            User user;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            
            try {
                user = userService.GetUser(email);
            }
            catch (Exception) {
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;

                errorBox.Show("Username not found!");
                return;
            }

            if (user != null && user.Password == password) {
                Employee employee = employeeService.GetEmployee(user.EmployeeID);
                Form form = GetForm(employee);
                ExecuteForm(form);
            }
            else {
                txtPassword.Text = string.Empty;
                errorBox.Show("Incorrect password!");
            }
        }

        private Form GetForm(Employee employee) {
            switch (employee.Position) {
                case Position.Waiter:
                    return new OrderForm(employee);
                case Position.Manager:
                    return new ManagerForm(employee);
                default:
                    return new KitchenForm(employee);
            }
        }

        private void ExecuteForm(Form form) {
            Hide();
            form.Show();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
