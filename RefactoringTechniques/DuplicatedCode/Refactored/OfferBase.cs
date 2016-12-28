using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public abstract class OfferBase
    {
        protected readonly IOrder Order;
        protected abstract decimal GetProductsDiscount(decimal baseOfferDiscount);
        protected abstract decimal GetBaseOfferDiscount();

        protected OfferBase(IOrder order)
        {
            Order = order;
        }

        public void Apply()
        {
            var baseOfferDiscount = GetBaseOfferDiscount();

            baseOfferDiscount = GetProductsDiscount(baseOfferDiscount);

            Order.Discount += baseOfferDiscount;
        }
    }
}