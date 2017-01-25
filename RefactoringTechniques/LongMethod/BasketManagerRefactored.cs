using System;

namespace LongMethod
{
    public class Measurement
    {
        public Measurement(decimal width, decimal height, decimal depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public decimal Width { get; }
        public decimal Height { get; }
        public decimal Depth { get; }

        public decimal GetCubicVolume()
        {
            return Width * Height * Depth;
        }
    }

    public class BasketManagerRefactored
    {
        private const decimal MaxCubicVolumeForProduct = 156m;

        private int _quantity;
        private Product _product;
        private decimal _winterRate;
        private decimal _summerRate;
        private decimal _winterServiceCharge;

        public Basket AddToBasket(Product product, int quantity, Basket basket, decimal winterRate, decimal summerRate, decimal winterServiceCharge)
        {
            //These fields can also be initialisde from the constructor if you want to keep the Manager class tied to a single product
            _winterServiceCharge = winterServiceCharge;
            _summerRate = summerRate;
            _winterRate = winterRate;
            _product = product;
            _quantity = quantity;

            var totalPrice = GetTotalPriceForSeason();

            basket.Add(product);
            basket.TotalPrice += totalPrice;

            return basket;

        }

        private decimal GetTotalPriceForSeason()
        {
            if (NotSummer()) //if winter then charge winter rate
            {
                return GetTotalPrice(WinterCharge());
            }

            return GetTotalPrice(SummerCharge());
        }

        private decimal SummerCharge()
        {
            return _quantity * _summerRate;
        }

        private decimal GetTotalPrice(decimal charge)
        {
            return charge + GetBasePrice();
        }

        private decimal GetBasePrice()
        {
            return _product.Price * _quantity;
        }

        private decimal WinterCharge()
        {
            return _quantity * _winterRate + _winterServiceCharge;
        }

        private static bool NotSummer()
        {
            var summerStart = DateTime.Now;
            var summerEnd = DateTime.Now;
            var now = DateTime.Now;
            return now < summerStart || now > summerEnd;
        }

        public bool FitsIntoTheBox(Measurement measurement, decimal cubicArea)
        {
            return (measurement.GetCubicVolume()) <= cubicArea;
        }

        public bool IsAboveMaxCubicVolume(Measurement measurement)
        {
            return (measurement.GetCubicVolume()) > MaxCubicVolumeForProduct;
        }
    }
}
