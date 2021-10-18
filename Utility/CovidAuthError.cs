using System;

namespace Utility
{
    public class CovidAuthError
    {
        public const string EMAILUSED = "This email is already in use. Please try to login or use a different email.";

        /// <summary>
        /// Registration of user failed
        /// </summary>
        public const string REGISTRATION_FAIL = "Invalid Registration Attempt. Please try again or login if you already have an account.";

        /// <summary>
        /// Authentication of user failed
        /// </summary>
        public const string LOGIN_FAIL = "Invalid Login Attempt. Please try again or create an account.";
    }
}
