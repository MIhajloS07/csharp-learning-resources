using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalLibrary;

namespace Vezbanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExternalClass obj = new ExternalClass(1,"Mihajlo","Stoiljkovic",17);
            ExternalClass.SetBackgroundColor("blue");
            //obj.SetId(1);
            //obj.SetName("Mihajlo");
            //obj.SetSurname("Stoiljkovic");
            //obj.SetAge(17);
            obj.ShowInfo();
            Console.WriteLine(obj.GetName());  
        }
    }
}
