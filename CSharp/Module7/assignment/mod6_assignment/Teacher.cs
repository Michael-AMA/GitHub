using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_assignment
{
    class Teacher : Person
    {
        public bool GradeTest(int ans)
        {
            if (ans == 4)
                return true;
            else
                return false;
        }
        
        private string _professorName;

        public string ProfessorName
        {
            get { return _professorName; }
            set { _professorName = value; }
        }
    }
}
