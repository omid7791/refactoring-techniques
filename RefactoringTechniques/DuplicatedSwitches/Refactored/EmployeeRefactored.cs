using System;
using DuplicatedSwitches.Common;
using DuplicatedSwitches.Interfaces;

namespace DuplicatedSwitches.Refactored
{
    public abstract class EmployeeRefactored : IEmployee
    {
        protected EmployeeRefactored(EmployeeType type)
        {
            EmployeeType = type;
        }

        public static IEmployee Create(EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.Engineer:
                    return new EngineerEmployee();
                case EmployeeType.Manager:
                    return new ManagerEmployee();
                case EmployeeType.Admin:
                    return new AdminEmployee();
                default:
                    throw new ArgumentOutOfRangeException(nameof(employeeType), employeeType, null);
            }
        }

        public string Name { get; set; }

        public EmployeeType EmployeeType { get; }

        public abstract decimal GetSalary();
    }
}
