using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace web_scraping_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Navigate().GoToUrl("https://nashville.craigslist.org/");
            driver.FindElement(By.ClassName("aos")).Click();
            driver.FindElement(By.ClassName("srchType")).Click();

        }
    }
}
