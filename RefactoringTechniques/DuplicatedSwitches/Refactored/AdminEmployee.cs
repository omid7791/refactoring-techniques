using DuplicatedSwitches.Common;

namespace DuplicatedSwitches.Refactored
{
    public class AdminEmployee : EmployeeRefactored
    {
        public AdminEmployee() : base(EmployeeType.Admin){}

        public override decimal GetSalary()
        {
            return 30m;
        }
    }
}