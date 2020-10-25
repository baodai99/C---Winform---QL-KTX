using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
          

        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            string taikhoan = txtUser.Text;
            if (taikhoan == "")
            {
                MessageBox.Show("\n Bạn cần nhập tên tai khoản", "MessageBoxButtons.OK");
                txtUser.Focus();
                return;
            }
            string mk = txtPass.Text;
            if (mk == "")
            {
                MessageBox.Show("\n Bạn cần nhâp mật khẩu");
                txtPass.Focus();
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TTFTRF5\MSSQLSERVER1;Initial Catalog=QLNhaTro;Integrated Security=True");
            try
            {
                con.Open();
                string tentk = txtUser.Text;
                string matk = txtPass.Text;
                string cl = "select * from login  where password='" + txtPass.Text + "'and username='" + txtUser.Text + "'";

                SqlCommand cm = new SqlCommand(cl, con);
                SqlDataReader dar = cm.ExecuteReader();
                if (dar.Read() == true)
                {
                    MessageBox.Show("\n Đăng nhập thành công!");
                    Home trangchu = new Home();
                    trangchu.Show();
                }
                else
                {
                    MessageBox.Show("\n Ban nhap sai mat khau hoac ten tai khoan");
                }
            }
            catch
            {
                MessageBox.Show("\n loi ket noi");
            }
            finally
            {
                con.Close();

            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
