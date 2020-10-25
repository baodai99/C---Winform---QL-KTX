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
using DAL;

namespace GUI
{
    public partial class BookingDetail : Form
    {
        public BookingDetail()
        {
            InitializeComponent();
        }
        Data br = new Data();
        BUS_BookingRoom bbr = new BUS_BookingRoom();
        DTO_BookingRoom dbr = new DTO_BookingRoom();
        private void BookingDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bbr.show_BookingRoom();
            dvgdanhsachdadat.DataSource = dt;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dvgdanhsachdadat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbltieude_Click(object sender, EventArgs e)
        {

        }
    }
}
