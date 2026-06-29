namespace ApiAutomation.Core.Configuration;

public class EnvironmentSettings
{
    public string Environment { get; set; } = "QA";

    public ApiSettings ApiSettings { get; set; } = new();

    public ReportingSettings Reporting { get; set; } = new();

    public LoggingSettings Logging { get; set; } = new();
}