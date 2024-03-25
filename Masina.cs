using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    public class Masina
    {
        public string Id { get; set; }
        public string IdFirma { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public bool EsteDisponibila { get; set; }
        int c;

        // Constructor pentru inițializarea mașinii.
        public Masina(string model, int an)
        {
            Id = Guid.NewGuid().ToString();
            Model = model;
            AnFabricatie = an;
            EsteDisponibila = true;
        }
        public override string ToString()
        {
            return $"ID masina: {Id},ID firma: {IdFirma}, Model: {Model}, An: {AnFabricatie}, Disponibila: {(EsteDisponibila ? "Da" : "Nu")}";
        }
    }
}
