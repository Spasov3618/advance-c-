using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        public Clinic(int capacity)
        {
            Capacity = capacity;
            PetList = new List<Pet>();  
        }

        public int Capacity { get; set; }
        List<Pet> PetList { get; set; }
        public int Count => PetList.Count;  

        public void Add(Pet pet)
        {
            if (PetList.Count<Capacity)
            {
                PetList.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            Pet search = PetList.FirstOrDefault(n => n.Name == name);
            if (search != null)
            {
                PetList.Remove(search);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Pet GetPet(string name, string owner)
        {
            return PetList.FirstOrDefault(n => n.Name == name && n.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return PetList.OrderByDescending(n => n.Age).FirstOrDefault();
        }

        public string 	GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var item in PetList)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }
            return sb.ToString();
        }
    }
}
