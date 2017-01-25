using System;

namespace LongMethod
{
    public class BasketManager
    {
        private const decimal MaxCubicVolumeForProduct = 156m;

        public void AddToBasket(
            Product product, 
            int quantity, 
            Basket basket, decimal winterRate, decimal summerRate, decimal winterServiceCharge)
        {
            var summerStart = DateTime.Now;
            var summerEnd = DateTime.Now;
            var now = DateTime.Now;
            var basePrice = product.Price * quantity;

            decimal totalPrice;
            decimal charge;

            if (now < summerStart || now > summerEnd) //if winter then charge winter rate
            {
                charge = quantity * winterRate + winterServiceCharge;
                totalPrice = charge + basePrice;
            }
            else //else charge summer rate
            {
                charge = quantity * summerRate;
                totalPrice = charge + basePrice;
            }

            basket.Add(product);
            basket.TotalPrice += totalPrice;
        }

        public bool FitsIntoTheBox(decimal width, decimal height, decimal depth, decimal cubicArea)
        {
            return (width * height * depth) <= cubicArea;
        }

        public bool IsAboveMaxCubicVolume(decimal width, decimal height, decimal depth)
        {
            return (width * height * depth) >MaxCubicVolumeForProduct;
        }
    }
    public class Product
    {
        public decimal Price { get; set; }
    }

    public class Basket
    {
        public decimal TotalPrice { get; set; }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
