using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private String customer_ID;
        private String customer_name;
        private int customer_age;
        private String customer_address;
        private String customer_gender;
        private String customer_phone;
        public DTO_Customer()
        {

        }
        public DTO_Customer(string customer_ID, string customer_name, int customer_age, string customer_address, string customer_gender, string customer_phone)
        {
            this.customer_ID = customer_ID;
            this.customer_name = customer_name;
            this.customer_age = customer_age;
            this.customer_address = customer_address;
            this.customer_gender = customer_gender;
            this.customer_phone = customer_phone;
        }

        public string Customer_ID { get => customer_ID; set => customer_ID = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public int Customer_age { get => customer_age; set => customer_age = value; }
        public string Customer_address { get => customer_address; set => customer_address = value; }
        public string Customer_gender { get => customer_gender; set => customer_gender = value; }
        public string Customer_phone { get => customer_phone; set => customer_phone = value; }

    }

}
