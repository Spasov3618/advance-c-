using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;


        public Zoo(string name, int capacity) 
        {
            Animals = new List<Animal>();
            Name = name;
            Capacity = capacity;
            
        }

        private string name;
        private int capacity;
        public int Count =>Animals.Count;

        public List<Animal> Animals { get => animals; set => animals = value; }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public	string AddAnimal(Animal animal)
        {
            if (Animals.Count < Capacity)
            {

                if (string.IsNullOrWhiteSpace(animal.Species))
                {
                    return "Invalid animal species.";
                }
                else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                {
                    return "Invalid animal diet.";
                }
               
                else
                {

                    Animals.Add(animal);
                    return $"Successfully added {animal.Species} to the zoo.";
                }
            }
            return "The zoo is full.";
        }
        public int RemoveAnimals(string species)
        {
            List<Animal> newAnumals = this.Animals.Where(x => x.Species != species).ToList();
            int result = this.Animals.Count - newAnumals.Count;
            this.Animals = newAnumals;
            return result;
        }

    
        public	List<Animal> GetAnimalsByDiet(string diet)
        {
            return Animals.Where(n => n.Diet == diet).ToList();
        }
        public	Animal GetAnimalByWeight(double weight)
        {
            return Animals.First(n => n.Weight == weight);
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
           List<Animal> animalsLeghth =new List<Animal>(Animals.Where(n => n.Length >= minimumLength && n.Length <= maximumLength));
            return $"There are {animalsLeghth.Count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
