using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.BaseClass;
using static System.Net.Mime.MediaTypeNames;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
            //cookies 
            IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuæ opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);
            //rej click
            IWebElement createAccountButton = driver.FindElement(By.XPath("//*[text()='Utwórz nowe konto']"));
            createAccountButton.Click();
            Thread.Sleep(1000);


            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(4000);

            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@name='birthday_month']")); 
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(2); // Select by index
            Thread.Sleep(1000);
            element.SelectByText("lip"); // Select by text
            Thread.Sleep(1000);
            element.SelectByValue("6"); // Select by value
            Thread.Sleep(1000);
        }
        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {
            //cookies 
            IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuæ opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            //cookies 
            IWebElement cookieButton = driver.FindElement(By.XPath("//*[text()='Odrzuæ opcjonalne pliki cookie']"));
            cookieButton.Click();
            Thread.Sleep(1000);

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }
    }
}