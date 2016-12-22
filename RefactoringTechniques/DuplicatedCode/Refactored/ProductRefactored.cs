using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class ProductRefactored : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Width { get; set; }
        public decimal Height{ get; set; }
        public decimal Depth { get; set; }
    }
}