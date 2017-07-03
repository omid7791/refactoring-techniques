using NLog;

namespace SRP.FirstExample
{
    public class OrderRepositoryLogger
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        
        public void LogSuccessfulOrdersRetreival(int customerId)
        {
            _logger.Info($"Getting orders for customer ID {customerId} was successful.");
        }

        public void LogOrdersRetreivalError()
        {
            _logger.Error("Something happend when trying to get orders from the database.");
        }

        public void LogOrdersRetreival(int customerId)
        {
            _logger.Info($"Getting orders for the Customer ID {customerId}");
        }
    }
}