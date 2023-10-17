using Specs.Test.Drivers;

namespace Specs.Test.Hooks;

[Binding]
public class AppiumHooks
{
    private readonly AppiumDriver _appiumDriver;

    public AppiumHooks(AppiumDriver appiumDriver)
    {
        _appiumDriver = appiumDriver;
    }

    [BeforeScenario]
    public void StartAndroidApp()
    {
        _appiumDriver.StartApp();
    }

    [AfterScenario]
    public void ShutdownAndroidApp()
    {
        _appiumDriver.StopApp();
    }
}