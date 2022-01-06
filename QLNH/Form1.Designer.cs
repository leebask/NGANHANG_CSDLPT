
namespace QLNH
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTransactionWithdraw = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAccount = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.update = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.customer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.employee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.transferTransaction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.withdrawTransaction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statistic = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.statisticAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statisticCustomer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_Group = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonEmployee,
            this.barButtonItem1,
            this.barButtonCustomer,
            this.barButtonTransactionWithdraw,
            this.barButtonAccount,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.update,
            this.statistic,
            this.ribbonPage2});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.barButtonItem9);
            this.ribbonControl1.Size = new System.Drawing.Size(1270, 158);
            // 
            // barButtonEmployee
            // 
            this.barButtonEmployee.Caption = "Nhân viên";
            this.barButtonEmployee.Id = 4;
            this.barButtonEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonEmployee.ImageOptions.Image")));
            this.barButtonEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonEmployee.ImageOptions.LargeImage")));
            this.barButtonEmployee.Name = "barButtonEmployee";
            this.barButtonEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonCustomer
            // 
            this.barButtonCustomer.Caption = "Khách hàng";
            this.barButtonCustomer.Id = 6;
            this.barButtonCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonCustomer.ImageOptions.Image")));
            this.barButtonCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonCustomer.ImageOptions.LargeImage")));
            this.barButtonCustomer.Name = "barButtonCustomer";
            this.barButtonCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCustomer_ItemClick);
            // 
            // barButtonTransactionWithdraw
            // 
            this.barButtonTransactionWithdraw.Caption = "Giao dịch gửi rút";
            this.barButtonTransactionWithdraw.Id = 7;
            this.barButtonTransactionWithdraw.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonTransactionWithdraw.ImageOptions.SvgImage")));
            this.barButtonTransactionWithdraw.Name = "barButtonTransactionWithdraw";
            this.barButtonTransactionWithdraw.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTransactionWithdraw_ItemClick);
            // 
            // barButtonAccount
            // 
            this.barButtonAccount.Caption = "Tài khoản";
            this.barButtonAccount.Id = 8;
            this.barButtonAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonAccount.ImageOptions.Image")));
            this.barButtonAccount.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonAccount.ImageOptions.LargeImage")));
            this.barButtonAccount.Name = "barButtonAccount";
            this.barButtonAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAccount_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đăng xuất";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Tìm NV";
            this.barButtonItem3.Id = 11;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Chuyển NV";
            this.barButtonItem4.Id = 15;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Chuyển tiền";
            this.barButtonItem5.Id = 16;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Giao dịch";
            this.barButtonItem6.Id = 17;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Khách hàng";
            this.barButtonItem7.Id = 18;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Tài khoản";
            this.barButtonItem8.Id = 19;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Đăng xuất";
            this.barButtonItem9.Id = 20;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // update
            // 
            this.update.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.customer,
            this.ribbonPageGroup1,
            this.employee,
            this.transferTransaction,
            this.withdrawTransaction,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4});
            this.update.Name = "update";
            this.update.Text = "Cập nhật";
            // 
            // customer
            // 
            this.customer.ItemLinks.Add(this.barButtonCustomer);
            this.customer.Name = "customer";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonAccount);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // employee
            // 
            this.employee.ItemLinks.Add(this.barButtonEmployee);
            this.employee.Name = "employee";
            // 
            // transferTransaction
            // 
            this.transferTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("transferTransaction.ImageOptions.Image")));
            this.transferTransaction.ItemLinks.Add(this.barButtonItem4);
            this.transferTransaction.Name = "transferTransaction";
            // 
            // withdrawTransaction
            // 
            this.withdrawTransaction.ItemLinks.Add(this.barButtonTransactionWithdraw);
            this.withdrawTransaction.Name = "withdrawTransaction";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup4.ImageOptions.Image")));
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // statistic
            // 
            this.statistic.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.statisticAccount,
            this.statisticCustomer,
            this.ribbonPageGroup6});
            this.statistic.Name = "statistic";
            this.statistic.Text = "Liệt kê - Thống kê";
            // 
            // statisticAccount
            // 
            this.statisticAccount.ItemLinks.Add(this.barButtonItem8);
            this.statisticAccount.Name = "statisticAccount";
            // 
            // statisticCustomer
            // 
            this.statisticCustomer.ItemLinks.Add(this.barButtonItem7);
            this.statisticCustomer.Name = "statisticCustomer";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_ID,
            this.statusLabel_Name,
            this.statusLabel_Group});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1270, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel_ID
            // 
            this.statusLabel_ID.Name = "statusLabel_ID";
            this.statusLabel_ID.Size = new System.Drawing.Size(18, 17);
            this.statusLabel_ID.Text = "ID";
            // 
            // statusLabel_Name
            // 
            this.statusLabel_Name.Name = "statusLabel_Name";
            this.statusLabel_Name.Size = new System.Drawing.Size(39, 17);
            this.statusLabel_Name.Text = "Name";
            // 
            // statusLabel_Group
            // 
            this.statusLabel_Group.Name = "statusLabel_Group";
            this.statusLabel_Group.Size = new System.Drawing.Size(40, 17);
            this.statusLabel_Group.Text = "Group";
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 688);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage update;
        private DevExpress.XtraBars.Ribbon.RibbonPage statistic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup statisticAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup employee;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup transferTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup withdrawTransaction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup statisticCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarButtonItem barButtonEmployee;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup customer;
        private DevExpress.XtraBars.BarButtonItem barButtonCustomer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_ID;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_Name;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_Group;
        private DevExpress.XtraBars.BarButtonItem barButtonTransactionWithdraw;
        private DevExpress.XtraBars.BarButtonItem barButtonAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
    }
}

