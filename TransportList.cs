using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TransportList: List<Transport>
    {
        public void Travel() 
        { 
            foreach (Transport transport in this)
            {
                if (transport != null)
                {
                    transport.TravelPrice = transport.CalculateTravelPrice();
                    Console.WriteLine($"{transport.GetType().Name} {transport.Car_number} {transport.TravelPrice}");
                }
            }
        }
    }
}
