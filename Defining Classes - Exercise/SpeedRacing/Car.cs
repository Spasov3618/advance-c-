using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private int travelledDistance;

        public Car(string model,double fuelAmount , double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
           
        }

        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } }

       public int TravelledDistance { get { return travelledDistance; } set { travelledDistance = value; } }
        
        public void Drive ( int amountOfKm)
        {
            if (FuelAmount>= (amountOfKm * fuelConsumptionPerKilometer))
            {
                FuelAmount -= amountOfKm*fuelConsumptionPerKilometer;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
