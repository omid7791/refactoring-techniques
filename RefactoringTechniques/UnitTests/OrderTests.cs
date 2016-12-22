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
        public ProductTests()
        {
            ObjectFactory.UseRefactoredClasses = true;
        }

        [Test]
        public void ShouldBeAboveStandardVolume()
        {
            var hat = ObjectFactory.GetHat();

            hat.Width = 20;
            hat.Height = 6;
            hat.Depth = 5;
           
            Assert.That(hat.IsAboveStandardVolume, Is.True);
        }

        [Test]
        public void ShouldNotBeAboveStandardVolume()
        {
            var hat = ObjectFactory.GetHat();

            hat.Width = 20;
            hat.Height = 3;
            hat.Depth = 5;
            
            Assert.That(hat.IsAboveStandardVolume, Is.False);
        }

        [Test]
        public void ShouldFitIntoTheBox()
        {
            var football = ObjectFactory.GetFootball();

            football.Width = 20;
            football.Height = 2;
            football.Depth = 5;
            
            Assert.That(football.CanFitIntoTheBox(205), Is.True);
        }

        [Test]
        public void ShouldNotFitIntoTheBox()
        {
            var football = ObjectFactory.GetFootball();

            football.Width = 20;
            football.Height = 2;
            football.Depth = 5;
        
            Assert.That(football.CanFitIntoTheBox(100), Is.False);
        }
    }
}
