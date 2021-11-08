namespace Utility.Email
{
    public interface IEmailer
    {
        bool SendEmail(string toEmail, string subject, string body, ClientType client = ClientType.Microsoft);
    }
}