using NUnit.Framework;
using SeleniumProject.Automation.Pages.Elements.Actions;

namespace SeleniumProject.Automation.Tests.Elements
{
    [TestFixture]
    public class OpenElementsMenu : Setup
    {
        private ElementsPageActions elementsPage;

        [SetUp]
        public void SetUp()
        {
            elementsPage = new ElementsPageActions(driver);
        }

        [Test]
        public void TestOpenElementsMenu()
        {
            OpenPage();
            elementsPage.ClickElementsMenu();
        }        
    } 
}
