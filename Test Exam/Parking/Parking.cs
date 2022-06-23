using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            ListCar = new List<Car>();
        }

        public List<Car> ListCar { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => ListCar.Count;

        public void Add(Car car)
        {
            if (Count< Capacity)
            {
                ListCar.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car search = ListCar.FirstOrDefault(n=> n.Manufacturer== manufacturer && n.Model== model);  
            if (search != null)
            {
                ListCar.Remove(search);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Car GetLatestCar()
        {
            return ListCar.OrderByDescending(n=> n.Year).FirstOrDefault();
        }

        public Car GetCar(string manufacturer, string model)
        {
            return ListCar.FirstOrDefault(n => n.Manufacturer == manufacturer && n.Model == model);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var item in ListCar)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
