using BasicApi.Controllers;
using FakeItEasy;
using Microsoft.Extensions.Logging;

namespace BasicApi.Tests;

public class WeatherForecastControllerTests
{
    [Test]
    public void get_forecast_for_5_days()
    {
        var controller = new WeatherForecastController(A.Fake<ILogger<WeatherForecastController>>());

        var result = controller.Get();

        Assert.That(result, Is.Not.Null);
        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count(), Is.EqualTo(5));
    }
}