
using Service.Enums;
namespace Service.Entity;


public class Employee : Person, IDisposable
{
    // Static field to keep track of the total number of employees created
    private static int _totalEmployees = 0;

    // Static property to get the total number of employees
    public static int TotalEmployees => _totalEmployees;

    public Employee(double? salary = null, string? firstName = null, string? lastName = null, Department? department = null)
        : base(firstName, lastName)
    {
        _totalEmployees++;
        EmployeeId = _totalEmployees;
        Salary = salary;
        Department = department;
    }


    public int EmployeeId { get; set; }
    public double? Salary { get; set; }
    public Department? Department { get; set; }


    // Destructor
    public void Dispose()
    {
        Console.WriteLine($"Employee object with ID {EmployeeId} is being destroyed.");
    }
}