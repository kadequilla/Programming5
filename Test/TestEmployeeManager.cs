using Service.Enums;
using Services.Service.Implementations;

namespace Test
{
    public class TestEmployeeManager
    {
        private EmployeeManager Init()
        {
            EmployeeManager _manager = new();
            _manager.Add(new(firstName: "Kim", lastName: "Dequilla", salary: 10000));
            _manager.Add(new(firstName: "Test", lastName: "Test", salary: 10000));
            _manager.Add(new(firstName: "Test", lastName: "Test", salary: 10000));

            return _manager;
        }

        [Fact]
        public void TestAddEmployee()
        {
            var manager = Init();

            if (manager.Display().Count > 3)
            {
                throw new Exception("Add method has duplication.");
            }
            if (manager.Display().Count < 1)
            {
                throw new Exception("Add method is not working.");
            }
        }

        [Fact]
        public void TestRemoveEmployee()
        {
            var manager = Init();
            manager.Remove(1);

            if (manager.Display().Count == 3)
            {
                throw new Exception("Doesn't remove");
            }
        }

        [Fact]
        public void TestAssignDepartment()
        {
            var manager = Init();
            var employee = manager.Display().First();
            manager.AssignEmployeeToDepartment(Department.Finance, employee);

            if (employee.Department != Department.Finance)
            {
                throw new Exception("Doesnt update department.");
            }
        }
    }
}