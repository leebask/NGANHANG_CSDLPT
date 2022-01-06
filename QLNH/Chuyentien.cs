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
    public partial class Chuyentien : DevExpress.XtraEditors.XtraForm
    {
         
        public Chuyentien()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gD_CHUYENTIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);
           
        }

        private void Chuyentien_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet.EnforceConstraints = false;
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Fill(this.nGANHANGDataSet.GD_CHUYENTIEN);
            btnchuyen.Enabled = false;
            if (Program.m_group == "NGANHANG")
            {
                barButtonItem1.Enabled = false;
            }
        }

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            nGAYGDDateEdit.DateTime = DateTime.Today;
            String stk_chuyen = sOTK_CHUYENTextEdit.Text;
            String stk_nhan = sOTK_NHANTextEdit.Text;
                String sotien = sOTIENTextEdit.Text;
                String NgayGD = nGAYGDDateEdit.Text;
            String MSG = "1";
            /*String macn = .Text;*/
            String manv = ((DataRowView)gD_CHUYENTIENBindingSource[gD_CHUYENTIENBindingSource.Position])["MANV"].ToString();
            try
            {
                string strLenh = "DECLARE @return_value int " + "EXEC @return_value= [dbo].[SP_CHUYENTIEN]" + "@SOTK_CHUYEN=" + stk_chuyen + "," + "@SOTK_NHAN=" + stk_nhan + ","+ "@SOTIEN=" + sotien + "," + "@NGAYGD=" + "'"+NgayGD+"'" + "," + "@MANV=" + manv + "," + "@MSG=" + MSG ;
                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                //read and take
                MessageBox.Show("Đã chuyển tiền sang tài khoản: " + stk_nhan, "", MessageBoxButtons.OK);
                
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
               
                
                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.nGANHANGDataSet.GD_CHUYENTIEN);
                
                

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi chuyển tiền sang tài khoản: " + stk_nhan, "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Enabled = true;
            sOTK_CHUYENTextEdit.Focus();
            gD_CHUYENTIENBindingSource.AddNew();
            nGAYGDDateEdit.DateTime = DateTime.Today;
           String manv = ((DataRowView)gD_CHUYENTIENBindingSource[gD_CHUYENTIENBindingSource.Position])["MANV"].ToString();

            btnchuyen.Enabled = true;
            /*mAGDTextEdit.Visible = false;*/
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_CHUYENTIENTableAdapter.Fill(this.nGANHANGDataSet.GD_CHUYENTIEN);
                MessageBox.Show("    Đã Reload!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload : " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}