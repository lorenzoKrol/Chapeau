namespace ChapeauUI {
    partial class KitchenForm {
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
            this.pnlKitchenOverview = new System.Windows.Forms.Panel();
            this.btnUpdate = new ChapeauStyle.FlatButton();
            this.btnReady = new ChapeauStyle.FlatButton();
            this.lvwItemOverview = new System.Windows.Forms.ListView();
            this.pnlKitchenOverview.SuspendLayout();
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
            // pnlKitchenOverview
            // 
            this.pnlKitchenOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlKitchenOverview.Controls.Add(this.btnUpdate);
            this.pnlKitchenOverview.Controls.Add(this.btnReady);
            this.pnlKitchenOverview.Controls.Add(this.lvwItemOverview);
            this.pnlKitchenOverview.Location = new System.Drawing.Point(-2, 77);
            this.pnlKitchenOverview.Name = "pnlKitchenOverview";
            this.pnlKitchenOverview.Size = new System.Drawing.Size(950, 491);
            this.pnlKitchenOverview.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(755, 327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 46);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(216)))), ((int)(((byte)(190)))));
            this.btnReady.FlatAppearance.BorderSize = 0;
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(755, 384);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(118, 46);
            this.btnReady.TabIndex = 4;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lvwItemOverview
            // 
            this.lvwItemOverview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvwItemOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwItemOverview.FullRowSelect = true;
            this.lvwItemOverview.GridLines = true;
            this.lvwItemOverview.Location = new System.Drawing.Point(71, 49);
            this.lvwItemOverview.MultiSelect = false;
            this.lvwItemOverview.Name = "lvwItemOverview";
            this.lvwItemOverview.Size = new System.Drawing.Size(654, 381);
            this.lvwItemOverview.TabIndex = 3;
            this.lvwItemOverview.UseCompatibleStateImageBehavior = false;
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.pnlKitchenOverview);
            this.Name = "KitchenForm";
            this.Text = "KitchenForm";
            this.Load += new System.EventHandler(this.KitchenForm_Load);
            this.Shown += new System.EventHandler(this.KitchenForm_Shown);
            this.Controls.SetChildIndex(this.pnlKitchenOverview, 0);
            this.pnlKitchenOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKitchenOverview;
        private System.Windows.Forms.ListView lvwItemOverview;
        private ChapeauStyle.FlatButton btnReady;
        private ChapeauStyle.FlatButton btnUpdate;
    }
}