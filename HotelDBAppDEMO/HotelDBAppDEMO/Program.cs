using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDBAppDEMO
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            using (var db = new HotelContext())
            {
                //List<Room> LegolandRooms = new List<Room>()
                //{
                //    new Room() {Hotel_No = 200, Room_No = 1, Price = 200, Types = "D"},
                //    new Room() {Hotel_No = 200, Room_No = 2, Price = 250, Types = "S"},
                //    new Room() {Hotel_No = 200, Room_No = 3, Price = 400, Types = "D"},
                //    new Room() {Hotel_No = 200, Room_No = 4, Price = 500, Types = "F"},
                //};

                //Hotel MyNewHotel = new Hotel()
                //{
                //    Hotel_No = 300,
                //    Name = "LegolandHotel",
                //    Address = "Legoland vej 1",
                //    Room = LegolandRooms
                //};

                //db.Hotel.Add(MyNewHotel);

                //db.SaveChanges();

                var hotellist = from h in db.Hotel
                    where h.Hotel_No == 200
                    select h;

                foreach (var item in hotellist)
                {
                    Console.WriteLine("Hotelname : "+ item.Name + item.HotelUrl);
                }


                Console.ReadLine();

            }
        }
    }
}
