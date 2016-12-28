using System.Collections.Generic;
using DuplicatedCode.Interfaces;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class OfferTests
    {
        public OfferTests()
        {
            ObjectFactory.UseRefactoredClasses = true;
        }

        [Test]
        public void ShouldApplyCorrectDiscountWithTwoHatsForSpringOffer()
        {
            var order = ObjectFactory.GetOrder();

            var product1 = ObjectFactory.GetHat();
            var product2 = ObjectFactory.GetHat();
            
            order.AddProducts(new List<IProduct>
            {
                product1,
                product2
            });

            var discountBefore = order.Discount;

            var springOffer = ObjectFactory.GetSpringOffer(order);
            springOffer.Apply();

            Assert.That(order.Discount, Is.EqualTo(0.052m));
            Assert.That(discountBefore, Is.EqualTo(0));
        }

        [Test]
        public void ShouldApplyCorrectDiscountWithOneHatForSpringOffer()
        {
            var order = ObjectFactory.GetOrder();

            var product1 = ObjectFactory.GetHat();
            
            order.AddProducts(new List<IProduct>
            {
                product1
            });

            var discountBefore = order.Discount;

            var springOffer = ObjectFactory.GetSpringOffer(order);
            springOffer.Apply();

            Assert.That(order.Discount, Is.EqualTo(0.051m));
            Assert.That(discountBefore, Is.EqualTo(0));
        }

        [Test]
        public void ShouldApplyCorrectDiscountWithOneFootballForChristmasOffer()
        {
            var order = ObjectFactory.GetOrder();

            var product1 = ObjectFactory.GetFootball();
            var product2 = ObjectFactory.GetHat();
            
            order.AddProducts(new List<IProduct>
            {
                product1,
                product2
            });

            var discountBefore = order.Discount;

            var christmasOffer = ObjectFactory.GetChristmasOffer(order);
            christmasOffer.Apply();

            Assert.That(order.Discount, Is.EqualTo(0.105m));
            Assert.That(discountBefore, Is.EqualTo(0));
        }

        [Test]
        public void ShouldApplyCorrectDiscountWithTwoFootballsForChristmasOffer()
        {
            var order = ObjectFactory.GetOrder();

            var product1 = ObjectFactory.GetFootball();
            var product2 = ObjectFactory.GetFootball();
            
            order.AddProducts(new List<IProduct>
            {
                product1,
                product2
            });

            var discountBefore = order.Discount;

            var christmasOffer = ObjectFactory.GetChristmasOffer(order);
            christmasOffer.Apply();

            Assert.That(order.Discount, Is.EqualTo(0.11m));
            Assert.That(discountBefore, Is.EqualTo(0));
        }
    }
}