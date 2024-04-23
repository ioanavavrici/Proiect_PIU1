using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public enum Culoare
{
    Rosu,
    Alb,
    Negru,
    Verde,
    Albastru
}

[Flags]
public enum Optiuni
{
    Niciuna = 0,
    AerConditionat = 1 << 0,
    Navigatie = 1 << 1,
    CutieAutomata = 1 << 2,
}

namespace Proiect_PIU
{
    public class Masina
    {
        public string Id { get; set; }
        public List<Client> IdClienti { get; set; }
        public string IdFirma { get; set; }
        public string Model { get; set; }
        public bool EsteDisponibila { get; set; }
        public Culoare CuloareMasina { get; set; }
        public List<string> OptiuniMasina { get; set; } // Changed to List<string>

        // Constructor for initializing the car.
        public Masina(string model, string culoareMasina, List<string> optiuniMasina)
        {
            Id = Guid.NewGuid().ToString();
            Model = model;
            EsteDisponibila = true;
            CuloareMasina = ParseCuloare(culoareMasina);
            OptiuniMasina = optiuniMasina;
        }

        // Deserialize constructor
        [JsonConstructor]
        public Masina(string id, List<Client> idClienti, string idFirma, string model, bool esteDisponibila, Culoare culoareMasina, List<string> optiuniMasina)
        {
            Id = id;
            IdClienti = idClienti;
            IdFirma = idFirma;
            Model = model;
            EsteDisponibila = esteDisponibila;
            CuloareMasina = culoareMasina;
            OptiuniMasina = optiuniMasina;
        }

        // Helper method to parse string to Culoare enum
        private Culoare ParseCuloare(string culoareString)
        {
            if (Enum.TryParse<Culoare>(culoareString, true, out Culoare culoare))
            {
                return culoare;
            }
            else
            {
                throw new ArgumentException("Invalid culoareMasina value");
            }
        }

        // Method to convert list of Optiuni enums to list of strings
        public List<string> GetOptiuniAsStrings()
        {
            return OptiuniMasina; // No need to convert
        }

        public override string ToString()
        {
            return $"ID masina: {Id}, ID firma: {IdFirma}, Model: {Model}, Disponibila: {(EsteDisponibila ? "Da" : "Nu")}, Culoare: {CuloareMasina}, Optiunii: {string.Join(", ", GetOptiuniAsStrings())}";
        }

        public static void WriteToFile(List<Masina> masini, string fileName)
        {
            string json = JsonConvert.SerializeObject(masini);
            File.WriteAllText(fileName, json);
        }

        public static void AppendToFile(Masina masina, string fileName)
        {
            List<Masina> masini = ReadFromFile(fileName);
            masini.Add(masina);
            WriteToFile(masini, fileName);
        }

        public static List<Masina> ReadFromFile(string fileName)
        {
            List<Masina> masini = new List<Masina>();

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                masini = JsonConvert.DeserializeObject<List<Masina>>(json);
            }

            return masini;
        }
    }
}
