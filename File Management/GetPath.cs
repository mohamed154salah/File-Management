using System.Xml;

namespace File_Management
{
    public static class GetPath
    {
        public static string Path()
        {
            try
            {
                // Load the XML file
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(@"C:\Users\mohamed.abdelmogoud\Source\Repos\File Management\File Management\path.xml");

                // Get the value of the FilePath node
                XmlNode filePathNode = xmlDoc.SelectSingleNode("/Configuration/FilePath");
                string filePath = filePathNode.InnerText;

                return filePath;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
