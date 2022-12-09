using Adactin;
using System;
using TechTalk.SpecFlow;

namespace ASTProject.StepDefinitions
{
    [Binding]
    public class LogoutStepDefinitions
    {
        LoginHelper loginHelper = new LoginHelper();
        LogoutHelper logoutHelper = new LogoutHelper();

        [Given(@"On User's Dashboard Screen")]
        public void GivenOnUsersDashboardScreen()
        {
            loginHelper.Initialization();
            loginHelper.OpenBrowser("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            loginHelper.LoginClick("Admin", "admin123");

        }

        [When(@"User click logout button")]
        public void WhenUserClickLogoutButton()
        {
            logoutHelper.LogoutClick();
        }

        [Then(@"It redirects to login page")]
        public void ThenItRedirectsToLoginPage()
        {
            logoutHelper.VerifyLogout("Login");
        }
    }
}
