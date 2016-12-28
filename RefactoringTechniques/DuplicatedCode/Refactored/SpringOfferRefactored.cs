using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class SpringOfferRefactored : OfferBase, IOffer
    {
        public SpringOfferRefactored(IOrder order) : base(order){ }

        protected override decimal GetProductsDiscount(decimal baseOfferDiscount)
        {
            Order.GetProducts().ForEach(product =>
            {
                if (product is IHat)
                    baseOfferDiscount += 0.001m;
            });
            return baseOfferDiscount;
        }

        protected override decimal GetBaseOfferDiscount()
        {
            return 0.05m;
        }
    }
}
