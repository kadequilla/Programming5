using Service.Entity;
using Service.Service.Implementations;

namespace Service
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //Functionalities demonstration
            var employeeManager = new EmployeeManager();
            //ADD
            employeeManager.Add(new Employee(firstName: "Kim", lastName: "Dequilla", salary: 10000));
            employeeManager.Add(new Employee(firstName: "Ariel", lastName: "Nino", salary: 15500));
            employeeManager.Add(new Employee(firstName: "Mitch", lastName: "Barcelona", salary: 16500));
            employeeManager.Add(new Employee(firstName: "John", lastName: "Joe", salary: 18900));

            //Remove
            employeeManager.Remove(4);
            
            //Add new
            employeeManager.Add(new Employee(firstName: "John1", lastName: "Joe", salary: 18900));
            employeeManager.Add(new Employee(firstName: "John2", lastName: "Joe", salary: 18900));
            
            //Display
            employeeManager.Display();
        }
    }
}