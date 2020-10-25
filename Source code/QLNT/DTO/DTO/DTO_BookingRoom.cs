using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BookingRoom
    {
        private String room_ID;
        private String customer_ID;
        private String date_hire;

        public DTO_BookingRoom()
        {
        }

        public DTO_BookingRoom(String room_ID, String customer_ID, String date_hire)
        {
            this.Room_ID = room_ID;
            this.Customer_ID = customer_ID;
            this.Date_hire = date_hire;
        }

        public string Room_ID { get => room_ID; set => room_ID = value; }
        public string Customer_ID { get => customer_ID; set => customer_ID = value; }
        public string Date_hire { get => date_hire; set => date_hire = value; }
    }
}
