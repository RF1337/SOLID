using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal interface IIngredient
    {
        void AddIngredient(int grams);
        void RemoveIngredient(int grams);
        int GetGramsOfIngredients();
    }
}
