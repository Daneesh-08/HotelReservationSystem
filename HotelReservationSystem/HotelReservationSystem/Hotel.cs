using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        public string name;
        public int RegularRates;
        public int RegularRatesWeekday;
        public int RegularRatesWeekend;
        public Hotel()
        {
            name = "";
            RegularRates = 0;
            RegularRatesWeekday = 0;
            RegularRatesWeekend = 0;
        }
        public Hotel(string name, int RegularRates)
        {
            this.name = name;
            this.RegularRates = RegularRates;
        }        
        public Hotel(string name, int RegularRatesWeekday, int RegularRatesWeekend)
        {
            this.name = name;
            this.RegularRatesWeekday = RegularRatesWeekday;
            this.RegularRatesWeekend = RegularRatesWeekend;
        }
    }
}
