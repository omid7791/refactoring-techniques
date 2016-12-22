using System.Collections.Generic;

namespace DuplicatedCode.Interfaces
{
    public interface IOrder
    {
        decimal Discount { get; set; }
        decimal TotalWithoutVat { get; }
        decimal TotalWithVat { get; }

        void AddProducts(List<IProduct> value);
        List<IProduct> GetProducts();
    }
}