using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class HatRefactored : ProductRefactored, IHat
    {
        private const decimal StandardVolume = 500.5m;

        public bool IsAboveStandardVolume()
        {
            var productVolume = GetProductVolume();
            return productVolume > StandardVolume;
        }
    }
}