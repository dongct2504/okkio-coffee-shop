namespace OkkioCoffeeShop.Main
{
    partial class FrmAdminTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nmDrinkCount = new System.Windows.Forms.NumericUpDown();
            this.cboDrink = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboChangeTable = new System.Windows.Forms.ComboBox();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 263);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 257);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.tàiKhoảngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // tàiKhoảngToolStripMenuItem
            // 
            this.tàiKhoảngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPersonalInfo,
            this.logout});
            this.tàiKhoảngToolStripMenuItem.Name = "tàiKhoảngToolStripMenuItem";
            this.tàiKhoảngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.tàiKhoảngToolStripMenuItem.Text = "Tài khoản";
            // 
            // viewPersonalInfo
            // 
            this.viewPersonalInfo.Name = "viewPersonalInfo";
            this.viewPersonalInfo.Size = new System.Drawing.Size(241, 26);
            this.viewPersonalInfo.Text = "Xem thông tin cá nhân";
            this.viewPersonalInfo.Click += new System.EventHandler(this.viewPersonalInfo_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(241, 26);
            this.logout.Text = "Đăng xuất";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmDrinkCount);
            this.panel3.Controls.Add(this.cboDrink);
            this.panel3.Controls.Add(this.cboCategory);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 66);
            this.panel3.TabIndex = 1;
            // 
            // nmDrinkCount
            // 
            this.nmDrinkCount.Location = new System.Drawing.Point(270, 36);
            this.nmDrinkCount.Name = "nmDrinkCount";
            this.nmDrinkCount.Size = new System.Drawing.Size(100, 22);
            this.nmDrinkCount.TabIndex = 7;
            this.nmDrinkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboDrink
            // 
            this.cboDrink.FormattingEnabled = true;
            this.cboDrink.Location = new System.Drawing.Point(65, 36);
            this.cboDrink.Name = "cboDrink";
            this.cboDrink.Size = new System.Drawing.Size(189, 24);
            this.cboDrink.TabIndex = 6;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(65, 10);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(189, 24);
            this.cboCategory.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(270, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 24);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đồ uống";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thể loại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cboChangeTable);
            this.panel4.Controls.Add(this.btnChangeTable);
            this.panel4.Controls.Add(this.btnPayment);
            this.panel4.Location = new System.Drawing.Point(12, 372);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(385, 66);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cboChangeTable
            // 
            this.cboChangeTable.FormattingEnabled = true;
            this.cboChangeTable.Location = new System.Drawing.Point(270, 39);
            this.cboChangeTable.Name = "cboChangeTable";
            this.cboChangeTable.Size = new System.Drawing.Size(100, 24);
            this.cboChangeTable.TabIndex = 8;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Location = new System.Drawing.Point(270, 3);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(100, 24);
            this.btnChangeTable.TabIndex = 8;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(115, 3);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(103, 60);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(403, 31);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(385, 407);
            this.flpTable.TabIndex = 3;
            // 
            // FrmAdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAdminTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt bàn";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem logout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDrink;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nmDrinkCount;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ComboBox cboChangeTable;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Button btnPayment;
    }
}