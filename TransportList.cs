using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TransportList: List<Transport>
    {
        public float SumTravelPrice = 0;
        public void Travel() 
        { 
            foreach (Transport transport in this)
            {
                    transport.TravelPrice = transport.CalculateTravelPrice();
                    Console.WriteLine($"Вид поездки: {transport.GetType().Name}; номер автомобиля: {transport.Car_number}; стоимость поездки: {transport.TravelPrice};");
            }
        }
        public void CalculateSumTravelPrice()
        {
            foreach (Transport transport in this)
            {
                SumTravelPrice += transport.TravelPrice;
            }
            Console.WriteLine($"Суммарная стоимость поездок: {SumTravelPrice}");
        }
    }
}
