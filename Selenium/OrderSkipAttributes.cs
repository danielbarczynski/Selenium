using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    [TestFixture]
    public class OrderSkipAttributes
    {
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.margonem.pl/";
            IWebElement input = webDriver.FindElement(By.Name("login"));
            input.SendKeys("Hello");
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void Test2()
        {
            Assert.Ignore();
            IWebDriver webDriver = new FirefoxDriver();
            webDriver.Url = "https://www.margonem.pl/";
            IWebElement input = webDriver.FindElement(By.Name("login"));
            input.SendKeys("Hello");
        }

        [Test, Order(2), Category("OrderSkipAttribute")]
        public void Test3()
        {
            Assert.Ignore();
            IWebDriver webDriver = new InternetExplorerDriver();
            webDriver.Url = "https://www.margonem.pl/";
            IWebElement input = webDriver.FindElement(By.Name("login"));
            input.SendKeys("Hello");
        }

    }
}
