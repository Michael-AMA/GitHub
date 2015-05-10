using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_assignment
{
    class Degree : UProgram
    {
        private string _degreeName;

        public string DegreeName
        {
            get { return _degreeName; }
            set { _degreeName = value; }
        }
    }
}
