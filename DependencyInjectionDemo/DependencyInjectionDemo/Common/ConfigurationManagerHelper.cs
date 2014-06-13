using System.Configuration;

namespace DependencyInjectionDemo.Common
{
    /// <summary>
    /// Helper class to pull configuration settings and connection strings;
    /// </summary>
    public static class ConfigurationManagerHelper
    {
        /// <summary>
        /// Gets Connection string by key
        /// </summary>
        /// <param name="key">lookup key for connection string</param>
        /// <returns>connection string</returns>
        public static string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        /// <summary>
        /// Gets Setting string by key
        /// </summary>
        /// <param name="key">lookup key for application setting</param>
        /// <returns>setting as string</returns>
        public static string GetSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
