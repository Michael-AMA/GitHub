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
            StudentDetails myStudent = new StudentDetails();
            myStudent.GetInfo();
            myStudent.DisplayInfo();
            TeacherDetails csTeacher = new TeacherDetails();
            csTeacher.GetInfo();
            csTeacher.DisplayInfo();
        }
    }
}