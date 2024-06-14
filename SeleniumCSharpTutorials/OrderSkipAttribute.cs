using Microsoft.VisualStudio.TestPlatform.TestHost;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    {

        [Test,Order(2),Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            //cookies 
            IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //rej click
            IWebElement createAccountButton = driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test,Order(1),Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            var driverPath = @"C:\Users\kamil\Desktop\gecko\geckodriver.exe";

            var firefoxPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(driverPath);

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = firefoxPath; // Set the Firefox binary path

            IWebDriver driver = new FirefoxDriver(service, options);

            driver.Url = "https://www.facebook.com/";

            // Handle cookies 
            IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);

            // Click "Create Account" button
            IWebElement createAccountButton = driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);

            // Enter email
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");

            driver.Close();
        }

        [Test,Order(0),Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://www.facebook.com/";
            //cookies 
            IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //rej click
            IWebElement createAccountButton = driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
