using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);            
            Console.WriteLine(myMachine.Model);

        }
    }
}
