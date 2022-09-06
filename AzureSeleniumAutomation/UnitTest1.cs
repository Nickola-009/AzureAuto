using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AzureSeleniumAutomation
{
    [TestFixture]
    public class UnitTest1
    {
       
        [OneTimeSetUp]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();   
            Global.chrome_Driver = driver;
            Global.chrome_Driver.Manage().Window.Maximize();
          
        }

        [Test]
        public void GoogleSearch()
        {
            Global.chrome_Driver.Url = "https://www.google.com";
            Global.chrome_Driver.FindElement(By.XPath("//input[@name='q']")).SendKeys("Selenium" + Keys.Enter);
        }
        [Test]
        public void MyntraSearch()
        {
            Global.chrome_Driver.Url = "https://www.myntra.com";
            Thread.Sleep(Global.timespan);
            Global.chrome_Driver.FindElement(By.XPath("//input[@placeholder='Search for products, brands and more']")).SendKeys("Hats" + Keys.Enter);

        }
        [Test]
        public void YahooSearch()
        {
            Global.chrome_Driver.Url = "https://www.yahoo.com";
            Global.chrome_Driver.FindElement(By.XPath("//input[@name='p']")).SendKeys("Wikipedia" + Keys.Enter);
        }
    }
}
