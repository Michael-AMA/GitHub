using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4_PracticeLab
{
    struct StudentInfo
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthday { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo student1 = new StudentInfo();
            student1.firstName = "Michael";
            student1.lastName = "Osborn";
            student1.birthday = "8/20/1984";


        }
    }
}
