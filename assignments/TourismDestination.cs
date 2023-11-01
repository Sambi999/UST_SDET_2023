using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class TourismDestination
    {

        /*
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating {  get; set; }
        public static List<TourismDestination> SortByRatingDescending(List<TourismDestination> destinations)
        {
            return destinations.OrderByDescending(dest => dest.Rating).ToList();
        }
        */


        
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int Rating { get; set; }
        public decimal PricePerNight { get; set; }

        public TourismDestination(string name, string location, int rating, decimal pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;


        }
        
         

    }
   
}
