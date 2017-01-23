using DuplicatedSwitches.Common;

namespace DuplicatedSwitches.Practice
{
    public class Employee
    {
        public Employee(EmployeeType type)
        {
            EmployeeType = type;
        }
        public string Name { get; set; }

        public EmployeeType EmployeeType { get; }
    }
}
