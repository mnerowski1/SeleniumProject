using NUnit.Framework;
using SeleniumProject.Automation.Pages.Elements.Actions;

namespace SeleniumProject.Automation.Tests.Elements
{
    internal class TextBoxFields : Setup
    {
        private ElementsPageActions elementsPage;
        private TextBoxActions textBoxActions;

        [SetUp]
        public new void SetUp()
        {
            elementsPage = new ElementsPageActions(driver);
            textBoxActions = new TextBoxActions(driver);
        }

        [Test]
        public void TestOpenElementsMenu()
        {
            OpenPage();
            elementsPage.ClickElementsMenu();
            textBoxActions.ImportFromXml();
        }
    }
}
