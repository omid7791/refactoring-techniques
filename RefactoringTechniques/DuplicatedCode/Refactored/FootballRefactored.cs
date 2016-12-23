using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class FootballRefactored : ProductRefactored, IFootball
    {
        public bool CanFitIntoTheBox(decimal boxVolume)
        {
            var productVolume = GetProductVolume();
            return productVolume < boxVolume;
        }
    }
}