using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;
using SeleniumCSharpTutorials.Utilities;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;
        [Test,Category("UAT Testing"),Category("Module1`")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1`")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);
            //accept cookies 
            IWebElement cookieButton = Driver.FindElement(By.XPath("//*[text()='Odrzuć opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //register click
            IWebElement createAccountButton = Driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);
            Driver.Close();
        }
    }
}
