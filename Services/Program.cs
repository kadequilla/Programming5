using Services.Service.Implementations;

namespace Service
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            EmployeeManager _manager = new();
            _manager.Add(new(firstName: "Kim", lastName: "Dequilla", salary: 10000));
            _manager.Add(new(firstName: "Test", lastName: "Test", salary: 10000));
            _manager.Add(new(firstName: "Test", lastName: "Test", salary: 10000));

            _manager.Remove(1);

            Console.WriteLine($"Length {_manager.Display().Count}");

            //foreach (var s in _manager.Display())
            //{
            //    Console.WriteLine(s.EmployeeId);
            //}
        }
    }
}