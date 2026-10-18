using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Rad_sa_knjigama_c__konzolna_aplikacija
{
    internal class Program
    {
        public struct Knjiga
        {
            public int Id;
            public string Naziv;
            public string Autor;
            public int GodinaIzdanja;
            public bool Dostupna;

            //setteri
            public void SetId(int Id)
            {
                this.Id = Id;   
            }
            public void SetNaziv(string Naziv)
            {
                this.Naziv = Naziv; 
            }
            public void SetAutor(string Autor)
            {
                this.Autor = Autor;
            }
            public void SetGodinaIzdanja(int GodinaIzdanja)
            {
                this.GodinaIzdanja = GodinaIzdanja;
            }
            public void SetDostupna(bool Dostupna)
            {
                this.Dostupna = Dostupna;
            }
            
            //getteri
            public int GetId()
            {
                return this.Id;
            }
            public string GetNaziv()
            {
                return this.Naziv;
            }
            public string GetAutor()
            {
                return this.Autor;
            }
            public int GetGodinaIzdanja()
            {
                return this.GodinaIzdanja;
            }
            public bool GetDostupna()
            {
                return this.Dostupna;
            }

            //Metode
            public void prikaziInfo() 
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"Id: {this.Id} | Naziv: {this.Naziv} | Autor: {this.Autor} | Godina izdanja: {this.GodinaIzdanja} | Dostupna: {this.Dostupna}");
                Console.WriteLine("-----------------------------------------------------------------------------");
            }
            //konstruktor
            public Knjiga(int Id, string Naziv, string Autor, int GodinaIzdanja, bool Dostupna)
            {
                this.Id = Id;
                this.Naziv = Naziv;
                this.Autor = Autor;
                this.GodinaIzdanja = GodinaIzdanja;
                this.Dostupna = Dostupna;
            }
        }

        static void GlavniMeni() 
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("|     GLAVNI MENI      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("|  1.Dodaj knjigu      |");
            Console.WriteLine("|  2.Prikazi knjige    |");
            Console.WriteLine("|  3.Pretraga (naziv)  |");
            Console.WriteLine("|  4.Pretraga (ID)     |");
            Console.WriteLine("|  5.Pretraga (Autor)  |");
            Console.WriteLine("|  6.Iznajmi knjigu    |");
            Console.WriteLine("|  7.Vrati knjigu      |");
            Console.WriteLine("|  0.Izlaz iz app      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("------------------------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            const int maxKnjiga = 100;
            Knjiga[] knjige = new Knjiga[maxKnjiga]; // niz koji omogucava smestanje max 100 knjiga
            int brojKnjiga = 0; //brojac za knijge
            bool running = true;

            try
            {
                do
                {
                    GlavniMeni();
                    Console.WriteLine();
                    byte izbor; Console.Write("Unesi izbor: "); izbor = Convert.ToByte(Console.ReadLine());

                    if (izbor <= 7 && izbor >= 0)
                    {
                        if (izbor == 0)
                        {
                            running = false;
                            Console.WriteLine("Izlaz iz aplikacije...");
                            Console.WriteLine();
                        }
                        else if (izbor == 1) //dodavanje knjige
                        {
                            if (brojKnjiga < maxKnjiga)
                            {
                                int Id;
                                string Naziv;
                                string Autor;
                                int GodinaIzdanja;
                                int DostupnaInt;
                                Console.WriteLine();
                                Console.WriteLine("== DODAVANJE KNJIGE ==");
                                Console.Write("Unesi ID knjige: "); Id = Convert.ToInt32(Console.ReadLine());
                                bool idPostoji = false;
                                for (int i = 0; i < brojKnjiga; i++)
                                {
                                    if (knjige[i].Id == Id)
                                    {
                                        idPostoji = true;
                                        break;
                                    }
                                }
                                if (idPostoji)
                                {
                                    Console.WriteLine($"Knjiga sa ID-jem {Id} već postoji! Unos je prekinut.");
                                }
                                else
                                {
                                    Console.Write("Unesi Naziv knjige: "); Naziv = Convert.ToString(Console.ReadLine());
                                    Console.Write("Unesi Autora knjige: "); Autor = Convert.ToString(Console.ReadLine());
                                    Console.Write("Unesi godinu izdanja knjige: "); GodinaIzdanja = Convert.ToInt32(Console.ReadLine());
                                    do
                                    {
                                        Console.Write("Potvrdi da li je knjiga dostupna (1 - da, 0 - ne): "); DostupnaInt = Convert.ToInt32(Console.ReadLine());
                                    } while (DostupnaInt != 0 && DostupnaInt != 1);
                                    bool Dostupna = DostupnaInt == 1;
                                    knjige[brojKnjiga++] = new Knjiga(Id, Naziv, Autor, GodinaIzdanja, Dostupna);
                                }
                            }
                        }
                        else if (izbor == 2) //prikaz informacija o knjigama
                        {
                            if (brojKnjiga == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("U Datom nizu nema knjiga...");
                                Console.WriteLine();
                            }
                            else
                            {
                                for (int i = 0; i < brojKnjiga; i++)
                                {
                                    knjige[i].prikaziInfo();
                                }
                            }
                        }
                        else if (izbor == 3)
                        {
                            Console.WriteLine();
                            Console.WriteLine("-- PRETRAGA KNJIGE PO NAZIVU --");
                            string Naziv; Console.Write("Unesi naziv knjige: "); Naziv = Convert.ToString(Console.ReadLine());

                            for (int i = 0; i < brojKnjiga; i++)
                            {
                                if (Naziv == knjige[i].Naziv)
                                {
                                    knjige[i].prikaziInfo();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"-- Knjiga sa nazivom {Naziv} nije pronadjena --");
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (izbor == 4)
                        {
                            Console.WriteLine();
                            Console.WriteLine("-- PRETRAGA KNJIGE PO ID - u --");
                            int Id; Console.Write("Unesi ID knjige: "); Id = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < brojKnjiga; i++)
                            {
                                if (Id == knjige[i].Id)
                                {
                                    knjige[i].prikaziInfo();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"-- Knjiga sa ID - em {Id} nije pronadjena --");
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (izbor == 5)
                        {
                            Console.WriteLine();
                            Console.WriteLine("-- PRETRAGA KNJIGE PO AUTORU --");
                            string Autor; Console.Write("Unesi Autora knjige: "); Autor = Convert.ToString(Console.ReadLine());

                            for (int i = 0; i < brojKnjiga; i++)
                            {
                                if (Autor == knjige[i].Autor)
                                {
                                    knjige[i].prikaziInfo();
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"-- Knjiga sa autorom {Autor} nije pronadjena --");
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (izbor == 6)
                        {
                            Console.WriteLine();
                            Console.WriteLine("-- NAJAM KNJIGE --");
                            int Id; Console.Write("Unesi ID knjige: "); Id = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < brojKnjiga; i++)
                            {
                                if (Id == knjige[i].Id)
                                {
                                    if (knjige[i].Dostupna == true)
                                    {
                                        Console.WriteLine($"Knjiga sa ID - em {Id} uspesno iznajmljena");
                                        knjige[i].Dostupna = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"Knjiga sa ID - em {Id} nije dostupna...");
                                        Console.WriteLine();
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"-- Knjiga sa ID - em {Id} nije pronadjena --");
                                    Console.WriteLine();
                                }
                            }
                        }
                        else if (izbor == 7)
                        {
                            Console.WriteLine();
                            Console.WriteLine("-- VRACANJE KNJIGE --");
                            int Id; Console.Write("Unesi ID knjige: "); Id = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < brojKnjiga; i++)
                            {
                                if (Id == knjige[i].Id)
                                {
                                    if (knjige[i].Dostupna == false)
                                    {
                                        knjige[i].Dostupna = true;
                                        Console.WriteLine($"-- Knjiga sa ID - em {Id} uspesno vracena --");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Knjiga sa ID - em {Id} je vec dostupna");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"-- Knjiga sa ID - em {Id} nije pronadjena --");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nepostojeci izbor...");
                        Console.WriteLine();
                    }

                } while (running);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
            }
            finally 
            {
                Console.WriteLine("-- Hvala sto ste koristili nas program --");
                Console.WriteLine();
            }
        }
    }
}