using SRP.SecondExample.MiscClasses;

namespace SRP.SecondExample
{
    public class EmailCache
    {
        public EmailTemplate GetCachedEmailTemplate()
        {
            return (EmailTemplate)Cache.Get("AuthenticationTemplate");
        }

        public void CacheEmailTemplate(EmailTemplate emailTemplate)
        {
            Cache.Add("AuthenticationTemplate", emailTemplate);
        }

        public bool IsAuthenticationEmailTemplateCached()
        {
            return Cache.Get("AuthenticationTemplate") == null;
        }
    }
}