using NUnit.Framework;
using ApiAutomation.Core.Configuration;

namespace APIAutomation.Tests;

public class ConfigurationTests
{
    [Test]
    public void Should_Load_QA_Configuration()
    {
        Assert.That(
            ConfigurationManager.Settings.ApiSettings.BaseUrl,
            Is.EqualTo("https://reqres.in/api"));

        Assert.That(
            ConfigurationManager.Settings.ApiSettings.Timeout,
            Is.EqualTo(30));

        Assert.That(
            ConfigurationManager.Settings.ApiSettings.RetryCount,
            Is.EqualTo(3));
    }
}