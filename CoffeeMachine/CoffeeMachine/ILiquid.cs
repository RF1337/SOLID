﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    internal interface ILiquid
    {
        void AddLiquid(int mL);
        void RemoveLiquid(int mL);
        int GetLiquidMillilitersOfLiquid();
    }
}
