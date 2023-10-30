using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
     class Student
     {
        public string studentName;
        public int[] studentGrades;

        public Student(string studentName, int[] studentGrades)
        {
            this.studentName = studentName;
            this.studentGrades = studentGrades;
        }
        public double CalculateAverage()
        {
            if (studentGrades.Length == 0)
            {
                return 0;

            }
            int sum = 0;
            foreach (int grade in studentGrades)
            {
                sum += grade;
            }
            return sum / studentGrades.Length;
        }


    }
}
