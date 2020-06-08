namespace ChapeauUI {
    partial class ManagerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnRemoveEmployeePanel = new ChapeauStyle.FlatButton();
            this.btnAddEmployeePanel = new ChapeauStyle.FlatButton();
            this.btnEditMenuPanel = new ChapeauStyle.FlatButton();
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new ChapeauStyle.FlatButton();
            this.btnCancelEmployee = new ChapeauStyle.FlatButton();
            this.lblConPassword = new ChapeauStyle.MainLabel();
            this.lblPassword = new ChapeauStyle.MainLabel();
            this.lblEmail = new ChapeauStyle.MainLabel();
            this.lblID = new ChapeauStyle.MainLabel();
            this.lblPosition = new ChapeauStyle.MainLabel();
            this.lblLastName = new ChapeauStyle.MainLabel();
            this.lblFirstName = new ChapeauStyle.MainLabel();
            this.tblFields = new System.Windows.Forms.TableLayoutPanel();
            this.txbConPassword = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbPosition = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.pnlEditMenu = new System.Windows.Forms.Panel();
            this.lvwItemOverview = new System.Windows.Forms.ListView();
            this.btnCancelMenu = new ChapeauStyle.FlatButton();
            this.btnChangeMenu = new ChapeauStyle.FlatButton();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.lblName = new ChapeauStyle.MainLabel();
            this.lblStock = new ChapeauStyle.MainLabel();
            this.pnlRemoveEmployee = new System.Windows.Forms.Panel();
            this.btnRemoveEmployee = new ChapeauStyle.FlatButton();
            this.lvwEmployeeOverview = new System.Windows.Forms.ListView();
            this.pnlOptions.SuspendLayout();
            this.pnlAddEmployee.SuspendLayout();
            this.tblFields.SuspendLayout();
            this.pnlEditMenu.SuspendLayout();
            this.pnlRemoveEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorBox
            // 
            this.errorBox.Location = new System.Drawing.Point(832, 444);
            // 
            // confirmationBox
            // 
            this.confirmationBox.Location = new System.Drawing.Point(832, 444);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnRemoveEmployeePanel);
            this.pnlOptions.Controls.Add(this.btnAddEmployeePanel);
            this.pnlOptions.Controls.Add(this.btnEditMenuPanel);
            this.pnlOptions.Location = new System.Drawing.Point(16, 109);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(205, 625);
            this.pnlOptions.TabIndex = 1;
            // 
            // btnRemoveEmployeePanel
            // 
            this.btnRemoveEmployeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnRemoveEmployeePanel.FlatAppearance.BorderSize = 0;
            this.btnRemoveEmployeePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployeePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployeePanel.Location = new System.Drawing.Point(4, 228);
            this.btnRemoveEmployeePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveEmployeePanel.Name = "btnRemoveEmployeePanel";
            this.btnRemoveEmployeePanel.Size = new System.Drawing.Size(196, 78);
            this.btnRemoveEmployeePanel.TabIndex = 2;
            this.btnRemoveEmployeePanel.Text = "Remove employee";
            this.btnRemoveEmployeePanel.UseVisualStyleBackColor = false;
            this.btnRemoveEmployeePanel.Click += new System.EventHandler(this.btnRemoveEmployeePanel_Click);
            // 
            // btnAddEmployeePanel
            // 
            this.btnAddEmployeePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnAddEmployeePanel.FlatAppearance.BorderSize = 0;
            this.btnAddEmployeePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployeePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployeePanel.Location = new System.Drawing.Point(4, 129);
            this.btnAddEmployeePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployeePanel.Name = "btnAddEmployeePanel";
            this.btnAddEmployeePanel.Size = new System.Drawing.Size(196, 78);
            this.btnAddEmployeePanel.TabIndex = 1;
            this.btnAddEmployeePanel.Text = "Add employee";
            this.btnAddEmployeePanel.UseVisualStyleBackColor = false;
            this.btnAddEmployeePanel.Click += new System.EventHandler(this.btnAddEmployeePanel_Click);
            // 
            // btnEditMenuPanel
            // 
            this.btnEditMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnEditMenuPanel.FlatAppearance.BorderSize = 0;
            this.btnEditMenuPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMenuPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenuPanel.Location = new System.Drawing.Point(4, 32);
            this.btnEditMenuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditMenuPanel.Name = "btnEditMenuPanel";
            this.btnEditMenuPanel.Size = new System.Drawing.Size(196, 78);
            this.btnEditMenuPanel.TabIndex = 0;
            this.btnEditMenuPanel.Text = "Edit menu";
            this.btnEditMenuPanel.UseVisualStyleBackColor = false;
            this.btnEditMenuPanel.Click += new System.EventHandler(this.btnEditMenuPanel_Click);
            // 
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.Controls.Add(this.btnAddEmployee);
            this.pnlAddEmployee.Controls.Add(this.btnCancelEmployee);
            this.pnlAddEmployee.Controls.Add(this.lblConPassword);
            this.pnlAddEmployee.Controls.Add(this.lblPassword);
            this.pnlAddEmployee.Controls.Add(this.lblEmail);
            this.pnlAddEmployee.Controls.Add(this.lblID);
            this.pnlAddEmployee.Controls.Add(this.lblPosition);
            this.pnlAddEmployee.Controls.Add(this.lblLastName);
            this.pnlAddEmployee.Controls.Add(this.lblFirstName);
            this.pnlAddEmployee.Controls.Add(this.tblFields);
            this.pnlAddEmployee.Location = new System.Drawing.Point(227, 109);
            this.pnlAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(1020, 625);
            this.pnlAddEmployee.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(280, 524);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(225, 58);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnCancelEmployee
            // 
            this.btnCancelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.btnCancelEmployee.FlatAppearance.BorderSize = 0;
            this.btnCancelEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEmployee.Location = new System.Drawing.Point(33, 524);
            this.btnCancelEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelEmployee.Name = "btnCancelEmployee";
            this.btnCancelEmployee.Size = new System.Drawing.Size(225, 58);
            this.btnCancelEmployee.TabIndex = 3;
            this.btnCancelEmployee.Text = "Cancel";
            this.btnCancelEmployee.UseVisualStyleBackColor = false;
            this.btnCancelEmployee.Click += new System.EventHandler(this.btnCancelEmployee_Click);
            // 
            // lblConPassword
            // 
            this.lblConPassword.AutoSize = true;
            this.lblConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPassword.Location = new System.Drawing.Point(28, 289);
            this.lblConPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConPassword.Name = "lblConPassword";
            this.lblConPassword.Size = new System.Drawing.Size(169, 25);
            this.lblConPassword.TabIndex = 7;
            this.lblConPassword.Text = "Confirm password";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(28, 247);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(28, 205);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(28, 163);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(28, 121);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(81, 25);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Position";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(28, 79);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(28, 37);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 25);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First name";
            // 
            // tblFields
            // 
            this.tblFields.ColumnCount = 1;
            this.tblFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFields.Controls.Add(this.txbConPassword, 0, 6);
            this.tblFields.Controls.Add(this.txbPassword, 0, 5);
            this.tblFields.Controls.Add(this.txbEmail, 0, 4);
            this.tblFields.Controls.Add(this.txbID, 0, 3);
            this.tblFields.Controls.Add(this.txbPosition, 0, 2);
            this.tblFields.Controls.Add(this.txbLastName, 0, 1);
            this.tblFields.Controls.Add(this.txbFirstName, 0, 0);
            this.tblFields.Location = new System.Drawing.Point(239, 33);
            this.tblFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblFields.Name = "tblFields";
            this.tblFields.RowCount = 7;
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblFields.Size = new System.Drawing.Size(267, 299);
            this.tblFields.TabIndex = 0;
            // 
            // txbConPassword
            // 
            this.txbConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConPassword.Location = new System.Drawing.Point(4, 256);
            this.txbConPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbConPassword.Name = "txbConPassword";
            this.txbConPassword.PasswordChar = '*';
            this.txbConPassword.Size = new System.Drawing.Size(257, 30);
            this.txbConPassword.TabIndex = 6;
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(4, 214);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(257, 30);
            this.txbPassword.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(4, 172);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(257, 30);
            this.txbEmail.TabIndex = 4;
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(4, 130);
            this.txbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(257, 30);
            this.txbID.TabIndex = 3;
            // 
            // txbPosition
            // 
            this.txbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPosition.Location = new System.Drawing.Point(4, 88);
            this.txbPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPosition.Name = "txbPosition";
            this.txbPosition.Size = new System.Drawing.Size(257, 30);
            this.txbPosition.TabIndex = 2;
            // 
            // txbLastName
            // 
            this.txbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLastName.Location = new System.Drawing.Point(4, 46);
            this.txbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(257, 30);
            this.txbLastName.TabIndex = 1;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFirstName.Location = new System.Drawing.Point(4, 4);
            this.txbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(257, 30);
            this.txbFirstName.TabIndex = 0;
            // 
            // pnlEditMenu
            // 
            this.pnlEditMenu.Controls.Add(this.lvwItemOverview);
            this.pnlEditMenu.Controls.Add(this.btnCancelMenu);
            this.pnlEditMenu.Controls.Add(this.btnChangeMenu);
            this.pnlEditMenu.Controls.Add(this.txbName);
            this.pnlEditMenu.Controls.Add(this.txbStock);
            this.pnlEditMenu.Controls.Add(this.lblName);
            this.pnlEditMenu.Controls.Add(this.lblStock);
            this.pnlEditMenu.Location = new System.Drawing.Point(227, 109);
            this.pnlEditMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEditMenu.Name = "pnlEditMenu";
            this.pnlEditMenu.Size = new System.Drawing.Size(1020, 625);
            this.pnlEditMenu.TabIndex = 3;
            // 
            // lvwItemOverview
            // 
            this.lvwItemOverview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvwItemOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwItemOverview.FullRowSelect = true;
            this.lvwItemOverview.GridLines = true;
            this.lvwItemOverview.Location = new System.Drawing.Point(17, 17);
            this.lvwItemOverview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwItemOverview.MultiSelect = false;
            this.lvwItemOverview.Name = "lvwItemOverview";
            this.lvwItemOverview.Size = new System.Drawing.Size(757, 583);
            this.lvwItemOverview.TabIndex = 3;
            this.lvwItemOverview.UseCompatibleStateImageBehavior = false;
            // 
            // btnCancelMenu
            // 
            this.btnCancelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.btnCancelMenu.FlatAppearance.BorderSize = 0;
            this.btnCancelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMenu.Location = new System.Drawing.Point(800, 537);
            this.btnCancelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelMenu.Name = "btnCancelMenu";
            this.btnCancelMenu.Size = new System.Drawing.Size(195, 63);
            this.btnCancelMenu.TabIndex = 9;
            this.btnCancelMenu.Text = "Cancel";
            this.btnCancelMenu.UseVisualStyleBackColor = false;
            this.btnCancelMenu.Click += new System.EventHandler(this.btnCancelMenu_Click);
            // 
            // btnChangeMenu
            // 
            this.btnChangeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnChangeMenu.FlatAppearance.BorderSize = 0;
            this.btnChangeMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMenu.Location = new System.Drawing.Point(800, 466);
            this.btnChangeMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeMenu.Name = "btnChangeMenu";
            this.btnChangeMenu.Size = new System.Drawing.Size(195, 63);
            this.btnChangeMenu.TabIndex = 8;
            this.btnChangeMenu.Text = "Change";
            this.btnChangeMenu.UseVisualStyleBackColor = false;
            this.btnChangeMenu.Click += new System.EventHandler(this.btnChangeMenu_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(800, 145);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(193, 30);
            this.txbName.TabIndex = 7;
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(800, 61);
            this.txbStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(193, 30);
            this.txbStock.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(799, 116);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Updated name";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(799, 32);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(137, 25);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Updated stock";
            // 
            // pnlRemoveEmployee
            // 
            this.pnlRemoveEmployee.Controls.Add(this.btnRemoveEmployee);
            this.pnlRemoveEmployee.Controls.Add(this.lvwEmployeeOverview);
            this.pnlRemoveEmployee.Location = new System.Drawing.Point(227, 109);
            this.pnlRemoveEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRemoveEmployee.Name = "pnlRemoveEmployee";
            this.pnlRemoveEmployee.Size = new System.Drawing.Size(1020, 625);
            this.pnlRemoveEmployee.TabIndex = 3;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.btnRemoveEmployee.FlatAppearance.BorderSize = 0;
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.Location = new System.Drawing.Point(559, 537);
            this.btnRemoveEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(195, 63);
            this.btnRemoveEmployee.TabIndex = 10;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // lvwEmployeeOverview
            // 
            this.lvwEmployeeOverview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvwEmployeeOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwEmployeeOverview.FullRowSelect = true;
            this.lvwEmployeeOverview.GridLines = true;
            this.lvwEmployeeOverview.Location = new System.Drawing.Point(17, 17);
            this.lvwEmployeeOverview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvwEmployeeOverview.MultiSelect = false;
            this.lvwEmployeeOverview.Name = "lvwEmployeeOverview";
            this.lvwEmployeeOverview.Size = new System.Drawing.Size(512, 583);
            this.lvwEmployeeOverview.TabIndex = 4;
            this.lvwEmployeeOverview.UseCompatibleStateImageBehavior = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 738);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlEditMenu);
            this.Controls.Add(this.pnlAddEmployee);
            this.Controls.Add(this.pnlRemoveEmployee);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(1271, 767);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.Controls.SetChildIndex(this.pnlRemoveEmployee, 0);
            this.Controls.SetChildIndex(this.pnlAddEmployee, 0);
            this.Controls.SetChildIndex(this.pnlEditMenu, 0);
            this.Controls.SetChildIndex(this.pnlOptions, 0);
            this.pnlOptions.ResumeLayout(false);
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            this.tblFields.ResumeLayout(false);
            this.tblFields.PerformLayout();
            this.pnlEditMenu.ResumeLayout(false);
            this.pnlEditMenu.PerformLayout();
            this.pnlRemoveEmployee.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private ChapeauStyle.FlatButton btnRemoveEmployeePanel;
        private ChapeauStyle.FlatButton btnAddEmployeePanel;
        private ChapeauStyle.FlatButton btnEditMenuPanel;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Panel pnlEditMenu;
        private System.Windows.Forms.Panel pnlRemoveEmployee;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbStock;
        private ChapeauStyle.MainLabel lblName;
        private ChapeauStyle.MainLabel lblStock;
        private System.Windows.Forms.ListView lvwItemOverview;
        private ChapeauStyle.FlatButton btnCancelMenu;
        private ChapeauStyle.FlatButton btnChangeMenu;
        private System.Windows.Forms.TableLayoutPanel tblFields;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbConPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbPosition;
        private System.Windows.Forms.TextBox txbLastName;
        private ChapeauStyle.MainLabel lblConPassword;
        private ChapeauStyle.MainLabel lblPassword;
        private ChapeauStyle.MainLabel lblEmail;
        private ChapeauStyle.MainLabel lblID;
        private ChapeauStyle.MainLabel lblPosition;
        private ChapeauStyle.MainLabel lblLastName;
        private ChapeauStyle.MainLabel lblFirstName;
        private ChapeauStyle.FlatButton btnAddEmployee;
        private ChapeauStyle.FlatButton btnCancelEmployee;
        private System.Windows.Forms.ListView lvwEmployeeOverview;
        private ChapeauStyle.FlatButton btnRemoveEmployee;
    }
}