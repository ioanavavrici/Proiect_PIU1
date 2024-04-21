using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Culoare CuloareMasina {  get; set; }
        public Optiuni OptiuniMasian { get; set; } 
        int c;

        // Constructor pentru inițializarea mașinii.
        public Masina(string model,  Culoare culoareMasina, Optiuni optiuniMasian,string _IdFirma)
        {
            Id = Guid.NewGuid().ToString();
            IdFirma = _IdFirma;
            Model = model;
            EsteDisponibila = true;
            CuloareMasina = culoareMasina;
            OptiuniMasian = optiuniMasian;
        }
        public override string ToString()
        {
            return $"ID masina: {Id},ID firma: {IdFirma}, Model: {Model}, Disponibila: {(EsteDisponibila ? "Da" : "Nu")}, Culoare: {CuloareMasina},Optiunii: {OptiuniMasian}";
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
