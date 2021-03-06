﻿using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class ChristmasOfferRefactored : OfferBase, IOffer
    {
        public ChristmasOfferRefactored(IOrder order) : base(order) { }

        protected override decimal GetProductsDiscount(decimal baseOfferDiscount)
        {
            Order.GetProducts().ForEach(product =>
            {
                if (product is IFootball)
                    baseOfferDiscount += 0.005m;
            });
            return baseOfferDiscount;
        }

        protected override decimal GetBaseOfferDiscount()
        {
            return 0.10m;
        }
    }
}