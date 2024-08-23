namespace OkkioCoffeeShop.Main
{
    partial class FrmAdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.tpDrink = new System.Windows.Forms.TabPage();
            this.tpTable = new System.Windows.Forms.TabPage();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.tcAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpCategory);
            this.tcAdmin.Controls.Add(this.tpDrink);
            this.tcAdmin.Controls.Add(this.tpTable);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(776, 426);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Location = new System.Drawing.Point(4, 25);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(768, 397);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Tổng doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // tpCategory
            // 
            this.tpCategory.Location = new System.Drawing.Point(4, 25);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tpCategory.Size = new System.Drawing.Size(768, 397);
            this.tpCategory.TabIndex = 1;
            this.tpCategory.Text = "Các loại đồ uống";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // tpDrink
            // 
            this.tpDrink.Location = new System.Drawing.Point(4, 25);
            this.tpDrink.Name = "tpDrink";
            this.tpDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tpDrink.Size = new System.Drawing.Size(768, 397);
            this.tpDrink.TabIndex = 2;
            this.tpDrink.Text = "Đồ uống";
            this.tpDrink.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            this.tpTable.Location = new System.Drawing.Point(4, 25);
            this.tpTable.Name = "tpTable";
            this.tpTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpTable.Size = new System.Drawing.Size(768, 397);
            this.tpTable.TabIndex = 3;
            this.tpTable.Text = "Đặt bàn";
            this.tpTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            this.tpAccount.Location = new System.Drawing.Point(4, 25);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(768, 397);
            this.tpAccount.TabIndex = 4;
            this.tpAccount.Text = "Quản lý tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // FrmAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAdmin);
            this.Name = "FrmAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.tcAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.TabPage tpDrink;
        private System.Windows.Forms.TabPage tpTable;
        private System.Windows.Forms.TabPage tpAccount;
    }
}