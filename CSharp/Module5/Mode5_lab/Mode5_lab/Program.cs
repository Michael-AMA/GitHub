using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moduloCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Instantiate three Student objects.
            Student objStuDentUno = new Student("Pedro", "Perez", "pperez@gmail.com ", DateTime.Parse("20/06/1974"));
            Student objStuDentDos = new Student("Juan", "Segundo", "jsegundo@gmail.com", DateTime.Parse("31/01/1985"));
            Student objStuDentTres = new Student("Carlorina", "Tres", "ctres@gmail.com", DateTime.Parse("17/10/1973"));

            //2.Instantiate a Course object called Programming with C#.
            Course objCourse = new Course(101, "Programming with C#", 5, 1000);

            //3.Add your three students to this Course object.
            objCourse.ArrayStudent[0] = objStuDentUno;
            objCourse.ArrayStudent[1] = objStuDentDos;
            objCourse.ArrayStudent[2] = objStuDentTres;

            //4.Instantiate at least one Teacher object.
            Teacher objteacher = new Teacher();
            objteacher.FirstName = "Roland";
            objteacher.LastName = "Garzon";
            objteacher.Email = "roljha@gmail.com";
            objteacher.Grade = "10";

            //5.Add that Teacher object to your Course object
            objCourse.ArrayTeacher[0] = objteacher;

            //6.Instantiate a Degree object, such as Bachelor.
            Degree objDegree = new Degree("Bachelor", 6, "Face to Face");

            //7.Add your Course object to the Degree object.
            objDegree.NewCourse = objCourse;

            //8.Instantiate a UProgram object called Information Technology.
            UProgram objUProgram = new UProgram("Information Technology", "Tres", "yes");

            //9.Add the Degree object to the UProgram object.
            objUProgram.NewDegree = objDegree;

            //10.Using Console.WriteLine statements, output the following information to the console window:
            //The name of the program and the degree it contains
            Console.WriteLine("The {0} program contains the {1} of Science degree.", objUProgram.ProgramName, objDegree.Type);
            //The name of the course in the degree
            Console.WriteLine("The {0} of Science degree contains the course {1}.", objDegree.Type, objCourse.NameCourse);
            //The count of the number of students in the course.
            Console.WriteLine("The {0} course contains {1} students.", objCourse.NameCourse, objCourse.Students_number(objCourse.ArrayStudent));
            Console.ReadKey();

        }
    }

    public class Student
    {
        private static int count = 0;
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private DateTime birthday;

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public static int Count()
        {
            return count;
        }

        public Student(string firstName, string lastName, string email, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Birthday = birthday;
            count++;
        }

    }

    public class Teacher
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }

    public class Degree
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private string mode;

        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        private Course newCourse;
        private string p1;
        private int p2;
        private string p3;

        public Degree(string type, int duration, string mode)
        {
            // TODO: Complete member initialization
            this.Type = type;
            this.Duration = duration;
            this.Mode = mode;
        }

        public Course NewCourse
        {
            get { return newCourse; }
            set { newCourse = value; }
        }

    }

    public class Course
    {
        private Student[] arrayStudent = new Student[4];

        public Student[] ArrayStudent
        {
            get { return arrayStudent; }
            set { arrayStudent = value; }
        }

        private Teacher[] arrayTeacher = new Teacher[3];

        public Teacher[] ArrayTeacher
        {
            get { return arrayTeacher; }
            set { arrayTeacher = value; }
        }

        private int idCourse;

        public int IdCourse
        {
            get { return idCourse; }
            set { idCourse = value; }
        }
        private string nameCourse;

        public string NameCourse
        {
            get { return nameCourse; }
            set { nameCourse = value; }
        }
        private int credit;

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        private decimal cost;

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public Course(int idcourse, string nameCourse, int credit, decimal cost)
        {
            // TODO: Complete member initialization
            this.IdCourse = idcourse;
            this.NameCourse = nameCourse;
            this.Credit = credit;
            this.Cost = cost;
        }

        public int Students_number(Student[] ArrayStudent)
        {
            int i = 0;
            while (ArrayStudent[i] != null)
            {
                i++;
            }
            return i;
        }

    }

    public class UProgram
    {
        private Degree newDegree;

        public Degree NewDegree
        {
            get { return newDegree; }
            set { newDegree = value; }
        }

        private string programName;

        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }
        private string programDegreesoffered;

        public string ProgramDegreesoffered
        {
            get { return programDegreesoffered; }
            set { programDegreesoffered = value; }
        }
        private string programDepartmentHead;

        public string ProgramDepartmentHead
        {
            get { return programDepartmentHead; }
            set { programDepartmentHead = value; }
        }

        public UProgram(string programName, string programDegreesoffered, string programDepartmentHead)
        {
            // TODO: Complete member initialization
            this.ProgramName = programName;
            this.ProgramDegreesoffered = programDegreesoffered;
            this.ProgramDepartmentHead = programDepartmentHead;
        }

    }

}