using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mode5_lab
{
    class UProgram
    {
        private string _programName;

        public string ProgramName
        {
            get { return _programName; }
            set { _programName = value; }
        }

        internal struct Degree
        {
            private string _degreeName;

            public string DegreeName
            {
                get { return _degreeName; }
                set { _degreeName = value; }
            }

            internal struct Course
            {
                private string _courseName;

                public string CourseName
                {
                    get { return _courseName; }
                    set { _courseName = value; }
                }

                internal struct Student
                {
                    private string _studentName;

                    public string StudentName
                    {
                        get { return _studentName; }
                        set { _studentName = value; }
                    }

                    private string _studentBirthday;

                    public string StudentBirthday
                    {
                        get { return _studentBirthday; }
                        set { _studentBirthday = value; }
                    }
                }

                internal struct Teacher
                {
                    private string _teacherName;

                    public string TeacherName
                    {
                        get { return _teacherName; }
                        set { _teacherName = value; }
                    }

                    internal struct TeacherAssistant
                    {
                        private string _tAName;

                        public string TAName
                        {
                            get { return _tAName; }
                            set { _tAName = value; }
                        }
                    }

                }

            }
        }
    }
}
