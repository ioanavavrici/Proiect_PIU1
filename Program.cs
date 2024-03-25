using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace Proiect_PIU
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxMasini = 100;
            Masina[] masini = new Masina[MaxMasini];
            int numarMasini = 0;

            const int MaxFirme = 50;
            Firma[] firme = new Firma[MaxFirme];
            int numarFirme = 0;


            const int MaxAngajati = 200;
            Angajat[] angajati = new Angajat[MaxAngajati];
            int numarAngajati = 0;

            const int MaxClienti = 200;
            Client[] clienti = new Client[MaxClienti];
            int numarClienti = 0;

            while (true)
            {
                Console.WriteLine("Meniu:");
                Console.WriteLine("1. Adaugare masina");
                Console.WriteLine("2. Adaugare firma");
                Console.WriteLine("3. Adaugare angajat");
                Console.WriteLine("4. Adaugare client");
                Console.WriteLine("5. Afisare masini");
                Console.WriteLine("6. Afisare firme");
                Console.WriteLine("7. Afisare angajati");
                Console.WriteLine("8. Afisare clienti");
                Console.WriteLine("9. Cautare masina dupa anul de fabricatie");
                Console.WriteLine("10.Citire cuvinte in fisier si stocarea lor intr-un tablou in scara");
                Console.WriteLine("11 Iesire");

                Console.Write("Alegeti optiunea: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        if (numarMasini < MaxMasini)
                        {
                            Console.WriteLine("Introduceti datele masinii:");

                            Console.Write("Model: ");
                            string model = Console.ReadLine();

                            Console.Write("An fabricatie: ");
                            int anFabricatie = int.Parse(Console.ReadLine());

                            Console.WriteLine("Introduceti culoarea masinii(Rosu,Alb,Negru,Verde,Albastru): ");
                            Culoare culoare;
                            while (!Enum.TryParse(Console.ReadLine(), true, out culoare))
                            {
                                Console.WriteLine("Introduceti o culaore valida");
                            }
                            Console.WriteLine("Introduceti optiunile masinii (AerConditionat/Navigatie/CutieAutomata):");
                            Optiuni optiuni = 0;
                            foreach (string optiunee in Console.ReadLine().Split(','))
                            {
                                if(Enum.TryParse(optiunee.Trim(),true,out Optiuni optiuneEnum))
                                {
                                    optiuni |= optiuneEnum;
                                }
                            }
                            masini[numarMasini] = new Masina(model, anFabricatie,culoare,optiuni);
                            numarMasini++;
                        }
                        else
                        {
                            Console.WriteLine("Numarul maxim de masini a fost atins.");
                        }
                        break;

                    case "2":
                        if (numarFirme < MaxFirme)
                        {
                            Console.WriteLine("Introduceti datele firmei:");

                            Console.Write("Nume: ");
                            string numeFirma = Console.ReadLine();

                            Console.Write("Adresa: ");
                            string adresaFirma = Console.ReadLine();

                            Console.Write("Numar angajati: ");
                            int numarAngajatiFirma = int.Parse(Console.ReadLine());

                            firme[numarFirme] = new Firma(numeFirma);
                            numarFirme++;
                        }
                        else
                        {
                            Console.WriteLine("Numarul maxim de firme a fost atins.");
                        }
                        break;

                    case "3":
                        if (numarAngajati < MaxAngajati)
                        {
                            Console.WriteLine("Introduceti datele angajatului:");

                            Console.Write("Nume: ");
                            string numeAngajat = Console.ReadLine();

                            Console.Write("Prenume: ");
                            string prenumeAngajat = Console.ReadLine();

                            Console.Write("Parola: ");
                            string parola = Console.ReadLine();

                            angajati[numarAngajati] = new Angajat(numeAngajat, prenumeAngajat, parola);
                            numarAngajati++;
                        }
                        else
                        {
                            Console.WriteLine("Numarul maxim de angajati a fost atinsa.");
                        }
                        break;

                    case "4":
                        if (numarClienti < MaxClienti)
                        {
                            Console.WriteLine("Introduceti datele clientului:");

                            Console.Write("Nume: ");
                            string numeClient = Console.ReadLine();

                            Console.Write("Prenume: ");
                            string prenumeClient = Console.ReadLine();

                            Console.Write("CNP: ");
                            string cnpClient = Console.ReadLine();
                            Console.Write("Parola: ");
                            string parola = Console.ReadLine();

                            clienti[numarClienti] = new Client(numeClient, prenumeClient, cnpClient, parola);
                            numarClienti++;
                        }
                        else
                        {
                            Console.WriteLine("Numarul maxim de clienti a fost atins.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Lista masinilor:");
                        for (int i = 0; i < numarMasini; i++)
                        {
                            Console.WriteLine($"Masina {i + 1}: {masini[i]}");
                        }
                        break;

                    case "6":
                        Console.WriteLine("Lista firmelor:");
                        for (int i = 0; i < numarFirme; i++)
                        {
                            Console.WriteLine($"Firma {i + 1}: {firme[i]}");
                        }
                        break;

                    case "7":
                        Console.WriteLine("Lista angajatilor:");
                        for (int i = 0; i < numarAngajati; i++)
                        {
                            Console.WriteLine($"Angajatul {i + 1}: {angajati[i]}");
                        }
                        break;

                    case "8":
                        Console.WriteLine("Lista clientilor:");
                        for (int i = 0; i < numarClienti; i++)
                        {
                            Console.WriteLine($"Clientul {i + 1}: {clienti[i]}");
                        }
                        break;

                    case "9":
                        Console.Write("Introduceți anul de fabricatie pentru cautare: ");
                        int anCautat = int.Parse(Console.ReadLine());

                        bool gasita = false;
                        for (int i = 0; i < numarMasini; i++)
                        {
                            if (masini[i].AnFabricatie == anCautat)
                            {
                                Console.WriteLine($"Masina gsasita: {masini[i]}");
                                gasita = true;
                            }
                        }

                        if (!gasita)
                        {
                            Console.WriteLine("Nu a fost gasita nicio masina pentru anul specificat.");
                        }
                        break;
                    case "10":
                        string file = "C:\\Users\\vavri\\Downloads\\Proiect_PIU\\Proiect_PIU\\PIU.txt"; 
                        Dictionary<char,List<string>> cuvintePeLitera= new Dictionary<char,List<string>>();
                        try
                        {
                            string[] linii = File.ReadAllLines(file);
                            foreach(string linia in linii)
                            {
                                string[] cuvinte=linia.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                                foreach(string cuvant in cuvinte)
                                {
                                    if(!string.IsNullOrEmpty(cuvant))
                                    {
                                        char primaL = cuvant[0];
                                        if (primaL == char.ToUpper(cuvant[0]))
                                            primaL = char.ToLower(primaL);
                                        if(!cuvintePeLitera.ContainsKey(primaL))
                                        {
                                            cuvintePeLitera[primaL]=new List<string>();

                                        }
                                        cuvintePeLitera[primaL].Add(cuvant);
                                    }
                                }
                            }
                            foreach(var i in cuvintePeLitera)
                            {
                                Console.WriteLine($"Cuvintele pentru litera '{i.Key}':");
                                foreach(string cuvant in i.Value)
                                {
                                    Console.WriteLine(cuvant);
                                }
                                Console.WriteLine();
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("A apărut o excepție: " + e.Message);
                        }
                    
                            break;

                    case "11":
                        Console.WriteLine("Program incheiat.");
                        return;

                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}

