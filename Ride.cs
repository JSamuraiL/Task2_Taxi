using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ride: Transport
    {
        public float HourDrive {  get; set; }
        public float NumberOfHours { get; set; }
        public override float CalculateTravelPrice() { return  HourDrive *  NumberOfHours; }
    }
}
