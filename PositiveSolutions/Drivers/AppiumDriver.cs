using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveSolutions.Drivers
{
    public class AppiumDriver
    {
        public AppiumDriver<AppiumWebElement> Driver { get; set; }

        public AndroidDriver<AppiumWebElement> InitializeAppium()
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "emulator-5554");

            driverOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "uk.co.pslhx.care");
            driverOptions.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "crc64e522e522f35f6dfe.MainActivity");
            //driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");

            return new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), driverOptions);
        }
    }
}