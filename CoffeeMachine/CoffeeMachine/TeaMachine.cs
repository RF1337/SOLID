using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class TeaMachine : BrewingMachine
    {
        public TeaMachine() : base(new Liquid("Water"), new Ingredient("Tea leaves"), 150, 1)
        {

        }

        public override void Brew()
        {
            // Logic for brewing tea
        }
    }
}
