using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }

        public List<Car> Participants { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public int Count => Participants.Count;

        public void  Add(Car car)
        {
                Car search = Participants.FirstOrDefault(p => p.LicensePlate == car.LicensePlate);
            if (Count<Capacity && search == null && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }

            
        }
        public bool  Remove(string licensePlate)
        {
            Car search = Participants.FirstOrDefault(p => p.LicensePlate == licensePlate);
            if (search != null)
            {
                Participants.Remove(search);
                return true;
            }
            return false;
        }
       public Car FindParticipant(string licensePlate)
        {
            Car search = Participants.FirstOrDefault(p => p.LicensePlate == licensePlate);
            if (search != null)
            {
            return search;

            }
            return null;
        }
        public Car GetMostPowerfulCar()
        {
            int maxhors = Participants.Max(n => n.HorsePower);
            Car search = Participants.FirstOrDefault(n => n.HorsePower == maxhors);
            return search;
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var item in Participants)
            {
                sb.AppendLine(item.ToString());
            }
            return  sb.ToString().TrimEnd();
        }
    }
}
