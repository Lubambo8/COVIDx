using FluentEmail.Smtp;
using System;
using System.Net.Mail;

namespace Utility.Email
{
    /// <summary>
    /// Email provider using 'Fluent Email'
    /// </summary>
 public class Emailer : IEmailer
    {
        private SmtpClient _client;
        private FluentEmail.Core.IFluentEmail email;

        /// <summary>
        /// Sends an email and returns true if successful
        /// </summary>
        /// <param name="client"></param>
        /// <param name="toEmail"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public bool SendEmail(string toEmail, string subject, string body, ClientType client = ClientType.Microsoft)
        {

            // resolve the SmtpClient
            switch (client)
            {
                case ClientType.Microsoft:
                    _client = new SmtpClient("smtp.live.com", 587);
                    break;
                case ClientType.Google:
                    _client = new SmtpClient("smtp.gmail.com", 587);
                    break;
                default:
                    return false;
            }

            // credentials for authentication
            var credentials = CredentialProvider.GetCredential(client);
            // enable encryption
            _client.EnableSsl = true;
            // out going email handler
            _client.DeliveryMethod = SmtpDeliveryMethod.Network;
            // credentials for authentication
            _client.Credentials = credentials;

            // set default sender
            FluentEmail.Core.Email.DefaultSender = new SmtpSender(_client);

            try
            {
                // configure email
                email = FluentEmail.Core.Email.From(credentials.UserName)
                    .To(toEmail)
                    .Subject(subject)
                    .Body(body);
            }
            catch (Exception) { return false; }

            // send email
            var response = email.Send();

            // true if email was sent
            return response.Successful;
        }
    }
}