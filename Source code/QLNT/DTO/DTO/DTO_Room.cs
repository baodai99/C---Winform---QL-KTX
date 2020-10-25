using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Room
    {
        private String room_ID;
        private String type_room;
        private int number_floor;
        private double price;
        private String status_room;
        private int number_person;

        public DTO_Room()
        {
        }
        public DTO_Room(string room_ID, string type_room, int number_floor, double price, string status_room, int number_person)
        {
            this.room_ID = room_ID;
            this.type_room = type_room;
            this.number_floor = number_floor;
            this.price = price;
            this.status_room = status_room;
            this.number_person = number_person;
        }

        

        public string Room_ID { get => room_ID; set => room_ID = value; }
        public string Type_room { get => type_room; set => type_room = value; }
        public int Number_floor { get => number_floor; set => number_floor = value; }
        public double Price { get => price; set => price = value; }
        public string Status_room { get => status_room; set => status_room = value; }
        public int Number_person { get => number_person; set => number_person = value; }
    }
}
