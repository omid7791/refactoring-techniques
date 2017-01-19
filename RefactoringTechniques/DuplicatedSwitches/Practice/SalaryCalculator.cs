using System;
using DuplicatedSwitches.Common;
using DuplicatedSwitches.Interfaces;

namespace DuplicatedSwitches.Practice
{
    public class SalaryCalculator : ISalaryCalculator
    {
        private readonly Employee _employee;

        public SalaryCalculator(Employee employee)
        {
            _employee = employee;
        }

        public decimal GetSalary()
        {
            switch (_employee.EmployeeType)
            {
                case EmployeeType.Engineer:
                    return 50m;
                case EmployeeType.Manager:
                    return 60m;
                case EmployeeType.Admin:
                    return 30m;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}