using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class EspressoMachine : BrewingMachine
    {
        // Using Water as liquid, Tea leaves as ingredient, takes 150 mL to make a cup and brews only 1 cup per brew
        public EspressoMachine() : base(new Liquid("Milk"), new Ingredient("Coffee Powder"), 150, 1)
        {

        }

        public override void Brew()
        {
            // Logic for brewing espresso
        }

    }
}
