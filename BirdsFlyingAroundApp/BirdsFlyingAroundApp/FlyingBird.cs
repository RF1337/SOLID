using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    internal abstract class FlyingBird : Bird
    {
        // Altitude of flying bird
        public string Altitude { get; private set; }
        // Setting the altitude of flying bird
        public abstract void SetAltitude(double altitude);
    }
}
