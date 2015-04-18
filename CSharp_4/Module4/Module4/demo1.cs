using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        static void Main(string[] args)
        {
            // loop through single dimensional array
            Console.WriteLine("Single Dimensional Array");
            int[] intArray = {5, 10, 1, 20, 25, 10};
            for(int counter = 0; counter < intArray.Length; counter++)
            {
                Console.WriteLine("{0}", intArray[counter]);
            }

            Console.WriteLine("\nTwo Dimensional Array");
            // two dimensional array
            int[,] twoDArray = { { 3, 2, 8, 9 }, { 4, 5, 6, 1 }, { 5, 6, 0, 5} };

            for (int x = 0; x < twoDArray.GetLength(0); x++)
            {
                for (int y = 0; y < twoDArray.GetLength(1); y++)
                {
                    int value = twoDArray[x, y];
                    Console.WriteLine(value.ToString());
                }
            }

            // Enums Arrays
            Console.WriteLine("");
            Console.WriteLine("Enums Array.");

            // enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
            #region enum demo

            int s = (int)Days.Thursday;
            int t = (int)Days.Friday;
            Console.WriteLine("Thurday = {0}", s);
            Console.WriteLine("Fri = {0}", t);

            #endregion


        }
    }
}
