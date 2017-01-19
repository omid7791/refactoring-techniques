
using DuplicatedSwitches.Common;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class SwitchTests
    {
        public SwitchTests()
        {
            ObjectFactory.UseRefactoredClasses = true;
        }

        [Test]
        public void SalaryCalculatorShouldCalculateCorrectSalary()
        {
            var calculator1 = ObjectFactory.GetCalculator(EmployeeType.Admin);
            var calculator2 = ObjectFactory.GetCalculator(EmployeeType.Engineer);
            var calculator3 = ObjectFactory.GetCalculator(EmployeeType.Manager);

            Assert.IsTrue(calculator1.GetSalary() == 30m);
            Assert.IsTrue(calculator2.GetSalary() == 50m);
            Assert.IsTrue(calculator3.GetSalary() == 60m);
        }
    }
}
