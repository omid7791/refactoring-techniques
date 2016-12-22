namespace DuplicatedCode.Interfaces
{
    public interface IFootball : IProduct
    {
        bool CanFitIntoTheBox(decimal boxVolume);
    }
}