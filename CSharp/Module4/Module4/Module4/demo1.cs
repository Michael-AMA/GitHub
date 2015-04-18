using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    struct Coffee2
    {
        public string Name { get; set; }
        public string Bean { get; set; }
        public string CountyOfOrigin { get; set; }
        public int Strength { get; set; }
        public string grind;

    }
    
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main(string[] args)
        {
            #region Single Dimensional Array
            // single dimensional array
            Console.WriteLine("Single Dimensional Array");
            int[] intArray = { 5, 10, 1, 20, 25, 10 };
            for (int counter = 0; counter < intArray.Length; counter++)
            {
                Console.WriteLine("{0}", intArray[counter]);
            }
            #endregion

            #region Two Dimensional Array
            Console.WriteLine("\nTwo Dimensional Array");
            // two dimensional array
            int[,] twoDArray = { { 3, 2}, { 4, 5}, { 5, 6 } };

            for (int x = 0; x < twoDArray.GetLength(0); x++)
            {
                for (int y = 0; y < twoDArray.GetLength(1); y++)
                {
                    int value = twoDArray[x, y];
                    Console.WriteLine(value.ToString());
                }
            }
            #endregion

            #region enum demo
            // Enums Arrays
            Console.WriteLine("");
            Console.WriteLine("Enums Array.");


            int s = (int)Days.Thursday;
            int t = (int)Days.Friday;
            Console.WriteLine("Thurday = {0}", s);
            Console.WriteLine("Fri = {0}", t);

            #endregion

            #region Structures #1
            // Structures
            Console.WriteLine("\nStructures");
            
            Coffee1 coffee1 = new Coffee1();
            coffee1.Strength = 3;
            coffee1.Bean = "Arabica";
            coffee1.CountryOfOrigin = "Kenya";
            Console.WriteLine("Bean:{0}\nStrength:{1}\nContry of Origin: {2}\n", coffee1.Bean, coffee1.Strength, coffee1.CountryOfOrigin);
            #endregion 

            #region using a struct

            Coffee2 coffee = new Coffee2();
            coffee.Name = "Fourth Coffee Quencher";
            coffee.CountyOfOrigin = "Indonesia";
            coffee.grind = "Fine";
            coffee.Strength = 3;
            Console.WriteLine("Name: {0}", coffee.Name);
            Console.WriteLine("Country of Origin: {0}", coffee.CountyOfOrigin);
            Console.WriteLine("Grind: {0}", coffee.grind);
            Console.WriteLine("Strength: {0}", coffee.Strength);

            #endregion






        }

        public struct Coffee1
        {
            public int Strength;
            public string Bean;
            public string CountryOfOrigin;
        }
    }
}
