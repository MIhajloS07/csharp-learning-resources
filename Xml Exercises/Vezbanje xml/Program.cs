using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vezbanje_xml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\mihaj\source\repos\c#\Vezbanje xml\Vezbanje xml\dokument.xml");
            XmlNamespaceManager xnsm = new XmlNamespaceManager(doc.NameTable);
            xnsm.AddNamespace("ns",@"http://tempuri.org/pravilo.xsd");
            XmlNodeList nodes = doc.SelectNodes(@"/ns:knjige/ns:knjiga", xnsm);
            foreach (XmlNode knjiga in nodes) 
            {
                Console.WriteLine(knjiga["naziv"].InnerText);
                Console.WriteLine(knjiga["godina"].InnerText);
                Console.WriteLine(knjiga.Attributes["id"].Value);
                Console.WriteLine(knjiga.Attributes["autorId"].Value);
                Console.WriteLine(knjiga.Attributes["knjigaId"].Value);
                Console.WriteLine("------------------------------");
            }
        }
    }
}
