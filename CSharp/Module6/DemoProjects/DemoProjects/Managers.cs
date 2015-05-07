using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjects
{
    // inheritance from Employee class; sub class
    class Managers : Employee
    {
        public override void Login()
        {
            Console.WriteLine("Manager Login");
        }

        public override void Hire()
        {
            Console.WriteLine("Hire someone");
        }

        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}
