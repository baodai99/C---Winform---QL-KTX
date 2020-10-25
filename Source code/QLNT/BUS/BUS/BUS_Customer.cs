using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;


namespace BUS
{
    public class BUS_Customer
    {

        Data da = new Data();
        public DataTable ShowCustomer()
        {
            string sql = "select *from customer";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void insert_Customer(string customer_ID, string customer_name, int customer_age, string customer_address, string customer_gender, string customer_phone)
        {
            string sql = "insert into customer values ('" + customer_ID + "',N'" + customer_name + "','" + customer_age + "',N'" + customer_address + "',N'" + customer_gender + "','" + customer_phone + "')";
            da.ExcuteNonQuery(sql);
        }
        public void update_Customer(string customer_ID, string customer_name, int customer_age, string customer_address, string customer_gender, string customer_phone)
        {
            string sql = "update customer set customer_name= N'" + customer_name + "', customer_age='" + customer_age + "', customer_address= N'" + customer_address + "', customer_gender= N'" + customer_gender + "', customer_phone='" + customer_phone + "' where customer_ID='" + customer_ID + "'";
            da.ExcuteNonQuery(sql);
        }
        public void delete_Customer(string customer_ID)
        {
            string sql = "delete customer where  customer_ID='" + customer_ID + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable search_Customer(string customer_ID)
        {
            string sql = "select * from customer where customer_ID like '" + customer_ID + "'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

    }
}
