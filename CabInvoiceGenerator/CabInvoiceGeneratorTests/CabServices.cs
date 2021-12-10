using CabInvoiceGeneratorTests;
using CabInvoiceGeneratorTests;
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
            InvoiceGenerator invoice = new InvoiceGenerator(5.0, 2);
            double result = invoice.CalculateCabFare();
            Assert.AreEqual(result, 52);
        }
    }
}
