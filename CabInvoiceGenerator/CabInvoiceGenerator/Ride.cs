using System;
using System.Collections.Generic;
using System.Text;
using System.Text;
using System.Threading.Tasks;
namespace CabInvoiceGenerator
{
    public class Ride
    {
        readonly public double DISTANCE;
        readonly public double TIME;
        public Ride(double RunningDistance,double RunningTime)
        {
            this.DISTANCE = RunningDistance;
            this.TIME = RunningTime;
        }
    }
}
