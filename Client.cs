using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public string IdMasina { get; set; }
        public string CNP { get; set; }

        public string Parola { get; set; }
        public string IdFirma {  get; set; }

        public DateTime data {  get; set; }

        // Constructor pentru inițializarea unui client.
        public Client(string nume, string prenume, string cnp, string parola,  DateTime data)
        {
            Id = Guid.NewGuid().ToString();
            Nume = nume;
            Prenume = prenume;
            CNP = cnp;
            Parola = parola;
            this.data = data;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Nume: {Nume}, Prenume: {Prenume}, CNP: {CNP}";
        }
        public static void WriteToFile(List<Client> clienti, string fileName)
        {
            string json = JsonConvert.SerializeObject(clienti);
            File.WriteAllText(fileName, json);
        }
        public static void AppendToFile(Client client, string fileName)
        {
            List<Client> clienti = ReadFromFile(fileName);
            clienti.Add(client);
            WriteToFile(clienti, fileName);
        }

        // Functie pentru citirea listei de angajati dintr-un fisier
        public static List<Client> ReadFromFile(string fileName)
        {
            List<Client> clienti = new List<Client>();

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                clienti = JsonConvert.DeserializeObject<List<Client>>(json);
            }

            return clienti;
        }
    }
}
