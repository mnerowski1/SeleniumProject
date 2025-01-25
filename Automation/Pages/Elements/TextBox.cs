using OpenQA.Selenium;

namespace SeleniumProject.Automation.Pages.Elements
{
    public class TextBox
    {
        public By TextBoxMenu = By.XPath("//*[contains(text(), 'Text Box')]");
        public By FullName = By.Id("userName");
        public By Email = By.Id("userEmail");
        public By CurrentAddress = By.Id("currentAddress");
        public By PermanentAddress = By.Id("permanentAddress");
    }
}
