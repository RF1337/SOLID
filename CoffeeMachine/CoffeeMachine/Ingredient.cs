using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class Ingredient : IIngredient
    {
        public string Name { get; private set; }
        public int GramsOfIngredient { get; private set; }

        public void AddIngredient(int grams)
        {
            GramsOfIngredient += grams;
        }

        public void RemoveIngredient(int grams)
        {
            GramsOfIngredient -= grams;
        }

        public int GetGramsOfIngredients()
        {
            return GramsOfIngredient;
        }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
