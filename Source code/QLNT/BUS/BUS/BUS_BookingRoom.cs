using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_BookingRoom
    {
        Data da = new Data();
        public DataTable show_BookingRoom()
        {
            string sql = "select *from Booking_room";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void insert_BookingRoom(String room_ID, String customer_ID, String date_hire)
        {
            string sql = "insert into Booking_room values ('" + room_ID + "','" + customer_ID + "','" + date_hire + "')";
            da.ExcuteNonQuery(sql);
        }
        public void update_BookingRoom(String room_ID, String customer_ID, String date_hire)
        {
            string sql = "update Booking_room set customer_ID='" + customer_ID + "', date_hire='" + date_hire + "' where room_ID='" + room_ID + "'";
            da.ExcuteNonQuery(sql);
        }
        public void delete_BookingRoom(string room_ID)
        {
            string sql = "delete Booking_room where  room_ID='" + room_ID + "'";
            da.ExcuteNonQuery(sql);
        }
        public void delete_BookingRoom1(string customer_ID)
        {
            string sql = "delete Booking_room where  room_ID='" + customer_ID + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable search_BookingRoom(string room_ID)
        {
            string sql = "select * from Booking_room where room_ID like '" + room_ID + "'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
    }
}
