using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Practice
{
    public class Football : Product, IFootball
    {
        public bool CanFitIntoTheBox(decimal boxVolume)
        {
            var productVolume = Width * Height * Depth;
            return productVolume < boxVolume;
        }
    }
}