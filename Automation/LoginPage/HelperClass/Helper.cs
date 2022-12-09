using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Adactin
{
    public class LoginHelper : BaseClass
    {
        By username = By.Name("username");
        By password = By.XPath("//input[@name=\"password\"]");
        By login = By.XPath("//button[text()=\" Login \"]");
        By dashboard = By.XPath("//h6[text()=\"Dashboard\"]");
        By invalidCredentials = By.XPath("//p[text()=\"Invalid credentials\"]");
        By usernNameRequired = By.XPath("//span[text()=\"Required\"]");
        
        public void LoginClick(string user, string passcode)
        {
            Thread.Sleep(3000);
            driver.FindElement(username).SendKeys(user);
            Thread.Sleep(1000);
            driver.FindElement(password).SendKeys(passcode);
            Thread.Sleep(1000);
            driver.FindElement(login).Click();
        }

        public void VerifyDashboard( string verifier)
        {
            Thread.Sleep(5000);
            string innerText=string.Empty;
            if (string.Equals(verifier, "Dashboard"))
            {
                innerText = driver.FindElement(dashboard).Text;
            }
            else if (string.Equals(verifier, "Required"))
            {
                innerText = driver.FindElement(usernNameRequired).Text;
            }
            else if (string.Equals(verifier, "Invalid credentials"))
            {
                innerText = driver.FindElement(invalidCredentials).Text;
            }
            
            Assert.AreEqual(innerText, verifier);
        }


    }
}
