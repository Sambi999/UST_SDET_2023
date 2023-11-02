using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Hotel : TourismDestination
    {
        //int currentRoom = 10;
        public Hotel(string? hotelName, int availableRoom, string? name, string? country, int rating) :
            base(name, country, rating)
        {
            HotelName = hotelName;
            AvailableRoom = availableRoom;
        }

        public string? HotelName { get; set; }
        public int AvailableRoom { get; set; }

        public async Task HotelBookingig(int hotelRoom, Hotel hotel)
        {

            if (hotelRoom <= AvailableRoom)
            {
                await Task.Delay(2000);
                AvailableRoom = AvailableRoom - hotelRoom;

                Console.WriteLine("Hotel booked for:{0} \t Rooms left:{1}", hotel.HotelName, AvailableRoom);
            }
            else
            {
                await Console.Out.WriteLineAsync("All rooms are booked");
            }
        }
    }
}
