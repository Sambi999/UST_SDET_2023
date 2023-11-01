using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQEx
    {
        public void eg1()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("Web Tech");
            courses.Add("DBMS");
            courses.Add("UI Exp");
            /*var result = from c in courses
                         where c.Equals("DBMS")
                         select c;
            */
            //var result = courses.Where(c => c.Equals("DBMS"));
            var result = courses.Where(c => c.Contains("Tutorial"));

            foreach (var c in result)
            {
                Console.WriteLine(c);

            }



        }
        public void eg2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "SAMBI", "CSE"));
            students.Add(new Student(2, "Trisha", "CSE"));

            students.Add(new Student(3, "Anupama", "CSE"));

            students.Add(new Student(4, "Kajal", "CSE"));

            students.Add(new Student(5, "Mumith", "CSE"));
            /*
            var stud = students.Where(s => s.Id == 5);
            foreach (var s in stud)
            {
                Console.WriteLine( " Student " + s.Id + " " + s.Name + " " + s.Dept);
            }
            var stud1 = students.Where(s => s.Name == "Kajal");
            foreach (var s in stud1)
            {
                Console.WriteLine(" Student " + s.Id + " " + s.Name + " " + s.Dept);
            }
            */
            /*
            Student stud = (Student)students.FirstOrDefault(s => s.Id == 3);
            if (stud != null)
            {
                Console.WriteLine(" Student : " + stud.Id + " " + stud.Name + stud.Dept);
            }
            else
            {
                Console.WriteLine("NF");
            }
                
            List<Student> stud1 = (List <Student>) students.FindAll(s => s.Name == "Kajal" || s.Name == "Mumith");
            foreach (var s in stud1)
            {
                Console.WriteLine("Student" + s.Id + " " + s.Name + " " + s.Dept);
            }
            Console.WriteLine(">=5");
            List<Student> stud2 = (List<Student>) students.FindAll(s => s.Name == "Kajal" || stud.Name == "Mumith");
            foreach (var s in stud2)
            {
                Console.WriteLine("Student" + s.Id + " " + s.Name + " " + s.Dept);
            }

            

        }
        */

            
        

 
            /*

            public void filteringOfType()
            {
                ArrayList elements = new ArrayList();
                elements.Add(1);
                elements.Add("Two);
                elements.Add(3);
                elements.Add(4);
                elements.Add("Five);
                /*
                var strings = from e in elements.OfType<string>()
                          select e;
                var numbers = from e in elements.OfType<int>()
                          select e;
            */
            /*
                var numbers = elements.OfType<int>();
                var strings = elements.OfType<string>();
                foreach (string str in strings)
                    Console.WriteLine("String : " + str);

                foreach (int num in numbers)
                    Console.WriteLine("Integer : " + num);
            }
            */


            /*
            public void Grouping()
            {
                IList<StudentList> studentList = new
                elements.Add(1);
                elements.Add("Two);
                elements.Add(3);
                elements.Add(4);
                elements.Add("Five); 

             /*
             var result = from s in studentList
                        group s by s.StudentName;
            */

            /*
            var result = studentList.ToLookup(s => s.StudentName);
                foreach (var s in result)
                {
                    Console.WriteLine(s.Key);
                    foreach (var x in s)
                        Console.WriteLine(x.StudentID + " " + x.Age);
                }
                */
                








            
        }
        
    }
}
