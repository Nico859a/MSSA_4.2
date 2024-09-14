using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    internal class Student
    {
        private int _studentID;
        private string _studentName;
        private decimal _GPA;

        public int StudentID { get => _studentID; set => _studentID = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public decimal GPA { get => _GPA; set => _GPA = value; }

        public Student(int studentID, string studentName, decimal GPA)
        {
            this.StudentID = studentID;
            this.StudentName = studentName;
            this.GPA = GPA;
        }

        public Student()
        {
            this.StudentID = 0;
            this.StudentName = "";
            this.GPA = 0;
        }
    }
}
