using System.Collections.Generic;
using System.Linq;
using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Practice
{
    public class Order : IOrder
    {
        private decimal _unitTotal;
        private const decimal Vat = 0.2m;
        private List<IProduct> _products;
        
        public decimal TotalWithVat
        {
            get { return (_unitTotal - (_unitTotal * Discount)) + ((_unitTotal - (_unitTotal * Discount)) * Vat); }
        }

        public decimal TotalWithoutVat
        {
            get { return (_unitTotal - (_unitTotal * Discount)); }
        }

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