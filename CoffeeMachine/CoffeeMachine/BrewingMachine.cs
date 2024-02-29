using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal abstract class BrewingMachine
    {
        protected ILiquid liquid;
        protected IIngredient ingredient;
        protected bool hasFilter;
        protected int liquidPerCup;
        protected int cupsPerBrew;

        public abstract void Brew();

        public virtual void ChangeFilter()
        {
            hasFilter = true;
        }
        public virtual void AddLiquid(int mL)
        {
            liquid.AddLiquid(mL);
        }

        public virtual void RemoveLiquid(int mL)
        {
            liquid.RemoveLiquid(mL);
        }

        public virtual void AddIngredient(int grams)
        {
            ingredient.AddIngredient(grams);
        }

        public virtual void RemoveIngredient(int grams)
        {
            ingredient.AddIngredient(grams);
        }

        protected BrewingMachine(ILiquid liquid, IIngredient ingredient, int liquidPerCup, int cupsPerBrew)
        {
            this.liquid = liquid;
            this.ingredient = ingredient;
            hasFilter = true;
            this.liquidPerCup = liquidPerCup;
            this.cupsPerBrew = cupsPerBrew;
        }
    }
}
