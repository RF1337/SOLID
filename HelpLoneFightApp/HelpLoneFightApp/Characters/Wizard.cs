using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpLoneFightApp.Interfaces.General;
using HelpLoneFightApp.Interfaces.Specific;

namespace HelpLoneFightApp.Characters
{
    internal class Wizard : ICharacter, ICanTeleport, ICanThrowMagic
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }

        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }

        public void ThrowMagicMissile()
        {
            Console.WriteLine("I'm throwing a magic misile");
        }
    }
}
