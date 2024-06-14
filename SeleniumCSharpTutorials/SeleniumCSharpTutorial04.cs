using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Tomasz","tomasz.dziedzic@gmail.com")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;

                //cookies 
                IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
                cookieButton.Click();
                Thread.Sleep(1000);

                //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='email']"));
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\kamil\\source\\repos\\SeleniumC#Sessions\\SeleniumCSharp\\SeleniumCSharpTutorials\\Screenshots\\s1.jpeg");
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
             
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            //list.Add("https://www.youtube.com/");
            //list.Add("https://www.gmail.com/");
            return list;
        }

        //[Test]
        //[Author("Tomasz", "tomasz.dziedzic@gmail.com")]
        //[Description("Facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com";

        //    //cookies 
        //    IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
        //    cookieButton.Click();
        //    Thread.Sleep(1000);

        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='email']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}
    }
}
