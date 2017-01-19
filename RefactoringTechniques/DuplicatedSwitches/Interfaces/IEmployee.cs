using DuplicatedSwitches.Common;

namespace DuplicatedSwitches.Interfaces
{
    public interface IEmployee
    {
        string Name { get; set; }
        //EmployeeType EmployeeType { get; }
        decimal GetSalary();
    }
}