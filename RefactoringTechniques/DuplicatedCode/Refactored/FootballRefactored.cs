using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class FootballRefactored : ProductRefactored, IFootball
    {
        public bool CanFitIntoTheBox(decimal boxVolume)
        {
            var productVolume = Width * Height * Depth;
            return productVolume < boxVolume;
        }
    }
}