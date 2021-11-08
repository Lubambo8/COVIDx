using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net;

namespace Utility.Email
{
    /// <summary>
    /// Helper class to resolve credentials
    /// </summary>
    internal static class CredentialProvider
    {
        private static string GetUsername(bool isMicrosoft)
        {
            // a ConfigurationBuilder object is created
            var builder = new ConfigurationBuilder()
                // get the current folder path of the application and
                // set it as the base path
                .SetBasePath(Directory.GetCurrentDirectory())
                // append the JSON file to be used to the base path
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.Development.json", optional: true);

            // configure the IConfiguration interface to use the
            // setting applied in the ConfigurationBuilder
            var config = builder.Build();

            // get the value from the key 'ConnectionStrings:DefaultConnection' found 
            // in the 'appsettings.json' file
            string value;
            if (isMicrosoft)
            {
                value = config["MicrosoftCredentials:Username"];
            }
            else
            {
                value = config["GoogleCredentials:Username"];
            }
            // return the value
            return value;
        }

        private static string GetPassword(bool isMicrosoft)
        {
            // a ConfigurationBuilder object is created
            var builder = new ConfigurationBuilder()
                // get the current folder path of the application and
                // set it as the base path
                .SetBasePath(Directory.GetCurrentDirectory())
                // append the JSON file to be used to the base path
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.Development.json", optional: true);

            // configure the IConfiguration interface to use the
            // setting applied in the ConfigurationBuilder
            var config = builder.Build();

            // get the value from the key 'ConnectionStrings:DefaultConnection' found 
            // in the 'appsettings.json' file
            string value;
            if (isMicrosoft)
            {
                value = config["MicrosoftCredentials:Password"];
            }
            else
            {
                value = config["GoogleCredentials:Password"];
            }

            // return the value
            return value;
        }

        /// <summary>
        /// Returns the default credentials for a Google or Microsoft user
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static NetworkCredential GetCredential(ClientType client)
        {
            switch (client)
            {
                case ClientType.Google:
                    return new NetworkCredential(
                    userName: GetUsername(false),
                    password: GetPassword(false));
                case ClientType.Microsoft:
                    return new NetworkCredential(
                    userName: GetUsername(true),
                    password: GetPassword(true));
                default:
                    throw new System.InvalidOperationException("Invalid email client type");
            }
        }
    }
}
