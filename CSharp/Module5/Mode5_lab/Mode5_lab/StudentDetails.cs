using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode5_lab
{
    class StudentDetails
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
        private string _bDay;

        public string BDay
        {
            get { return _bDay; }
            set { _bDay = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine("Student Infomation");
            Console.WriteLine("First Name:");
            FName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            LName = Console.ReadLine();
            Console.WriteLine("Birthday:");
            BDay = Console.ReadLine();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Student: {0} {1} \nBirthday: {2}", FName, LName, BDay);
        }
    }

    
}
