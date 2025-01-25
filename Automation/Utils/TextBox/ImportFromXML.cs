using System.Xml;

namespace SeleniumProject.Automation.Utils.TextBox
{
    internal class ImportFromXML
    {
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string CurrentAddress { get; private set; }
        public string PermanentAddress { get; private set; }

        public void DataLoader(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            XmlNode usernameNode = xmlDoc.SelectSingleNode("//Users/User/UserName");
            XmlNode emailNode = xmlDoc.SelectSingleNode("//Users/User/Email");
            XmlNode currentAddressNode = xmlDoc.SelectSingleNode("//Users/User/CurrentAddress");
            XmlNode permanentAddressNode = xmlDoc.SelectSingleNode("//Users/User/PermanentAddress");

            if (usernameNode != null && emailNode != null && currentAddressNode != null && permanentAddressNode != null)
            {
                UserName = usernameNode.InnerText;
                Email = emailNode.InnerText;
                CurrentAddress = currentAddressNode.InnerText;
                PermanentAddress = permanentAddressNode.InnerText;
            }
            else
            {
                throw new Exception("Missing data in the XML");
            }
        }
    }
}
