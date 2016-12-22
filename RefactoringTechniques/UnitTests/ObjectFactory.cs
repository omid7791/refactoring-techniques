using DuplicatedCode.Interfaces;
using DuplicatedCode.Practice;
using DuplicatedCode.Refactored;

namespace UnitTests
{
    public static class ObjectFactory
    {
        public static bool UseRefactoredClasses;

        public static IFootball GetFootball()
        {
            if (UseRefactoredClasses) return new FootballRefactored();
            return new Football();
        }

        public static IProduct GetProduct()
        {
            if (UseRefactoredClasses) return new ProductRefactored();
            return new Product();
        }

        public static IHat GetHat()
        {
            if (UseRefactoredClasses) return new HatRefactored();
            return new Hat();
        }

        public static IOrder GetOrder()
        {
            if (UseRefactoredClasses) return new OrderRefactored();
            return new Order();
        }
    }
}
