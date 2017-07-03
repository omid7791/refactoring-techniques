using System;
using SRP.SecondExample.MiscClasses;

namespace SRP.SecondExample
{
    public class EmailSender
    {
        public void SendAuthenticationEmail(int customerId)
        {
            Console.WriteLine($"Sending email authentication email for the customer with customer ID of {customerId}");

            try
            {
                var emailService = new EmailService();

                EmailTemplate emailTemplate;
                if (Cache.Get("AuthenticationTemplate") == null)
                {
                    emailTemplate = emailService.GetAuthenticationTemplate();
                    Cache.Add("AuthenticationTemplate", emailTemplate);
                }
                else
                    emailTemplate = (EmailTemplate)Cache.Get("AuthenticationTemplate");

                var emailToBeSnt = emailTemplate.Populate(customerId);

                SmtpServer.Send(emailToBeSnt);

                Console.WriteLine($"Authentication email sent for the customer with customer ID of {customerId}");

            }
            catch (Exception)
            {
                Console.WriteLine($"Authentication email sent unsuccessfully for the customer with customer ID of {customerId}");
            }
        }
    }
}
