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
    public partial class Firma_Login : Form
    {
        public List<Firma> firma = new List<Firma>();
        public Firma_Login()
        {
            InitializeComponent();
            txtMesajEroare.Visible = false;
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Firma.ReadFromFile(Path.Combine(path, "firma.json"));
           
            if (firma == null)
            {
                firma = new List<Firma>();

            }
           

        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Firma_Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numef = textBoxN_Firma.Text;
            string parolaf = textBoxParolaFirma.Text;
            firma = Firma.ReadFromFile("firma.json");
            if (firma == null)
            {
                firma = new List<Firma>();

            }
            if (parolaf.Length == 0 && numef.Length == 0)
            {

                txtMesajEroare.Text = "Nu ati introdus parola sau numele firmei";
                txtMesajEroare.Visible = true;
                return;
            }
            if (parolaf.Length < 8)
            {
                txtMesajEroare.Text = "Parola are mai putin de 8 caractere";
                txtMesajEroare.Visible = true;
                return;
            }
            foreach (Firma f in firma)
            {
                if (f.NumeFirma == numef && f.Parola==parolaf)
                {
                    Angajat_Login aplicatie = new Angajat_Login(f.Id);
                    aplicatie.Show();
                    this.Hide();

                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numef = textBoxN_Firma.Text;
            string parolaf = textBoxParolaFirma.Text;
            firma = Firma.ReadFromFile("firma.json");
            if (firma == null)
            {
                firma = new List<Firma>();

            }

            foreach (Firma f in firma)
                {
                    if (f.NumeFirma == numef)
                    {
                        txtMesajEroare.Text = "O firma cu acest nume exista deja";
                        txtMesajEroare.Visible = true;
                        return;

                    }
                    txtMesajEroare.Visible = false;
                }
                if (parolaf.Length == 0 && numef.Length == 0)
                {

                    txtMesajEroare.Text = "Nu ati introdus parola sau numele firmei";
                    txtMesajEroare.Visible = true;
                    return;
                }
                if (parolaf.Length < 8)
                {
                    txtMesajEroare.Text = "Parola are mai putin de 8 caractere";
                    txtMesajEroare.Visible = true;
                    return;
                }
                Firma firma1 = new Firma(numef, parolaf);
                firma.Add(firma1);
                Firma.WriteToFile(firma, "firma.json");
                txtMesajEroare.Visible = false;
                Angajat_Login aplicatie = new Angajat_Login(firma1.Id);
                aplicatie.Show();
            
                this.Hide();
            
        }

        private void txtMesajEroare_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
