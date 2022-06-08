using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        

        static void Main()
        {
            List<Car> list = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                Car newCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                list.Add(newCar);
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arg = command.Split();
                string model = arg[1];
                int amountOfKm = int.Parse(arg[2]);

                list.Find(c => c.Model == model).Drive(amountOfKm);


            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }

        }
    }
}
