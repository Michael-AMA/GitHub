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

            Console.WriteLine("\nStructures\nBeen:{0}", coffee1.Bean);
            Console.Read();
        }

        public struct Coffee
        {
            public int Strength;
            public string Bean;
            public string CountryOfOrigin;
        }
    }
}
