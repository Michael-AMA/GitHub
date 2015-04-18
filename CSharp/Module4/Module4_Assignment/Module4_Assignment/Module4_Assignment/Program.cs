using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_Assignment
{
    public struct StudentInfo
    {
        public string firstName;
        public string lastName;
        public string birthdate;
        public StudentInfo(string fName, string lName, string bDate)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthdate = bDate;
        }
    }
    struct TeacherInfo
    {
        public string tfirstName;
        public string tlastName;
        public TeacherInfo(string tfName, string tlName)
        {
            this.tfirstName = tfName;
            this.tlastName = tlName;
        }
    }
    struct CourseInfo
    {
        public string courseName;
        public CourseInfo(string cName)
        {
            this.courseName = cName;
        }
    }
    struct ProgramInfo
    {
        public string programName;
        public string degreeName;
        public ProgramInfo(string pName, string dName)
        {
            this.programName = pName;
            this.degreeName = dName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo[] students = new StudentInfo[5];
            students[0] = new StudentInfo("John", "Smith", "4/30/69");
            TeacherInfo[] teachers = new TeacherInfo[5];
            teachers[0] = new TeacherInfo("David", "Malon");
            CourseInfo[] course = new CourseInfo[5];
            course[0] = new CourseInfo("Intro to C#");
            ProgramInfo[] program = new ProgramInfo[5];
            program[0] = new ProgramInfo("C#", "Computer Science");

            Console.WriteLine("Student Details: {0} {1} Born on: {2}", students[0].firstName, students[0].lastName, students[0].birthdate);
            Console.WriteLine("Teacher Details: {0} {1}", teachers[0].tfirstName, teachers[0].tlastName);
            Console.WriteLine("Course Name: {0}", course[0].courseName);
            Console.WriteLine("Program Name: {0}", program[0].programName);
            Console.WriteLine("Degree Name: {0}", program[0].degreeName);
        }
    }
}
