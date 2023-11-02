using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class TourismDestinations
    {
        public string? Name { get; set; }
        public string? Country { get; set; }

        public int Rating { get; set; }

        public double PricePerNight { get; set; }

        public static List<TourismDestinations> tourismDestinations = new List<TourismDestinations>();

        public TourismDestinations(string? name, string? country, int rating, double pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }
        public static void DisplayTopRated()
        {
            var data = tourismDestinations.FindAll(X => X.Rating > 3);
            if (data != null)
            {
                foreach (var item in data)
                {
                    Console.WriteLine("Top rated tourist destination:" + item.Name);
                }
            }
            else
            {
                Console.WriteLine("No details found");
            }
        }
        public static void SortedDestination()
        {
            Console.WriteLine("Sorted Destination Based on Price per night");
            var data = tourismDestinations.OrderBy(x => x.PricePerNight);
            foreach (var item in data)
            {

                Console.WriteLine();
                Console.WriteLine("Destination:" + item.Name + "\t" + "Country:" + item.Country + "\t" + "Rating:" + item.Rating + "\t" + "Price per night:" + item.PricePerNight);
            }
        }
        public static void FilterDestination()
        {
            Console.WriteLine();
            Console.WriteLine("Filter Destination:");
            var data = tourismDestinations.FindAll(X => X.Country == "India");
            if (data != null)
            {
                foreach (var item in data)
                {
                    Console.WriteLine();
                    Console.WriteLine("Destination:" + item.Name + "\t" + "Country:" + item.Country + "\t" + "Rating:" + item.Rating + "\t" + "Price per night:" + item.PricePerNight);
                }
            }
            else
            {
                Console.WriteLine("No details found");
            }
        }
    }
}
