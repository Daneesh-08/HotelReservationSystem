using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelCollection
    {
        public List<Hotel> HotelList;
        HotelService hotelservice = new HotelService();
        public HotelCollection()
        {
            HotelList = new List<Hotel>();
        }
        public void AddHotel(Hotel hotel)
        {
            HotelList.Add(hotel);
        }
        public Hotel GetCheapestHotel(string[] dates)
        {
            DateTime[] validatedDates = hotelservice.ValidDates(dates);
            HotelList.Sort((e1, e2) => e1.RegularRates.CompareTo(e2.RegularRates));
            return HotelList[0];
        }
    }
}
