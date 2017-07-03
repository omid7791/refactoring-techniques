using System.Collections.Generic;
using SRP.FirstExample.MiscClasses;

namespace SRP.FirstExample
{
    public class OrderRepositoryWithSingleResponsibility
    {
        private readonly Storage _store;

        public OrderRepositoryWithSingleResponsibility(Storage store)
        {
            _store = store;
        }

        public List<Order> GetOrdersForCustomer(int customerId)
        {
            return _store.GetOrdersForCustomer(customerId);
        }
    }
}
