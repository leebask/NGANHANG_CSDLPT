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
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        private static SqlConnection conn_publisher = new SqlConnection();
        public formLogin()
        {
            InitializeComponent();
        }
        private int connectToPublisher()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connectStr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tên database và tên server");
                return 0;
            }
        }
        private void getListSubscribes(String cmd)
        {
            DataTable dataTable = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn_publisher);
            dataAdapter.Fill(dataTable);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dataTable;
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCHINHANH";
            cmbChiNhanh.ValueMember = "TENSERVER";
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            if (connectToPublisher() == 0) return;
            getListSubscribes("select * from Get_ChiNhanh");
            if(cmbChiNhanh.SelectedIndex < 0)
            {
                cmbChiNhanh.SelectedIndex = 0;
            }
            txtPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                return;
            }
            Program.m_login = txtLogin.Text;
            Program.password = txtPassword.Text;
            if (Program.GetConnection() == 0) return;

            Program.m_subscribes = cmbChiNhanh.SelectedIndex;
            Program.m_loginDN = Program.m_login;
            Program.passwordDN = Program.password;
            String cmd = "exec SP_DANGNHAP '" + Program.m_loginDN + "'";

            Program.reader = Program.ExecSqlDataReader(cmd);
            if (Program.reader == null) return;
            Program.reader.Read();

            Program.username = Program.reader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Bạn không quyền truy cập dữ liệu.\nXem lại username và password");
                return;
            }
            if (Program.reader.GetString(1) == null) Program.m_hoTen = "Nhân viên";
            else Program.m_hoTen = Program.reader.GetString(1);
            Program.m_group = Program.reader.GetString(2);
            Program.reader.Close();

            Program.conn.Close();

            Program.f_main = new Form1();
            Program.f_main.Show();
            Program.f_main.infoUser_Load(Program.username, Program.m_hoTen, Program.m_group);
            this.Visible = false;
            this.txtLogin.Text = "";
            this.txtPassword.Text = "";

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtPassword.PasswordChar = '*';
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                button1.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}