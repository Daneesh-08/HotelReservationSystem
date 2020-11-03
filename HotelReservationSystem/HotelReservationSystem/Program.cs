using System;

namespace HotelReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hotel Reservation System !!");
            HotelCollection hotelSystem = new HotelCollection();
            hotelSystem.AddHotel(new Hotel("Lakewood", 110));
            hotelSystem.AddHotel(new Hotel("Bridgewood", 150));
            hotelSystem.AddHotel(new Hotel("Ridgewood", 220));
        }
    }
}
