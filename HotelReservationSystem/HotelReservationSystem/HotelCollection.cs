using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelCollection
    {
        public List<Hotel> HotelList;
        public HotelCollection()
        {
            HotelList = new List<Hotel>();
        }
        public void AddHotel(Hotel hotel)
        {
            HotelList.Add(hotel);
        }
    }
}
