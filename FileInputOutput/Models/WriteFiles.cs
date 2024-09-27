using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileInputOutput.Models
{
    internal class WriteFiles
    {
        //Write the xml file
        //We append the input text into file rather than overriding it
        //using XmlDocument class we perform write operation on it
        public static void WriteXmlFile(string filePath, string input) 
        {
            //We creating object of XmlDocument class to load the xml file and perform the write operation on it
            XmlDocument xmlFile = new XmlDocument();
            xmlFile.Load(filePath);

            // Create a new username element
            XmlElement newUsername = xmlFile.CreateElement("username");
            newUsername.InnerText = input;

            // Append the new username element to the root
            xmlFile.DocumentElement.AppendChild(newUsername);

            xmlFile.Save(filePath);
        }

        //Write the html file
        //We append the input text into file rather than overriding it
        //to do so we use AppendAllText method
        public static void WriteHtmlFile(string filePath, string input)
        {
            string content = $"<p>{input}</p>\n";
            File.AppendAllText(filePath, content);
        }

        //Write the text file
        //We append the input text into file rather than overriding it
        //to do so we use AppendAllText method
        public static void WriteTextFile(string filePath, string input)
        {
            File.AppendAllText(filePath, input + Environment.NewLine); 
        }
    }
}
