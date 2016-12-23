using DuplicatedCode.Interfaces;

namespace DuplicatedCode.Practice
{
    public class SpringOffer : IOffer
    {
        private readonly IOrder _order;

        public SpringOffer(IOrder order)
        {
            _order = order;
        }

        public void Apply()
        {
            var baseOfferDiscount = 0.05m;

            _order.GetProducts().ForEach(product =>
            {
                if (product is IHat)
                    baseOfferDiscount += 0.001m;
            });

            _order.Discount += baseOfferDiscount;
        }
    }
}