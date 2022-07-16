using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.BaseClass;
using Selenium.Utilities;

namespace Selenium
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test1()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement input = Driver.FindElement(By.Name("login"));
            input.SendKeys("Hello");
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test2()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement input = Driver.FindElement(By.Name("login"));
            input.SendKeys("Hello");
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test3()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement input = Driver.FindElement(By.Name("login"));
            input.SendKeys("Hello");
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void Test4()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement input = Driver.FindElement(By.Name("login"));
            input.SendKeys("Hello");
        }
    }
}