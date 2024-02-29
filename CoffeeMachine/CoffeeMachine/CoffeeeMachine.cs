using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    // Naming it with 3 e's instead, since namespace would get in the way
    internal class CoffeeeMachine : BrewingMachine
    {
        // Using Water as liquid, Tea leaves as ingredient, takes 200 mL to make a cup and brews 1 cups per brew
        public CoffeeeMachine() : base(new Liquid("Water"), new Ingredient("Coffee Powder"), 200, 1)
        {
            
        }

        public override void Brew()
        {
            // Logic for brewing coffee
        }
    }
}
