using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Assignment
{
    public struct StudentInfo
    {
        public string[] firstName;
        public string[] lastName;
        public string[] birthdate;
    }
    struct TeacherInfo
    {
        public string[] firstName;
        public string[] lastName;
    }
    struct CourseInfo
    {
        public string[] courseName;
    }
    struct ProgramInfo
    {
        public string[] programName;
        public string[] degree;
    }
    
    class Program
    {
            // Get the students inforamtion
            static void GetStudentInfo(out string firstName, out string lastName, out string birthday, out string teacher, out string course, out string program, out string degree)
        {
            Console.WriteLine("First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            lastName  = Console.ReadLine();
            Console.WriteLine("Birthday: ");
            birthday = Console.ReadLine();
            Console.WriteLine("Teacher: ");
            teacher = Console.ReadLine();
            Console.WriteLine("Course");
            course = Console.ReadLine();
            Console.WriteLine("Program: ");
            program = Console.ReadLine();
            Console.WriteLine("Degree: ");
            degree = Console.ReadLine();

        }

        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string birthday;
            string teacher;
            string course;
            string program;
            string degree;
            GetStudentInfo(out firstName, out lastName, out birthday, out teacher, out course, out program, out degree);
            StudentInfo studentsDetails = new StudentInfo();
            studentsDetails.firstName = new string[] {firstName, "Mary", "April", "Mike", "Steve"};
            studentsDetails.lastName = new string[] {lastName};
            studentsDetails.birthdate = new string[] {birthday};

            Console.WriteLine("{0} {1} Born on: {2}", studentsDetails.firstName[0], studentsDetails.lastName[0], studentsDetails.birthdate[0]);


        }
    }
}
