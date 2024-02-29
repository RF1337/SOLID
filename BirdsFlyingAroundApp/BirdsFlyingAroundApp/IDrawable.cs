using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal interface IDrawable
    {
        // Only able to implement IDrawable if it contains information to get drawn
        string GetDrawingCoordinates();
    }
}
