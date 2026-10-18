using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    //interface IZivotinja
    //{
    //    void Zvuk();
    //    void KreciSe();
    //}
    //interface IZivoBice : IZivotinja
    //{
    //    void Dise();
    //}

    //class Pas : IZivoBice
    //{
    //    public void Zvuk()
    //    {
    //        Console.WriteLine("Av Av");
    //    }
    //    public void KreciSe()
    //    {
    //        Console.WriteLine("Pas se krece.");
    //    }
    //    public void Dise()
    //    {
    //        Console.WriteLine("Pas dise");
    //    }

    //}
    //class Macka : IZivoBice
    //{
    //    public void Zvuk()
    //    {
    //        Console.WriteLine("Mjau Mjau");
    //    }
    //    public void KreciSe()
    //    {
    //        Console.WriteLine("Macka se krece.");
    //    }
    //    public void Dise()
    //    {
    //        Console.WriteLine("Macka dise");
    //    }
    //}


    //interface IOsoba
    //{
    //    string Ime(string ime);
    //}

    //class Osoba : IOsoba
    //{
    //    public string Ime(string ime)
    //    {
    //        return ime;
    //    }
    //}

    //class Nastavnik : Osoba, IOsoba
    //{
    //    public void ImeNastavnika(string imeNastavnika)
    //    {
    //        Console.WriteLine("Nastavnik: " + imeNastavnika);
    //    }
    //}

        //interface IZivotinja
        //{
        //    void Zvuk();
        //    void KreciSe();
        //}
        //interface IZivoBice : IZivotinja
        //{
        //    void Dise();
        //}

        //class Pas : IZivoBice
        //{
        //    public void Zvuk()
        //    {
        //        Console.WriteLine("Av Av");
        //    }
        //    public void KreciSe()
        //    {
        //        Console.WriteLine("Pas se krece.");
        //    }
        //    public void Dise()
        //    {
        //        Console.WriteLine("Pas dise");
        //    }

        //}
        //class Macka : IZivoBice
        //{
        //    public void Zvuk()
        //    {
        //        Console.WriteLine("Mjau Mjau");
        //    }
        //    public void KreciSe()
        //    {
        //        Console.WriteLine("Macka se krece.");
        //    }
        //    public void Dise()
        //    {
        //        Console.WriteLine("Macka dise");
        //    }
        //}

        //primer 2

        //interface IOsoba
        //{
        //    string Ime(string ime);
        //}

        //class Osoba : IOsoba
        //{
        //    public string Ime(string ime)
        //    {
        //        return ime;
        //    }
        //}

        //class Nastavnik : Osoba, IOsoba
        //{
        //    public void ImeNastavnika(string imeNastavnika)
        //    {
        //        Console.WriteLine("Nastavnik: " + imeNastavnika);
        //    }
        //}


    interface IIme
    {
        string Ime(string ime);
    }

    interface IJmbg
    {
        string Jmbg(string jmbg);
    }

    interface IJob
    {
        string Job(string job);
    }

    class Nastavnik : IIme, IJmbg
    {
        public string Ime(string ime)
        {
            return ime;
        }

        public string Jmbg(string jmbg)
        {
            return jmbg;
        }
    }

    class Ucenik : IIme, IJmbg, IJob
    {
        public string Ime(string ime)
        {
            return ime;
        }

        public string Jmbg(string jmbg)
        {
            return jmbg;
        }

        public string Job(string job)
        {
            return job;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Macka macka = new Macka();
            //macka.Zvuk();
            //macka.KreciSe();

            //Pas pas = new Pas();
            //pas.Zvuk();
            //pas.KreciSe();
            //pas.Dise();


        }
    }
}
