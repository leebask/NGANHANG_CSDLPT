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
    public partial class FormAccount : DevExpress.XtraEditors.XtraForm
    {
        string macn = "";
        public FormAccount()
        {
            InitializeComponent();
        }

        private void buttonAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void FormAccount_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet.TaiKhoan);
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);

            macn = ((DataRowView)taiKhoanBindingSource[0])["MACN"].ToString();

            comboBox1.DataSource = Program.bds_dspm;
            comboBox1.DisplayMember = "TENCHINHANH";
            comboBox1.ValueMember = "TENSERVER";
            comboBox1.SelectedIndex = Program.mChinhanh; //hiện chi nhánh
            if (Program.m_group == "NGANHANG")
            {
                comboBox1.Enabled = true;
                
            }
            else comboBox1.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taiKhoanBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.taiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet.TaiKhoan);
                MessageBox.Show("    Đã Reload!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload : " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}