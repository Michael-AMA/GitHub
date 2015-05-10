using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204_Module6
{
    class Program
    {
        public class course
        {

            public student[] students = new student[3];
            public teacher[] teachers = new teacher[3];

            private string _courseTitle;
            public string CourseTitle
            {
                get { return _courseTitle; }
                set { _courseTitle = value; }
            }

            private int _courseLength;

            public int CourseLength
            {
                get { return _courseLength; }
                set { _courseLength = value; }
            }

            private int _courseCredits;

            public int CourseCredits
            {
                get { return _courseCredits; }
                set { _courseCredits = value; }
            }

        }

        public class degree
        {

            public course degreecourse { get; set; }

            private string _degreeName;
            public string DegreeName
            {
                get { return _degreeName; }
                set { _degreeName = value; }
            }

            private string _degreelength;
            public string Degreelength
            {
                get { return _degreelength; }
                set { _degreelength = value; }
            }

            private string _degreecredits;
            public string Degreecredits
            {
                get { return _degreecredits; }
                set { _degreecredits = value; }
            }

        }

        public class Person
        {
            private string firstname;
            public string Firstname
            {
                get { return firstname; }
                set { firstname = value; }
            }
            private string lastname;
            public string Lastname
            {
                get { return lastname; }
                set { lastname = value; }
            }
            private string address;
            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            private string dateofbirth;
            public string Dateofbirth
            {
                get { return dateofbirth; }
                set { dateofbirth = value; }
            }

        }

        public class student : Person
        {
            public void TakeTest()
            {
                Console.WriteLine("This is a taken test");
            }
        }

        public class teacher : Person
        {
            public void GradeTest()
            {
                Console.WriteLine("This is a grade test");
            }
        }

        class uprogram
        {
            public degree Programdegree { get; set; }

            private string _programtitle;
            public string Programtitle
            {
                get { return _programtitle; }
                set { _programtitle = value; }
            }

            private string _progamschool;

            public string Progamschool
            {
                get { return _progamschool; }
                set { _progamschool = value; }
            }

        }

        static void Main(string[] args)
        {
            // 5.Run the same code in Program.cs from Module 5 to create instances of your classes so that you can setup a single course that is part of a program and a degree path. Be sure to include at least one Teacher and an array of Students.
            student student1 = new student();
            student1.Firstname = "Tony";
            student1.Lastname = "Stark";
            student1.Dateofbirth = "1st Jan 1969";

            student student2 = new student();
            student2.Firstname = "Steve";
            student2.Lastname = "Rodgers";
            student2.Dateofbirth = "1st Feb 1920";

            student student3 = new student();
            student3.Firstname = "Bruce";
            student3.Lastname = "Banner";
            student3.Dateofbirth = "1st April 1975";

            //2.Instantiate a Course object called Programming with C#.
            course Programming = new course();
            Programming.CourseTitle = "Programming with C#";
            Programming.CourseLength = 3;
            Programming.CourseCredits = 90;

            //3.Add your three students to this Course object
            Programming.students[0] = student1;
            Programming.students[1] = student2;
            Programming.students[2] = student3;

            //4.Instantiate at least one Teacher object.
            teacher teacher1 = new teacher();
            teacher1.Firstname = "Stan";
            teacher1.Lastname = "Winston";
            teacher1.Dateofbirth = "1st Dec 1919";

            //5.Add that Teacher object to your Course object
            Programming.teachers[0] = teacher1;

            //6.Instantiate a Degree object, such as Bachelor.
            degree degree1 = new degree();
            degree1.DegreeName = "Bachelor";

            //7.Add your Course object to the Degree object.
            degree1.degreecourse = Programming;

            //8.Instantiate a UProgram object called Information Technology.
            uprogram uprogram1 = new uprogram();
            uprogram1.Programtitle = "Information Technology";

            //9.Add the Degree object to the UProgram object.
            uprogram1.Programdegree = degree1;

            //10.Using Console.WriteLine statements, output
            Console.WriteLine("The {0} program contains the {1} degree", uprogram1.Programtitle, degree1.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}", degree1.DegreeName, Programming.CourseTitle);
            Console.WriteLine("The {0} course contains {1} students(s)", Programming.CourseTitle, Programming.students.Length);
            //student1.TakeTest();
            Console.ReadLine();

        }
    }
}