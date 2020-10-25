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
    public class BUS_Room
    {
        DTO.DTO_Bill l = new DTO.DTO_Bill();
        DAL.Data da = new DAL.Data();

        public DataTable showRoom()
        {
            string sql = "select * from Room";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }

        public void insert_Room(string room_ID, string type_room, int number_floor, double price, string status_room, int number_person)
        {
            
            string sql = " insert into Room values('" + room_ID + "','"+type_room+"',"+number_floor+","+price+",'" + status_room + "'," + number_person + ")";
            da.ExcuteNonQuery(sql);
        }

        public void update_Room(string room_ID, string type_room,int number_floor, double price, string status_room, int number_person)
        {
            string sql = " update  Room set type_room='"+type_room+"',  number_floor =  " + number_floor + ",price= " + price + ", status_room= '" + status_room + "',number_person="+ number_person + " where room_ID= '" + room_ID + "'";
            da.ExcuteNonQuery(sql);
        }

        public void delete_Room(string room_ID)
        {
            string sql = " delete  Room where room_ID ='" + room_ID + "'";
            da.ExcuteNonQuery(sql);
        }

        public DataTable search_Room(string dk)
        {
            string sql = "select * from Room where room_ID like '%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public void insert_Room1(string room_ID, string type_room, int number_floor, double price, string status_room)
        {

            string sql = " insert into Room values('" + room_ID + "','" + type_room + "'," + number_floor + "," + price + ",'" + status_room + "')";
            da.ExcuteNonQuery(sql);
        }




    }
}
