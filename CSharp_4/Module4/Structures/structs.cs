using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            Coffee coffee1 = new Coffee();
            coffee1.Strength = 3;
            coffee1.Bean = "Arabica";
            coffee1.CountryOfOrigin = "Kenya";
            //Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Console.WriteLine("\nStructures\nBean:{0}", coffee1.Bean);
        }

        public struct Coffee
        {
            public int Strength;
            public string Bean;
            public string CountryOfOrigin;
        }
    }
}
