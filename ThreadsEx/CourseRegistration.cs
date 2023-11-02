using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsEx
{
    internal class CourseRegistration
    {
        /*
        private List<string> registeredStudents = new List<string>();
        public void RegisterStudent(string studentName)
        {
            Thread.Sleep(100); //Simulate the time it takes to register a student
                               
            lock (registeredStudents)
            {
                registeredStudents.Add(studentName);
                Console.WriteLine($"{studentName} has registered for the course.");
            }
        }
        public int GetRegisteredStudentCount()
        {
            lock (registeredStudents)
            {
                return registeredStudents.Count;
            }
        }
        */
        private List<string> registeredStudents = new List<string>();
        public async Task RegisterStudentAsync(string studentName)
        {
            //Simulate an asynchronous registration process
            await Task.Delay(1000); //Delay for 1 second (simulating work)
            lock (registeredStudents)
            {
                registeredStudents.Add(studentName);
                Console.WriteLine($"{studentName} has registered for the course. ");
            }
        }
        public int GetRegisteredStudentCount()
        {
            lock (registeredStudents)
            {
                return registeredStudents.Count;
            }
        }

    }
}
