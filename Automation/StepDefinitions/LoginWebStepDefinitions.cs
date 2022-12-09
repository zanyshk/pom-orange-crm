using Adactin;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Automation.StepDefinitions
{
    //[Binding]
    public class LoginWebStepDefinitions
    {
        LoginHelper loginHelper = new LoginHelper();
        string userID = string.Empty;
        string password = string.Empty;

        [Given(@"userId is '([^']*)'")]
        public void GivenUserIdIs(string p0)
        {
            loginHelper.Initialization();
            userID = p0;
        }

        [Given(@"password is '([^']*)'")]
        public void GivenPasswordIs(string p0)
        {
            password = p0;
        }

        [When(@"clicks the login button")]
        public void WhenClicksTheLoginButton()
        {
            loginHelper.OpenBrowser("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            loginHelper.LoginClick(userID, password);

        }

        [Then(@"it redirects to search page")]
        public void ThenItRedirectsToSearchPage()
        {
            loginHelper.VerifyDashboard("Dashboard");
            loginHelper.CloseBrowser();


        }

        [Then(@"it shows invalid credentials")]
        public void ItShowsInvalidCredentials()
        {
            loginHelper.VerifyDashboard("Invalid credentials");
            loginHelper.CloseBrowser();
        }

        [Then(@"it shows required username")]
        public void ItShowsRequiredUsername()
        {
            loginHelper.VerifyDashboard("Required");
            loginHelper.CloseBrowser();
        }
    }
}
