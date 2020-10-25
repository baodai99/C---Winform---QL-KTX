using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;
using System.CodeDom;

namespace GUI.GUI
{
    public partial class Booking_room : Form
    {
        public Booking_room()
        {
            InitializeComponent();
        }
        Data br = new Data();
        BUS_BookingRoom bbr = new BUS_BookingRoom();
        DTO_BookingRoom dbr = new DTO_BookingRoom();
        BUS_Room brr = new BUS_Room();
        DTO_Room db = new DTO_Room();
        BUS_Customer bc = new BUS_Customer();
        DTO_Customer dc = new DTO_Customer();
        
        private void btndanhsach_Click(object sender, EventArgs e)
        {
            BookingDetail frm = new BookingDetail();
            frm.ShowDialog();

        }

        private void Booking_room_Load(object sender, EventArgs e)
        {
            cbbloaiphong.Items.Add("VIP");
            cbbloaiphong.Items.Add("Thường");

            cbbtang.Items.Add("1");
            cbbtang.Items.Add("2");
            cbbtang.Items.Add("3");
            cbbtang.Items.Add("4");
            cbbtang.Items.Add("5");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndat_Click(object sender, EventArgs e)
        {

            
            if (txtmaphong.Text == "" || cbbloaiphong.SelectedItem.ToString() == "" || cbbtang.Text == "" || txtgia.Text == ""|| txtcustomer_ID.Text == "" || txtcustomer_name.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hết ! Xin nhập lại...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (db.Number_floor > 5)
            {
                MessageBox.Show("Nhà có 5 tầng , Xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    db.Room_ID = txtmaphong.Text;
                    db.Type_room = cbbloaiphong.SelectedItem.ToString();
                    db.Number_floor = int.Parse(cbbtang.Text);
                    db.Price = int.Parse(txtgia.Text);
                    dbr.Date_hire = DateTime.Now.ToString();
                    if (rdbfull.Checked)
                    {
                        db.Status_room = "Full";
                    }
                    else
                    {
                        db.Status_room = "Empty";
                    }
                    db.Number_person = int.Parse(txtSonguoi.Text);

                    dc.Customer_ID = txtcustomer_ID.Text;
                    dc.Customer_name = txtcustomer_name.Text;
                    dc.Customer_age = int.Parse(txtcustomer_age.Text);
                    dc.Customer_address = txtcustomer_address.Text;

                    dbr.Customer_ID = txtcustomer_ID.Text;
                    dbr.Room_ID = txtmaphong.Text;
                    if (rdbnam.Checked)
                    {
                        dc.Customer_gender = "Nam";
                    }
                    else
                    {
                        dc.Customer_gender = "Nữ";
                    }
                    dc.Customer_phone = txtcustomer_phone.Text;
                    brr.insert_Room(db.Room_ID, db.Type_room, db.Number_floor, db.Price, db.Status_room, db.Number_person);
                    bc.insert_Customer(dc.Customer_ID, dc.Customer_name, dc.Customer_age, dc.Customer_address, dc.Customer_gender, dc.Customer_phone);
                    bbr.insert_BookingRoom(dbr.Room_ID, dbr.Customer_ID, dbr.Date_hire);
                    MessageBox.Show("Đã thêm thành công");
                    Booking_room_Load(sender, e);
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
            //BookingDetail frm = new BookingDetail();
            //frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbtang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
