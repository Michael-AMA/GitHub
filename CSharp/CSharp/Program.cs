using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        // Get the students inforamtion
        static void GetStudentInfo(out string firstName, out string lastName, out string birthday)
        {
            Console.WriteLine("First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Birthday: ");
            birthday = Console.ReadLine();
        }

        // Get School information
        static void GetSchoolInfo(out string teacher, out string course, out string program, out string degree)
        {
            Console.WriteLine("Teacher: ");
            teacher = Console.ReadLine();
            Console.WriteLine("Course: ");
            course = Console.ReadLine();
            Console.WriteLine("Program: ");
            program = Console.ReadLine();
            Console.WriteLine("Degree: ");
            degree = Console.ReadLine();
        }

        // Print to the screen ALL student information
        static void PrintStudentInfo(string first, string last, string birthday, string teacher, string course, string program, string degree)
        {
            Console.WriteLine("Name: {0} {1}", first, last);
            Console.WriteLine("Birthdate: {0}", birthday);
            Console.WriteLine("Teacher: {0}", teacher);
            Console.WriteLine("Course: {0}", course);
            Console.WriteLine("Program: {0}", program);
            Console.WriteLine("Degree: {0}", degree);
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
            GetStudentInfo(out firstName, out lastName, out birthday);
            GetSchoolInfo(out teacher, out course, out program, out degree);
            PrintStudentInfo(firstName, lastName, birthday, teacher, course, program, degree);
            try
            {
                BirthdayValidation();
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
        }
        static void BirthdayValidation()
        {
            throw new NotImplementedException();
        }
    }
}
