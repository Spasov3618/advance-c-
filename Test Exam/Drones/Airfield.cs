using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            Drones = new List<Drone>();
        }

        public List<Drone> Drones { get; set; }
        public string	Name { get; set; }
        public int	Capacity { get; set; }
        public double	LandingStrip { get; set; }

        public int Count => Drones.Count;

        public	string AddDrone(Drone drone)
        {
            if (Count<Capacity)
            {
                if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand)|| drone.Range < 5 || drone.Range > 15)
                {
                    return "Invalid drone."; 
                }
            }
            else
            {
                return "Airfield is full.";
            }
            Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }
        public	bool RemoveDrone(string name)
        {
            Drone search = Drones.FirstOrDefault(dr => dr.Name == name);
            if (search != null)
            {
                Drones.Remove(search);
                return true;
            }
            return false;

        }
        public	int RemoveDroneByBrand(string brand)
        {
            
            List<Drone> search =this. Drones.Where(dr => dr.Brand != brand).ToList();
            int count =this. Drones.Count - search.Count;
           this. Drones = search.ToList();
            return count;
        }
        public Drone FlyDrone(string name)
        {
            
            Drone search = Drones.FirstOrDefault(dr => dr.Name == name);
            if (search != null)
                search.Available = false;

            return search;
          
               

           
        }
       public	List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> search = this.Drones.FindAll(dr => dr.Range == range);
            
            return search;
        }
        public string Report()
        {
            var result = new StringBuilder();
            result.AppendLine($"Drones available at { this.Name }:");

            var dronesNotInFlight = this.Drones.Where(d => d.Available == true);
            foreach (var drone in dronesNotInFlight)
            {
                result.AppendLine(drone.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
