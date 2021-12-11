using System;

namespace CabInvoiceGeneratorTests
{
    internal class InvoiceSummary
    {
        internal int totalFare;
        internal object averageFarePerRide;

        public int totalNumberOfRides { get; internal set; }

        internal void CalulateAverageFare()
        {
            throw new NotImplementedException();
        }
    }
}