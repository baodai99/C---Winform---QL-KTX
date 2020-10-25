using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Bill
    {
        DTO.DTO_Bill l = new DTO.DTO_Bill();
        DAL.Data da = new DAL.Data();
        DTO.DTO_Room r = new DTO_Room();

        public DataTable showBill()
        {
            string sql = "select * from bill";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public void insert_Bill(string bill_ID, string room_ID, string customer_ID, string month, double service_money)
        {
            string sql = " insert into bill values('"+bill_ID+"','"+room_ID+"','"+customer_ID+"','"+month+"',"+service_money+")";
            da.ExcuteNonQuery(sql);
        }

        public void update_Bill(string bill_ID, string room_ID, string customer_ID, string month, double service_money)
        {
            string sql = " update  bill set  room_ID= '" + room_ID + "', customer_ID =  '" + customer_ID + "',month= '" + month + "',service_money = " + service_money + "where bill_ID ='" + bill_ID + "'";
            da.ExcuteNonQuery(sql);
        }

        public void delete_Bill(string bill_ID)
        {
            string sql = " delete  bill where customer_ID ='" + bill_ID + "'";
            da.ExcuteNonQuery(sql);
        }
        public void delete_Bill1(string customer_ID)
        {
            string sql = " delete  bill where customer_ID ='" + customer_ID + "'";
            da.ExcuteNonQuery(sql);
        }

        public DataTable search_Bill(string dk)
        {
            string sql = "select * from bill where bill_ID like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable room()
        {
            string sql = "select room_ID from Room";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        


    }
}
