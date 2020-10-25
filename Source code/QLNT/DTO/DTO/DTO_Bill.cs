using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Bill
    {
        private String bill_ID;
        private String room_ID;
        private String customer_ID;
        private String month;
        private double service_money;

        public DTO_Bill(string bill_ID, string room_ID, string customer_ID, string month, double service_money)
        {
            this.bill_ID = bill_ID;
            this.room_ID = room_ID;
            this.customer_ID = customer_ID;
            this.month = month;
            this.service_money = service_money;
        }

        public DTO_Bill()
        {

        }

        public string Bill_ID { get => bill_ID; set => bill_ID = value; }
        public string Room_ID { get => room_ID; set => room_ID = value; }
        public string Customer_ID { get => customer_ID; set => customer_ID = value; }
        public string Month { get => month; set => month = value; }
        public double Service_money { get => service_money; set => service_money = value; }


    }
}
