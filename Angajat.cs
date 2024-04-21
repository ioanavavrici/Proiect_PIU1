using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Proiect_PIU
{
    public class Angajat
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Parola { get; set; }
        public string IDFirma {  get; set; }
      

        // Constructor pentru inițializarea unui angajat.
        public Angajat(string nume, string prenume, string parola)
        {
            Nume = nume;
            Prenume = prenume;
            Id = Guid.NewGuid().ToString();
            Parola = parola;
        }
    

        public override string ToString()
        {
            return $"Nume: {Nume}, Prenume: {Prenume}, Parola: {Parola}";
        }
        // Functie pentru scrierea listei de angajati intr-un fisier
        public static void WriteToFile(List<Angajat> angajati, string fileName)
        {
            string json = JsonConvert.SerializeObject(angajati);
            File.WriteAllText(fileName, json);
        }
        public static void AppendToFile(Angajat angajat, string fileName)
        {
            List<Angajat> angajati = ReadFromFile(fileName);
            angajati.Add(angajat);
            WriteToFile(angajati, fileName);
        }

        // Functie pentru citirea listei de angajati dintr-un fisier
        public static List<Angajat> ReadFromFile(string fileName)
        {
            List<Angajat> angajati = new List<Angajat>();

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                angajati = JsonConvert.DeserializeObject<List<Angajat>>(json);
            }

            return angajati;
        }

    }

}
