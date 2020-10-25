using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BUS;
using System.Data.SqlClient;

namespace GUI.GUI
{
    public partial class Room : Form
    {
        Data l = new Data();
        BUS_Room br = new BUS_Room();
        DTO_Room db = new DTO_Room();
        BUS_BookingRoom bbr = new BUS_BookingRoom();
        DTO_BookingRoom dbr = new DTO_BookingRoom();
        void hienthi()
        {
            DataTable dt = new DataTable();
            dt = br.showRoom();
            dgvRoom.DataSource = dt;

        }
        public Room()
        {
            InitializeComponent();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            cbLoaip.Items.Add("VIP");
            cbLoaip.Items.Add("Thường");
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                db.Room_ID = txtMap.Text;
                db.Type_room = cbLoaip.SelectedItem.ToString();
                db.Number_floor = int.Parse(txtTang.Text);
                db.Price = int.Parse(txtGia.Text);
                if (rdbFull.Checked)
                {
                    db.Status_room = "Full";
                }
                else
                {
                    db.Status_room = "Empty";
                }
                db.Number_person = int.Parse(txtSonguoi.Text);
                if (txtMap.Text == ""||cbLoaip.SelectedItem.ToString()==""||txtTang.Text==""||txtGia.Text==""||txtSonguoi.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập hết ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (db.Number_floor > 5)
                {
                    MessageBox.Show("Nhà có 5 tầng , Xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                br.insert_Room(db.Room_ID, db.Type_room, db.Number_floor, db.Price, db.Status_room, db.Number_person);
                MessageBox.Show("Đã Thêm Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                Room_Load(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SqlException ex)
            {
                if(ex.Message.Contains("PRIMARY KEY"))
                {
                    MessageBox.Show("Trùng mã phòng ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi truy vấn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            if (id >= 0)
            {
                txtMap.Text = dgvRoom.Rows[id].Cells[0].Value.ToString();

                cbLoaip.Text = dgvRoom.Rows[id].Cells[1].Value.ToString();
                if (dgvRoom.Rows[id].Cells[1].Value.Equals("VIP"))
                {
                    cbLoaip.Text = "VIP";
                }else cbLoaip.Text = "thuong";

                txtTang.Text = dgvRoom.Rows[id].Cells[2].Value.ToString();
                txtGia.Text = dgvRoom.Rows[id].Cells[3].Value.ToString();
                if (dgvRoom.Rows[id].Cells[4].Value.Equals("full"))
                {
                    rdbFull.Checked=true;
                }
                else rdbEmpty.Checked=true;
                txtSonguoi.Text = dgvRoom.Rows[id].Cells[5].Value.ToString();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

            try
            {

                db.Room_ID = txtMap.Text;
                db.Type_room = cbLoaip.SelectedItem.ToString();
                db.Number_floor = int.Parse(txtTang.Text);
                db.Price = int.Parse(txtGia.Text);
                if (rdbFull.Checked)
                {
                    db.Status_room = "Full";
                }
                else
                {
                    db.Status_room = "Empty";
                }
                db.Number_person = int.Parse(txtSonguoi.Text);
                
                if (db.Number_floor > 5)
                {
                    MessageBox.Show("Nhà có 5 tầng , Xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                br.update_Room(db.Room_ID, db.Type_room, db.Number_floor, db.Price, db.Status_room, db.Number_person);
                MessageBox.Show("Đã Cập Nhật Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Room_Load(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                dbr.Customer_ID = txtMap.Text;
                db.Room_ID = txtMap.Text;
                if (txtMap.Text == "" )
                {
                    MessageBox.Show("Bạn chưa nhập mã phòng ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bbr.delete_BookingRoom(dbr.Room_ID);
                br.delete_Room(db.Room_ID);

                MessageBox.Show("Đã Xóa Thành Công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Room_Load(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {

                db.Room_ID = txtMap.Text;
                
                if (txtMap.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã phòng ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                DataTable dt = new DataTable();
                dt = br.search_Room(db.Room_ID);
                dgvRoom.DataSource = dt;
                MessageBox.Show("Kết Quả Tìm Kiếm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi cú pháp ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtMap.Clear();
            txtGia.Clear();
            cbLoaip.Items.Clear();
            txtSonguoi.Clear();
            txtTang.Clear();
            txtMap.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
