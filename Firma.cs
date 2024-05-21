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
        public string Parola { get; set; }
        public List<string> MasiniDetinute { get; set; }
        public List<string> Angajati { get; set; }
        public List<string> Client { get; set; }

        // Parameterless constructor needed for deserialization
        public Firma()
        {
            MasiniDetinute = new List<string>();
            Angajati = new List<string>();
            Client = new List<string>();
        }

        // Constructor for initializing a firm
        [JsonConstructor]
        public Firma(string nume, string parola)
        {
            Id = Guid.NewGuid().ToString();
            Parola = parola;
            NumeFirma = nume;
            MasiniDetinute = new List<string>();
            Angajati = new List<string>();
            Client = new List<string>();
        }

        // Methods for adding machines and employees
        public void AdaugaMasina(string masina)
        {
            MasiniDetinute.Add(masina);
        }

        public void AdaugaAngajat(string angajat)
        {
            Angajati.Add(angajat);
        }

        public void AdaugaClient(string client)
        {
            Client.Add(client);
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Nume: {NumeFirma}, Numar masini detinute: {MasiniDetinute.Count}";
        }

        // Methods for writing and reading from file
        public static void WriteToFile(List<Firma> firme, string fileName)
        {
            string json = JsonConvert.SerializeObject(firme);
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
                firme = JsonConvert.DeserializeObject<List<Firma>>(json);

              
            } 
            return firme;
        }
    }
}