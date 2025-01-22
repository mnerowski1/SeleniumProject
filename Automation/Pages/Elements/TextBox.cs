using OpenQA.Selenium;

namespace SeleniumProject.Automation.Pages.Elements
{
    public class User
    {
        public string UserName {  get; set; }
        public string Email {  get; set; }
        public string CurrentAdress {  get; set; }
        public string PermanentAddress {  get; set; }
    }

    public class TextBox
    {
        public By TextBoxMenu = By.XPath("//*[contains(text(), 'Text Box')]");
        public By FullName = By.Id("Full Name");
        public By Email = By.Id("userMail");
        public By CurrentAddress = By.Id("currentAddress");
        public By PermanentAddress = By.Id("permanentAddress");
    }
}
