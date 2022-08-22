using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AppiumProject.LoginPageSpace
{
    public class LoginPage
    {
        private ScenarioContext _scenarioContext;
        public AndroidDriver<AppiumWebElement> AppDriver;



        private AppiumWebElement _usernameField => AppDriver.FindElementByXPath("//android.widget.EditText[@content-desc='txt_UserName']");
        
        private AppiumWebElement _passwordField => AppDriver.FindElementByXPath("//android.widget.EditText[@content-desc='lbl_Password']");
        
        private AppiumWebElement _loginClick => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_login']");

        private AppiumWebElement _startround => AppDriver.FindElementByXPath("(//android.widget.TextView[@content-desc='lbl_Action'])[1]");

        private AppiumWebElement _viewmedication => AppDriver.FindElementByXPath("//android.widget.TextView[@content-desc='lbl_ViewMedication']");

        private AppiumWebElement _admin => AppDriver.FindElementByXPath("(//android.widget.Button[@content-desc='btn_Admin'])[2]");

        private AppiumWebElement _increment => AppDriver.FindElementByAccessibilityId("img_inc_white");

        private AppiumWebElement _crosssign => AppDriver.FindElementByAccessibilityId("img_Close");

        private AppiumWebElement _nonadmin => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_NonAdmin']");

        private AppiumWebElement _vomiting => AppDriver.FindElementByAccessibilityId("lbl_Dosage");


        public LoginPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            AppDriver = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>();
        }



        public void LoginToApp()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_usernameField));
            _usernameField.Click();
            _usernameField.SendKeys("dhamini.s@positive-solutions.co.uk");
            wait.Until(ExpectedConditions.ElementToBeClickable(_passwordField));
            _passwordField.Click();
            _passwordField.SendKeys("Test1234!");
            wait.Until(ExpectedConditions.ElementToBeClickable(_loginClick));
            _loginClick.Click();


        }
        public void Rounds()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_startround));
            _startround.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_viewmedication));
            _viewmedication.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_admin));
            _admin.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_increment));
            _increment.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_crosssign));
            _crosssign.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_nonadmin));
            _nonadmin.Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(_vomiting));
            _vomiting.Click();
        }
        







    }
}