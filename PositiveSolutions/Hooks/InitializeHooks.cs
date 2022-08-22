using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using PositiveSolutions.Drivers;

namespace PositiveSolutions.Hooks 
{
    [Binding]
    internal class InitializeHooks
    {
        private readonly ScenarioContext _scenarioContext;

        public InitializeHooks(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [BeforeScenario]
        public void Initialize()
        {
            AppiumDriver appiumDriver = new AppiumDriver();
            _scenarioContext.Set(appiumDriver.InitializeAppium());
        }

    }
}