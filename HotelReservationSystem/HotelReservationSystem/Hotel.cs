using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        public string name;
        public int RegularRates;
        public Hotel()
        {
            name = "";
            RegularRates = 0;
        }
        public Hotel(string name, int RegularRates)
        {
            this.name = name;
            this.RegularRates = RegularRates;
        }
    }
}
