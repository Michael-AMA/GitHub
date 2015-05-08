using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student test = new Student();
            int testAnswer = test.TakeTest();
            Teacher grading = new Teacher();

            if (grading.GradeTest(testAnswer))
                Console.WriteLine("Past");
            else
                Console.WriteLine("Failed");

        }
    }
}
