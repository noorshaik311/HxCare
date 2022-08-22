using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AppiumProject.HomePageSpace
{
    internal class HomePage
    {
        private ScenarioContext _scenarioContext;
        public AndroidDriver<AppiumWebElement> AppDriver;       

        private AppiumWebElement _profilebtn => AppDriver.FindElementByXPath("//android.widget.FrameLayout[@content-desc='Profile']");

        private AppiumWebElement _logoutbtn1 => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_Logout']");

        private AppiumWebElement _cancel => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_close']");

        private AppiumWebElement _logoutbtn2 => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_Logout']");

        private AppiumWebElement _logoutbtn3 => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_Logout']");

        private AppiumWebElement _serviceuserbtn => AppDriver.FindElementByXPath("//android.widget.FrameLayout[@content-desc='Service User']/android.widget.ImageView");

        private AppiumWebElement _viewserviceuserbtn => AppDriver.FindElementByXPath("(//android.widget.TextView[@content-desc='lbl_ViewSU'])[1]");

        private AppiumWebElement _viewprnbtn => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_ViewPRN']");

        private AppiumWebElement _adminbtn => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_Admin']");

        private AppiumWebElement _administereddosage => AppDriver.FindElementByAccessibilityId("txt_AdminDosage");

        private AppiumWebElement _cancelbtn1 => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_close']");

        private AppiumWebElement _nonadminbtn => AppDriver.FindElementByXPath("//android.widget.Button[@content-desc='btn_NonAdmin']");

        private AppiumWebElement _sleepingbtn => AppDriver.FindElementByAccessibilityId("lbl_Dosage");

        private AppiumWebElement _canceloption => AppDriver.FindElementByAccessibilityId("img_Close");

        public HomePage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            AppDriver = _scenarioContext.Get<AndroidDriver<AppiumWebElement>>();
        }


        public void Serviceuserbt()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_serviceuserbtn));
            _serviceuserbtn.Click();
        }
        public void Viewserviceuserbt()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_viewserviceuserbtn));
            _viewserviceuserbtn.Click();
        }

        public void Viewprnbt()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_viewprnbtn));
            _viewprnbtn.Click();
        }
        public void Adminbt()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_adminbtn));
            _adminbtn.Click();
        }

        public void Administereddosage()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_administereddosage));
            _administereddosage.Click();
            _administereddosage.SendKeys("2");
        }

        public void Cancelbt1()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_cancelbtn1));
            _cancelbtn1.Click();
        }

        public void Nonadminbt()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_nonadminbtn));
            _nonadminbtn.Click();
        }

        public void Sleepingbt()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_sleepingbtn));
            _sleepingbtn.Click();
        }    

        public void CancelOption()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_canceloption));
            _canceloption.Click();
        }
        
        public void Profilebt()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_profilebtn));
            _profilebtn.Click();
        }
            
        public void Logoutbt1()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_logoutbtn1));
            _logoutbtn1.Click();
        }    

        public void Cancel()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_cancel));
            _cancel.Click();
        }
            
        public void Logoutbt2()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_logoutbtn2));
            _logoutbtn2.Click();
        }

        public void Logoutbt3()
        {
            WebDriverWait wait = new WebDriverWait(AppDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(_logoutbtn3));
            _logoutbtn3.Click();
        }


            
        
        
      
    }
}