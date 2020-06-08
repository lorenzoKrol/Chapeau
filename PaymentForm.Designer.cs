namespace ChapeauUI {
    partial class PaymentForm {
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
            this.rbnCash = new System.Windows.Forms.RadioButton();
            this.rbnDebitCard = new System.Windows.Forms.RadioButton();
            this.rbnIDeal = new System.Windows.Forms.RadioButton();
            this.picCash = new System.Windows.Forms.PictureBox();
            this.picDebitCard = new System.Windows.Forms.PictureBox();
            this.picIDeal = new System.Windows.Forms.PictureBox();
            this.lvwItemOverview = new System.Windows.Forms.ListView();
            this.btnTip = new ChapeauStyle.FlatButton();
            this.btnFeedback = new ChapeauStyle.FlatButton();
            this.btnCancel = new ChapeauStyle.FlatButton();
            this.btnPay = new ChapeauStyle.FlatButton();
            this.txbTipBox = new System.Windows.Forms.TextBox();
            this.btnEnter = new ChapeauStyle.FlatButton();
            this.txbFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit = new ChapeauStyle.FlatButton();
            this.tblAmount = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotal = new ChapeauStyle.MainLabel();
            this.lblTotalText = new ChapeauStyle.MainLabel();
            this.lblTip = new ChapeauStyle.MainLabel();
            this.lblTipText = new ChapeauStyle.MainLabel();
            this.lblVAT = new ChapeauStyle.MainLabel();
            this.lblVATText = new ChapeauStyle.MainLabel();
            this.lblSubTotal = new ChapeauStyle.MainLabel();
            this.lblSubTotalText = new ChapeauStyle.MainLabel();
            this.tblOptions = new System.Windows.Forms.TableLayoutPanel();
            this.tblPaymentMethods = new System.Windows.Forms.TableLayoutPanel();
            this.lblPay = new ChapeauStyle.MainLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebitCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIDeal)).BeginInit();
            this.tblAmount.SuspendLayout();
            this.tblOptions.SuspendLayout();
            this.tblPaymentMethods.SuspendLayout();
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
            // rbnCash
            // 
            this.rbnCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnCash.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnCash.AutoSize = true;
            this.rbnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.rbnCash.FlatAppearance.BorderSize = 0;
            this.rbnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnCash.Location = new System.Drawing.Point(3, 71);
            this.rbnCash.Name = "rbnCash";
            this.rbnCash.Size = new System.Drawing.Size(270, 28);
            this.rbnCash.TabIndex = 5;
            this.rbnCash.Text = "Cash";
            this.rbnCash.UseVisualStyleBackColor = false;
            // 
            // rbnDebitCard
            // 
            this.rbnDebitCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnDebitCard.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnDebitCard.AutoSize = true;
            this.rbnDebitCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.rbnDebitCard.FlatAppearance.BorderSize = 0;
            this.rbnDebitCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnDebitCard.Location = new System.Drawing.Point(3, 105);
            this.rbnDebitCard.Name = "rbnDebitCard";
            this.rbnDebitCard.Size = new System.Drawing.Size(270, 28);
            this.rbnDebitCard.TabIndex = 6;
            this.rbnDebitCard.Text = "Debit Card";
            this.rbnDebitCard.UseVisualStyleBackColor = false;
            // 
            // rbnIDeal
            // 
            this.rbnIDeal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnIDeal.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbnIDeal.AutoSize = true;
            this.rbnIDeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.rbnIDeal.FlatAppearance.BorderSize = 0;
            this.rbnIDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbnIDeal.Location = new System.Drawing.Point(3, 139);
            this.rbnIDeal.Name = "rbnIDeal";
            this.rbnIDeal.Size = new System.Drawing.Size(270, 31);
            this.rbnIDeal.TabIndex = 7;
            this.rbnIDeal.Text = "IDeal";
            this.rbnIDeal.UseVisualStyleBackColor = false;
            // 
            // picCash
            // 
            this.picCash.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCash.Image = global::ChapeauUI.Properties.Resources.ChapeauCash;
            this.picCash.Location = new System.Drawing.Point(276, 68);
            this.picCash.Margin = new System.Windows.Forms.Padding(0);
            this.picCash.Name = "picCash";
            this.picCash.Size = new System.Drawing.Size(51, 34);
            this.picCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCash.TabIndex = 9;
            this.picCash.TabStop = false;
            // 
            // picDebitCard
            // 
            this.picDebitCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picDebitCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picDebitCard.Image = global::ChapeauUI.Properties.Resources.ChapeauIDeal;
            this.picDebitCard.Location = new System.Drawing.Point(276, 102);
            this.picDebitCard.Margin = new System.Windows.Forms.Padding(0);
            this.picDebitCard.Name = "picDebitCard";
            this.picDebitCard.Size = new System.Drawing.Size(51, 34);
            this.picDebitCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDebitCard.TabIndex = 10;
            this.picDebitCard.TabStop = false;
            // 
            // picIDeal
            // 
            this.picIDeal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picIDeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picIDeal.Image = global::ChapeauUI.Properties.Resources.ChapeauMaestro;
            this.picIDeal.Location = new System.Drawing.Point(276, 136);
            this.picIDeal.Margin = new System.Windows.Forms.Padding(0);
            this.picIDeal.Name = "picIDeal";
            this.picIDeal.Size = new System.Drawing.Size(51, 37);
            this.picIDeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIDeal.TabIndex = 11;
            this.picIDeal.TabStop = false;
            // 
            // lvwItemOverview
            // 
            this.lvwItemOverview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvwItemOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwItemOverview.FullRowSelect = true;
            this.lvwItemOverview.GridLines = true;
            this.lvwItemOverview.Location = new System.Drawing.Point(22, 92);
            this.lvwItemOverview.MultiSelect = false;
            this.lvwItemOverview.Name = "lvwItemOverview";
            this.lvwItemOverview.Size = new System.Drawing.Size(360, 308);
            this.lvwItemOverview.TabIndex = 14;
            this.lvwItemOverview.UseCompatibleStateImageBehavior = false;
            // 
            // btnTip
            // 
            this.btnTip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.btnTip.FlatAppearance.BorderSize = 0;
            this.btnTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTip.Location = new System.Drawing.Point(4, 4);
            this.btnTip.Margin = new System.Windows.Forms.Padding(4);
            this.btnTip.Name = "btnTip";
            this.btnTip.Size = new System.Drawing.Size(155, 42);
            this.btnTip.TabIndex = 15;
            this.btnTip.Text = "Tip";
            this.btnTip.UseVisualStyleBackColor = false;
            this.btnTip.Click += new System.EventHandler(this.btnTip_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(167, 4);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(156, 42);
            this.btnFeedback.TabIndex = 16;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(91)))), ((int)(((byte)(105)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(4, 54);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 42);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(167, 54);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(156, 42);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txbTipBox
            // 
            this.txbTipBox.Location = new System.Drawing.Point(492, 352);
            this.txbTipBox.Margin = new System.Windows.Forms.Padding(2);
            this.txbTipBox.Multiline = true;
            this.txbTipBox.Name = "txbTipBox";
            this.txbTipBox.Size = new System.Drawing.Size(155, 24);
            this.txbTipBox.TabIndex = 21;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(492, 380);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(155, 34);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txbFeedback
            // 
            this.txbFeedback.Location = new System.Drawing.Point(655, 291);
            this.txbFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.txbFeedback.Multiline = true;
            this.txbFeedback.Name = "txbFeedback";
            this.txbFeedback.Size = new System.Drawing.Size(161, 85);
            this.txbFeedback.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(655, 380);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(161, 34);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tblAmount
            // 
            this.tblAmount.BackColor = System.Drawing.SystemColors.Control;
            this.tblAmount.ColumnCount = 2;
            this.tblAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAmount.Controls.Add(this.lblTotal, 1, 3);
            this.tblAmount.Controls.Add(this.lblTotalText, 0, 3);
            this.tblAmount.Controls.Add(this.lblTip, 1, 2);
            this.tblAmount.Controls.Add(this.lblTipText, 0, 2);
            this.tblAmount.Controls.Add(this.lblVAT, 1, 1);
            this.tblAmount.Controls.Add(this.lblVATText, 0, 1);
            this.tblAmount.Controls.Add(this.lblSubTotal, 1, 0);
            this.tblAmount.Controls.Add(this.lblSubTotalText, 0, 0);
            this.tblAmount.Location = new System.Drawing.Point(23, 411);
            this.tblAmount.Name = "tblAmount";
            this.tblAmount.RowCount = 4;
            this.tblAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAmount.Size = new System.Drawing.Size(359, 130);
            this.tblAmount.TabIndex = 29;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(274, 101);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 22);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalText
            // 
            this.lblTotalText.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Location = new System.Drawing.Point(5, 101);
            this.lblTotalText.Margin = new System.Windows.Forms.Padding(5);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(243, 22);
            this.lblTotalText.TabIndex = 6;
            this.lblTotalText.Text = "Total";
            this.lblTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTip
            // 
            this.lblTip.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(274, 69);
            this.lblTip.Margin = new System.Windows.Forms.Padding(5);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(75, 21);
            this.lblTip.TabIndex = 5;
            this.lblTip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipText
            // 
            this.lblTipText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipText.Location = new System.Drawing.Point(5, 69);
            this.lblTipText.Margin = new System.Windows.Forms.Padding(5);
            this.lblTipText.Name = "lblTipText";
            this.lblTipText.Size = new System.Drawing.Size(243, 21);
            this.lblTipText.TabIndex = 4;
            this.lblTipText.Text = "Tip";
            this.lblTipText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVAT
            // 
            this.lblVAT.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(274, 37);
            this.lblVAT.Margin = new System.Windows.Forms.Padding(5);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(75, 21);
            this.lblVAT.TabIndex = 3;
            this.lblVAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVATText
            // 
            this.lblVATText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVATText.Location = new System.Drawing.Point(5, 37);
            this.lblVATText.Margin = new System.Windows.Forms.Padding(5);
            this.lblVATText.Name = "lblVATText";
            this.lblVATText.Size = new System.Drawing.Size(243, 21);
            this.lblVATText.TabIndex = 2;
            this.lblVATText.Text = "VAT";
            this.lblVATText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(274, 5);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(75, 21);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotalText
            // 
            this.lblSubTotalText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalText.Location = new System.Drawing.Point(5, 5);
            this.lblSubTotalText.Margin = new System.Windows.Forms.Padding(5);
            this.lblSubTotalText.Name = "lblSubTotalText";
            this.lblSubTotalText.Size = new System.Drawing.Size(243, 21);
            this.lblSubTotalText.TabIndex = 0;
            this.lblSubTotalText.Text = "Sub-total";
            this.lblSubTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblOptions
            // 
            this.tblOptions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblOptions.ColumnCount = 2;
            this.tblOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOptions.Controls.Add(this.btnTip, 0, 0);
            this.tblOptions.Controls.Add(this.btnCancel, 0, 1);
            this.tblOptions.Controls.Add(this.btnFeedback, 1, 0);
            this.tblOptions.Controls.Add(this.btnPay, 1, 1);
            this.tblOptions.Location = new System.Drawing.Point(493, 441);
            this.tblOptions.Name = "tblOptions";
            this.tblOptions.RowCount = 2;
            this.tblOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblOptions.Size = new System.Drawing.Size(327, 100);
            this.tblOptions.TabIndex = 30;
            // 
            // tblPaymentMethods
            // 
            this.tblPaymentMethods.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tblPaymentMethods.ColumnCount = 2;
            this.tblPaymentMethods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.58334F));
            this.tblPaymentMethods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.41667F));
            this.tblPaymentMethods.Controls.Add(this.rbnCash, 0, 2);
            this.tblPaymentMethods.Controls.Add(this.rbnDebitCard, 0, 3);
            this.tblPaymentMethods.Controls.Add(this.rbnIDeal, 0, 4);
            this.tblPaymentMethods.Controls.Add(this.picCash, 1, 2);
            this.tblPaymentMethods.Controls.Add(this.picDebitCard, 1, 3);
            this.tblPaymentMethods.Controls.Add(this.picIDeal, 1, 4);
            this.tblPaymentMethods.Controls.Add(this.lblPay, 0, 0);
            this.tblPaymentMethods.Location = new System.Drawing.Point(493, 92);
            this.tblPaymentMethods.Name = "tblPaymentMethods";
            this.tblPaymentMethods.RowCount = 5;
            this.tblPaymentMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentMethods.Size = new System.Drawing.Size(327, 173);
            this.tblPaymentMethods.TabIndex = 31;
            // 
            // lblPay
            // 
            this.lblPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPay.AutoSize = true;
            this.lblPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.tblPaymentMethods.SetColumnSpan(this.lblPay, 2);
            this.lblPay.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(5, 5);
            this.lblPay.Margin = new System.Windows.Forms.Padding(5);
            this.lblPay.Name = "lblPay";
            this.tblPaymentMethods.SetRowSpan(this.lblPay, 2);
            this.lblPay.Size = new System.Drawing.Size(317, 58);
            this.lblPay.TabIndex = 12;
            this.lblPay.Text = "Pay";
            this.lblPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.tblPaymentMethods);
            this.Controls.Add(this.tblOptions);
            this.Controls.Add(this.tblAmount);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbFeedback);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txbTipBox);
            this.Controls.Add(this.lvwItemOverview);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(957, 592);
            this.Name = "PaymentForm";
            this.Text = "Chapeau Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.Controls.SetChildIndex(this.lvwItemOverview, 0);
            this.Controls.SetChildIndex(this.txbTipBox, 0);
            this.Controls.SetChildIndex(this.btnEnter, 0);
            this.Controls.SetChildIndex(this.txbFeedback, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.tblAmount, 0);
            this.Controls.SetChildIndex(this.tblOptions, 0);
            this.Controls.SetChildIndex(this.tblPaymentMethods, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDebitCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIDeal)).EndInit();
            this.tblAmount.ResumeLayout(false);
            this.tblOptions.ResumeLayout(false);
            this.tblPaymentMethods.ResumeLayout(false);
            this.tblPaymentMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.RadioButton rbnCash;
        private System.Windows.Forms.RadioButton rbnDebitCard;
        private System.Windows.Forms.RadioButton rbnIDeal;
        private System.Windows.Forms.PictureBox picCash;
        private System.Windows.Forms.PictureBox picDebitCard;
        private System.Windows.Forms.PictureBox picIDeal;
        private System.Windows.Forms.ListView lvwItemOverview;
        private ChapeauStyle.FlatButton btnTip;
        private ChapeauStyle.FlatButton btnFeedback;
        private ChapeauStyle.FlatButton btnCancel;
        private ChapeauStyle.FlatButton btnPay;
        private System.Windows.Forms.TextBox txbTipBox;
        private ChapeauStyle.FlatButton btnEnter;
        private System.Windows.Forms.TextBox txbFeedback;
        private ChapeauStyle.FlatButton btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tblAmount;
        private ChapeauStyle.MainLabel lblTotal;
        private ChapeauStyle.MainLabel lblTotalText;
        private ChapeauStyle.MainLabel lblTip;
        private ChapeauStyle.MainLabel lblTipText;
        private ChapeauStyle.MainLabel lblVAT;
        private ChapeauStyle.MainLabel lblVATText;
        private ChapeauStyle.MainLabel lblSubTotal;
        private ChapeauStyle.MainLabel lblSubTotalText;
        private System.Windows.Forms.TableLayoutPanel tblOptions;
        private System.Windows.Forms.TableLayoutPanel tblPaymentMethods;
        private ChapeauStyle.MainLabel lblPay;
    }
}