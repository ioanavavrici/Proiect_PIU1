using System;
using System.Collections.Generic;
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
        public string IdFirma { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public bool EsteDisponibila { get; set; }
        public Culoare CuloareMasina {  get; set; }
        public Optiuni OptiuniMasian { get; set; } 
        int c;

        // Constructor pentru inițializarea mașinii.
        public Masina(string model, int an, Culoare culoareMasina, Optiuni optiuniMasian)
        {
            Id = Guid.NewGuid().ToString();
            Model = model;
            AnFabricatie = an;
            EsteDisponibila = true;
            CuloareMasina = culoareMasina;
            OptiuniMasian = optiuniMasian;
        }
        public override string ToString()
        {
            return $"ID masina: {Id},ID firma: {IdFirma}, Model: {Model}, An: {AnFabricatie}, Disponibila: {(EsteDisponibila ? "Da" : "Nu")}, Culoare: {CuloareMasina},Optiunii: {OptiuniMasian}";
        }
    }
}
