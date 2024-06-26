﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Ride: Transport
    {
        public int HourDrive {  get; set; }
        public int NumberOfHours { get; set; }
        public override float CalculateTravelPrice() 
        {
            if (HourDrive <= 0) { throw new ArgumentOutOfRangeException(nameof(HourDrive)); }
            else if (NumberOfHours <= 0) { throw new ArgumentOutOfRangeException(nameof(NumberOfHours)); }
            else return  HourDrive *  NumberOfHours; 
        }
    }
}
