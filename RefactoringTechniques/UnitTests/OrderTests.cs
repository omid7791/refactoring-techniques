using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void ShouldCalculateTotalExcludingVat()
        {
            var order = new Order();
            const decimal discount = 0.5m;

            order.SetProducts(new List<Product>
            {
                new Product { Price = 15},
                new Product { Price = 15}
            });
            order.Discount = discount;


            Assert.That(order.Total, Is.EqualTo(15m));
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public class Order
    {
        private decimal _total = 0;
        private List<Product> products;

        public List<Product> GetProducts()
        {
            return products;
        }

        public void SetProducts(List<Product> value)
        {
            products = value;
        }

        public decimal Total
        {
            get { return _total * Discount; }
        }

        public decimal Discount { get; set; }
    }
}
