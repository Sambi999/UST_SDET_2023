using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class RoomReservation<T> where T : HotelRoom
    {
        public static List<T> values = new List<T>();
        public void BookRoom(T room)
        {
            values.Add(room);
        }
        public void CancelRoom(T room)
        {
            values.Remove(room);
        }
    }
}
