using System;
using Programming5.Entity;
using Service.Enums;

namespace Service.Entity
{
    public class Employee : Person
    {
        // Static field to keep track of the total number of employees created
        private static int _totalEmployees = 0;

        // Static property to get the total number of employees
        public static int TotalEmployees => _totalEmployees;

        public Employee(double salary, string firstName, string lastName, Department? department = null)
            : base(firstName, lastName)
        {
            _totalEmployees++;
            EmployeeId = _totalEmployees;
            Salary = salary;
            Department = department;
        }

        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public Department? Department { get; set; }


        // Destructor
        ~Employee()
        {
            Console.WriteLine($"Employee object with ID {EmployeeId} is being destroyed.");
        }
    }
}