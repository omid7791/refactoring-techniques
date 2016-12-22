using System.Collections.Generic;
using DuplicatedCode.Interfaces;
using DuplicatedCode.Practice;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class OrderTests
    {
        public OrderTests()
        {
            ObjectFactory.UseRefactoredClasses = false;
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

    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ShouldBeAboveStandardVolume()
        {
            var hat = new Hat
            {
                Width = 20,
                Height = 6,
                Depth = 5
            };

            Assert.That(hat.IsAboveStandardVolume, Is.True);
        }

        [Test]
        public void ShouldNotBeAboveStandardVolume()
        {
           var hat = new Hat
            {
                Width = 20,
                Height = 3,
                Depth = 5
            };

            Assert.That(hat.IsAboveStandardVolume, Is.False);
        }

        [Test]
        public void ShouldFitIntoTheBox()
        {
            var hat = new Football
            {
                Width = 20,
                Height = 2,
                Depth = 5
            };

            Assert.That(hat.CanFitIntoTheBox(205), Is.True);
        }

        [Test]
        public void ShouldNotFitIntoTheBox()
        {
            var hat = new Football
            {
                Width = 20,
                Height = 2,
                Depth = 5
            };

            Assert.That(hat.CanFitIntoTheBox(100), Is.False);
        }
    }
}
