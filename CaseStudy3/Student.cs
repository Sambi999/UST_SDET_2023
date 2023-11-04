using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy3
{
    internal class Student
    {


        public int Id { get; set; }
        public string? StudName { get; set; }
        public string? Email { get; set; }
        public static List<Student> students = new List<Student>();


    }
}
