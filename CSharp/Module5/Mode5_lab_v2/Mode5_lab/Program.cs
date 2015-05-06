using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode5_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            AllDetails.StudentInfo[] students = new AllDetails.StudentInfo[1];
            students[0] = new AllDetails.StudentInfo();
            students[0].StudentName = "Student 1";


            Console.WriteLine("{0}", students[0].StudentName);
        }
    }
}