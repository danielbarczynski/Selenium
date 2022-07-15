using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.BaseClass;
namespace Selenium
{
    [TestFixture]
    public class Tests : BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebElement input = driver.FindElement(By.Name("login"));
            IWebElement password = driver.FindElement(By.Name("password"));
            IWebElement password2 = driver.FindElement(By.Id("popup-create-account-password2"));
            IWebElement checkbox = driver.FindElement(By.Id("popup-create-account-checkbox"));
            IWebElement checkbox2 = driver.FindElement(By.Id("popup-create-account-checkbox-openid-rodo"));
            IWebElement button = driver.FindElement(By.ClassName("button-register"));
            input.SendKeys("dalksdnasjn");
            password.SendKeys("dalksdnasjn23");
            password2.SendKeys("dalksdnasjn23");
            checkbox.Click();
            checkbox2.Click();
            button.Click();
            Thread.Sleep(5000);
        }
        [Test]
        public void Test2()
        {
            IWebElement input = driver.FindElement(By.Name("login"));
            IWebElement password = driver.FindElement(By.Name("password"));
            IWebElement password2 = driver.FindElement(By.Id("popup-create-account-password2"));
            IWebElement checkbox = driver.FindElement(By.Id("popup-create-account-checkbox"));
            IWebElement checkbox2 = driver.FindElement(By.Id("popup-create-account-checkbox-openid-rodo"));
            IWebElement button = driver.FindElement(By.ClassName("button-register"));
            input.SendKeys("dalksdnasjn");
            password.SendKeys("dalksdnasjn23");
            password2.SendKeys("dalksdnasjn23");
            checkbox.Click();
            checkbox2.Click();
            button.Click();
        }

    }
}