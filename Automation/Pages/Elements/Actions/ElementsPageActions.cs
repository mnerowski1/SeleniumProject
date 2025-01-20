using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumProject.Automation.Pages.Elements.Actions
{
    public class ElementsPageActions
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait Wait;

        public ElementsPageActions(IWebDriver driver)
        {
            this.driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private By ElementsMenu = By.XPath("//div[@class='card-body']//h5[text()='Elements']");

        public void ClickElementsMenu()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(ElementsMenu));
            driver.FindElement(ElementsMenu).Click();
        }
    }
}
