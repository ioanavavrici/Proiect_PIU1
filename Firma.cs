using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Proiect_PIU
{
    public class Firma
    {
        public string Id { get; set; }
        public string NumeFirma { get; set; }
        public List<Masina> MasiniDetinute { get; set; }

        public List<Angajat> IdAngajat {  get; set; }
        int c;
        // Constructor pentru inițializarea unei firme.
        public Firma(string nume)
        {
            Id = System.Guid.NewGuid().ToString();
            NumeFirma = nume;
            MasiniDetinute = new List<Masina>();
            IdAngajat = new List<Angajat>();

        }

        // Metodă pentru adăugarea unei mașini în lista deținută de firmă.
        public void AdaugaMasina(Masina masina)
        {
            MasiniDetinute.Add(masina);
        }
        public void AdaugaAngajat(Angajat angajat) 
        {  
            IdAngajat.Add(angajat);
        }

        // Metodă pentru returnarea listei de mașini deținute de firmă.
        public List<Masina> ObtineMasiniDetinute()
        {
            return MasiniDetinute;
        }
        public List <Angajat>OtineAngajati()
        { return IdAngajat; 
        }
        public override string ToString()
        {
            return $"Nume: {NumeFirma}, Numar masini detinute: {MasiniDetinute.Count}";
        }

        public static void WriteToFile(List<Firma> firma, string fileName)
        {
            string json = JsonConvert.SerializeObject(firma);
            File.WriteAllText(fileName, json);
        }
        public static void AppendToFile(Firma firma, string fileName)
        {
            List<Firma> firme = ReadFromFile(fileName);
            firme.Add(firma);
            WriteToFile(firme, fileName);
        }

        // Functie pentru citirea listei de angajati dintr-un fisier
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
