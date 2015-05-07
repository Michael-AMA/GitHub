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
            UProgram ComputerScience = new UProgram();
            ComputerScience.ProgramName = "Information Technology";
            UProgram.Degree BS = new UProgram.Degree();
            BS.DegreeName = "Bachelor of Science";
            UProgram.Degree.Course[] ProgrammingWithCSharp = new UProgram.Degree.Course[3];
            ProgrammingWithCSharp[0].CourseName = "Programming with C#";
            UProgram.Degree.Course.Student[] students = new UProgram.Degree.Course.Student[3];
            students[0].StudentName = "student 1";
            students[1].StudentName = "student 2";
            students[2].StudentName = "student 3";
            UProgram.Degree.Course.Teacher[] TeacherName = new UProgram.Degree.Course.Teacher[3];
            TeacherName[0].TeacherName = "Pro. O'Brien";
            UProgram.Degree.Course.Teacher.TeacherAssistant[] TAsName = new UProgram.Degree.Course.Teacher.TeacherAssistant[3];
            TAsName[0].TAName = "Mike Jones";

            Console.WriteLine("The {0} program contains the {1} degree.", ComputerScience.ProgramName, BS.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}.", BS.DegreeName, ProgrammingWithCSharp[0].CourseName);
            Console.WriteLine("The {0} course contains {1} student(s).", ProgrammingWithCSharp[0].CourseName, students.Length);
        }
    }
}