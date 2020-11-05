using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelService
    {
        public DateTime[] ValidDates(string[] GivenDates)
        {
            if (GivenDates == null)
                throw new HotelReservationException(HotelReservationException.ExceptionType.NULL_DATES, "No dates given");
            DateTime[] DatesValid = new DateTime[GivenDates.Length];
            for (int i = 0; i < GivenDates.Length; i++)
            {
                DateTime date = ConvertToDate(GivenDates[i]);
                if (date > DateTime.Today)
                    throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE, "Invalid Date");
                DatesValid[i] = date;
            }
            return DatesValid;
        }
        public DateTime ConvertToDate(string InputDate)
        {
            try
            {
                DateTime date = DateTime.Parse(InputDate);
                return date;
            }
            catch (FormatException)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE_FORMAT, "Invalid Date Format");
            }
        }
    }
}
