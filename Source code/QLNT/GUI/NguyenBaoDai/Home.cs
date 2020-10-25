using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btndatphong_Click(object sender, EventArgs e)
        {
            Booking_room frm1 = new Booking_room();
            frm1.ShowDialog();
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            Customer frm2 = new Customer();
            frm2.ShowDialog();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            Bill frm3 = new Bill();
            frm3.ShowDialog();
        }

        private void btnphong_Click(object sender, EventArgs e)
        {
            Room frm4 = new Room();
            frm4.ShowDialog();
        }
    }
}
