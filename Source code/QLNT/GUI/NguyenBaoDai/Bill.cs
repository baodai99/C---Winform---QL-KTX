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
using BUS;
using DTO;
using System.Data.SqlClient;



namespace GUI.GUI
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        Data l = new Data();
        BUS_Bill bl = new BUS_Bill();
        DTO_Bill db = new DTO_Bill();
        void hienthi()
        {
            DataTable dt = new DataTable();
            dt = bl.showBill();
            dgvHoaDon.DataSource = dt;
            
        }

         void Bill_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt.Clear();
            dt = bl.room();

            this.cbxMap.DataSource = dt;
            this.cbxMap.DisplayMember = "room_ID";
            this.cbxMap.ValueMember = "room_ID";


            
          

        }

        private void btnXemds_Click_1(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {

                db.Room_ID = txtMahd.Text;
                db.Bill_ID = txtMahd.Text;
                if (txtMahd.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã hd ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                DataTable dt = new DataTable();
                dt.Clear();
                dt = bl.search_Bill(db.Bill_ID);
                dgvHoaDon.DataSource = dt;

                MessageBox.Show("Kết Quả Tìm Kiếm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            try
            {

                db.Bill_ID = txtMahd.Text;
                db.Room_ID = cbxMap.Text;
                db.Customer_ID = txtMakh.Text;
                db.Month = dtp1.Value.ToString();
               
                db.Service_money = double.Parse(txtTiendv.Text);
                
                bl.insert_Bill(db.Bill_ID, db.Room_ID, db.Customer_ID, db.Month, db.Service_money);
                MessageBox.Show("Đã Thêm Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hienthi();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Trùng mã hoa don ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi truy vấn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMahd.Clear();
            txtMakh.Clear();
            txtTiendv.Clear();
            
            
            
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id >= 0)
            {
                txtMahd.Text = dgvHoaDon.Rows[id].Cells[0].Value.ToString();

                cbxMap.Text = dgvHoaDon.Rows[id].Cells[1].Value.ToString();
                txtMakh.Text = dgvHoaDon.Rows[id].Cells[2].Value.ToString();
                dtp1.Text = dgvHoaDon.Rows[id].Cells[3].Value.ToString();
                txtTiendv.Text = dgvHoaDon.Rows[id].Cells[4].Value.ToString();
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                db.Bill_ID = txtMahd.Text;
                db.Room_ID = cbxMap.Text;
                db.Customer_ID = txtMakh.Text;
                db.Month = dtp1.Value.ToString();

                db.Service_money = double.Parse(txtTiendv.Text);

                bl.update_Bill(db.Bill_ID, db.Room_ID, db.Customer_ID, db.Month, db.Service_money);
                MessageBox.Show("Đã Sua Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hienthi();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                
                    MessageBox.Show("Lỗi truy vấn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {

                db.Bill_ID = txtMahd.Text;
            

                bl.delete_Bill(db.Bill_ID);
                MessageBox.Show("Đã Xoa Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hienthi();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi truy vấn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
