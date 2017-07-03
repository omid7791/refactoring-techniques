using System;
using SRP.SecondExample.MiscClasses;

namespace SRP.SecondExample
{
    public class EmailController
    {
        private readonly EmailLogger _emailLogger = new EmailLogger();
        private readonly EmailCache _emailCache = new EmailCache();
        private readonly EmailerWithSingleResponsibility _emailer = new EmailerWithSingleResponsibility();
        private readonly EmailService _emailService = new EmailService();

        public void SendAuthenticationEmail(int customerId)
        {
            _emailLogger.LogEmailSending(customerId);

            try
            {
                EmailTemplate emailTemplate;
                if (_emailCache.IsAuthenticationEmailTemplateCached())
                {
                    emailTemplate = _emailService.GetAuthenticationTemplate();
                    _emailCache.CacheEmailTemplate(emailTemplate);
                }
                else
                    emailTemplate = _emailCache.GetCachedEmailTemplate();

                var emailToBeSnt = emailTemplate.Populate(customerId);

                _emailer.SendAuthenticationEmail(emailToBeSnt);

                _emailLogger.LogSuccessfulEmail(customerId);

            }
            catch (Exception)
            {
                _emailLogger.LogUnsuccessfulEmail(customerId);
            }
        }
    }
}
