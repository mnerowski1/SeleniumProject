using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestFixture]
    public class Setup
    {
        private IWebDriver driver = null!;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized"); 
            driver = new ChromeDriver(options);
        }

        [Test]
        public void OpenGoogleTest()
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
