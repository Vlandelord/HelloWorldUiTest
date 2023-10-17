using Specs.Test.Drivers;

namespace Specs.Test.Steps;

[Binding]
public class AppSteps
{
    private readonly AppiumDriver _appiumDriver;

    public AppSteps(AppiumDriver appiumDriver)
    {
        _appiumDriver = appiumDriver;
    }

    [Then(@"check app launched")]
    public void ThenTheAppWasStarted()
    {
        var titleElement = _appiumDriver.Driver?.FindElementByAccessibilityId("Welcome");
        titleElement!.Text.Should().Be("Welcome to Xamarin.Forms!");
    }
}