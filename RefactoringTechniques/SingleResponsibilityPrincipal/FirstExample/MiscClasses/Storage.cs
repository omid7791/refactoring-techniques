using System;
using System.Collections.Generic;

namespace SRP.FirstExample.MiscClasses
{
    public class Storage : IDisposable
    {
        public List<Order> GetOrdersForCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}