using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjects
{
    // base class
    abstract class Employee
    {
        public virtual void Login()
        {
            Console.WriteLine("Employee login");
        }

        public abstract void Hire();

        #region class encapsulate
        private string empNumber;
        private string lastName;
        private string address;
        private string firstName;


        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
#endregion
        
    }
}
