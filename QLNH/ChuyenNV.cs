using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH
{
    public partial class ChuyenNV : DevExpress.XtraEditors.XtraForm
    {
        public ChuyenNV()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void ChuyenNV_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);
            if (Program.m_group == "NGANHANG")
            {
                mANVTextEdit.Enabled = mACNTextBox.Enabled = btnChuyen.Enabled = false;
            }
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            String macn = mACNTextBox.Text;
            String manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString(); ;
            
            try
            { 
                string strLenh =  "DECLARE @return_value int " +"EXEC @return_value= [dbo].[SP_CHUYENCHINHANH_NV]" + "@MANV = " + manv + "," + "@MACN = "+ macn/*+ " "  + "SELECT 'Return Value' = @return_value" */;
                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                //read and take
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);

                MessageBox.Show("Đã chuyển nhân viên sang chi nhánh: "+macn, "", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
            /*string strLenh = "exec SP_CHUYENCHINHANH_NV '" + mANVTextEdit + "','" + mACNTextBox + "'";
            Program.reader = Program.ExecSqlDataReader(strLenh);
            if (Program.reader == null)
            {
                MessageBox.Show("Lỗi chuyển lớp,xin kiểm tra lại");
                return;
            }
            else
            {
                XtraMessageBox.Show("Chuyển Sinh Viên Qua Lớp " + mACNTextBox + " Thành Công", "INFO", MessageBoxButtons.OK);
                return;
            }*/
        }

        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}