using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    [TestFixture]
    public class UnitTesting2
    {
        IWebDriver webDriver;
        [Test, Author("Daniel", "daniel.barczynski@onet.pl")]
        [Description("Margonem login")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(string urlName)
        {
            try
            {
                webDriver = new ChromeDriver();
                webDriver.Url = urlName;
                //IWebElement input = webDriver.FindElement(By.Name("login"));
                IWebElement input = webDriver.FindElement(By.Name("loginn"));
                input.SendKeys("Bye");
            }
            catch (Exception e)
            {
                ITakesScreenshot takesScreenshot = webDriver as ITakesScreenshot;
                Screenshot screenshot = takesScreenshot.GetScreenshot();
                screenshot.SaveAsFile(@"C:\Users\Użytkownik\source\repos\WhatIveBecome\Selenium\Selenium\Screenshots\s1.png", ScreenshotImageFormat.Png);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(webDriver!= null)
                {
                    webDriver.Quit();
                }
            }
        }

        static IList DataDrivenTesting()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("https://www.margonem.pl/");
            //arrayList.Add("https://poczta.wp.pl/rejestracja/");
            return arrayList;
        }
        //[Test]
        //[Author("Daniel", "daniel.barczynski@onet.pl")]
        //[Description("Margonem login")]
        //public void Test2()
        //{
        //    IWebDriver webDriver = new ChromeDriver();
        //    webDriver.Url = "https://www.margonem.pl/";
        //    IWebElement input = webDriver.FindElement(By.Name("login"));
        //    input.SendKeys("Bye");
        //}
    }
}
