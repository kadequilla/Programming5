using Service.Entity;
using Service.Enums;

namespace Service.Service.Contracts;

public interface IManager
{
    public Employee AssignEmployeeToDepartment(Department department, Employee employee);
}