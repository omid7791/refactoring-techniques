using System;
using DuplicatedSwitches.Common;

namespace DuplicatedSwitches.Refactored
{
    public abstract class EmployeeRefactored
    {
        public static EmployeeRefactored Create(EmployeeType employeeType)
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

        public abstract decimal GetSalary();
    }
}
