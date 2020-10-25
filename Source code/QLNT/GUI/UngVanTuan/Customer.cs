using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
using System.Data.SqlClient;



namespace GUI
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        Data c = new Data();
        BUS_Customer bc = new BUS_Customer();
        DTO_Customer dc = new DTO_Customer();
        BUS_BookingRoom bbr = new BUS_BookingRoom();
        DTO_BookingRoom dbr = new DTO_BookingRoom();
        BUS_Room brr = new BUS_Room();
        DTO_Room db = new DTO_Room();
        BUS_Bill bl = new BUS_Bill();
        DTO_Bill dbb = new DTO_Bill();
        private void Customer_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bc.ShowCustomer();
            dvgCustomer.DataSource = dt;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtcustomer_ID.Clear();
            txtcustomer_name.Clear();
            txtcustomer_age.Clear();
            txtcustomer_address.Clear();
            txtcustomer_phone.Clear();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtcustomer_ID.Text == "" || txtcustomer_name.Text== "")
            {
                MessageBox.Show("Mã khách hàng và tên khách hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtcustomer_ID.TextLength >10)
            {
                MessageBox.Show("Mã khách hàng không được quá 10 kí tự", "Thông  báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    dc.Customer_ID = txtcustomer_ID.Text;
                    dc.Customer_name = txtcustomer_name.Text;
                    dc.Customer_age = int.Parse(txtcustomer_age.Text);
                    dc.Customer_address = txtcustomer_address.Text;
                    if(rdbnam.Checked)
                    {
                        dc.Customer_gender = "Nam";
                    }
                    else
                    {
                        dc.Customer_gender = "Nữ";
                    }
                    dc.Customer_phone = txtcustomer_phone.Text;

                    bc.insert_Customer(dc.Customer_ID,  dc.Customer_name,  dc.Customer_age,  dc.Customer_address,  dc.Customer_gender, dc.Customer_phone);
                    MessageBox.Show("Đã thêm thành công");
                    Customer_Load(sender, e);
                }
                
                catch (FormatException ex)
                {
                    MessageBox.Show("Lỗi rồi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Trùng mã rồi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtcustomer_ID.Text == "" || txtcustomer_name.Text == "")
            {
                MessageBox.Show("Mã khách hàng và tên khách hàng không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtcustomer_ID.TextLength > 10)
            {
                MessageBox.Show("Mã khách hàng không được quá 10 kí tự", "Thông  báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    dc.Customer_ID = txtcustomer_ID.Text;
                    dc.Customer_name = txtcustomer_name.Text;
                    dc.Customer_age = int.Parse(txtcustomer_age.Text);
                    dc.Customer_address = txtcustomer_address.Text;
                    if (rdbnam.Checked)
                    {
                        dc.Customer_gender = "Nam";
                    }
                    else
                    {
                        dc.Customer_gender = "Nữ";
                    }
                    dc.Customer_phone = txtcustomer_phone.Text;

                    bc.update_Customer(dc.Customer_ID, dc.Customer_name, dc.Customer_age, dc.Customer_address, dc.Customer_gender, dc.Customer_phone);
                    MessageBox.Show("Đã cập nhật thành công");
                    Customer_Load(sender, e);
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        MessageBox.Show("Trùng mã rồi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i>=0)
            {
                txtcustomer_ID.Text = dvgCustomer.Rows[i].Cells[0].Value.ToString();
                txtcustomer_name.Text = dvgCustomer.Rows[i].Cells[1].Value.ToString();
                txtcustomer_age.Text = dvgCustomer.Rows[i].Cells[2].Value.ToString();
                txtcustomer_address.Text = dvgCustomer.Rows[i].Cells[3].Value.ToString();
                if(dvgCustomer.Rows[i].Cells[4].Value.Equals("Nam"))
                {
                    rdbnam.Checked = true;
                }
                else
                {
                    rdbnu.Checked = true;
                }
                txtcustomer_phone.Text = dvgCustomer.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            dbr.Customer_ID = txtcustomer_ID.Text;
            dbb.Customer_ID = txtcustomer_ID.Text;
            
            

            dc.Customer_ID = txtcustomer_ID.Text;

            if (txtcustomer_ID.Text=="")
            {
                MessageBox.Show("Bạn cần chọn mã khách hàng để xóa");
            }
            else
            {
                bl.delete_Bill(dbb.Customer_ID);
                bbr.delete_BookingRoom1(dbr.Customer_ID);
                bc.delete_Customer(dc.Customer_ID);
                MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Customer_Load(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtcustomer_ID.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable dt = new DataTable();
                dt = bc.search_Customer(txtcustomer_ID.Text);
                dvgCustomer.DataSource = dt;
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bc.ShowCustomer();
            dvgCustomer.DataSource = dt;
        }

        private void dvgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
