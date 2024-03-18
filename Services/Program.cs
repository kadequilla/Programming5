using Service.Entity;
using Services.Service.Implementations;

namespace Service
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //Functionalities demonstration
            var employeeManager = new EmployeeManager();
            //ADD

            using (Employee myObject = new(firstName: "Kim", lastName: "Dequilla", salary: 10000))
                employeeManager.Add(myObject);

            using (Employee myObject = new(firstName: "Ariel", lastName: "Dequilla", salary: 10000))
                employeeManager.Add(myObject);

            using (Employee myObject = new(firstName: "John", lastName: "Joe", salary: 10000))
                employeeManager.Add(myObject);


            //Remove
            employeeManager.Remove(2);


            //Display
            employeeManager.Display();
            Console.ReadKey();
        }
    }
}