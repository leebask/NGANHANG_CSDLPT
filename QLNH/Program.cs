using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLNH
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand Sqlcmd = new SqlCommand();
        public static String connectStr_publisher = @"Data Source=LEEBASK;Initial Catalog=NGANHANG;Integrated Security=True";
        public static String connectStr;

        public static SqlDataReader reader;
        public static String servername = "";
        public static String username = "";
        public static String m_login = "";
        public static String password = "";

        public static String database = "NGANHANG";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";

        public static String m_loginDN = "";
        public static String passwordDN = "";

        public static String m_group = "";
        public static String m_hoTen = "";
        public static int m_subscribes = 0;
        public static int mChinhanh = 0;
        public static formLogin f_login;
        public static Form1 f_main;

        public static BindingSource bds_dspm = new BindingSource();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            f_login = new formLogin();
            Application.Run(f_login);
        }
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                // đóng đối tượng kết nối
                Program.conn.Close();
            try
            {
                Program.connectStr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.m_login + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connectStr;

                // mở đối tượng kết nối
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("---> Lỗi kết nối cơ sở dữ liệu.\n---> Bạn xem lại Username và Password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int GetConnection()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }
            try
            {
                Program.connectStr = @"Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" + Program.m_login + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connectStr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại username và password");
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader reader;
            SqlCommand sqlcmd = new SqlCommand(cmd, conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                reader = sqlcmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTble(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            da.Fill(dt);
            Program.conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd)
        {
            SqlCommand Sqlcmd = new SqlCommand(cmd, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                return ex.State;
            }
        }
    }
}
