using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsFlyingAroundApp
{
    public abstract class Bird
    {
        // The location of the bird
        public string Location { get; private set; }
        // Setting location of the bird
        public abstract void SetLocation(double longitude, double latitude);
    }
}
