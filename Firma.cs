using System.Collections.Generic;

namespace Proiect_PIU
{
    public class Firma
    {
        public string Id { get; set; }
        public string NumeFirma { get; set; }
        public List<Masina> MasiniDetinute { get; set; }

        int c;
        // Constructor pentru inițializarea unei firme.
        public Firma(string nume)
        {
            Id = System.Guid.NewGuid().ToString();
            NumeFirma = nume;
            MasiniDetinute = new List<Masina>();
        }

        // Metodă pentru adăugarea unei mașini în lista deținută de firmă.
        public void AdaugaMasina(Masina masina)
        {
            MasiniDetinute.Add(masina);
        }

        // Metodă pentru returnarea listei de mașini deținute de firmă.
        public List<Masina> ObtineMasiniDetinute()
        {
            return MasiniDetinute;
        }
        public override string ToString()
        {
            return $"Nume: {NumeFirma}, Numar masini detinute: {MasiniDetinute.Count}";
        }
    }
}
