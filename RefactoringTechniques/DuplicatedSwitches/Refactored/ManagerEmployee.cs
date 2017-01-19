using DuplicatedSwitches.Common;

namespace DuplicatedSwitches.Refactored
{
    public class ManagerEmployee : EmployeeRefactored
    {
        public ManagerEmployee() : base(EmployeeType.Manager)
        {
        }

        public override decimal GetSalary()
        {
            return 60m;
        }
    }
}