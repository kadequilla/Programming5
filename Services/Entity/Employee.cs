using Service.Enums;

namespace Service.Entity
{
    public class Employee : Person, IDisposable
    {
        // Static field to keep track of the total number of employees created
        private static int _totalEmployees = 0;
        private bool isDisposed = false;

        // Static property to get the total number of employees
        public static int TotalEmployees => _totalEmployees;

        public Employee(double? salary = null, string? firstName = null, string? lastName = null, Department? department = null)
            : base(firstName, lastName)
        {
            Console.WriteLine("NEW INSTANCE");

            if (isDisposed)
            {
                throw new ObjectDisposedException(nameof(Employee));
            }

            _totalEmployees++;
            EmployeeId = _totalEmployees;
            Salary = salary;
            Department = department;
        }

        public int EmployeeId { get; set; }
        public double? Salary { get; set; }
        public Department? Department { get; set; }

        // Dispose method to release resources
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected virtual method to provide a way for derived classes to clean up resources
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;

            if (disposing)
            {
                // Dispose of managed resources 
            }

            // Dispose of unmanaged resources here

            _totalEmployees--;

            isDisposed = true;
            Console.WriteLine($"Employee object with ID {EmployeeId} is being destroyed.");
        }

        // Destructor (finalizer) to release unmanaged resources
        ~Employee()
        {
            Dispose(false);
        }

    }
}
