using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode5_lab
{
    class TeacherDetails
    {
        private string _fName;

        public string FName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        private string _lName;

        public string LName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine("Teacher Information");
            Console.WriteLine("First Name:");
            FName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            LName = Console.ReadLine();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Teacher: {0} {1}.", FName, LName);
        }
    }
}
