using ChapeauLogic.Services;
using ChapeauModel.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MenuItem = ChapeauModel.Models.MenuItem;

namespace ChapeauUI {
    public partial class ManagerForm : BaseForm {
        private MenuItemService menuItemService = new MenuItemService();
        private EmployeeService employeeService = new EmployeeService();
        private UserService userService = new UserService();

        public ManagerForm(Employee employee)
            : base(employee) {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, System.EventArgs e) {
            InitializeItemOverview();
            InitializeEmployeeOverview();
            DisplayItemOverview();
        }

        private void InitializeItemOverview() {
            lvwItemOverview.Clear();
            lvwItemOverview.View = View.Details;

            lvwItemOverview.Font = new Font(lvwItemOverview.Font, FontStyle.Bold);

            lvwItemOverview.Columns.Add("ID", 50);
            lvwItemOverview.Columns.Add("Name", 300);
            lvwItemOverview.Columns.Add("Stock", 100);
        }

        private void InitializeEmployeeOverview() {
            lvwEmployeeOverview.Clear();
            lvwEmployeeOverview.View = View.Details;

            lvwEmployeeOverview.Font = new Font(lvwItemOverview.Font, FontStyle.Bold);

            lvwEmployeeOverview.Columns.Add("ID", 50);
            lvwEmployeeOverview.Columns.Add("First name", 100);
            lvwEmployeeOverview.Columns.Add("Last name", 100);
            lvwEmployeeOverview.Columns.Add("Position", 100);
        }

        private void DisplayItemOverview() {
            List<MenuItem> menuItems = menuItemService.GetAllMenuItems();
            lvwItemOverview.Items.Clear();

            foreach (MenuItem item in menuItems) {
                ListViewItem lvwItem = new ListViewItem(new[] {
                    item.ItemID.ToString(),
                    item.ItemName,
                    item.InStock.ToString()
                }) {
                    Font = new Font(lvwItemOverview.Font, FontStyle.Regular),
                    Tag = item
                };
                lvwItemOverview.Items.Add(lvwItem);
            }
        }

        private void DisplayEmployeeOverview() {
            lvwEmployeeOverview.Items.Clear();
            List<Employee> employees = employeeService.GetAllEmployees();

            foreach (Employee employee in employees) {
                ListViewItem lvwItem = new ListViewItem(new[] {
                    employee.EmployeeID.ToString(),
                    employee.FirstName,
                    employee.LastName,
                    employee.Position.ToString()
                }) {
                    Font = new Font(lvwItemOverview.Font, FontStyle.Regular),
                    Tag = employee
                };
                lvwEmployeeOverview.Items.Add(lvwItem);
            }
        }

        private void btnEditMenuPanel_Click(object sender, System.EventArgs e) {
            pnlEditMenu.Show();
        }

        private void btnAddEmployee_Click(object sender, System.EventArgs e) {
            bool fieldsFilled = true;

            foreach (Control control in tblFields.Controls)
                if (control.Text == string.Empty)
                    fieldsFilled = false;
            try {
                if (!fieldsFilled) {
                    throw new Exception("Not all fields have been filled!");
                }
                else {
                    int employeeID = int.Parse(txbID.Text);
                    string firstName = txbFirstName.Text;
                    string lastName = txbLastName.Text;
                    Position position = GetPosition(txbPosition.Text);

                    Employee employee = new Employee(employeeID, firstName, lastName, position);

                    string email = txbEmail.Text;
                    string password = txbPassword.Text;

                    if (password != txbConPassword.Text)
                        throw new Exception("Passwords do not match!");

                    User user = new User(employeeID, email, password);

                    employeeService.AddEmployee(employee);
                    userService.AddUser(user);

                    errorBox.Show("User added succesfully");
                    ClearFields();
                }
            }
            catch (Exception exception) {
                errorBox.Show(exception.Message);
            }
        }

        private void btnChangeMenu_Click(object sender, System.EventArgs e) {
            string name = txbName.Text;

            string stockText = txbStock.Text;
            bool parsable = int.TryParse(stockText, out int stock);

            MenuItem menuItem = (MenuItem)lvwItemOverview.SelectedItems[0].Tag;

            if (name != string.Empty) {
                menuItem.ItemName = name;
                menuItemService.ChangeName(menuItem);
            }

            if (parsable) {
                menuItem.InStock = stock;
                menuItemService.ChangeStock(menuItem);
            }

            txbName.Text = string.Empty;
            txbStock.Text = string.Empty;
            DisplayItemOverview();
        }

        private void btnCancelMenu_Click(object sender, System.EventArgs e) {
            txbName.Text = string.Empty;
            txbStock.Text = string.Empty;
        }

        private void btnCancelEmployee_Click(object sender, System.EventArgs e) {
            pnlEditMenu.Show();
            ClearFields();
        }

        private void ClearFields() {
            foreach (Control control in tblFields.Controls)
                control.Text = string.Empty;
        }

        private void btnAddEmployeePanel_Click(object sender, System.EventArgs e) {
            pnlEditMenu.Hide();
            pnlAddEmployee.Show();
        }

        private Position GetPosition(string position) {
            switch (position) {
                case "manager":
                    return Position.Manager;
                case "bartender":
                    return Position.Bartender;
                case "chef":
                    return Position.Chef;
                case "waiter":
                    return Position.Waiter;
                default:
                    throw new Exception("Unknown position");
            }
        }

        private void btnRemoveEmployeePanel_Click(object sender, EventArgs e) {
            pnlEditMenu.Hide();
            pnlAddEmployee.Hide();
            pnlRemoveEmployee.Show();

            DisplayEmployeeOverview();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e) {
            if (lvwEmployeeOverview.SelectedItems.Count > 0) {
                Employee employee = (Employee)lvwEmployeeOverview.SelectedItems[0].Tag;

                string text = "Are you sure you want to delete user?";
                DialogResult result = confirmationBox.Show(text);

                if (result == DialogResult.Cancel)
                    return;

                userService.RemoveUser(employee);
                employeeService.RemoveEmployee(employee);

                errorBox.Show("Employee removed successfully!");
            }
            else {
                errorBox.Show("No employee selected!");
            }
            DisplayEmployeeOverview();
        }
    }
}
