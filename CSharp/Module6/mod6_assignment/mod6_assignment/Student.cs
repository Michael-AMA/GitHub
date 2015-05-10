using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_assignment
{
    class Student : Person
    {
        public int TakeTest()
        {
            Console.WriteLine("What is:\n 2 + 2");
            string answer = Console.ReadLine();
            return Convert.ToInt32(answer);
        }
        private int _studentID;
        private string _house;

        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }
        
        public string House
        {
            get { return _house; }
            set { _house = value; }
        }
    }
}
