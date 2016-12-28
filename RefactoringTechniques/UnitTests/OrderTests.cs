using System.Collections.Generic;
using DuplicatedCode.Interfaces;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class OrderTests
    {
        public OrderTests()
        {
            ObjectFactory.UseRefactoredClasses = true;
        }

        [Test]
        public void ShouldCalculateTotalWithoutVat()
        {
            var order = ObjectFactory.GetOrder();

            var product1 = ObjectFactory.GetProduct();
            var product2 = ObjectFactory.GetProduct();

            product1.Price = 50m;
            product2.Price = 50m;
            
            order.AddProducts(new List<IProduct>
            {
                product1,
                product2
            });
             
            Assert.That(order.TotalWithoutVat, Is.EqualTo(100m));
        }

        [Test]
        public void ShouldCalculateTotalWithVat()
        {
            var order = ObjectFactory.GetOrder();

            var product1 = ObjectFactory.GetProduct();
            var product2 = ObjectFactory.GetProduct();

            product1.Price = 50m;
            product2.Price = 50m;

            order.AddProducts(new List<IProduct>
            {
                product1,
                product2
            });

            Assert.That(order.TotalWithVat, Is.EqualTo(120m));
        }
    }
}
