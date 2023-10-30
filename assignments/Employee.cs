using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Employee : Person, IDisplayable
    {
        private int employeeId;
        public Employee(string firstName, string lastName, int age, int employeeId)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            this.employeeId = employeeId;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID: {employeeId}, Full Name:{FirstName} {LastName}, Age: {Age}");
        }

    }
}
