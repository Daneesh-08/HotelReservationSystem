using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        HotelCollection hotelcollection = new HotelCollection();
        [TestMethod]
        public void TestMethod1()
        {
            string HotelName = "Ridgewood";
            int RegularRates = 220;
            Hotel hotel = new Hotel(HotelName, RegularRates);
            hotelcollection.AddHotel(hotel);
            Assert.AreEqual("Ridgewood", hotelcollection.HotelList[0].name);
        }
    }
}
