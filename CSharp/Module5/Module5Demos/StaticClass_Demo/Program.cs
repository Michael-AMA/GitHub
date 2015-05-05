using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Anonymous Class
            #region Anonymous Class
            var anon = new { Name = "Mikie", Age = 31 };

            Console.WriteLine(anon.Name + " " + anon.Age);
            #endregion



        }
    }
}
