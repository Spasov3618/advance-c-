using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private string material;
        private int capacity;
        private List<Fish> fish;
        public int Count => fish.Count;
       

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            this.fish = new List<Fish>();
        }

        public string Material { get => material; set => material = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public List<Fish> Fish { get => fish; set => fish = value; }
        
       public string AddFish(Fish fish)
        {
            if (Fish.Count< Capacity)
            {
                if (string.IsNullOrWhiteSpace(fish.FishType))
                {
                    return "Invalid fish.";
                }
                else if (fish.Length <= 0 || fish.Weight<=0)
                {
                    return "Invalid fish.";
                }
                else
                {
                    Fish.Add(fish);
                    return $"Successfully added {fish.FishType} to the fishing net.";
                }


            }
            return "Fishing net is full.";

       }
        public 	bool ReleaseFish(double weight)
        {
            bool isFish = false;
            List<Fish> newAnumals = this.Fish.Where(x => x.Weight == weight).ToList(); 


            if (newAnumals.Count>0)
            {
                List<Fish> newFish = this.Fish.Where(x => x.Weight != weight).ToList();

                this.Fish = newFish;
                isFish = true;
            }
            
            return isFish;
        }

        public 	Fish GetFish(string fishType)
        {
            return  Fish.FirstOrDefault(x => x.FishType == fishType);
        }
        public 	Fish GetBiggestFish()
        {
            var search = Fish.Max(x => x.Length);
            return Fish.First(n => n.Length == search);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");

            foreach (var item in Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
