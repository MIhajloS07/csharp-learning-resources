using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Rad_sa_JSON
{
    public class Student
    {
        //[JsonPropertyName("ime")]
        public string Ime { get; set; }
        //[JsonPropertyName("godine")]
        public int Godine { get; set; }
        //[JsonPropertyName("ocene")]
        //public List<int> Ocene { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string json = File.ReadAllText(@"E:\VISUAL STUDIO\Rad sa JSON\Rad sa JSON\format.json");
                //Student s = JsonSerializer.Deserialize<Student>(json);
                //Console.WriteLine($"Ime: {s.Ime}");
                //Console.WriteLine($"Godine: {s.Godine}"); 
                //Console.WriteLine($"Ocene: {string.Join(",", s.Ocene)}");
                string filePathJson = @"E:\VISUAL STUDIO\Rad sa JSON\Rad sa JSON\format.json";
                List<Student> studenti = new List<Student>();

                // Ucitaj studente ako fajl postoji
                if (File.Exists(filePathJson))
                {
                    string jsonExisting = File.ReadAllText(filePathJson);
                    if (!string.IsNullOrEmpty(jsonExisting))
                        studenti = JsonSerializer.Deserialize<List<Student>>(jsonExisting);
                }

                // Instanca
                Student student = new Student();
                Console.Write("Unesi ime: ");
                student.Ime = Console.ReadLine();
                Console.Write("Unesi godine: ");
                student.Godine = int.Parse(Console.ReadLine());

                studenti.Add(student);

                string json = JsonSerializer.Serialize(studenti, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePathJson, json);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Greska pri parsiranju JSON-a: {ex.Message}");
            }
        }
    }
}
