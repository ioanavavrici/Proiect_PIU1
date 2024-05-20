using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms; // Add this for Form
using Newtonsoft.Json;

namespace Proiect_PIU
{
    internal class Program
    {
        public static List<Firma> RefreshFirma()
        {
            return Firma.ReadFromFile("firma.json");
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Firma_Login());
           /* Console.WriteLine("Meniu:");
            Console.WriteLine("1. Afisare meniu consola");
            Console.WriteLine("2. Lansare Form1");
            Console.WriteLine("3. Iesire");

            Console.Write("Alegeti optiunea: ");
            string optiune = Console.ReadLine();

            switch (optiune)
            {
                case "1":
                    RunConsoleMenu();
                    break;
                case "2":
                    Application.Run(new Firma_Login());
                    break;
                case "3":
                    Console.WriteLine("Program incheiat.");
                    return;
                default:
                    Console.WriteLine("Optiune invalida.");
                    break;
            }
        }

        static void RunConsoleMenu()
        {
            List<Masina> masini = new List<Masina>();
            List<Firma> firma = new List<Firma>();
            firma = Firma.ReadFromFile("firma.json");
            List<Angajat> angajati = new List<Angajat>();
            angajati = Angajat.ReadFromFile("angajati.json");
            masini = Masina.ReadFromFile("masini.json");
            List<Client> client = new List<Client>();
            client = Client.ReadFromFile("client.json");

            while (true)
            {
                Console.WriteLine("Meniu:");
                Console.WriteLine("1. Adaugare firma");
                Console.WriteLine("2. Adaugare masina");
                Console.WriteLine("3. Adaugare angajat");
                Console.WriteLine("4. Adaugare client");
                Console.WriteLine("5. Afisare masini");
                Console.WriteLine("6. Afisare firme");
                Console.WriteLine("7. Afisare angajati");
                Console.WriteLine("8. Afisare clienti");
                Console.WriteLine("9. Cautare masina dupa anul de fabricatie");
                Console.WriteLine("10. Citire cuvinte in fisier si stocarea lor intr-un tablou in scara");
                Console.WriteLine("11. Lansare Form1");
                Console.WriteLine("12. Iesire");

                Console.Write("Alegeti optiunea: ");
                string optiune = Console.ReadLine();

               /* switch (optiune)
                {
                    case "2":
                        Console.WriteLine("Introduceti datele masinii:");
                        Console.WriteLine("Introduceti numele firmei");
                        string nume_firma = Console.ReadLine();
                        string id_firma = null;
                        int indfirma = 0;
                        foreach (var nume in firma)
                        {
                            if (nume.NumeFirma == nume_firma)
                            {
                                id_firma = nume.Id;
                                indfirma = firma.IndexOf(nume);
                                break;
                            }
                        }
                      /*  if (id_firma != null)
                        {
                            Console.Write("Model: ");
                            string model = Console.ReadLine();

                            Console.WriteLine("Introduceti culoarea masinii(Rosu,Alb,Negru,Verde,Albastru): ");
                            Culoare culoare;
                            while (!Enum.TryParse(Console.ReadLine(), true, out culoare))
                            {
                                Console.WriteLine("Introduceti o culaore valida");
                            }
                            Console.WriteLine("Introduceti optiunile masinii (AerConditionat/Navigatie/CutieAutomata):");
                            List<Optiuni>  optiuni = null;
                            int nr = 0;
                            foreach (string optiunee in Console.ReadLine().Split(','))
                            {
                                if (Enum.TryParse(optiunee.Trim(), true, out Optiuni optiuneEnum))
                                {
                                    optiuni[++nr] = optiuneEnum;
                                }
                            }
                            firma[indfirma].AdaugaMasina(new Masina(model, culoare.ToString(), optiuni.ToList()));
                            Masina masina = new Masina(model, culoare, optiuni);
                            masina.IdFirma= id_firma;
                            Firma.WriteToFile(firma, "firma.json");
                            Masina.AppendToFile(new Masina(model, culoare, optiuni), "masini.json");
                        }
                        else
                        {
                            Console.WriteLine("Nu ati introdus un nume de firma corect");
                        }
                        break;

                    case "1":
                        Console.WriteLine("Introduceti datele firmei:");
                        Console.Write("Nume: ");
                        string numeFirma = Console.ReadLine();
                        string parola=Console.ReadLine();
                        Firma.AppendToFile(new Firma(numeFirma,parola), "firma.json");
                        firma = RefreshFirma();
                        break;

                    case "3":
                        Console.WriteLine("Introduceti datele angajatului:");
                        Console.WriteLine("Introduceti numele firmei");
                        string nume_firma1 = Console.ReadLine();
                        id_firma = null;
                        indfirma = 0;
                        foreach (var nume in firma)
                        {
                            if (nume.NumeFirma == nume_firma1)
                            {
                                id_firma = nume.Id;
                                indfirma = firma.IndexOf(nume);
                                break;
                            }
                        }
                        if (id_firma != null)
                        {
                            Console.Write("Nume: ");
                            string numeAngajat = Console.ReadLine();

                            Console.Write("Prenume: ");
                            string prenumeAngajat = Console.ReadLine();

                            Console.Write("Parola: ");
                            string parola1 = Console.ReadLine();
                            firma[indfirma].AdaugaAngajat(new Angajat(numeAngajat, prenumeAngajat, parola1));
                            Firma.WriteToFile(firma, "firma.json");
                            Angajat.AppendToFile(new Angajat(numeAngajat, prenumeAngajat, parola1), "angajati.json");
                        }
                        else
                        {
                            Console.WriteLine("Nu ati introdus un nume de firma corect");
                        }
                        break;

                    case "4":
                        Console.WriteLine("Introduceti datele clientului:");
                        Console.Write("Nume: ");
                        string numeClient = Console.ReadLine();
                        Console.Write("Prenume: ");
                        string prenumeClient = Console.ReadLine();
                        Console.Write("CNP: ");
                        string cnpClient = Console.ReadLine();
                        Console.Write("Parola: ");
                        string parola2 = Console.ReadLine();
                        Client.AppendToFile(new Client(numeClient, prenumeClient, cnpClient, parola2), "client.json");
                        break;

                    case "5":
                        List<Masina> Masini = Masina.ReadFromFile("masini.json");
                        foreach (var masina in Masini)
                        {
                            Console.WriteLine(masina);
                        }
                        break;

                    case "6":
                        List<Firma> firme = Firma.ReadFromFile("firma.json");
                        foreach (var fir in firme)
                        {
                            Console.WriteLine(fir);
                        }
                        break;

                    case "7":
                        List<Angajat> angajatiCititi = Angajat.ReadFromFile("angajati.json");
                        foreach (var angajat1 in angajatiCititi)
                        {
                            Console.WriteLine(angajat1);
                        }
                        break;

                    case "8":
                        Console.WriteLine("Lista clientilor:");
                        List<Client> clienti_1 = Client.ReadFromFile("client.json");
                        foreach (var cli in clienti_1)
                        {
                            Console.WriteLine(cli);
                        }
                        break;

                    case "9":
                    case "10":
                        string file = "C:\\Users\\vavri\\Downloads\\Proiect_PIU\\Proiect_PIU\\PIU.txt";
                        Dictionary<char, List<string>> cuvintePeLitera = new Dictionary<char, List<string>>();
                        try
                        {
                            string[] linii = File.ReadAllLines(file);
                            foreach (string linia in linii)
                            {
                                string[] cuvinte = linia.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string cuvant in cuvinte)
                                {
                                    if (!string.IsNullOrEmpty(cuvant))
                                    {
                                        char primaL = cuvant[0];
                                        if (primaL == char.ToUpper(cuvant[0]))
                                            primaL = char.ToLower(primaL);
                                        if (!cuvintePeLitera.ContainsKey(primaL))
                                        {
                                            cuvintePeLitera[primaL] = new List<string>();
                                        }
                                        cuvintePeLitera[primaL].Add(cuvant);
                                    }
                                }
                            }
                            foreach (var i in cuvintePeLitera)
                            {
                                Console.WriteLine($"Cuvintele pentru litera '{i.Key}':");
                                foreach (string cuvant in i.Value)
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
                        Application.Run(new Form1());
                        break;

                    case "12":
                        Console.WriteLine("Program incheiat.");
                        return;

                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }*/
                Console.WriteLine();
            }
        }
    }
