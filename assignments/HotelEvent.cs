using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class HotelEvent
    {
        public HotelEvent(string? eventName, string? location, string? eventDate, int capacity)
        {
            EventName = eventName;
            Location = location;
            EventDate = eventDate;
            Capacity = capacity;
        }

        public string? EventName { get; set; }
        public string? Location { get; set; }
        public string? EventDate { get; set; }
        public int Capacity { get; set; }

        public static string EventRegistration(string msg)
        {

            return msg;

        }
    }
}
