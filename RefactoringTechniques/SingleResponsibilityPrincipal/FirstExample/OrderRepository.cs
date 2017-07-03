using System;
using System.Collections.Generic;
using NLog;
using SRP.FirstExample.MiscClasses;

namespace SRP.FirstExample
{
    public class OrderRepository
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly Cache _cache = new Cache();

        public List<Order> GetOrdersForCustomer(int customerId)
        {
            _logger.Info($"Getting orders for the Customer ID {customerId}");
            
            var orders = new List<Order>();

            try
            {
                if (_cache.Get("GetOrdersForCustomer") == null)
                {
                    orders = new Storage().GetOrdersForCustomer(customerId);
                    _cache.Add("GetOrdersForCustomer", orders);
                }
                else
                    orders = _cache.Get("GetOrdersForCustomer");
            }
            catch (Exception)
            {
                _logger.Error("Something happend when trying to get orders from the database.");
            }

            _logger.Info($"Getting orders for customer ID {customerId} was successful.");
            return orders;
        } 
    }
}
