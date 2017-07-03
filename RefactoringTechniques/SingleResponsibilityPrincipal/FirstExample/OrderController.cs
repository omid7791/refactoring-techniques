using System;
using System.Collections.Generic;
using SRP.FirstExample.MiscClasses;

namespace SRP.FirstExample
{
    public class OrderController
    {
        private readonly OrderRepositoryWithSingleResponsibility _orderRepository;
        private readonly OrderRepositoryLogger _orderRepositoryLogger;
        private readonly OrderRepositoryCache _orderRepositoryCache;

        public OrderController(OrderRepositoryWithSingleResponsibility orderRepository)
        {
            _orderRepository = orderRepository;
            _orderRepositoryLogger = new OrderRepositoryLogger();
            _orderRepositoryCache = new OrderRepositoryCache();
        }

        public List<Order> GetOrdersForCustomer(int customerId)
        {
            _orderRepositoryLogger.LogOrdersRetreival(customerId);

            var orders = new List<Order>();

            try
            {
                if (_orderRepositoryCache.IsCustomerOrdersCached(customerId))
                {
                    orders = _orderRepository.GetOrdersForCustomer(customerId);
                    _orderRepositoryCache.CacheCustomerOrders(orders);
                }
                else
                    orders = _orderRepositoryCache.GetCachedCustomerOrders(customerId);
            }
            catch (Exception)
            {
                _orderRepositoryLogger.LogOrdersRetreivalError();
            }

            _orderRepositoryLogger.LogSuccessfulOrdersRetreival(customerId);
            return orders;
        }
    }
}
