namespace SaLyrics.Common.ConfigurationProvider {
    public interface IConfigurationProvider {
        string MongoDbConnectionString   { get; }
    }
}