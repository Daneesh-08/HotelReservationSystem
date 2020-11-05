using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservationException : Exception
    {
        public enum ExceptionType 
        {
            NULL_DATES,
            INVALID_DATE,            
            INVALID_DATE_FORMAT,
        }
        public ExceptionType type;
        public HotelReservationException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
