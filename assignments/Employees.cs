using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignments
{
    internal class Employees
    {
        public Employees(int employeeId, string? employeeName, double performanceRange)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            PerformanceRange = performanceRange;
        }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public double PerformanceRange { get; set; }
        public static double BonusCalculation(Employees employee)
        {
            double bonusCalculation = 0;
            if (employee.PerformanceRange > 1 && employee.PerformanceRange <= 2)
            {
                bonusCalculation = employee.PerformanceRange * 10000;
            }
            else if (employee.PerformanceRange > 3 && employee.PerformanceRange <= 4)
            {
                bonusCalculation = employee.PerformanceRange * 20000;
            }
            else
            {
                bonusCalculation = employee.PerformanceRange * 30000;
            }

            return bonusCalculation;
        }
        public static double BonusCalculationOne(Employees employeeone)
        {
            double bonusCalculationone = 0;
            if (employeeone.PerformanceRange > 1 && employeeone.PerformanceRange <= 2)
            {
                bonusCalculationone = employeeone.PerformanceRange * 5000;
            }
            else if (employeeone.PerformanceRange > 3 && employeeone.PerformanceRange <= 4)
            {
                bonusCalculationone = employeeone.PerformanceRange * 6000;
            }
            else
            {
                bonusCalculationone = employeeone.PerformanceRange * 7000;
            }

            return bonusCalculationone;
        }
    }
}
