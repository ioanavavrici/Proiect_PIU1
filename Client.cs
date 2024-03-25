using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PIU
{

    public class Client
    {
        public string Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        int c;

        public string Parola { get; set; }

        // Constructor pentru inițializarea unui client.
        public Client(string nume, string prenume, string cnp, string parola)
        {
            Id = Guid.NewGuid().ToString();
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            Parola = parola;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Nume: {Nume}, Prenume: {Prenume}, CNP: {CNP}";
        }
    }
}
