using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class TeaMachine : BrewingMachine
    {
        // Using Water as liquid, Tea leaves as ingredient, takes 150 mL to make a cup and brews 3 cups per brew
        public TeaMachine() : base(new Liquid("Water"), new Ingredient("Tea leaves"), 150, 3)
        {

        }

        public override void Brew()
        {
            // Logic for brewing tea
        }
    }
}
