using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Adactin
{
    public class BaseClass
    {
        
        public static IWebDriver driver;
        public void Initialization()
        {
           // ChromeOptions options = new ChromeOptions();
            //options.AddArguments("--start-maximized");
            //options.AddArguments("-incognito");
            //options.AddArguments("headless");

            driver = new ChromeDriver();
        }

        public void Dispose()
        {
            driver = new ChromeDriver();
            driver.Dispose();
        }

        public void OpenBrowser(string url)
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser() 
        {
            driver.Close();
        }


    }
}
