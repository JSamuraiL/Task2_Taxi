// See https://aka.ms/new-console-template for more information
using Task2;

var TransportList  = new TransportList
{
    new Delivery {Car_number = "l13k4",LoadUnloadPrice = 50, DeliveryPrice = 100},
    new Delivery {Car_number = "ka1j3",LoadUnloadPrice = 10, DeliveryPrice = 10},
    new Delivery {Car_number = "fk7l3",LoadUnloadPrice = 70, DeliveryPrice = 110},
    new Ride{Car_number = "fk7l3", HourDrive = 13, NumberOfHours = 5},
    new Ride{Car_number = "g1j7d", HourDrive = 10, NumberOfHours = 3}
};
TransportList.Travel();
TransportList.CalculateSumTravelPrice();