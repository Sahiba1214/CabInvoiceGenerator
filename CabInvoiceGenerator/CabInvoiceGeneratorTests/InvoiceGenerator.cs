using System;

namespace CabInvoiceGeneratorTests
{
    internal class InvoiceGenerator
    {
        private double v1;
        private int v2;

        public InvoiceGenerator(double v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        internal double CalculateCabFare()
        {
            throw new NotImplementedException();
        }
    }
}