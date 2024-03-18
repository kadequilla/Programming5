using System;
using System.Collections.Generic;
using System.Linq;
using Service.Entity;
using Service.Enums;
using Service.Service.Contracts;

namespace Service.Service.Implementations
{
    /// <summary>
    /// Represents a manager for handling operations on a collection of Employee objects.
    /// Implements the IManager interface.
    /// </summary>
    public class EmployeeManager : IManager
    {
        private readonly List<Employee> _employees; // Collection of employees managed by this manager.

        /// <summary>
        /// Initializes a new instance of the EmployeeManager class with the specified list of employees.
        /// </summary>
        public EmployeeManager()
        {
            this._employees = [];
        }

        /// <summary>
        /// Adds an employee to the collection.
        /// </summary>
        /// <param name="employee">The employee to be added.</param>
        /// <returns>The updated list of employees after adding the new employee.</returns>
        public List<Employee> Add(Employee employee)
        {
            _employees.Add(employee);
            return _employees;
        }

        /// <summary>
        /// Removes an employee from the collection based on the employee's ID.
        /// </summary>
        /// <param name="id">The ID of the employee to be removed.</param>
        /// <returns>The updated list of employees after removing the specified employee.</returns>
        public List<Employee> Remove(int id)
        {
            try
            {
                var employee = _employees.FirstOrDefault(emp => emp.EmployeeId == id);
                _employees.Remove(employee);
                return _employees;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Employee not found.");
                // Handle the exception or rethrow it if needed
                throw;
            }
        }

        /// <summary>
        /// Displays information about all employees in the collection.
        /// </summary>
        /// <returns>The list of employees being displayed.</returns>
        public List<Employee> Display()
        {
            foreach (var employee in _employees)
            {
                Console.WriteLine(
                    $"{employee.EmployeeId}  {employee.FirstName} {employee.LastName}  {employee.Salary}");
            }

            return _employees;
        }

        /// <summary>
        /// Calculates the total salary of all employees in the collection.
        /// </summary>
        /// <returns>The total salary of all employees.</returns>
        public double CalculateTotalSalary()
        {
            double total = 0;
            _employees.ForEach(emp => total += emp.Salary);
            return total;
        }

        /// <summary>
        /// Assigns an employee to a department.
        /// </summary>
        /// <param name="department">The department to which the employee is assigned.</param>
        /// <param name="employee">The employee to be assigned.</param>
        /// <returns>The employee being assigned to the department.</returns>
        public Employee AssignEmployeeToDepartment(Department department, Employee employee)
        {
            employee.Department = department;
            return employee;
        }
    }
}