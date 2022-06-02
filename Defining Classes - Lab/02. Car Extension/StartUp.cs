using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
           Car car = new Car();
            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 1992;
            car.FuelQuantity = 50;
            car.FuelConsumption = 0.07;
            car.Drive(700);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
