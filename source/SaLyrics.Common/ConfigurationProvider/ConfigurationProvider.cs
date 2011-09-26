using System.Configuration;

namespace SaLyrics.Common.ConfigurationProvider {
    public class ConfigurationProvider : IConfigurationProvider {
        public string MongoDbConnectionString {
            get {
                return ConfigurationManager.ConnectionStrings["MongoDb"].ConnectionString
                    ;
            }
        }
    }
}