namespace ChapeauUI {
    partial class OrderForm {
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
            this.components = new System.ComponentModel.Container();
            this.fpnlTables = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTableOverview = new System.Windows.Forms.Panel();
            this.pnlMenuOverview = new System.Windows.Forms.Panel();
            this.tblOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnComment = new ChapeauStyle.FlatButton();
            this.btnSend = new ChapeauStyle.FlatButton();
            this.btnPayment = new ChapeauStyle.FlatButton();
            this.btnIncrement = new ChapeauStyle.FlatButton();
            this.btnDecrement = new ChapeauStyle.FlatButton();
            this.btnCancel = new ChapeauStyle.FlatButton();
            this.tblComment = new System.Windows.Forms.TableLayoutPanel();
            this.txbComment = new System.Windows.Forms.TextBox();
            this.btnAddComment = new ChapeauStyle.FlatButton();
            this.btnCancelComment = new ChapeauStyle.FlatButton();
            this.lvwItemOverview = new System.Windows.Forms.ListView();
            this.fpnlMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrReloadTables = new System.Windows.Forms.Timer(this.components);
            this.pnlTableOverview.SuspendLayout();
            this.pnlMenuOverview.SuspendLayout();
            this.tblOptions.SuspendLayout();
            this.tblComment.SuspendLayout();
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
            // fpnlTables
            // 
            this.fpnlTables.AutoScroll = true;
            this.fpnlTables.BackColor = System.Drawing.SystemColors.Control;
            this.fpnlTables.Location = new System.Drawing.Point(79, 81);
            this.fpnlTables.Name = "fpnlTables";
            this.fpnlTables.Size = new System.Drawing.Size(782, 317);
            this.fpnlTables.TabIndex = 1;
            // 
            // pnlTableOverview
            // 
            this.pnlTableOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTableOverview.Controls.Add(this.fpnlTables);
            this.pnlTableOverview.Location = new System.Drawing.Point(-2, 77);
            this.pnlTableOverview.Name = "pnlTableOverview";
            this.pnlTableOverview.Size = new System.Drawing.Size(950, 491);
            this.pnlTableOverview.TabIndex = 2;
            // 
            // pnlMenuOverview
            // 
            this.pnlMenuOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenuOverview.Controls.Add(this.tblOptions);
            this.pnlMenuOverview.Controls.Add(this.tblComment);
            this.pnlMenuOverview.Controls.Add(this.lvwItemOverview);
            this.pnlMenuOverview.Controls.Add(this.fpnlMenuItems);
            this.pnlMenuOverview.Controls.Add(this.fpnlCategories);
            this.pnlMenuOverview.Location = new System.Drawing.Point(-2, 77);
            this.pnlMenuOverview.Name = "pnlMenuOverview";
            this.pnlMenuOverview.Size = new System.Drawing.Size(950, 490);
            this.pnlMenuOverview.TabIndex = 3;
            // 
            // tblOptions
            // 
            this.tblOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tblOptions.ColumnCount = 3;
            this.tblOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOptions.Controls.Add(this.btnComment, 0, 1);
            this.tblOptions.Controls.Add(this.btnSend, 2, 1);
            this.tblOptions.Controls.Add(this.btnPayment, 2, 0);
            this.tblOptions.Controls.Add(this.btnIncrement, 0, 0);
            this.tblOptions.Controls.Add(this.btnDecrement, 1, 0);
            this.tblOptions.Controls.Add(this.btnCancel, 1, 1);
            this.tblOptions.Location = new System.Drawing.Point(489, 351);
            this.tblOptions.Name = "tblOptions";
            this.tblOptions.Padding = new System.Windows.Forms.Padding(5);
            this.tblOptions.RowCount = 2;
            this.tblOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblOptions.Size = new System.Drawing.Size(445, 121);
            this.tblOptions.TabIndex = 3;
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.btnComment.FlatAppearance.BorderSize = 0;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Location = new System.Drawing.Point(8, 63);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(102, 49);
            this.btnComment.TabIndex = 6;
            this.btnComment.Text = "Comment";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(225, 63);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(211, 49);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(225, 8);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(211, 48);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.btnIncrement.FlatAppearance.BorderSize = 0;
            this.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrement.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrement.Location = new System.Drawing.Point(8, 8);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(102, 49);
            this.btnIncrement.TabIndex = 4;
            this.btnIncrement.Text = "+";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.btnDecrement.FlatAppearance.BorderSize = 0;
            this.btnDecrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrement.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrement.Location = new System.Drawing.Point(116, 8);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(102, 49);
            this.btnDecrement.TabIndex = 5;
            this.btnDecrement.Text = "-";
            this.btnDecrement.UseVisualStyleBackColor = false;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(116, 63);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 49);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblComment
            // 
            this.tblComment.BackColor = System.Drawing.SystemColors.Control;
            this.tblComment.ColumnCount = 4;
            this.tblComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblComment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblComment.Controls.Add(this.txbComment, 0, 0);
            this.tblComment.Controls.Add(this.btnAddComment, 2, 0);
            this.tblComment.Controls.Add(this.btnCancelComment, 3, 0);
            this.tblComment.Location = new System.Drawing.Point(489, 414);
            this.tblComment.Name = "tblComment";
            this.tblComment.RowCount = 1;
            this.tblComment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblComment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblComment.Size = new System.Drawing.Size(445, 58);
            this.tblComment.TabIndex = 4;
            // 
            // txbComment
            // 
            this.tblComment.SetColumnSpan(this.txbComment, 2);
            this.txbComment.Location = new System.Drawing.Point(5, 5);
            this.txbComment.Margin = new System.Windows.Forms.Padding(5);
            this.txbComment.Multiline = true;
            this.txbComment.Name = "txbComment";
            this.txbComment.Size = new System.Drawing.Size(212, 48);
            this.txbComment.TabIndex = 0;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnAddComment.FlatAppearance.BorderSize = 0;
            this.btnAddComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComment.Location = new System.Drawing.Point(225, 4);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(105, 49);
            this.btnAddComment.TabIndex = 4;
            this.btnAddComment.Text = "Add";
            this.btnAddComment.UseVisualStyleBackColor = false;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnCancelComment
            // 
            this.btnCancelComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.btnCancelComment.FlatAppearance.BorderSize = 0;
            this.btnCancelComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelComment.Location = new System.Drawing.Point(338, 4);
            this.btnCancelComment.Name = "btnCancelComment";
            this.btnCancelComment.Size = new System.Drawing.Size(102, 49);
            this.btnCancelComment.TabIndex = 2;
            this.btnCancelComment.Text = "Cancel";
            this.btnCancelComment.UseVisualStyleBackColor = false;
            this.btnCancelComment.Click += new System.EventHandler(this.btnCancelComment_Click);
            // 
            // lvwItemOverview
            // 
            this.lvwItemOverview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvwItemOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwItemOverview.FullRowSelect = true;
            this.lvwItemOverview.GridLines = true;
            this.lvwItemOverview.Location = new System.Drawing.Point(489, 21);
            this.lvwItemOverview.MultiSelect = false;
            this.lvwItemOverview.Name = "lvwItemOverview";
            this.lvwItemOverview.Size = new System.Drawing.Size(445, 308);
            this.lvwItemOverview.TabIndex = 2;
            this.lvwItemOverview.UseCompatibleStateImageBehavior = false;
            // 
            // fpnlMenuItems
            // 
            this.fpnlMenuItems.AutoScroll = true;
            this.fpnlMenuItems.BackColor = System.Drawing.SystemColors.Control;
            this.fpnlMenuItems.Location = new System.Drawing.Point(331, 21);
            this.fpnlMenuItems.Name = "fpnlMenuItems";
            this.fpnlMenuItems.Size = new System.Drawing.Size(138, 451);
            this.fpnlMenuItems.TabIndex = 1;
            // 
            // fpnlCategories
            // 
            this.fpnlCategories.AutoScroll = true;
            this.fpnlCategories.BackColor = System.Drawing.SystemColors.Control;
            this.fpnlCategories.Location = new System.Drawing.Point(14, 21);
            this.fpnlCategories.Name = "fpnlCategories";
            this.fpnlCategories.Size = new System.Drawing.Size(300, 451);
            this.fpnlCategories.TabIndex = 0;
            // 
            // tmrReloadTables
            // 
            this.tmrReloadTables.Enabled = true;
            this.tmrReloadTables.Interval = 5000;
            this.tmrReloadTables.Tick += new System.EventHandler(this.tmrReloadTables_Tick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.pnlTableOverview);
            this.Controls.Add(this.pnlMenuOverview);
            this.MinimumSize = new System.Drawing.Size(958, 594);
            this.Name = "OrderForm";
            this.Text = "Chapeau Order";
            this.Shown += new System.EventHandler(this.OrderForm_Shown);
            this.Controls.SetChildIndex(this.pnlMenuOverview, 0);
            this.Controls.SetChildIndex(this.pnlTableOverview, 0);
            this.pnlTableOverview.ResumeLayout(false);
            this.pnlMenuOverview.ResumeLayout(false);
            this.tblOptions.ResumeLayout(false);
            this.tblComment.ResumeLayout(false);
            this.tblComment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlTables;
        private System.Windows.Forms.Panel pnlTableOverview;
        private System.Windows.Forms.Panel pnlMenuOverview;
        private System.Windows.Forms.FlowLayoutPanel fpnlMenuItems;
        private System.Windows.Forms.FlowLayoutPanel fpnlCategories;
        private System.Windows.Forms.ListView lvwItemOverview;
        private System.Windows.Forms.TableLayoutPanel tblOptions;
        private ChapeauStyle.FlatButton btnSend;
        private ChapeauStyle.FlatButton btnCancel;
        private ChapeauStyle.FlatButton btnPayment;
        private ChapeauStyle.FlatButton btnIncrement;
        private ChapeauStyle.FlatButton btnDecrement;
        private System.Windows.Forms.Timer tmrReloadTables;
        private ChapeauStyle.FlatButton btnComment;
        private System.Windows.Forms.TableLayoutPanel tblComment;
        private ChapeauStyle.FlatButton btnCancelComment;
        private ChapeauStyle.FlatButton btnAddComment;
        private System.Windows.Forms.TextBox txbComment;
    }
}