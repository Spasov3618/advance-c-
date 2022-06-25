using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
            Renovators = new List<Renovator>();
        }

        public List<Renovator> Renovators { get; set; }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public int Count => Renovators.Count;

        public string AddRenovator(Renovator renovator)
        {


                if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
                {
                    return "Invalid renovator's information.";

                }

               if (Count >= NeededRenovators)
                  {
                return "Renovators are no more needed.";
                
                 }
                if (renovator.Rate > 350)
                {
                    return "Invalid renovator's rate.";
                }

            
            Renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";




        }

        public bool RemoveRenovator(string name)
        {
            Renovator search = Renovators.Where(n => n.Name == name).FirstOrDefault();
            if (search != null)
            {
                Renovators.Remove(search);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            if (Renovators.Any(n=> n.Type==type))
            {

            List<Renovator> search = Renovators.Where(n => n.Type != type).ToList();
            int count = Renovators.Count - search.Count;
            Renovators = search.ToList();

            return count;
            }
            return 0;

        }

        public Renovator HireRenovator(string name)
        {
            Renovator search = Renovators.Where (n => n.Name == name).FirstOrDefault();
            if (search != null)
            {
                search.Hired = true;
            return search;
            }
            else
            {
                return null;
            }
        }
        public List<Renovator> PayRenovators(int days)
        {
            return Renovators.Where(n => n.Days >= days).ToList();
           
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in Renovators.Where(n => n.Hired == false))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
