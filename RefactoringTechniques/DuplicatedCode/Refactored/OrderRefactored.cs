using System.Collections.Generic;
using System.Linq;
using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class OrderRefactored : IOrder
    {
        private decimal _unitTotal;
        private const decimal Vat = 0.2m;
        private List<IProduct> _products;
        private decimal GetTotal() => (_unitTotal - (_unitTotal * Discount));

        public decimal TotalWithVat => GetTotal() + (GetTotal() * Vat);
        public decimal TotalWithoutVat => GetTotal();
        public decimal Discount { get; set; }

        public List<IProduct> GetProducts() => _products;

        public void AddProducts(List<IProduct> value)
        {
            _products = value;
            SetUnitTotal();
        }

        private void SetUnitTotal() => _unitTotal = _products.Sum(product => product.Price);
    }
}