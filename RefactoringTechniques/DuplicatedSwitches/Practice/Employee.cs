using DuplicatedSwitches.Common;
using DuplicatedSwitches.Interfaces;

namespace DuplicatedSwitches.Practice
{
    public class Employee : IEmployee
    {
        public Employee(EmployeeType type)
        {
            EmployeeType = type;
        }
        public string Name { get; set; }

        public EmployeeType EmployeeType { get; }
        public decimal GetSalary()
        {
            throw new System.NotImplementedException();
        }
    }
}
