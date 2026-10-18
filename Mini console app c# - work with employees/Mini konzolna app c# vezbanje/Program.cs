using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_konzolna_app_c__vezbanje
{
    public struct Korisnik
    {
        public int Id;
        public int Godine;
        public string Ime;

        //metoda (setteri)
        public void setId(int Id)
        {
            this.Id = Id;    
        }
        public void setGodine(int Godine) 
        {
            this.Godine = Godine;
        }
        public void setIme(string Ime)
        {
            this.Ime = Ime;
        }

        //metode (getteri)
        public int getId()
        {
            return this.Id; 
        }
        public int getGodine()
        {
            return this.Godine; 
        }
        public string getIme()
        {
            return this.Ime;    
        }
        public void info()
        {
            Console.WriteLine("-- Informacije o korisniku --");
            Console.WriteLine($"ID: {this.Id} | Ime: {this.Ime} | Godine: {this.Godine}");
        }

        //konstruktor
        public Korisnik(int Id,int Godine, string Ime)
        {
            this.Id = Id;
            this.Godine = Godine;
            this.Ime = Ime;
        }

    }
    internal class Program
    {
        static double Suma(double a, double b)
        {
            return a + b;
        }
        static double Razlika(double a, double b)
        {
            return a - b;
        }
        static double Proizvod(double a, double b)
        {
            return a * b;
        }
        static double Kolicnik(double a, double b)
        {
            return (a > b) ? (a / b) : (b / a);
        }
        static double Stepenovanje(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static void KonvertorCmInch()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|| CM -> INCH konvertor ||");
            const double inch = 0.39370079;
            Console.Write("Unesi broj centimetara: "); double cm; cm = double.Parse(Console.ReadLine());
            Console.WriteLine($"-- {cm} centimetara iznosi {cm * inch} inca --");
        }
        static void KonvertorCelziusFarenhajt()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("|| CELZIUS -> FARENHAJT konvertor ||");
            Console.WriteLine("Unesi broj celziusa: "); double celzius; celzius = double.Parse(Console.ReadLine());
            double farenhajt = (celzius * 9 / 5) + 32;
            Console.WriteLine($"-- {celzius} °C iznosi {farenhajt} °F --");
        }
        static void InteraktivniMeni()
        {
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine("|   INTERAKTIVNI MENI   |");
            Console.WriteLine("|                       |");
            Console.WriteLine("|  1.Kalkulator         |");
            Console.WriteLine("|  2.Konvertor          |");
            Console.WriteLine("|  3.Menadzer korisnika |");
            Console.WriteLine("|  0.Izlaz              |");
            Console.WriteLine("|                       |");
            Console.WriteLine("=========================");
            Console.WriteLine();
        }
        static void podMeni()
        {
            Console.WriteLine();
            Console.WriteLine("=========================");
            Console.WriteLine("|   MENADZER KORISNIKA  |");
            Console.WriteLine("|                       |");
            Console.WriteLine("|  1.Dodaj korisnika    |");
            Console.WriteLine("|  2.Prikazi korisnike  |");
            Console.WriteLine("|  3.Pretraga po ID - u |");
            Console.WriteLine("|  4.Pretraga po imenu  |");
            Console.WriteLine("|  5.Pretraga po godini |");
            Console.WriteLine("|  0.Nazad              |");
            Console.WriteLine("|                       |");
            Console.WriteLine("=========================");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            const int maxKorisnici = 100;
            Korisnik[] korisnici = new Korisnik[maxKorisnici];         
            bool rad = true;
            int brojKorisnika = 0;
            bool pronadjen = false;
            try
            {
                do
                {  
                    InteraktivniMeni();
                    //  Unos izbora korisnika
                    byte izbor; Console.Write("Unesi izbor (0-3): "); izbor = Convert.ToByte(Console.ReadLine());

                    switch (izbor)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("-----------------------");
                            double brojJedan, brojDva;
                            Console.Write("Unesi prvi broj: "); brojJedan = double.Parse(Console.ReadLine());
                            Console.Write("Unesi drugi broj: "); brojDva = double.Parse(Console.ReadLine());
                            byte izborOperacije;
                            Console.Write("Unesi operaciju (1 - Sabiranje,2 - oduzimanje,3 - mnozenje,4 - deljenje,5 - stepenovanje): ");
                            izborOperacije = Convert.ToByte(Console.ReadLine());
                            if (izborOperacije >= 1 && izborOperacije <= 5)
                            {
                                if (izborOperacije == 1)
                                {
                                    Console.WriteLine($"Zbir broja {brojJedan} i {brojDva} je: {Suma(brojJedan, brojDva)}");
                                }
                                else if (izborOperacije == 2)
                                {
                                    Console.WriteLine($"Razlika broja {brojJedan} i {brojDva} je: {Razlika(brojJedan, brojDva)}");
                                }
                                else if (izborOperacije == 3)
                                {
                                    Console.WriteLine($"Proizvod broja {brojJedan} i {brojDva} je: {Proizvod(brojJedan, brojDva)}");
                                }
                                else if (izborOperacije == 4)
                                {
                                    Console.WriteLine($"Kolicnik broja {brojJedan} i {brojDva} je: {Kolicnik(brojJedan, brojDva)}");
                                }
                                else if (izborOperacije == 5)
                                {
                                    Console.WriteLine($"Stepenovanje broja {brojJedan} ^ {brojDva} je: {Stepenovanje(brojJedan, brojDva)}");
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Nepostojeca opcija...");
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine(" -- Konvertor mera --");
                            Console.Write("Unesi tip konvertora (1 - cm u inch, 2 - celzius u farenhajt): ");
                            byte izborKonvertora; izborKonvertora = Convert.ToByte(Console.ReadLine());
                            if (izborKonvertora >= 1 && izborKonvertora <= 2)
                            {
                                if (izborKonvertora == 1)
                                {
                                    KonvertorCmInch();
                                }
                                else if (izborKonvertora == 2)
                                {
                                    KonvertorCelziusFarenhajt();
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Nepostojeca opcija...");
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            podMeni();
                            int izborMenadzera; Console.Write("Unesi izbor: "); izborMenadzera = Convert.ToInt32(Console.ReadLine());
                            if (izborMenadzera >= 0 && izborMenadzera <= 5)
                            {
                                if (izborMenadzera == 0)
                                {
                                    //vracanje nazad
                                }
                                else if (izborMenadzera == 1)
                                {
                                    //dodavanje korisnika
                                    if(brojKorisnika < maxKorisnici)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Unesi ID korisnika: ");
                                        int id = int.Parse(Console.ReadLine());

                                        Console.Write("Unesi ime korisnika: ");
                                        string ime = Console.ReadLine();

                                        Console.Write("Unesi broj godina: ");
                                        int godine = int.Parse(Console.ReadLine());

                                        korisnici[brojKorisnika++] = new Korisnik(id, godine, ime);
                                        Console.WriteLine();
                                    }
                                }
                                else if (izborMenadzera == 2)
                                {
                                    //prikaz korisnika
                                    if (brojKorisnika == 0)
                                    {
                                        Console.WriteLine("Nema nijednog korisnika unetog.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < brojKorisnika; i++)
                                        {
                                            korisnici[i].info();  
                                        }
                                    }
                                }
                                else if (izborMenadzera == 3) 
                                {
                                    Console.WriteLine();
                                    int id; Console.Write("Unesi ID korisnika koga zelis pretraziti: "); id = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    for (int i = 0; i < brojKorisnika; i++)
                                    {
                                        if(id == korisnici[i].Id)
                                        {
                                            korisnici[i].info();
                                        }
                                    }
                                    if (!pronadjen)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------------");
                                        Console.WriteLine($"Korisnik sa ID {id} nije pronadjen");
                                        Console.WriteLine("--------------------------------------------");
                                        Console.WriteLine();
                                    }
                                }
                                else if (izborMenadzera == 4)
                                {
                                    Console.WriteLine();
                                    string ime; Console.Write("Unesi Ime korisnika koga zelis pretraziti: "); ime = Convert.ToString(Console.ReadLine());
                                    Console.WriteLine();
                                    for (int i = 0; i < brojKorisnika; i++)
                                    {
                                        if (ime == korisnici[i].Ime)
                                        {
                                            korisnici[i].info();
                                            pronadjen = true;
                                        }
                                    }
                                    if (!pronadjen)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------------");
                                        Console.WriteLine($"Korisnik sa Imenom {ime} nije pronadjen");
                                        Console.WriteLine("--------------------------------------------");
                                        Console.WriteLine();
                                    }
                                }
                                else if (izborMenadzera == 5)
                                {                           
                                    Console.WriteLine();
                                    int godine; Console.Write("Unesi broj godina korisnika koga zelis pretraziti: "); godine = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine();
                                    for (int i = 0; i < brojKorisnika; i++)
                                    {
                                        if (godine == korisnici[i].Godine)
                                        {
                                            korisnici[i].info();
                                            pronadjen = true;
                                        }
                                    }
                                    if (!pronadjen)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("--------------------------------------------");
                                        Console.WriteLine($"Korisnik sa broj godina {godine} nije pronadjen");
                                        Console.WriteLine("--------------------------------------------");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("---------------------");
                                Console.WriteLine("Nepostojeca opcija...");
                                Console.WriteLine("---------------------");
                                Console.WriteLine();
                            }
                            break;
                        case 0:
                            Console.WriteLine("-----------------------------");
                            Console.WriteLine("Izlaz iz aplikacije...");
                            rad = false;
                            break;
                        default:
                            Console.WriteLine("Nepostojeca opcija!");
                            break;
                    }
                } while (rad);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Greska: {e.Message}");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine(" -- Hvala na koriscenju naseg programa --");
                Console.WriteLine();
            }

            Console.WriteLine("Hvala Vam sto ste posetili nas program,dodjite nam opet!!!");
            int broj;
            Console.WriteLine("Unesi broj"); broj = Convert.ToInt32(Console.ReadLine());
        }
    }
}
