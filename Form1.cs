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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class Form1 : Form
    {
        public List<Masina> masini = new List<Masina>();
        public List<Firma> firma = new List<Firma>();
        public Firma firma_;
        public List<Angajat> angajati = new List<Angajat>();
        public List<Client> client = new List<Client>();
        public string idfirma;
        public Form1(string idFirma)
        {
            InitializeComponent();
            this.idfirma = idFirma;
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            firma = Firma.ReadFromFile(Path.Combine(path, "firma.json"));
            angajati = Angajat.ReadFromFile(Path.Combine(path, "angajati.json"));
            masini = Masina.ReadFromFile(Path.Combine(path, "masini.json"));
            client = Client.ReadFromFile(Path.Combine(path, "client.json"));
          
            if(client==null)
            { client = new List<Client>(); }

            if(masini== null) 
            { masini = new List<Masina>(); }

            if(angajati==null)
            { angajati = new List<Angajat>(); } 
            
            if(firma == null)
            {
                firma = new List<Firma>();
            }

            foreach (Firma firm in firma)
            {
                if (firm.Id == idFirma)
                {
                    firma_ = firm;
                 
                    break;
                }
            }
            loadColors();
            loadObtions();  
          
            GetClientData();
            GetMasinaData();
            grupBoxMasina.Visible = false;
            groupBoxClient.Visible = false;
            labelMesajEroare1.Visible = false;
            labelMesajEroare2.Visible = false;
            labelMesajEroare3.Visible = false;
            labelMesajEroare4.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            dataGridViewMasini.Columns.Add("Id", "Id");
            dataGridViewMasini.Columns.Add("Model", "Model");
            dataGridViewMasini.Columns.Add("Culoare", "Culoare");
            dataGridViewMasini.Columns.Add("Optiuni", "Optiuni");
            dataGridViewMasini.Columns.Add("Pret", "Pret");
            dataGridViewMasini.Columns[0].Visible = false;

            if (masini == null)
            {
                return;
            }

            // Add data to DataGridView
            foreach (var masina in masini)
            {
                List<string> optiuni = masina.OptiuniMasina.ConvertAll(optiune => optiune.ToString()); // Convert List<Optiuni> to List<string>
                dataGridViewMasini.Rows.Add(masina.Id,masina.Model, masina.CuloareMasina, string.Join(", ", optiuni) ,masina.Pret);
            }
            foreach (DataGridViewColumn column in dataGridViewMasini.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            grupBoxMasina.Visible = false;
           
        }


        private void txtNumeAngajat_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBoxFirma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMasini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grupBoxMasina.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
            DateTime data = dateTimePicker1.Value;
            Client client_ = new Client(nume, prenume, CNP, Parola, data);
          

            
                
                client_.IdFirma = idfirma;

                client.Add(client_);
                Masina.WriteToFile(masini, "masini.json");
                GetMasinaData(); // Refresh DataGridView
                loadObtions();



            
           
          //  client.Add(new Client(nume, prenume, CNP, Parola));
            Client.WriteToFile(client, "client.json");
            Client.AppendToFile(client_, "client.json");
            client = Client.ReadFromFile("client.json");

            textBoxNum_Client.Clear();
            textBoxPrenume_Client.Clear();
            textBoxCNP.Clear();
            textBoxParolaC.Clear();
            GetClientData();
          
            groupBoxClient.Visible = false;
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
                return ;
            }
            foreach (var optiune in checkedListBoxOptiuni.CheckedItems)
            {
                list.Add(optiune.ToString());
            }

           
            float pret; 
            float.TryParse( txtBoxPret.Text,out pret);
           

           

                Masina newMasina = new Masina(marca, culoare, list,pret);
                 newMasina.IdFirma = idfirma;

                masini.Add(newMasina);
                Masina.WriteToFile(masini, "masini.json");
                GetMasinaData(); // Refresh DataGridView

                firma_.AdaugaMasina(newMasina);
                Firma.WriteToFile(firma, "firma.json");
                textBoxModel.Clear();
                checkedListBoxOptiuni.Items.Clear();
                loadObtions();

               

            
           
        }

        private void dataGridViewAngajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewFirme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxNum_Firma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxParolaF_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrenume_Client_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxParolaC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void grupBoxMasina_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxClient_Enter(object sender, EventArgs e)
        {

        }

        private void buttonStergereMasina_Click(object sender, EventArgs e)
        {
           
            if (dataGridViewMasini.SelectedRows.Count == 1)
            {
                string masinaid = dataGridViewMasini.SelectedRows[0].Cells[0].Value.ToString();
                foreach(Masina m in masini)
                {
                    if(m.Id == masinaid)
                    {
                       masini.Remove(m);
                       firma_.MasiniDetinute.Remove(m);
                        labelMesajEroare3.Text = "Masina a fost stearsa";
                        labelMesajEroare3.Visible = true;
                       break;
                    }
                }
               
            }
            else
            {
                labelMesajEroare3.Text = "Nu ati selectat masina pe care doriti sa o stergeti ";
                labelMesajEroare3.Visible= true;
            }
            Firma.WriteToFile(firma, "firma.json");
            Masina.WriteToFile(masini, "masini.json");
            GetMasinaData(); 
           
                 

        }

        private void buttonActualizareMasina_Click(object sender, EventArgs e)
        {  
            loadColors();
            comboBoxCuloare.SelectedText = "";
            comboBoxCuloare.SelectedIndex = -1;

            button1.Visible = false;
            buttonActualizareDateM.Visible = true ;
            grupBoxMasina.Visible = true;
            if (dataGridViewMasini.SelectedRows.Count == 1)
            {
                string masinaid = dataGridViewMasini.SelectedRows[0].Cells[0].Value.ToString();
                foreach (Masina m in masini)
                {
                    if (m.Id == masinaid)
                    {
                        txtBoxPret.Text = m.Pret.ToString();
                        textBoxModel.Text = m.Model;
                        foreach(var cul in comboBoxCuloare.Items)
                        {
                            if(cul.ToString() == m.CuloareMasina.ToString())
                            {
                                // MessageBox.Show(cul.ToString());
                                comboBoxCuloare.Text = "";
                                comboBoxCuloare.SelectedText = cul.ToString();
                                break;
                            }
                        }
                        foreach(var opti in m.OptiuniMasina)
                        {

                            for(int i=0; i< checkedListBoxOptiuni.Items.Count;i++)
                            {
                                if (checkedListBoxOptiuni.Items[i].ToString() == opti.ToString())
                                {
                                    checkedListBoxOptiuni.SetItemChecked(i, true);
                                }
                            }
                           
                        }

                        break;

                    }
                }

            }
            else
            {
                labelMesajEroare3.Text = "Nu ati selectat masina pe care doriti sa o actualizati ";
                labelMesajEroare3.Visible = true;
            }
            checkedListBoxOptiuni.SelectedItems.Clear();
           

        }

        private void textBoxMesajEroareMasina_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStergeClient_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizareClient_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMesajEroare2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddMasina_Click(object sender, EventArgs e)
        {
            buttonActualizareDateM.Visible = false;
            button1.Visible = true;
            grupBoxMasina.Visible = true;
        }

        private void Add_Client_Click(object sender, EventArgs e)
        {
            groupBoxClient.Visible = true;
        }

        private void buttonActualizareDateM_Click(object sender, EventArgs e)
        { 
            float pret;
            float.TryParse( txtBoxPret.Text,out pret); 
            string model =textBoxModel.Text;
            List<string> optiuni = new List<string>();
            string culoare = comboBoxCuloare.Text;
            foreach (var optiune in checkedListBoxOptiuni.CheckedItems)
             {
                optiuni.Add(optiune.ToString());
             }
            string masinaid = dataGridViewMasini.SelectedRows[0].Cells[0].Value.ToString();
            foreach (Masina m in masini)
            {
                if (m.Id == masinaid)
                {
                 m.Pret = pret;
                 m.Model = model;
                 m.CuloareMasina = m.ParseCuloare(culoare);
                 m.OptiuniMasina = optiuni;
                    break;
                }
            }
           
           labelMesajEroare3.Text = "Datele despre masina au fost actualizate ";
           labelMesajEroare3.Visible = true;
            Firma.WriteToFile(firma, "firma.json");
            Masina.WriteToFile(masini, "masini.json");
            GetMasinaData();

        }
    }
}
