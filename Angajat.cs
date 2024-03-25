using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{
    public class Angajat
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Parola { get; set; }
        int c;

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
    }

}
