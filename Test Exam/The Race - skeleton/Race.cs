using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Racers = new List<Racer>();
        }

        public List<Racer> Racers { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count => Racers.Count;

        public void Add(Racer Racer)
        {
            if (Racers.Count<Capacity)
            {
                Racers.Add(Racer);
            }
        }

        public bool Remove(string name)
        {

            Racer find = Racers.FirstOrDefault(n => n.Name == name);
            if (find != null)
            {
                Racers.Remove(find);
                return true;
            }
            else
            {

            return false;
            }

            
        }
       public Racer GetOldestRacer()
        {
            return Racers.OrderByDescending(n => n.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        {
            return Racers.FirstOrDefault(n => n.Name == name);  
        }

        public Racer GetFastestRacer()
        {
            return Racers.OrderByDescending(n => n.Cars.Speed).FirstOrDefault();
        }

        public string 	Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var item in Racers)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
