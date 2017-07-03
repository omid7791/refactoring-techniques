using System;

namespace SRP.SecondExample
{
    public class EmailLogger
    {
        public void LogUnsuccessfulEmail(int customerId)
        {
            Console.WriteLine($"Authentication email sent unsuccessfully for the customer with customer ID of {customerId}");
        }

        public void LogSuccessfulEmail(int customerId)
        {
            Console.WriteLine($"Authentication email sent for the customer with customer ID of {customerId}");
        }

        public void LogEmailSending(int customerId)
        {
            Console.WriteLine($"Sending email authentication email for the customer with customer ID of {customerId}");
        }
    }
}