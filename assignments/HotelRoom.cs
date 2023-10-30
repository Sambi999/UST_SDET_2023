using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class HotelRoom
    {
        public HotelRoom(int roomNumber, string? roomType, bool isBooked)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsBooked = isBooked;
        }

        public int RoomNumber { get; set; }
        public string? RoomType { get; set; }
        public bool IsBooked { get; set; }

        public static HotelRoom GetRoom(int roomNumber)
        {
            return RoomReservation<HotelRoom>.values.Find(x => x.RoomNumber == roomNumber);
        }
    }
}
