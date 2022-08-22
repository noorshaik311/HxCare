using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using AppiumProject.LoginPageSpace;
using AppiumProject.HomePageSpace;



namespace AppiumProject.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private AndroidDriver<AppiumWebElement> AppDriver;
        private LoginPage LoginObject;
        private HomePage HomeObject;



        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            LoginObject = new LoginPage(scenarioContext);
            HomeObject = new HomePage(scenarioContext);
        }




        [Given(@"Login to the application")]
        public void GivenLoginToTheApplication()
        {
            LoginObject.LoginToApp();
        }

        [Then(@"click on start round")]
        public void ThenClickOnStartRound()
        {
            Thread.Sleep(10000);
            LoginObject.Rounds();
        }

        [Then(@"click on view medication")]
        public void ThenClickOnViewMedication()
        {
            Thread.Sleep(10000);
            LoginObject.Rounds();
        }

        [Then(@"click on admin")]
        public void ThenClickOnAdmin()
        {
            Thread.Sleep(10000);
            LoginObject.Rounds();
        }

        [Then(@"click on dosage increment")]
        public void ThenClickOnDosageIncrement()
        {
            Thread.Sleep(10000);
            LoginObject.Rounds();
        }

        [Then(@"click on cross sign")]
        public void ThenClickOnCrossSign()
        {
            Thread.Sleep(10000);
            LoginObject.Rounds();
        }

        [Then(@"click on non admin")]
        public void ThenClickOnNonAdmin()
        {
            Thread.Sleep(10000);
            LoginObject.Rounds();
        }

        [Then(@"click on vomiting")]
        public void ThenClickOnVomiting()
        {
            Thread.Sleep(10000);
            LoginObject.Rounds();
        }


        [Then(@"Click on Service User")]
        public void ThenClickOnServiceUser()
        {
            Thread.Sleep(10000);
            HomeObject.Serviceuserbt();
        }

        [Then(@"click on CTA view service user")]
        public void ThenClickOnCTAViewServiceUser()
        {
            Thread.Sleep(10000);
            HomeObject.Viewserviceuserbt();
        }
        [Then(@"click on view PRN button")]
        public void ThenClickOnViewPRNButton()
        {
            Thread.Sleep(10000);
            HomeObject.Viewprnbt();
        }
        [Then(@"click on admin button")]
        public void ThenClickOnAdminButton()
        {
            Thread.Sleep(10000);
            HomeObject.Adminbt();
        }
        [Then(@"click on administered dosage")]
        public void ThenClickOnAdministeredDosage()
        {
            Thread.Sleep(10000);
            HomeObject.Administereddosage();
        }
        [Then(@"enter dosage number")]
        public void ThenEnterDosageNumber()
        {
            Thread.Sleep(10000);
            HomeObject.Administereddosage();
        }


        [Then(@"click on cancel button")]
        public void ThenClickOnCancelButton()
        {
            Thread.Sleep(10000);
            HomeObject.Cancelbt1();
        }
        [Then(@"click on non admin button")]
        public void ThenClickOnNonAdminButton()
        {
            Thread.Sleep(10000);
            HomeObject.Nonadminbt();
        }
        [Then(@"click on sleeping button")]
        public void ThenClickOnSleepingButton()
        {
            Thread.Sleep(10000);
            HomeObject.Sleepingbt();
        }
        [Then(@"click on cancel option")]
        public void ThenClickOnCancelOption()
        {
            Thread.Sleep(10000);
            HomeObject.CancelOption();
        }

        [Then(@"click on profile")]
        public void ThenClickOnProfile()
        {
            Thread.Sleep(10000);
            HomeObject.Profilebt();
        }
        [Then(@"click on logout button")]
        public void ThenClickOnLogoutButton()
        {
            Thread.Sleep(10000);
            HomeObject.Logoutbt1();
        }
        
        [Then(@"click on cancel")]
        public void ThenClickOnCancel()
        {
            Thread.Sleep(10000);
            HomeObject.Cancel();
        }
        [Then(@"click on logout button again")]
        public void ThenClickOnLogoutButtonAgain()
        {
            Thread.Sleep(10000);
            HomeObject.Logoutbt2();
        }

        [Then(@"click on logout")]
        public void ThenClickOnLogout()
        {
            Thread.Sleep(10000);
            HomeObject.Logoutbt3();
            Console.Write("Test Passed!");
        }




    }
}