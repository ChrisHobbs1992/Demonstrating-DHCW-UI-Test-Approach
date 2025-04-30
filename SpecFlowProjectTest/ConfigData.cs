using Microsoft.Extensions.Configuration;

namespace NhsWales.Ui.Integration.Tests
{
    public static class ConfigData
    {
        public static ConfigDataModel Get()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            var config = builder.Build();

            return config.Get<ConfigDataModel>()!;
        }
    }
    public class ConfigDataModel
    {
        public required string Browser { get; init; }
        public required string BaseUrl { get; init; }
        public required bool Headless { get; init; }
        public required User User { get; init; }
    }

    public class User
    {
        public required string Email { get; init; }
        public required string Password { get; init; }
    }
}