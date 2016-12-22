using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Practice
{
    public class Hat : Product, IHat
    {
        private const decimal StandardVolume = 500.5m;

        public bool IsAboveStandardVolume()
        {
            var productVolume = Width * Height * Depth;
            return productVolume > StandardVolume;
        }
    }
}