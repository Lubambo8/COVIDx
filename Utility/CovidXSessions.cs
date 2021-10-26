using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Utility
{
    public static class CovidXSessions
    {
        /// <summary>
        /// Save data to the session to access it from different requests
        /// </summary>
        /// <typeparam name="TData">The value that will be saved</typeparam>
        /// <param name="session">Extending the session methods</param>
        /// <param name="key">The identifier to find the session data</param>
        /// <param name="value">The data to store</param>
        public static void Set<TData>(this ISession session, string key, TData value)
        {
            // convert the value received into a byte array [ 10001010111 ]
            byte[] data = JsonSerializer.SerializeToUtf8Bytes(value);

            // save the data to the session
            session.Set(key, data);
        }

        /// <summary>
        /// Load data from the session
        /// </summary>
        /// <typeparam name="TResult">The value that will be retrieved</typeparam>
        /// <param name="session">Extending the session methods</param>
        /// <param name="key">The identifier to find the session data</param>
        /// <returns></returns>
        public static TResult Get<TResult>(this ISession session, string key) where TResult : class, new()
        {
            // instantiate the object
            var output = new TResult();

            // get object data using key
            byte[] data;

            var success = session.TryGetValue(key, out data);

            if (success)
            {
                // convert the byte array data to the object type requested
                output = JsonSerializer.Deserialize<TResult>(data);
            }

            // return object
            return output;
        }

        /// <summary>
        /// Load data from the session and remove it from memory
        /// </summary>
        /// <typeparam name="TResult">The value that will be retrieved</typeparam>
        /// <param name="session">Extending the session methods</param>
        /// <param name="key">The identifier to find the session data</param>
        /// <returns></returns>
        public static TResult GetAndRemove<TResult>(this ISession session, string key) where TResult : class, new()
        {
            // instantiate the object
            var output = new TResult();

            // get object data using key
            byte[] data;

            var success = session.TryGetValue(key, out data);

            if (success)
            {
                // convert the byte array data to the object type requested
                output = JsonSerializer.Deserialize<TResult>(data);
                // remove data from session
                session.Remove(key);
            }

            // return object
            return output;
        }
    }
}
