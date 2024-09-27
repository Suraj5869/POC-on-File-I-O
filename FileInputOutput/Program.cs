using FileInputOutput.Models;

namespace FileInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlFilePath = "C:\\Users\\Suraj\\OneDrive\\Desktop\\internship\\Tasks\\FileInputOutput\\Sample.xml";
            string htmlFilePath = "C:\\Users\\Suraj\\OneDrive\\Desktop\\internship\\Tasks\\FileInputOutput\\Sample.html";
            string textFilePath = "C:\\Users\\Suraj\\OneDrive\\Desktop\\internship\\Tasks\\FileInputOutput\\Sample.txt";


            Console.WriteLine(ReadFile.ReadXmlFile(xmlFilePath));//read xml file
            Console.WriteLine(ReadFile.ReadHtmlFile(htmlFilePath));//read html ile
            Console.WriteLine(ReadFile.ReadTextFile(textFilePath));//read text file

            //Taking the usename from the user
            Console.WriteLine("Enter the username to write in file");
            string username = Console.ReadLine();
            Console.WriteLine();

            WriteFiles.WriteXmlFile(xmlFilePath, username);//write text into xml file
            Console.WriteLine(ReadFile.ReadXmlFile(xmlFilePath));

            WriteFiles.WriteTextFile(textFilePath, username);//write text into text file
            Console.WriteLine(ReadFile.ReadTextFile(textFilePath));

            WriteFiles.WriteHtmlFile(htmlFilePath, username);//write text into html file
            Console.WriteLine(ReadFile.ReadHtmlFile(htmlFilePath));


        }
    }
}
