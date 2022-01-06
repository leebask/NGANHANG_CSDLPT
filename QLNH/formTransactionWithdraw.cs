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
    public partial class formTransactionWithdraw : DevExpress.XtraEditors.XtraForm
    {
        string macn = "";
        public formTransactionWithdraw()
        {
            InitializeComponent();
        }


        private void formTransactionWithdraw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
           

            nGANHANGDataSet.EnforceConstraints = false;
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);
            
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khachHangTableAdapter.Fill(this.nGANHANGDataSet.KhachHang);
           
            comboBox1.DataSource = Program.bds_dspm;
            comboBox1.DisplayMember = "TENCHINHANH";
            comboBox1.ValueMember = "TENSERVER";
            comboBox1.SelectedIndex = Program.mChinhanh; //hiện chi nhánh
            if (Program.m_group == "NGANHANG")
            {
                comboBox1.Enabled = true;
                barButtonItem2.Enabled = false;

            }
            else comboBox1.Enabled = false;
            panel1.Enabled = false;
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelLoaiGiaoDich_Click(object sender, EventArgs e)
        {

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
                    

                    this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);

                   

                    macn = ((DataRowView)gD_GOIRUTBindingSource[0])["MACN"].ToString().Trim();

                }
                catch (Exception) { }
            }

            }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sotien = sOTIENTextEdit.Text;
            String LoaiGD = lOAIGDComboBox.Text;
            String SoTK = sOTKComboBox.Text;

            try
            {
                string strLenh = "DECLARE @return_value int " + "EXEC @return_value= [dbo].[SP_GDGOIRUT]" + "@SOTIEN = " + sotien + "," + "@TYPE = " + LoaiGD + "," + "@SOTK= "+SoTK/*+ " "  + "SELECT 'Return Value' = @return_value" */;
                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                //read and take
                MessageBox.Show("Đã "+LoaiGD+ "dịch cho : " + SoTK, "", MessageBoxButtons.OK);
                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);

                

            }
            catch (Exception ex)
            {
                /*MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);*/
            }
            panel1.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);
                MessageBox.Show("    Đã Reload!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload : " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Enabled = true;
            gD_GOIRUTBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}