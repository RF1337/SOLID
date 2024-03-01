using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChewAndPhew
{
    public class GumDispenser
    {
        public List<Gum> Gums { get; set; }
        private static GumDispenser _instance;
        Random random = new Random();

        public static GumDispenser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GumDispenser();
                }
                return _instance;
            }
        }

        public void DispenseGum()
        {
            if (Gums.Count == 0)
            {
                Console.WriteLine("No gums left");
                return;
            }
            int randomIndex = random.Next(Gums.Count);
            Gum removedGum = Gums[randomIndex];
            Gums.RemoveAt(randomIndex);
            Console.WriteLine($"Dispensed {removedGum.Name}");
        }

        // Only for checking if list works
        public void PrintAmount()
        {
            Console.WriteLine(Gums.Count);
        }

        public GumDispenser()
        {
            Gums = new List<Gum>();
        }
    }
}
