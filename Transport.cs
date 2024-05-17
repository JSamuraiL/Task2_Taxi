using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Transport
    {
        public string Car_number {  get; set; }
        public float TravelPrice { get; set; }

        public virtual float CalculateTravelPrice() 
        { 
            return CalculateTravelPrice();  //это заглушка, в дальнейшем метод будет перезаписываться
        }

    }
}
