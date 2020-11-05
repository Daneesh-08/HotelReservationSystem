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
        [TestMethod]
        public void TestMethod2()
        {
            hotelcollection.AddHotel(new Hotel("Lakewood", 110));
            hotelcollection.AddHotel(new Hotel("Bridgewood", 160));
            hotelcollection.AddHotel(new Hotel("Ridgewood", 220));
            string[] dates = "10Sep2020,11Sep2020".Split(",");
            Hotel cheapest = hotelcollection.GetCheapestHotel(dates);
            Assert.AreEqual("Lakewood", cheapest.name);
        }
        [TestMethod]
        public void TestMethod3()
        {
            hotelcollection.AddHotel(new Hotel("Lakewood", 110, 90));
            hotelcollection.AddHotel(new Hotel("Bridgewood", 150, 50));
            hotelcollection.AddHotel(new Hotel("Ridgewood", 220, 150));
            Assert.AreEqual(220, hotelcollection.HotelList[2].RegularRatesWeekday);
        }
    }
}
