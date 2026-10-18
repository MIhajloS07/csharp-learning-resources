using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// namespace
using System.Xml;

namespace Osnovni_rad_sa_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("studenti.xml");
                XmlNodeList list = xml.SelectNodes(@"/ucenici/ucenik");
                PrintDataXml(list);
                Console.Write("Unesi ID ucenika koga zelis da obrises: ");
                string ID = Console.ReadLine()?.Trim();
                XmlNode forDelete = xml.SelectSingleNode($"/ucenici/ucenik[@id='{ID}']");
                if (forDelete != null)
                {
                    xml.DocumentElement.RemoveChild(forDelete);
                    xml.Save("studenti.xml");
                    Console.WriteLine($"Ucenik sa ID - {ID} obrisan, da li zelis da ispises sve ucenike (y/n) ?");
                    string answer = Console.ReadLine().Trim().ToLower();
                    if (answer == "y")
                    {
                        XmlNodeList updatedList = xml.SelectNodes(@"/ucenici/ucenik");
                        PrintDataXml(updatedList);
                    }
                }
                else
                {
                    Console.WriteLine($"Ucenik sa ID - {ID} ne postoji");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Fajl nije pronadjen");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PrintDataXml(XmlNodeList list)
        {
            foreach (XmlNode node in list)
            {
                //if (node["grad"].InnerText.Trim() == "Nis")
                //{
                Console.WriteLine(
                    $"{node.Attributes["id"].Value} -" +
                    $"{node["ime"].InnerText} -" +
                    $"{node["skola"].InnerText} -" +
                    $"{node["grad"].InnerText} -" +
                    $"{node["razred"].InnerText}. razred-" +
                    $"{node["smer"].InnerText}"
                );
                //}
            }
        }
    }
}
