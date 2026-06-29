using Microsoft.Extensions.Configuration;

namespace ApiAutomation.Core.Configuration;

public static class ConfigurationManager
{
    public static EnvironmentSettings Settings { get; }

    static ConfigurationManager()
    {
        IConfigurationRoot configuration = BuildConfiguration();

        Settings = new EnvironmentSettings();

        configuration.Bind(Settings);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var baseConfiguration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var environment =
            baseConfiguration["Environment"] ?? "QA";

        return new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false)
            .AddJsonFile($"appsettings.{environment.ToLower()}.json", optional: false)
            .Build();
    }
}