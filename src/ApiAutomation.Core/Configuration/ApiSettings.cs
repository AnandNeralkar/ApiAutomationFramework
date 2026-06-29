namespace ApiAutomation.Core.Configuration;

public class ApiSettings
{
    public string BaseUrl { get; set; } = string.Empty;

    public int Timeout { get; set; }

    public int RetryCount { get; set; }
}