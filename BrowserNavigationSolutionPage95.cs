using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace BrowserNavigationSolutionPage95
{
    class Program
    {
        static void Main(string[] args)
        {      
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            IWebDriver driver = new ChromeDriver(@"C:\QaLearning", options);
            driver.Navigate().GoToUrl("https://itechcraft.com/");
            driver.Navigate().GoToUrl("https://itechcraft.com/about-it-craft/");
            driver.Navigate().Back();
            driver.Close();
        }
    }
}
