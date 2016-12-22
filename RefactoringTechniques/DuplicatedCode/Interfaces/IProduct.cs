namespace DuplicatedCode.Interfaces
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
        decimal Width { get; set; }
        decimal Height { get; set; }
        decimal Depth { get; set; }
    }
}