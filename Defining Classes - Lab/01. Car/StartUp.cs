﻿using System;

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

            Console.WriteLine($"Make: {car.Make}\nMfdel: {car.Model}\nYear: {car.Year}");
        }
    }
}
