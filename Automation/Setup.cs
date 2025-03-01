﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject.Automation
{
    [TestFixture]
    public class Setup
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
        }

        [Test]
        public void OpenPage()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            Assert.That(driver.Title, Is.EqualTo("DEMOQA"));
        }

        [TearDown]
        public void Cleanup()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
