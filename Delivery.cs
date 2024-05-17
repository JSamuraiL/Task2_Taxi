using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Delivery: Transport
    {
        public float LoadUnloadPrice {  get; set; }
        public float DeliveryPrice { get; set; }
        public override float CalculateTravelPrice() { return DeliveryPrice + LoadUnloadPrice;}
    }
}
