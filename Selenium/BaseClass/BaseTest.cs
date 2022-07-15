using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void OpenWebsites()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Url = "https://www.margonem.pl/";
            driver.Url = "https://poczta.wp.pl/rejestracja/";

        }
        
        [OneTimeTearDown]
        public void Close()
        {
           // driver.Quit(); 
        }
    }
}
