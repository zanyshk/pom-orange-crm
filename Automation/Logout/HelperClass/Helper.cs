using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace Adactin
{
    public class LogoutHelper : BaseClass
    {

        By LoginPage = By.XPath("//h5");
        By ProfileButton = By.XPath("//li[@class=\"oxd-userdropdown\"]");
        By LogoutButton = By.XPath("//a[text()=\"Logout\"]");


        public void VerifyLogout( string verifier)
        {
            Thread.Sleep(5000);
            string innerText=string.Empty;
            innerText = driver.FindElement(LoginPage).Text;
            Assert.AreEqual(innerText, verifier);
        }

        public void LogoutClick() 
        {
            Thread.Sleep(5000);
            driver.FindElement(ProfileButton).Click();
            Thread.Sleep(2000);
            driver.FindElement(LogoutButton).Click();
        }


    }
}
