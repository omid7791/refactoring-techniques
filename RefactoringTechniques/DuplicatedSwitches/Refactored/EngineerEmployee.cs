using DuplicatedSwitches.Common;

namespace DuplicatedSwitches.Refactored
{
    public class EngineerEmployee : EmployeeRefactored
    {
        public EngineerEmployee() : base(EmployeeType.Engineer)
        {
        }

        public override decimal GetSalary()
        {
            return 50m;
        }
    }
}