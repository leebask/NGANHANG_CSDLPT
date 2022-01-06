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
    public partial class FormEmployee : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        string macn = "";
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet);

        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            nGANHANGDataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connectStr;
            // TODO: This line of code loads data into the 'nGANHANGDataSet.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Fill(this.nGANHANGDataSet.GD_CHUYENTIEN);

            // TODO: This line of code loads data into the 'nGANHANGDataSet.NhanVien' table. You can move, or remove it, as needed.
            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            comboBox1.DataSource = Program.bds_dspm;
            comboBox1.DisplayMember = "TENCHINHANH";
            comboBox1.ValueMember = "TENSERVER";

            comboBox1.SelectedIndex = Program.mChinhanh; //hiện chi nhánh
            if (Program.m_group == "NGANHANG")
            {
                comboBox1.Enabled = true;
                btnThem.Enabled = btnHC.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPH.Enabled = false;
            }
            else comboBox1.Enabled = false;

        }

        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            bdsNV.AddNew();
            trangThaiXoaComboBox.Text = "0";
            txtMCN.Text = macn; //chờ gộp tài lấy
            btnThem.Enabled = btnHC.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            gcNhanvien.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            if (bdsCT.Count > 0)
            {
                try
                {

                    trangThaiXoaComboBox.Text = "1";
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                
                return;
            }
            if (bdsGuiRut.Count > 0)
            {
                try
                {

                    trangThaiXoaComboBox.Text = "1";
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xóa nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

                return;
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString()); //giữ lại xóa k được thì lấy về lại vị trí
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnThem.Enabled == false) bdsNV.Position = vitri;
            gcNhanvien.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHC.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
        }

        private void btnHC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnHC.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            gcNhanvien.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //chưa viết sp tìm xem thử các phân mảnh khác đã có manv chưa không cho trùng

            // txtMCN.Text = "CN1";

            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            try
            {
                bdsNV.EndEdit();
                bdsNV.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.nhanVienTableAdapter.Update(this.nGANHANGDataSet.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            panelControl2.Enabled = false;
            btnThem.Enabled = btnHC.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            gcNhanvien.Enabled = true;
        }

        private void hOLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);
                MessageBox.Show("    Đã Reload!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload : " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);

                    this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);

                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.gD_CHUYENTIENTableAdapter.Fill(this.nGANHANGDataSet.GD_CHUYENTIEN);

                    macn = ((DataRowView)bdsNV[0])["MACN"].ToString().Trim();

                }
                catch (Exception) { }
                /*if (comboBox1.SelectedValue.ToString() == "systemData.DataRowView")
                    return;
                Program.servername = comboBox1.SelectedValue.ToString();

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

    *//*
                if (Program.GetConnection() == 0)
                    MessageBox.Show("lỗi kết nối chi nhánh mới", "", MessageBoxButtons.OK);
                else*//*
                {
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet.NhanVien);

                    this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);

                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connectStr;

                    this.gD_CHUYENTIENTableAdapter.Fill(this.nGANHANGDataSet.GD_CHUYENTIEN);

                    macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
                }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lgname = txtLoginName.Text;
            String pass = txtPass.Text;
            String username = mANVTextEdit.Text;
            String role = cmbRole.Text;
            try
            {
                string strLenh = "DECLARE @return_value int " + "EXEC @return_value= [dbo].[SP_TAOLOGIN]" + "@LGNAME = " + lgname + "," + "@PASS = " + pass + "," + "@USERNAME= " + username+","+ "@ROLE= "+role/*+ " "  + "SELECT 'Return Value' = @return_value" */;
                SqlDataReader dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                //read and take
                MessageBox.Show("Đã tạo login cho" + username, "", MessageBoxButtons.OK);
               // dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                this.gD_GOIRUTTableAdapter.Fill(this.nGANHANGDataSet.GD_GOIRUT);



            }
            catch (Exception ex)
            {
                /*MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);*/
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }
    }
}