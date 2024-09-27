using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileInputOutput.Models
{
    internal class ReadFile
    {
        //Method to read XML file
        //Using XElement class and Load method to load file content in a variable 
        public static string ReadXmlFile(string filePath)
        {
            if (File.Exists(filePath)) 
            { 
                XElement xml = XElement.Load(filePath);
                return "===== Xml file Content: ======\n" + $"{xml}\n";
            }
            return "Xml file not found.\n";
        }

        //Method to read Html file
        //Using ReadAllText method we read all content in file and store in a variable
        public static string ReadHtmlFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string html = File.ReadAllText(filePath);
                return "===== Html file Content: =====\n" + $"{html}\n";  
            }
            return "Html file not found.\n";
        }

        //Method to read Text file
        //It is another method to read the file
        //Using StreamReader class we read all content in file line by line and store in a variable
        public static string ReadTextFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader Textfile = new StreamReader(filePath);
                string line;
                var allText = "";

                while ((line = Textfile.ReadLine()) != null)
                {
                    allText = $"{allText}\n{line}";
                }

                Textfile.Close();
                return "===== Text file Content: =====\n" + $"{allText}\n";
            }
            return "Text file not found.\n";
           
        }
    }
}
