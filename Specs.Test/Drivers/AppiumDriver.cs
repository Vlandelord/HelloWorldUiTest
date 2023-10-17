using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace Specs.Test.Drivers;

public class AppiumDriver
{
    private readonly TestContext _testRunContext;
    public AndroidDriver<AndroidElement>? Driver { get; private set; }

    public AppiumDriver(TestContext testRunContext)
    {
        _testRunContext = testRunContext;
    }

    public void StartApp()
    {
        var driverOptions = new AppiumOptions();
        driverOptions.AddAdditionalCapability("appium:automationName", "uiautomator2");

        driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "13.0");
        var apkPath = Path.Combine(_testRunContext.TestDirectory, "..\\..\\..\\..\\HelloWorldMobile\\HelloWorldMobile.Android\\bin\\Release\\com.companyname.helloworldmobile.apk");
        driverOptions.AddAdditionalCapability(MobileCapabilityType.App, apkPath);

        Driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/"), driverOptions, TimeSpan.FromSeconds(30));
    }

    public void StopApp()
    {
        Driver.Quit();
    }
}