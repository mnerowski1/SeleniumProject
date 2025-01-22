using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject.Automation.Pages.Elements.Actions
{
    public class ElementsPageActions : ElementsPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ElementsPageActions(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void ClickElementsMenu()
        {
            IWebElement elementsMenu = driver.FindElement(ElementsMenu);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elementsMenu));
            elementsMenu.Click();
        }
    }
}
