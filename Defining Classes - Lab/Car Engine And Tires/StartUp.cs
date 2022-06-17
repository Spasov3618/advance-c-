using System;
using System.Runtime.ConstrainedExecution;
using CarManufacturer;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());

            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            var tires = new Tire[4]
          {
                new Tire(2015, 2.5),
                new Tire(2015, 2.5),
                new Tire(2015, 2.3),
                new Tire(2015, 2.3)
          };
            Engine lamboEngine = new Engine(560, 6300);
            Car lambo = new Car("lambo", "TXZ", 2010, 200, 9, lamboEngine, tires);

            Console.WriteLine(lambo.WhoAmI());


        }
    }
        }

