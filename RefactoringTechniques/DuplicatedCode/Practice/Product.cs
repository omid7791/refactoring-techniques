using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Practice
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Width { get; set; }
        public decimal Height{ get; set; }
        public decimal Depth { get; set; }
    }
}