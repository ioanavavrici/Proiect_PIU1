using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Proiect_PIU
{
    public class Firma
    {
        public string Id { get; set; }
        public string NumeFirma { get; set; }
        public List<Masina> MasiniDetinute { get; set; }
        public List<Angajat> Angajati { get; set; }

        // Constructor for initializing a firm
        public Firma(string nume)
        {
            Id = Guid.NewGuid().ToString();
            NumeFirma = nume;
            MasiniDetinute = new List<Masina>();
            Angajati = new List<Angajat>();
        }

        // Methods for adding machines and employees
        public void AdaugaMasina(Masina masina)
        {
            MasiniDetinute.Add(masina);
        }

        public void AdaugaAngajat(Angajat angajat)
        {
            Angajati.Add(angajat);
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Nume: {NumeFirma}, Numar masini detinute: {MasiniDetinute.Count}";
        }

        // Methods for writing and reading from file
        public static void WriteToFile(List<Firma> firme, string fileName)
        {
            string json = JsonConvert.SerializeObject(firme, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            });
            File.WriteAllText(fileName, json);
        }
        public static void AppendToFile(Firma firma, string fileName)
        {
            List<Firma> firme = ReadFromFile(fileName);
            firme.Add(firma);
            WriteToFile(firme, fileName);
        }

        public static List<Firma> ReadFromFile(string fileName)
        {
            List<Firma> firme = new List<Firma>();

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                firme = JsonConvert.DeserializeObject<List<Firma>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
            }

            return firme;
        }

    }
}
