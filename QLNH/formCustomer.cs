using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class FormCustomer : DevExpress.XtraEditors.XtraForm
    {
        private int index = 0;
        string mcn = "";
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
            string mcn = "";
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet.TaiKhoan);
            mcn = ((DataRowView)taiKhoanBindingSource[0])["MACN"].ToString();
            comboBox1.DataSource = Program.bds_dspm;
            comboBox1.DisplayMember = "TENCHINHANH";
            comboBox1.ValueMember = "TENSERVER";
            comboBox1.SelectedIndex = Program.mChinhanh; //hiện chi nhánh
            if (Program.m_group == "NGANHANG")
            {
                comboBox1.Enabled = true;
                barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = barButtonItem4.Enabled = barButtonItem5.Enabled= button3.Enabled = false;
            }
            else comboBox1.Enabled = false;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = khachHangBindingSource.Position;

            khachHangBindingSource.AddNew();
            mACNTextEdit.Text = ((DataRowView)Program.bds_dspm[Program.m_subscribes])["MACN"].ToString();
            nGAYCAPDateEdit.DateTime = DateTime.Today;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                Program.servername = comboBox1.SelectedValue.ToString();

            }
            if (comboBox1.SelectedIndex != Program.mChinhanh)
            {
                Program.m_login = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.m_login = Program.m_loginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.GetConnection() == 0)
            {
                MessageBox.Show("Lỗi chuyển chi nhánh", "Thông báo !", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    nGANHANGDataSet.EnforceConstraints = false;
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);

                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet.TaiKhoan);

                   

                    mcn = ((DataRowView)taiKhoanBindingSource[0])["MACN"].ToString().Trim();

                }
                catch (Exception) { }
            }
            }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
                MessageBox.Show("    Đã Reload!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload : " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khachHangBindingSource.CancelEdit();
            if (barButtonItem1.Enabled == false) khachHangBindingSource.Position = index;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                khachHangBindingSource.EndEdit();
                khachHangBindingSource.ResetCurrentItem();
                khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                khachHangTableAdapter.Update(this.nGANHANGDataSet.KhachHang);
                khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khách hàng.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            index = khachHangBindingSource.Position;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void khachHangGridControl_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet.TaiKhoan);
            panelControl5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                taiKhoanBindingSource.EndEdit();
                taiKhoanBindingSource.ResetCurrentItem();
                taiKhoanTableAdapter.Connection.ConnectionString = Program.connectStr;
                taiKhoanTableAdapter.Update(this.nGANHANGDataSet.TaiKhoan);
                panelControl5.Enabled = false;
                MessageBox.Show("Đã mở tài khoản\n", "", MessageBoxButtons.OK);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm tài khoản!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void mACNTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mACNTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            panelControl5.Enabled = true;
            taiKhoanBindingSource.AddNew();
            tRANGTHAIXOAComboBox1.Text = "0";
            ngayMoTKDateEdit.DateTime = DateTime.Today;
            mACNTextEdit1.Text = ((DataRowView)Program.bds_dspm[Program.m_subscribes])["MACN"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Khônng thể thêm tài khoản!\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void ngayMoTKDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ngayMoTKLabel_Click(object sender, EventArgs e)
        {

        }

        private void cMNDTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}