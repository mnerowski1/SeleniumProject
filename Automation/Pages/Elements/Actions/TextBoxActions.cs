using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumProject.Automation.Utils.TextBox;

namespace SeleniumProject.Automation.Pages.Elements.Actions
{
    internal class TextBoxActions : TextBox
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public TextBoxActions(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void ImportFromXml()
        {
            var import = new ImportFromXML();
            import.DataLoader("C:\\Users\\micha\\source\\repos\\SeleniumProject\\Automation\\Utils\\TextBox\\TextBox.xml");

            FillInFields(import.UserName, import.Email, import.CurrentAddress, import.PermanentAddress);
        }

        private void FillInFields( string username, string email, string currentaddress, string permanentaddress)
        {
            IWebElement textBoxMenu = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(TextBoxMenu));
            textBoxMenu.Click();
            IWebElement userName = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(FullName));
            userName.Click();
            userName.SendKeys(username);
            IWebElement eMail = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Email));
            eMail.Click();
            eMail.SendKeys(email);
            IWebElement currentAddress = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CurrentAddress));
            currentAddress.Click();
            currentAddress.SendKeys(currentaddress);
            IWebElement permanentAddress = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PermanentAddress));
            permanentAddress.Click();
            permanentAddress.SendKeys(permanentaddress);
        }
    }
}
