using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public SkiRental(string name, int capacity)
        {
           this. Name = name;
           this. Capacity = capacity;
           this. Data = new List<Ski>();
        }
        private List<Ski> data;
        private string name;
        private int capacity;

        public int Count { get { return Data.Count; } }

      public void  Add(Ski ski)
        {
            if (Count< Capacity)
            {
                Data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Ski ski= Data.FirstOrDefault(n =>n.Manufacturer==manufacturer && n.Model==model);
            if (ski == null)
            {
                return false;
            }
            Data.Remove(ski);
            return true;
        }
       public Ski GetNewestSki()
        {
            //int ski = Data.Max(n => n.Year);
            Ski newSki = Data.OrderByDescending(n => n.Year).First();
            if (newSki == null)
            {
                return null;
            }
            return newSki;
        }
       public string GetSki(string manufacturer, string model)
        {
            var ski = Data.Select(n => n.Manufacturer == manufacturer && n.Model == model).ToList();
            return ski.ToString();
        }
        public string	GetStatistics()
        { 
            var sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var item in Data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();


    }





        public List<Ski> Data { get =>this. data; set =>this. data = value; }
        public string Name { get =>this. name; set =>this. name = value; }
        public int Capacity { get =>this. capacity; set =>this. capacity = value; }



    }
}
