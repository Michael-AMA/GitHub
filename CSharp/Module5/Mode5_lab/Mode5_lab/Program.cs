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
            ProgramClass.StudentInfo[] students = new ProgramClass.StudentInfo[3];
            students[0] = new ProgramClass.StudentInfo();
            students[1] = new ProgramClass.StudentInfo();
            students[2] = new ProgramClass.StudentInfo();
            students[0].Name = "student 1";
            students[0].BDay = "4/20/84";
            students[1].Name = "student 2";
            students[1].BDay = "1/2/34";
            students[2].Name = "student 3";
            students[2].BDay = "8/29/91";

            ProgramClass.Course[] ProgrammingWithCsharp = new ProgramClass.Course[3];
            ProgrammingWithCsharp[0] = new ProgramClass.Course();
            //ProgrammingWithCsharp[1] = new ProgramClass.Course();
            //ProgrammingWithCsharp[2] = new ProgramClass.Course();
            ProgrammingWithCsharp[0].CourseInfo = "Programming With C#";
            ProgrammingWithCsharp[0].EnrolledStudents = students[0];
            Console.WriteLine(ProgrammingWithCsharp[0].CourseInfo);
        }
    }
}