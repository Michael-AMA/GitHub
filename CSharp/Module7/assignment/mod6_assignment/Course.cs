using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_assignment
{
    class Course : Degree
    {
        private string _courseName;

        public Course(string _courseName)
        {
            this.CourseName = _courseName;
        }


        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
    }
}
