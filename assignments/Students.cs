using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    
    
        internal class Students
        {
            private string? name;
            private double[] marks = new double[10];
            private char grade;



            public Students(string? name, double[] marks, char grade)
            {
                this.Name = name;
                this.Marks = marks;
                this.Grade = grade;
            }

            public string? Name { get => name; set => name = value; }
            public double[] Marks { get => marks; set => marks = value; }
            public char Grade { get => grade; set => grade = value; }
            public double CalculateAverage()
            {
                double average, total = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    total = total + marks[i];

                }
                average = total / marks.Length;
                return average;
            }
            public string GetMarksSummary()
            {
                return $"Highest is: {marks.Max()} + Lowest Mark is:  {marks.Min()}";

            }
        }
    }



