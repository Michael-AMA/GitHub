using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode5_lab
{

    class AllDetails
    {
        internal class StudentInfo
        {
            private string _studentName;

            public string StudentName
            {
                get { return _studentName; }
                set { _studentName = value; }
            }

            private string _birthday;

            public string Birthday
            {
                get { return _birthday; }
                set { _birthday = value; }
            }
        }

        internal class StudentInfoLastName
        {
            private string _lastName;

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = value; }
            }
        }

        

        internal class CourseDetails
        {
            private string _teacherName;

            public string TeacherName
            {
                get { return _teacherName; }
                set { _teacherName = value; }
            }
        
            private string _courseName;

            public string CourseName
            {
                get { return _courseName; }
                set { _courseName = value; }
            }
            private string _degreeName;

            public string DegreeName
            {
                get { return _degreeName; }
                set { _degreeName = value; }
            }
            private string _uProgram;

            public string UProgram
            {
                get { return _uProgram; }
                set { _uProgram = value; }
            }
        }
//        #region StudentInfo Class
//        internal class StudentInfo
//        {
//            private string _name;

//            public string Name
//            {
//                get { return _name; }
//                set { _name = value; }
//            }
//            private string _bDay;

//            public string BDay
//            {
//                get { return _bDay; }
//                set { _bDay = value; }
//            }
//        }
//#endregion
//        #region TeacherInfo class
//        internal class TeacherInfo
//        {
//            private string _fName;

//            public string FName
//            {
//                get { return _fName; }
//                set { _fName = value; }
//            }
//            private string _lName;

//            public string LName
//            {
//                get { return _lName; }
//                set { _lName = value; }
//            }

//        }
//        #endregion
//        #region UProgram Class
//        internal class UProgram
//        {
//            private string _programInfo;

//            public string ProgramInfo
//            {
//                get { return _programInfo; }
//                set { _programInfo = value; }
//            }

//        }
//        #endregion
//        #region Degree Class
//        internal class Degree
//        {
//            private string _degreeInfo;

//            public string DegreeInfo
//            {
//                get { return _degreeInfo; }
//                set { _degreeInfo = value; }
//            }
//        }
//        #endregion
//        #region Course Class
//        internal class Course
//        {
//            private string _courseInfo;

//            public string CourseInfo
//            {
//                get { return _courseInfo; }
//                set { _courseInfo = value; }
//            }

//            private string _enrolledStudents;

//            public string EnrolledStudents
//            {
//                get { return _enrolledStudents; }
//                set { _enrolledStudents = value; }
//            }
//        }
//        #endregion

    }
}
