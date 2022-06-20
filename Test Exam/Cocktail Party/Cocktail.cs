using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new List<Ingredient>();
        }

        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel => Ingredients.Count;
        public void Add(Ingredient ingredient)
        {
            Ingredient search = Ingredients.FirstOrDefault(n => n.Name == ingredient.Name   || ingredient.Quantity<= Capacity );
            if (search == null   )
                
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            Ingredient searh = Ingredients.FirstOrDefault(n => n.Name == name);
            if (searh == null)
            {
            return false;
            }
                Ingredients.Remove(searh);
                return true;
        }
        public Ingredient FindIngredient(string name)
        {
            return Ingredients.FirstOrDefault(n => n.Name == name);
            
        }
        public Ingredient GetMostAlcoholicIngredient()
        {
           return Ingredients.OrderByDescending(n => n.Alcohol).FirstOrDefault();
            
        }
        
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: { Name} - Current Alcohol Level: { CurrentAlcoholLevel}");

            foreach (var item in Ingredients)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
