using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod6_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram uProgram = new UProgram();
            Degree degree = new Degree();
            Course[] course = new Course[3];
            Student[] student = new Student[3];

            uProgram.UProgramName = "Information Technology";
            degree.DegreeName = "Bachelor of Science";
            course[0] = new Course();
            course[0].CourseName = "Programming with C#";

            //Student 0 info
            student[0] = new Student();
            student[0].FirstName= "Student";
            student[0].LastName = "0";
            student[0].Birthday = "4/29/92";
            student[0].StudentID = 1234;
            student[0].UProgramName = uProgram.UProgramName;
            student[0].DegreeName = degree.DegreeName;

            student[0].CourseName = course[0].CourseName;
            // Student 1 info
            student[1] = new Student();
            student[1].FirstName = "Student";
            student[1].LastName = "1";
            student[1].Birthday = "3/15/84";
            student[1].UProgramName = uProgram.UProgramName;
            student[1].DegreeName = degree.DegreeName;
            student[1].CourseName = course[0].CourseName;
            // Student 2 info
            student[2] = new Student();
            student[2].FirstName = "Student";
            student[2].LastName = "2";
            student[2].Birthday = "12/25/79";
            student[2].UProgramName = uProgram.UProgramName;
            student[2].DegreeName = degree.DegreeName;
            student[2].CourseName = course[0].CourseName;

            // Teacher detail
            Teacher[] teacher = new Teacher[3];
            teacher[0] = new Teacher();
            teacher[0].FirstName = "Teacher";
            teacher[0].LastName = "0";
            teacher[0].Birthday = "10/23/65";
            teacher[0].ProfessorName = "Professor 0";
            
            Console.WriteLine("The {0} program contains the {1}", uProgram.UProgramName, degree.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}", degree.DegreeName, course[0].CourseName);
            Console.WriteLine("The {0} course contains {1} student(s).", course[0].CourseName, student.Length);
        }
    }
}
