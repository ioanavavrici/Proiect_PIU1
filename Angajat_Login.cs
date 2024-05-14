using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class Angajat_Login : Form
    {
        public List<Angajat> angajati = new List<Angajat>();
        public List<Firma> firma = new List<Firma>();
        public Firma firma_;
        public string id_firma;
        public Angajat_Login(string Id_Firma)
        {
            InitializeComponent();
            id_firma = Id_Firma;
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            angajati = Angajat.ReadFromFile(Path.Combine(path, "angajati.json"));
            firma = Firma.ReadFromFile(Path.Combine(path, "firma.json"));

            if (angajati == null)
            { 
                angajati = new List<Angajat>(); 
            }
            foreach (Firma firm in firma)
            {
                if (firm.Id == Id_Firma)
                {
                    firma_ = firm;

                    break;
                }
            }
            textBoxMesajEroare.Visible = false;

        }

        private void txtNumeAngajat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtParolaAngajat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenumeAngajat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = txtNumeAngajat.Text;
            string prenume = txtPrenumeAngajat.Text;
            string parola = txtParolaAngajat.Text;
            if (nume.Length == 0 || prenume.Length == 0 || parola.Length == 0)
            {
                MessageBox.Show("Nu ati introdus toate datele pentru angajat");
                return;
            }
            foreach (Angajat a in angajati)
            {

                if (a.Prenume == prenume && a.Nume == nume && a.IDFirma == id_firma && a.Parola == parola)
                {
                    textBoxMesajEroare.Text = "Aveti deja un cont";
                    textBoxMesajEroare.Visible = true;
                    return;
                }

            }
            Angajat newAngajat = new Angajat(nume, prenume, parola);
            newAngajat.IDFirma = id_firma;
            angajati.Add(newAngajat);
            Angajat.WriteToFile(angajati, "angajati.json");
            
            firma_.AdaugaAngajat(newAngajat);
            Firma.WriteToFile(firma, "firma.json");
            txtNumeAngajat.Clear();
            txtPrenumeAngajat.Clear();
            txtParolaAngajat.Clear();
            Form1 aplicatie = new Form1(id_firma);
            aplicatie.Show();
            this.Hide();
        }
        

        private void Angajat_Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string nume = txtNumeAngajat.Text;
            string prenume = txtPrenumeAngajat.Text;
            string parola = txtParolaAngajat.Text;
            if (nume.Length == 0 || prenume.Length == 0 || parola.Length == 0)
            {
                textBoxMesajEroare.Text = "Nu ati introdus toate datele necesare";
                textBoxMesajEroare.Visible = true;
                return;
            }
            if(parola.Length<8)
            {
                textBoxMesajEroare.Text = "Parola trebuie sa aiba cel putin 8 caractere";
                textBoxMesajEroare.Visible = true;
                return;
            }
            foreach(Angajat a in angajati)
            {
              
                if(a.Prenume==prenume && a.Nume == nume && a.IDFirma==id_firma && a.Parola==parola)
                {
                    Form1 aplicatie = new Form1(id_firma);
                    aplicatie.Show();
                    this.Hide();
                    break;
                }
                
            }
            if(this.Visible==true)
            {
                textBoxMesajEroare.Text = "Nu exista un angajat cu aceste date";
                textBoxMesajEroare.Visible = true;
                return;
            }
           

            Angajat newAngajat = new Angajat(nume, prenume, parola);
            newAngajat.IDFirma = id_firma;
            angajati.Add(newAngajat);
            Angajat.WriteToFile(angajati, "angajati.json");

            firma_.AdaugaAngajat(newAngajat);
            Firma.WriteToFile(firma, "firma.json");
            txtNumeAngajat.Clear();
            txtPrenumeAngajat.Clear();
            txtParolaAngajat.Clear();
        }
    }
}
