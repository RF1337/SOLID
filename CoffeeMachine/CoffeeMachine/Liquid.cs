using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal class Liquid : ILiquid
    {
        public string Name { get; private set; }
        public int mLOfLiquid {  get; private set; }



        public Liquid(string name) 
        {
            Name = name;
        }

        public void AddLiquid(int mL)
        {
            mLOfLiquid += mL;
        }

        public void RemoveLiquid(int mL)
        {
            mL += mL;
        }

        public int GetLiquidMillilitersOfLiquid()
        {
            return mLOfLiquid;
        }
    }
}
