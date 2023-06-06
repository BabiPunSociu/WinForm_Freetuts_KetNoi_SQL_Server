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

namespace KetNoi_SQL_SERVER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoWindows_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoWindows.Checked)
                grbSQLServer.Visible = false;
            if(rdoSQLServer.Checked)
                grbSQLServer.Visible = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();   // Tạo đối tượng kết nối
                string connectionstring = "";
                if (rdoWindows.Checked == true)
                {
                    connectionstring = "server=" + txtNameServer.Text;
                    connectionstring += ";database=" + txtNameDatabase.Text;
                    connectionstring += ";integrated security=true";    // Không cần tài khoản - mật khẩu
                    conn.ConnectionString = connectionstring;
                }
                else
                {
                    connectionstring = "server=" + txtNameServer.Text;
                    connectionstring += ";database=" + txtNameDatabase.Text;
                    connectionstring += ";uid=" + txtUser.Text;
                    connectionstring += ";pwd=" + txtPassWord.Text;
                    conn.ConnectionString = connectionstring;
                }
                conn.Open();    // Phương thức mở kết nối
                MessageBox.Show("ket noi thanh cong");
                conn.Close();   // Phương thức đóng kết nối, cần đóng kết nối ngay khi xong câu lệnh sql
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
