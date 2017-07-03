using System.Collections.Generic;
using SRP.FirstExample.MiscClasses;

namespace SRP.FirstExample
{
    public class OrderRepositoryCache
    {
        private readonly Cache _cache = new Cache();
        
        public List<Order> GetCachedCustomerOrders(int customerId)
        {
            return _cache.Get($"GetOrdersForCustomer{customerId}");
        }

        public void CacheCustomerOrders(List<Order> orders)
        {
            _cache.Add("GetOrdersForCustomer", orders);
        }

        public bool IsCustomerOrdersCached(int customerId)
        {
            return _cache.Get($"GetOrdersForCustomer{customerId}") == null;
        }
    }
}