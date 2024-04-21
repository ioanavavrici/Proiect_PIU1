using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class Form1 : Form
    {
        public List<Masina> masini = new List<Masina>();
        public List<Firma> firma = new List<Firma>();
        public List<Angajat> angajati = new List<Angajat>();
        public List<Client> client = new List<Client>();

        public Form1()
        {
            InitializeComponent();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            firma = Firma.ReadFromFile(Path.Combine(path, "firma.json"));
            angajati = Angajat.ReadFromFile(Path.Combine(path, "angajati.json"));
            masini = Masina.ReadFromFile(Path.Combine(path, "masini.json"));
            client = Client.ReadFromFile(Path.Combine(path, "client.json"));

            GetAngajatData();
            GetFirmaData();
            GetClientData();
            GetMasinaData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GetFirmaData()
        {
            dataGridViewFirme.Rows.Clear();
            dataGridViewFirme.Columns.Clear();

            // Add columns to DataGridView
            dataGridViewFirme.Columns.Add("Id", "Id");
            dataGridViewFirme.Columns.Add("NumeFirma", "NumeFirma");

            // Add data to DataGridView
            foreach (var firm in firma)
            {
                dataGridViewFirme.Rows.Add(firm.Id, firm.NumeFirma);
            }
        }

        private void GetAngajatData()
        {
            dataGridViewAngajati.Rows.Clear();
            dataGridViewAngajati.Columns.Clear();

            // Add columns to DataGridView
            dataGridViewAngajati.Columns.Add("Id", "Id");
            dataGridViewAngajati.Columns.Add("Nume", "Nume");
            dataGridViewAngajati.Columns.Add("Prenume", "Prenume");
            dataGridViewAngajati.Columns.Add("Parola", "Parola");

            // Add data to DataGridView
            foreach (var angajat in angajati)
            {
                dataGridViewAngajati.Rows.Add(angajat.Id, angajat.Nume, angajat.Prenume, angajat.Parola);
            }
        }
        private void GetClientData()
        {
            dataGridViewClienti.Rows.Clear();
            dataGridViewClienti.Columns.Clear();

            // Add columns to DataGridView
            dataGridViewClienti.Columns.Add("Id", "Id");
            dataGridViewClienti.Columns.Add("Nume", "Nume");
            dataGridViewClienti.Columns.Add("Prenume", "Prenume");
            dataGridViewClienti.Columns.Add("CNP", "CNP");
            dataGridViewClienti.Columns.Add("Parola", "Parola");

            // Add data to DataGridView
            foreach (var cli in client)
            {
                dataGridViewClienti.Rows.Add(cli.Id, cli.Nume, cli.Prenume, cli.CNP, cli.Parola);
            }
        }
        private void GetMasinaData()
        {
            dataGridViewMasini.Rows.Clear();
            dataGridViewMasini.Columns.Clear();

            // Add columns to DataGridView
            dataGridViewMasini.Columns.Add("Id", "Id");
            dataGridViewMasini.Columns.Add("Model", "Model");
            dataGridViewMasini.Columns.Add("Culoare", "Culoare");
            dataGridViewMasini.Columns.Add("Optiuni", "Optiuni");

            // Add data to DataGridView
            foreach (var masina in masini)
            {
                dataGridViewMasini.Rows.Add(masina.Id, masina.Model, masina.CuloareMasina, masina.OptiuniMasian);
            }
        }

    }
}
