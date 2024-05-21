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
            dataGridViewClienti.Columns.Add("Id", "Id");
            dataGridViewClienti.Columns[0].Visible = false;
            dataGridViewClienti.Columns.Add("Nume", "Nume");
            dataGridViewClienti.Columns.Add("Prenume", "Prenume");
            dataGridViewClienti.Columns.Add("CNP", "CNP");
            dataGridViewClienti.Columns.Add("Data inchiriere","Data inchiriere");
            dataGridViewClienti.Columns.Add("Data returnare", "Data returnare");



            if (client == null) {  return ; }
            // Add data to DataGridView
            foreach (var cli in client)
            {
                if(cli.IdFirma==idfirma)
                {
                    dataGridViewClienti.Rows.Add(cli.Id,cli.Nume, cli.Prenume, cli.CNP,cli.data_Inceput,cli.data_Final); 
                }
                
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
            dataGridViewMasini.Columns.Add("Date ocupate","Date");
            dataGridViewMasini.Columns[0].Visible = false;

            if (masini == null)
            {
                return;
            }

            // Add data to DataGridView
            foreach (var masina in masini)
            {
                if (masina.IdFirma == idfirma)
                {
                    List<string> optiuni = masina.OptiuniMasina.ConvertAll(optiune => optiune.ToString()); // Convert List<Optiuni> to List<string>
                    if (masina.date != null)
                    {
                        var allDates = masina.date.Values.SelectMany(dates => dates).ToList();


                        var allDatesAsString = allDates.ConvertAll(date => date.ToString("yyyy-MM-dd"));


                        string datesString = string.Join(", ", allDatesAsString);


                        dataGridViewMasini.Rows.Add(masina.Id, masina.Model, masina.CuloareMasina, string.Join(", ", optiuni), masina.Pret, datesString);
                    }
                    else
                        dataGridViewMasini.Rows.Add(masina.Id, masina.Model, masina.CuloareMasina, string.Join(", ", optiuni), masina.Pret, masina.date);
                }
            }
            

            grupBoxMasina.Visible = false;
           
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
            DateTime datai = dateTimePicker1.Value;
            DateTime dataf = dateTimePicker2.Value;
            if(dataf<=datai)
            {
                labelMesajEroare4.Text = "Data de inchiriere nu poate fi mai mare sau egala ca data de returnare ";
                labelMesajEroare4.Visible = true;
                return;
            }
            Client client_ = new Client(nume, prenume, CNP, Parola, datai,dataf);
          

            
                
                client_.IdFirma = idfirma;

                client.Add(client_);
                Masina.WriteToFile(masini, "masini.json");
                GetMasinaData(); // Refresh DataGridView
                loadObtions();
          //  client.Add(new Client(nume, prenume, CNP, Parola));
            Client.WriteToFile(client, "client.json");
         
            client = Client.ReadFromFile("client.json");

            textBoxNum_Client.Clear();
            textBoxPrenume_Client.Clear();
            textBoxCNP.Clear();
            textBoxParolaC.Clear();
            GetClientData();

            labelMesajEroare4.Visible = false;
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
                // Refresh DataGridView

                firma_.AdaugaMasina(newMasina.Id);
                Firma.WriteToFile(firma, "firma.json");
                textBoxModel.Clear();
                txtBoxPret.Clear();
                checkedListBoxOptiuni.Items.Clear();
                comboBoxCuloare.Text = "";
               
                GetMasinaData();
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
                       firma_.MasiniDetinute.Remove(m.Id);
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
            button1.Visible = false;
            buttonActualizareDateM.Visible = true ;
            if (dataGridViewMasini.SelectedRows.Count == 1)
            {
                grupBoxMasina.Visible = true;

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
            groupBoxClient.Visible = false;
            if (dataGridViewClienti.SelectedRows.Count == 1)
            {
                string clientid = dataGridViewClienti.SelectedRows[0].Cells[0].Value.ToString();
                foreach (Client c in client)
                {
                    if (c.Id == clientid)
                    {
                        client.Remove(c);
                        firma_.Client.Remove(c.Id);
                        labelMesajEroare4.Text = "Clientul a fost sters";
                        labelMesajEroare4.Visible = true;
                        break;
                    }
                }

            }
            else
            {
                labelMesajEroare4.Text = "Nu ati selectat clientul pe care doriti sa o stergeti ";
                labelMesajEroare4.Visible = true;
            }
            Firma.WriteToFile(firma, "firma.json");
            Client.WriteToFile(client, "client.json");
            client = Client.ReadFromFile("client.json");
            GetClientData();
        }

        private void buttonActualizareClient_Click(object sender, EventArgs e)
        {

            buttonAdaugaClient.Visible = false;
            buttonAcClient.Visible = true;
            groupBoxClient.Visible = true;

            loadColors();
           
            if (dataGridViewClienti.SelectedRows.Count == 1)
            {
                string clientid = dataGridViewClienti.SelectedRows[0].Cells[0].Value.ToString();
                foreach (Client c in client)
                {
                    if (c.Id == clientid)
                    {
                        textBoxNum_Client.Text = c.Nume;
                        textBoxCNP.Text = c.CNP;
                        textBoxParolaC.Text = c.Parola;
                        textBoxPrenume_Client.Text = c.Prenume;
                        dateTimePicker1.Text = c.data_Inceput.ToString();
                        dateTimePicker2.Text = c.data_Final.ToString();
                        break;

                    }
                }

            }
            else
            {
                labelMesajEroare4.Text = "Nu ati selectat clientul pe care doriti sa o actualizati ";
                labelMesajEroare4.Visible = true;
            }
         

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
            buttonAcClient.Visible = false;
            buttonAdaugaClient.Visible=true;
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
            if (dataGridViewMasini.SelectedRows.Count == 1)
            {
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

                comboBoxCuloare.Text = "";
                txtBoxPret.Clear();
                textBoxModel.Clear();
                labelMesajEroare3.Text = "Datele despre masina au fost actualizate ";
                labelMesajEroare3.Visible = true;
                checkedListBoxOptiuni.Items.Clear();
                loadObtions();

                Firma.WriteToFile(firma, "firma.json");
                Masina.WriteToFile(masini, "masini.json");
                GetMasinaData();

            }
            else
            {
               // labelMesajEroare3.ForeColor = Color.Red;
                labelMesajEroare3.Text = "Nu ati selectat masina pe care doriti sa o actualizati ";
                labelMesajEroare3.Visible = true;
            }

        }

        private void buttonAcClient_Click(object sender, EventArgs e)
        {

            if (dataGridViewClienti.SelectedRows.Count == 1)
            {
                string clientid = dataGridViewClienti.SelectedRows[0].Cells[0].Value.ToString();
                foreach (Client c in client)
                {
                    if (c.Id == clientid)
                    {
                        c.Nume = textBoxNum_Client.Text;
                        c.Prenume=textBoxPrenume_Client.Text;
                        c.Parola=textBoxParolaC.Text;
                        c.CNP = textBoxCNP.Text;
                        c.data_Final = dateTimePicker2.Value;
                        c.data_Inceput=dateTimePicker1.Value;
                        if(c.data_Final<c.data_Inceput )
                        {
                            labelMesajEroare4.Text = "Data de inchiriere nu poate fi mai mare sau egala ca data de returnare ";
                            labelMesajEroare4.Visible = true;
                            return;
                        }
                        Client.WriteToFile(client, "client.json");
                        client = Client.ReadFromFile("client.json");
                        GetClientData();

                        break;

                    }
                }

            }
            else
            {
                labelMesajEroare4.Text = "Nu ati selectat clientul pe care doriti sa o actualizati ";
                labelMesajEroare4.Visible = true;
            } 
            groupBoxClient.Visible = false;
            textBoxNum_Client.Clear();
            textBoxPrenume_Client.Clear();
            textBoxParolaC.Clear();
            textBoxCNP.Clear();
            labelMesajEroare4.Visible=false;
          


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMasiniDisponibile.Checked) 
            {
                if (dataGridViewClienti.SelectedRows.Count == 1)
                {
                    string clientid = dataGridViewClienti.SelectedRows[0].Cells[0].Value.ToString();
                    string data_inchiriere = dataGridViewClienti.SelectedRows[0].Cells[4].Value.ToString();
                    string data_returnare = dataGridViewClienti.SelectedRows[0].Cells[5].Value.ToString();
                    dataGridViewMasini.Rows.Clear();
                    dataGridViewMasini.Columns.Clear();

                    // Add columns to DataGridView
                    dataGridViewMasini.Columns.Add("Id", "Id");
                    dataGridViewMasini.Columns.Add("Model", "Model");
                    dataGridViewMasini.Columns.Add("Culoare", "Culoare");
                    dataGridViewMasini.Columns.Add("Optiuni", "Optiuni");
                    dataGridViewMasini.Columns.Add("Pret", "Pret");
                    dataGridViewMasini.Columns.Add("Date ocupate", "Date");
                    dataGridViewMasini.Columns[0].Visible = false;

                    if (masini == null)
                    {
                        return;
                    }

                    // Add data to DataGridView
                    foreach (var masina in masini)
                    {
                        if (masina.IdFirma == idfirma)
                        {

                            List<string> optiuni = masina.OptiuniMasina.ConvertAll(optiune => optiune.ToString());
                            if (masina.date != null)
                            {
                                
                                    
                                
                                
                                    foreach (var d in masina.date)
                                    {
                                        DateTime.TryParse(data_returnare, out DateTime dr);
                                        if (d.Value[0] > dr)
                                        {
                                            var allDates = masina.date.Values.SelectMany(dates => dates).ToList();


                                            var allDatesAsString = allDates.ConvertAll(date => date.ToString("yyyy-MM-dd"));


                                            string datesString = string.Join(", ", allDatesAsString);


                                            dataGridViewMasini.Rows.Add(masina.Id, masina.Model, masina.CuloareMasina, string.Join(", ", optiuni), masina.Pret, datesString);
                                        }
                                        DateTime.TryParse(data_inchiriere, out DateTime di);
                                        if (d.Equals(null))
                                        {
                                            var allDates = masina.date.Values.SelectMany(dates => dates).ToList();


                                            var allDatesAsString = allDates.ConvertAll(date => date.ToString("yyyy-MM-dd"));


                                            string datesString = string.Join(", ", allDatesAsString);


                                            dataGridViewMasini.Rows.Add(masina.Id, masina.Model, masina.CuloareMasina, string.Join(", ", optiuni), masina.Pret, datesString);
                                        }
                                    }


                                
                            }
                            else
                            {
                                dataGridViewMasini.Rows.Add(masina.Id, masina.Model, masina.CuloareMasina, string.Join(", ", optiuni), masina.Pret, masina.date);
                            }
                            
                        }
                    }
                   
                    grupBoxMasina.Visible = false;
                }
                else
                {
                    labelMesajEroare4.Text = "Nu ati selectat clientul ";
                    labelMesajEroare4.Visible = true;
                    return;
                 
                }
                
            }
            else
            {
                GetMasinaData();
                return;
            }
            
            
            labelMesajEroare3.Visible = false;
            labelMesajEroare4.Visible= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBoxMasiniDisponibile.Checked)
            {
                if (dataGridViewClienti.SelectedRows.Count == 1)
                {
                    if (dataGridViewMasini.SelectedRows.Count ==1)
                    {
                        string data_inchiriere = dataGridViewClienti.SelectedRows[0].Cells[4].Value.ToString();
                        DateTime.TryParse(data_inchiriere, out DateTime di);
                       
                        string data_returnare = dataGridViewClienti.SelectedRows[0].Cells[5].Value.ToString();
                        DateTime.TryParse(data_returnare, out DateTime dr);
                        List<DateTime> lista = new List<DateTime>();
                        lista.Add(di);
                        lista.Add(dr);
                        string masinaId = dataGridViewMasini.SelectedRows[0].Cells[0].Value.ToString();
                        string clientID=dataGridViewClienti.SelectedRows[0].Cells[0].Value.ToString();
                        foreach (Masina m in masini)
                        {
                            
                            if (m.Id == masinaId)
                            {
                            if(m.date==null)
                            { m.date=new Dictionary<string, List<DateTime>>(); 
                                }
                                m.date.Add(clientID,lista);
                                Masina.WriteToFile(masini, "masini.json");
                   
                                foreach(Firma f in firma)
                                {
                                    if (firma_.Id == f.Id)
                                        f.AdaugaClient(clientID);
                                }
                                Firma.WriteToFile(firma, "firma.json");
                                masini = Masina.ReadFromFile( "masini.json");
                                
                                GetMasinaData();
                                break;
                                
                               
                            }
                        }

                    }
                    else
                    {
                        labelMesajEroare3.Text = "Nu ati selectat masina pe care doriti sa o inchiriati ";
                        labelMesajEroare3.Visible = true;
                        return;
                    }
                }
                else
                {
                    labelMesajEroare4.Text = "Nu ati selectat clientul care doreste sa inchirieze ";
                    labelMesajEroare4.Visible = true;
                    return;
                }
            }
            else
            {
                labelMesajEroare3.Text = "Nu ati apasat butonul care afiseaza masinile disponibile ";
                labelMesajEroare4.Visible = true;
                labelMesajEroare3.Text = "Nu ati apasat butonul care afiseaza masinile disponibile ";
                labelMesajEroare4.Visible = true;
                return ;
            }
            labelMesajEroare3.Visible = false;
            labelMesajEroare4.Visible = false;
            checkBoxMasiniDisponibile.Checked = false;
            GetMasinaData();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxMasiniInchiriate.Checked)
            {
                dataGridViewMasini.Rows.Clear();
                dataGridViewMasini.Columns.Clear();
                dataGridViewMasini.Visible = true;

                dataGridViewMasini.Columns.Add("Model", "Model");
                dataGridViewMasini.Columns.Add("Client", "Client");
                dataGridViewMasini.Columns.Add("Pret", "Pret");
                dataGridViewMasini.Columns.Add("Date ocupate", "Date");


                if (masini == null)
                {
                    return;
                }

                // Add data to DataGridView
                foreach (var masina in masini)
                {
                    if (masina.IdFirma == idfirma)
                    {

                        if (masina.date != null)
                        {
                            var allDates = masina.date.Values.SelectMany(dates => dates).ToList();


                            var allDatesAsString = allDates.ConvertAll(date => date.ToString("yyyy-MM-dd"));


                            string datesString = string.Join(", ", allDatesAsString);
                            foreach (Client c in client)
                            {
                                if (masina.date != null)
                                {
                                    foreach (var d in masina.date)
                                    {
                                        if (c.Id == d.Key)
                                        {
                                            dataGridViewMasini.Rows.Add(masina.Model, c.Nume, masina.Pret, datesString);
                                        }
                                    }
                                }
                            }


                        }
                        break;
                    }
                }
                

                grupBoxMasina.Visible = false;
            }
            else
            {
                GetMasinaData();
                grupBoxMasina.Visible = false;
            }
          
          

        }
    }
}
