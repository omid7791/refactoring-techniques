using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Practice
{
    public class ChristmasOffer : IOffer
    {
        private readonly IOrder _order;

        public ChristmasOffer(IOrder order)
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