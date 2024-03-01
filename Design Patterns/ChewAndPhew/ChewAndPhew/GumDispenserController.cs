using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewAndPhew
{
    public class GumDispenserController
    {
        GumDispenser gumDispenser = GumDispenser.Instance;

        public void AddGum(Gum gum, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                gumDispenser.Gums.Add(gum);
            }
        }
    }
}
