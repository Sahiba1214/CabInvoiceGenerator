using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_WhenCalculate_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double result = invoice.CalculateCabFare(5.0, 2);
            double expected = 52;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void GivenMultipleRides_WhenCalculate_ShouldReturnTotalFare()
        {
            Ride[] rides = { new Ride(7.0, 3), new Ride(6.5, 4) };
            InvoiceGenerator invoice = new InvoiceGenerator();
            double result = invoice.CalculateCabFare(rides);
            double expected = 142;
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void GivenSummary_WhenCalculate_ShouldReturnAverageFare()
        {
            Ride[] rides = { new Ride(7.0, 3), new Ride(6.5, 4) };
            InvoiceGenerator invoice = new InvoiceGenerator();
            InvoiceSummary summary = new InvoiceSummary();
            InvoiceSummary result = invoice.CalculateInvoiceSummary(rides);
            summary.totalFare = 142;
            summary.totalNumberOfRides = 2;
            summary.CalulateAverageFare();
            if (result.totalFare == summary.totalFare && result.totalNumberOfRides == summary.totalNumberOfRides && result.averageFarePerRide == summary.averageFarePerRide)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
