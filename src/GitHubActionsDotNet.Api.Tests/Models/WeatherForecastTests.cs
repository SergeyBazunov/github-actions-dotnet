namespace GitHubActionsDotNet.Api.Tests;
using FluentAssertions;
using GitHubActionsDotNet.Api.Models;

public class WeatherForecastTests
{
    [Fact]
    public void TemperatureFShouldReturnCorrectValueBasedOnTemperatureC()
    {
        var weatherForecast = new WeatherForecast
        {
            TemperatureC = 0
        };

<<<<<<< HEAD
        weatherForecast.TemperatureF.Should().Be(32);
        weatherForecast.TemperatureF.Should().Be(32);
=======
        weatherForecast.TemperatureF.Should().Be(31);
>>>>>>> 10806d7 (test fails)
    }
}
