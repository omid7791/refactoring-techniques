using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Refactored
{
    public class ChristmasOfferRefactored : IOffer
    {
        private readonly IOrder _order;

        public ChristmasOfferRefactored(IOrder order)
        {
            _order = order;
        }

        public void Apply()
        {
            var baseOfferDiscount = 0.10m;

            _order.GetProducts().ForEach(product =>
            {
                if (product is IFootball)
                    baseOfferDiscount += 0.005m;
            });

            _order.Discount += baseOfferDiscount;
        }
    }
}