using SRP.SecondExample.MiscClasses;

namespace SRP.SecondExample
{
    public class EmailerWithSingleResponsibility
    {
        public void SendAuthenticationEmail(string emailToBeSnt)
        {
            SmtpServer.Send(emailToBeSnt);
        }
    }
}
