using SRP.SecondExample.MiscClasses;

namespace SRP.SecondExample
{
    public class EmailSenderWithSingleResponsibility
    {
        public void SendAuthenticationEmail(string emailToBeSnt)
        {
            SmtpServer.Send(emailToBeSnt);
        }
    }
}
