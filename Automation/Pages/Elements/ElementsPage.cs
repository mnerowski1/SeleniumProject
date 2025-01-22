using OpenQA.Selenium;

namespace SeleniumProject.Automation.Pages.Elements.Actions
{
    public class ElementsPage
    {
        public By ElementsMenu = By.XPath("//div[@class='card-body']//h5[text()='Elements']");
        public By ElementsCollapse = By.XPath("//div[@class='header-text']//span[text()='Elements']");
    }
}
