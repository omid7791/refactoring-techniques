using DuplicatedSwitches.Interfaces;

namespace DuplicatedSwitches.Refactored
{
    public class SalaryCalculatorRefactored : ISalaryCalculator
    {
        private readonly IEmployee _employee;

        public SalaryCalculatorRefactored(IEmployee employee)
        {
            _employee = employee;
        }

        public decimal GetSalary()
        {
            return _employee.GetSalary();

            //switch (_employee.EmployeeType)
            //{
            //    case EmployeeType.Engineer:
            //        return 50m;
            //    case EmployeeType.Manager:
            //        return 60m;
            //    case EmployeeType.Admin:
            //        return 30m;
            //    default:
            //        throw new ArgumentOutOfRangeException();
            //}

        }
    }
}