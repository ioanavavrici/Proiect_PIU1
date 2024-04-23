using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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
            loadColors();
            loadObtions();  
            GetAngajatData();
            GetFirmaData();
            GetClientData();
            GetMasinaData();
            if(firma == null)
            {
                firma = new List<Firma>();
            }
            if(client==null)
            { client = new List<Client>(); }

            if(masini== null) { masini = new List<Masina>(); }

            if(angajati==null) { angajati = new List<Angajat>(); }  

            if(firma != null)
            {
                foreach (Firma firm in firma)
                {

                    comboBoxFirma.Items.Add(firm.NumeFirma);
                    comboBoxFirma_M.Items.Add(firm.NumeFirma);
                }
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GetFirmaData()
        {
            dataGridViewFirme.Rows.Clear();
            dataGridViewFirme.Columns.Clear();

            // Add columns to DataGridView
           
            dataGridViewFirme.Columns.Add("NumeFirma", "NumeFirma");
            if (firma == null)
            {
                return;
            }
            // Add data to DataGridView
            foreach (var firm in firma)
            {
                dataGridViewFirme.Rows.Add(firm.NumeFirma);
            }
        }

        private void GetAngajatData()
        {
            dataGridViewAngajati.Rows.Clear();
            dataGridViewAngajati.Columns.Clear();

            // Add columns to DataGridView
          
            dataGridViewAngajati.Columns.Add("Nume", "Nume");
            dataGridViewAngajati.Columns.Add("Prenume", "Prenume");
         
            if(angajati == null)
            {
                   return ;
            }
            // Add data to DataGridView
            foreach (var angajat in angajati)
            {
                dataGridViewAngajati.Rows.Add(angajat.Nume, angajat.Prenume);
            }
        }
        private void GetClientData()
        {
            dataGridViewClienti.Rows.Clear();
            dataGridViewClienti.Columns.Clear();

            // Add columns to DataGridView
           
            dataGridViewClienti.Columns.Add("Nume", "Nume");
            dataGridViewClienti.Columns.Add("Prenume", "Prenume");
            dataGridViewClienti.Columns.Add("CNP", "CNP");
           
            if (client == null) {  return ; }
            // Add data to DataGridView
            foreach (var cli in client)
            {
                dataGridViewClienti.Rows.Add(cli.Nume, cli.Prenume, cli.CNP);
            }
            foreach (DataGridViewColumn column in dataGridViewClienti.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        public void loadObtions()
        {
            checkedListBoxOptiuni.Items.Clear();
            foreach (var col in Enum.GetValues(typeof(Optiuni)).Cast<Optiuni>().ToList())
            {
               checkedListBoxOptiuni.Items.Add(col);
            }

        }
        private void loadColors()
        {
          
        comboBoxCuloare.Items.Clear();
        foreach(var col in Enum.GetValues(typeof(Culoare)).Cast<Culoare>().ToList())
            {
                comboBoxCuloare.Items.Add(col);
            }
        }
        private void GetMasinaData()
        {
            dataGridViewMasini.Rows.Clear();
            dataGridViewMasini.Columns.Clear();

            // Add columns to DataGridView
            dataGridViewMasini.Columns.Add("Model", "Model");
            dataGridViewMasini.Columns.Add("Culoare", "Culoare");
            dataGridViewMasini.Columns.Add("Optiuni", "Optiuni");

            if (masini == null)
            {
                return;
            }

            // Add data to DataGridView
            foreach (var masina in masini)
            {
                List<string> optiuni = masina.OptiuniMasina.ConvertAll(optiune => optiune.ToString()); // Convert List<Optiuni> to List<string>
                dataGridViewMasini.Rows.Add(masina.Model, masina.CuloareMasina, string.Join(", ", optiuni));
            }
            foreach (DataGridViewColumn column in dataGridViewMasini.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }


        private void txtNumeAngajat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAngajat_Click(object sender, EventArgs e)
        {
         
                string nume = txtNumeAngajat.Text;
                string prenume = txtPrenumeAngajat.Text;
                string parola = txtParolaAngajat.Text;
                if (comboBoxFirma.SelectedItem == null)
                {
                    MessageBox.Show("Firma neselectata");
                    return;
                }
                if (nume.Length == 0 ||  prenume.Length==0 || parola.Length==0)
                {
                    MessageBox.Show("Nu ati introdus toate datele pentru angajat");
                    return;
                }
            string selectedFirmaName = comboBoxFirma.SelectedItem.ToString();
            Firma selectedFirma = firma.FirstOrDefault(f => f.NumeFirma == selectedFirmaName);

            if (selectedFirma != null)
            {
                Angajat newAngajat = new Angajat(nume, prenume, parola);
                newAngajat.IDFirma = selectedFirma.Id;
                angajati.Add(newAngajat);
                Angajat.WriteToFile(angajati, "angajati.json");
                GetAngajatData(); // Refresh DataGridView
                firma[firma.IndexOf(selectedFirma)].AdaugaAngajat(newAngajat);
                Firma.WriteToFile(firma, "firma.json");
                foreach (DataGridViewColumn column in dataGridViewAngajati.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                txtNumeAngajat.Text = " ";
                txtPrenumeAngajat.Text = " ";
                txtParolaAngajat.Text = " ";
                comboBoxFirma.Items.Clear();

            }
       
        }

        private void comboBoxFirma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMasini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
       

        private void buttonAdaugare_Firma_Click(object sender, EventArgs e)
        {
            string numef = textBoxNum_Firma.Text;
            if(numef.Length==0)
            {
                MessageBox.Show("Nu ati introdus numele firmei");
                return;
            }
            firma.Add(new Firma(numef));
            Firma.WriteToFile(firma, "firma.json");
         //   Firma.AppendToFile(new Firma(numef),"firma.json");
            firma = Firma.ReadFromFile("firma.json");

            GetFirmaData();
            if (firma != null)
            {
                comboBoxFirma.Items.Clear();
                comboBoxFirma_M.Items.Clear();
                foreach (Firma firm in firma)
                {

                    comboBoxFirma.Items.Add(firm.NumeFirma);
                    comboBoxFirma_M.Items.Add(firm.NumeFirma);
                }
                textBoxNum_Firma.Text = " ";
            }
        }
        private void comboBoxFirma_M_Click()
        { 
        

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume= textBoxNum_Client.Text;
            string prenume = textBoxPrenume_Client.Text;
            string CNP = textBoxCNP.Text;
            string Parola = textBoxParolaC.Text;
            if(nume.Length==0 || prenume.Length==0 || CNP.Length==0 || Parola.Length==0)
            {
                MessageBox.Show("Nu ati introdus toate datele pentru client.");
                return;
            }
            if(CNP.Length>13 || CNP.Length<13)
            {
                MessageBox.Show("CNP nu are lungimea 13 ");
                return;
            }
          //  client.Add(new Client(nume, prenume, CNP, Parola));
            Client.WriteToFile(client, "client.json");
            Client.AppendToFile(new Client(nume, prenume, CNP, Parola), "client.json");
            client = Client.ReadFromFile("client.json");

            textBoxNum_Client.Text = " ";
            textBoxPrenume_Client.Text = " ";
            textBoxCNP.Text = " ";
            textBoxParolaC.Text =" ";
            GetClientData();

        }
       
        private void dataGridViewClienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCuloare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBoxFirma_M_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string marca = textBoxModel.Text;
            if (comboBoxCuloare.SelectedItem == null)
            {
                MessageBox.Show("Culoare neselectata");
                return;
            }
            string culoare = comboBoxCuloare.Text;

            if (marca.Length==0 )
            {
                MessageBox.Show("Nu ati introdus toate datele pentru masina");
                return;
            }
            List<string> list = new List<string>();

            if(checkedListBoxOptiuni.CheckedItems.Count==0)
            {
                MessageBox.Show("Nu ati selectat nicio optiune pentru masina");
            }
            foreach (var optiune in checkedListBoxOptiuni.CheckedItems)
            {
                list.Add(optiune.ToString());
            }

            if (comboBoxFirma_M.SelectedItem == null)
            {
                MessageBox.Show("Firma neselectata");
                return;
            }
            string selectedFirmaName = comboBoxFirma_M.SelectedItem.ToString();
            Firma selectedFirma = firma.FirstOrDefault(f => f.NumeFirma == selectedFirmaName);

            if (selectedFirma != null)
            {
                Masina newMasina = new Masina(marca, culoare, list);
                newMasina.IdFirma = selectedFirma.Id;

                masini.Add(newMasina);
                Masina.WriteToFile(masini, "masini.json");
                GetMasinaData(); // Refresh DataGridView

                selectedFirma.AdaugaMasina(newMasina);
                Firma.WriteToFile(firma, "firma.json");
                textBoxModel.Text= " ";
                checkedListBoxOptiuni.Items.Clear();
                loadObtions();

               

            }
            else
            {
                MessageBox.Show("Select a firm for the car.");
            }
        }

        private void dataGridViewAngajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
