using NUnit.Framework;

namespace UnitTests
{
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