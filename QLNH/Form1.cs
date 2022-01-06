using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNH
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void infoUser_Load(String id, String HovaTen, String group)
        {
            statusLabel_Group.Text = group;
            statusLabel_ID.Text = id;
            statusLabel_Name.Text = HovaTen;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
/*            login();*/
        }

        private void login()
        {
            Form frm = this.CheckExists(typeof(formLogin));
            if (frm != null) frm.Activate();
            else
            {
                formLogin f = new formLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormEmployee));
            if (frm != null) frm.Activate();
            else
            {
                FormEmployee f = new FormEmployee();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormCustomer));
            if (frm != null) frm.Activate();
            else
            {
                FormCustomer f = new FormCustomer();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonTransactionWithdraw_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(formTransactionWithdraw));
            if (frm != null) frm.Activate();
            else
            {
                formTransactionWithdraw f = new formTransactionWithdraw();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormAccount));
            if (frm != null) frm.Activate();
            else
            {
                FormAccount f = new FormAccount();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
            Program.f_login.Visible = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(TimNV));
            if (frm != null) frm.Activate();
            else
            {
                TimNV f = new TimNV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(ChuyenNV));
            if (frm != null) frm.Activate();
            else
            {
                ChuyenNV f = new ChuyenNV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Chuyentien));
            if (frm != null) frm.Activate();
            else
            {
                Chuyentien f = new Chuyentien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
            Program.f_login.Visible = true;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(FormReportKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                FormReportKhachHang f = new FormReportKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormReportKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                FormReportKhachHang f = new FormReportKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
