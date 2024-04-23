using System;

namespace Proiect_PIU
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAngajati = new System.Windows.Forms.DataGridView();
            this.dataGridViewFirme = new System.Windows.Forms.DataGridView();
            this.dataGridViewMasini = new System.Windows.Forms.DataGridView();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.txtNumeAngajat = new System.Windows.Forms.TextBox();
            this.txtPrenumeAngajat = new System.Windows.Forms.TextBox();
            this.txtParolaAngajat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAngajat = new System.Windows.Forms.Button();
            this.comboBoxFirma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNum_Firma = new System.Windows.Forms.TextBox();
            this.buttonAdaugare_Firma = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNum_Client = new System.Windows.Forms.TextBox();
            this.textBoxPrenume_Client = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxParolaC = new System.Windows.Forms.TextBox();
            this.buttonAdaugaClient = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxCuloare = new System.Windows.Forms.ComboBox();
            this.checkedListBoxOptiuni = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxFirma_M = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngajati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAngajati
            // 
            this.dataGridViewAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAngajati.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewAngajati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAngajati.Name = "dataGridViewAngajati";
            this.dataGridViewAngajati.RowHeadersWidth = 51;
            this.dataGridViewAngajati.RowTemplate.Height = 24;
            this.dataGridViewAngajati.Size = new System.Drawing.Size(617, 218);
            this.dataGridViewAngajati.TabIndex = 0;
            this.dataGridViewAngajati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAngajati_CellContentClick);
            // 
            // dataGridViewFirme
            // 
            this.dataGridViewFirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirme.Location = new System.Drawing.Point(667, 52);
            this.dataGridViewFirme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewFirme.Name = "dataGridViewFirme";
            this.dataGridViewFirme.RowHeadersWidth = 51;
            this.dataGridViewFirme.RowTemplate.Height = 24;
            this.dataGridViewFirme.Size = new System.Drawing.Size(480, 218);
            this.dataGridViewFirme.TabIndex = 1;
            // 
            // dataGridViewMasini
            // 
            this.dataGridViewMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasini.Location = new System.Drawing.Point(12, 387);
            this.dataGridViewMasini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.RowHeadersWidth = 51;
            this.dataGridViewMasini.RowTemplate.Height = 24;
            this.dataGridViewMasini.Size = new System.Drawing.Size(617, 290);
            this.dataGridViewMasini.TabIndex = 2;
            this.dataGridViewMasini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMasini_CellContentClick);
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(670, 387);
            this.dataGridViewClienti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.Size = new System.Drawing.Size(477, 300);
            this.dataGridViewClienti.TabIndex = 3;
            this.dataGridViewClienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClienti_CellContentClick);
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(13, 295);
            this.txtNumeAngajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtNumeAngajat.TabIndex = 4;
            this.txtNumeAngajat.TextChanged += new System.EventHandler(this.txtNumeAngajat_TextChanged);
            // 
            // txtPrenumeAngajat
            // 
            this.txtPrenumeAngajat.Location = new System.Drawing.Point(147, 295);
            this.txtPrenumeAngajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenumeAngajat.Name = "txtPrenumeAngajat";
            this.txtPrenumeAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtPrenumeAngajat.TabIndex = 5;
            // 
            // txtParolaAngajat
            // 
            this.txtParolaAngajat.Location = new System.Drawing.Point(283, 295);
            this.txtParolaAngajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParolaAngajat.Name = "txtParolaAngajat";
            this.txtParolaAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtParolaAngajat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume angajat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume Angajat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parola";
            // 
            // btnAddAngajat
            // 
            this.btnAddAngajat.Location = new System.Drawing.Point(389, 295);
            this.btnAddAngajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAngajat.Name = "btnAddAngajat";
            this.btnAddAngajat.Size = new System.Drawing.Size(141, 43);
            this.btnAddAngajat.TabIndex = 10;
            this.btnAddAngajat.Text = "Adauga Angajat";
            this.btnAddAngajat.UseVisualStyleBackColor = true;
            this.btnAddAngajat.Click += new System.EventHandler(this.btnAddAngajat_Click);
            // 
            // comboBoxFirma
            // 
            this.comboBoxFirma.FormattingEnabled = true;
            this.comboBoxFirma.Location = new System.Drawing.Point(12, 343);
            this.comboBoxFirma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxFirma.Name = "comboBoxFirma";
            this.comboBoxFirma.Size = new System.Drawing.Size(233, 24);
            this.comboBoxFirma.TabIndex = 11;
            this.comboBoxFirma.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirma_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tabel angajati";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tabel firme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 369);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tabel masini";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tabel Clienti";
            // 
            // textBoxNum_Firma
            // 
            this.textBoxNum_Firma.Location = new System.Drawing.Point(667, 294);
            this.textBoxNum_Firma.Name = "textBoxNum_Firma";
            this.textBoxNum_Firma.Size = new System.Drawing.Size(136, 22);
            this.textBoxNum_Firma.TabIndex = 16;
            // 
            // buttonAdaugare_Firma
            // 
            this.buttonAdaugare_Firma.Location = new System.Drawing.Point(858, 294);
            this.buttonAdaugare_Firma.Name = "buttonAdaugare_Firma";
            this.buttonAdaugare_Firma.Size = new System.Drawing.Size(119, 44);
            this.buttonAdaugare_Firma.TabIndex = 18;
            this.buttonAdaugare_Firma.Text = "Adauga firma";
            this.buttonAdaugare_Firma.UseVisualStyleBackColor = true;
            this.buttonAdaugare_Firma.Click += new System.EventHandler(this.buttonAdaugare_Firma_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nume firma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(671, 689);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nume client";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(790, 689);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Prenume client";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(667, 737);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "CNP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(790, 737);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Parola";
            // 
            // textBoxNum_Client
            // 
            this.textBoxNum_Client.Location = new System.Drawing.Point(667, 708);
            this.textBoxNum_Client.Name = "textBoxNum_Client";
            this.textBoxNum_Client.Size = new System.Drawing.Size(100, 22);
            this.textBoxNum_Client.TabIndex = 24;
            this.textBoxNum_Client.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPrenume_Client
            // 
            this.textBoxPrenume_Client.Location = new System.Drawing.Point(793, 708);
            this.textBoxPrenume_Client.Name = "textBoxPrenume_Client";
            this.textBoxPrenume_Client.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrenume_Client.TabIndex = 25;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(667, 756);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(100, 22);
            this.textBoxCNP.TabIndex = 26;
            this.textBoxCNP.TextChanged += new System.EventHandler(this.textBoxCNP_TextChanged);
            // 
            // textBoxParolaC
            // 
            this.textBoxParolaC.Location = new System.Drawing.Point(793, 756);
            this.textBoxParolaC.Name = "textBoxParolaC";
            this.textBoxParolaC.Size = new System.Drawing.Size(100, 22);
            this.textBoxParolaC.TabIndex = 27;
            // 
            // buttonAdaugaClient
            // 
            this.buttonAdaugaClient.Location = new System.Drawing.Point(928, 730);
            this.buttonAdaugaClient.Name = "buttonAdaugaClient";
            this.buttonAdaugaClient.Size = new System.Drawing.Size(126, 30);
            this.buttonAdaugaClient.TabIndex = 28;
            this.buttonAdaugaClient.Text = "Adauga ";
            this.buttonAdaugaClient.UseVisualStyleBackColor = true;
            this.buttonAdaugaClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 689);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Model";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(156, 689);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Culoare Masina";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(334, 689);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Optiuni Masina";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 322);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "Firme";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(12, 708);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(126, 22);
            this.textBoxModel.TabIndex = 34;
            // 
            // comboBoxCuloare
            // 
            this.comboBoxCuloare.FormattingEnabled = true;
            this.comboBoxCuloare.Location = new System.Drawing.Point(159, 708);
            this.comboBoxCuloare.Name = "comboBoxCuloare";
            this.comboBoxCuloare.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCuloare.TabIndex = 35;
            this.comboBoxCuloare.SelectedIndexChanged += new System.EventHandler(this.comboBoxCuloare_SelectedIndexChanged);
            // 
            // checkedListBoxOptiuni
            // 
            this.checkedListBoxOptiuni.FormattingEnabled = true;
            this.checkedListBoxOptiuni.Location = new System.Drawing.Point(337, 708);
            this.checkedListBoxOptiuni.Name = "checkedListBoxOptiuni";
            this.checkedListBoxOptiuni.Size = new System.Drawing.Size(167, 89);
            this.checkedListBoxOptiuni.TabIndex = 36;
            this.checkedListBoxOptiuni.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 771);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 35);
            this.button1.TabIndex = 37;
            this.button1.Text = "Adauga Masina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxFirma_M
            // 
            this.comboBoxFirma_M.FormattingEnabled = true;
            this.comboBoxFirma_M.Location = new System.Drawing.Point(12, 741);
            this.comboBoxFirma_M.Name = "comboBoxFirma_M";
            this.comboBoxFirma_M.Size = new System.Drawing.Size(268, 24);
            this.comboBoxFirma_M.TabIndex = 38;
            this.comboBoxFirma_M.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirma_M_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 859);
            this.Controls.Add(this.comboBoxFirma_M);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxOptiuni);
            this.Controls.Add(this.comboBoxCuloare);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonAdaugaClient);
            this.Controls.Add(this.textBoxParolaC);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxPrenume_Client);
            this.Controls.Add(this.textBoxNum_Client);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAdaugare_Firma);
            this.Controls.Add(this.textBoxNum_Firma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxFirma);
            this.Controls.Add(this.btnAddAngajat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParolaAngajat);
            this.Controls.Add(this.txtPrenumeAngajat);
            this.Controls.Add(this.txtNumeAngajat);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.dataGridViewMasini);
            this.Controls.Add(this.dataGridViewFirme);
            this.Controls.Add(this.dataGridViewAngajati);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngajati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAngajati;
        private System.Windows.Forms.DataGridView dataGridViewFirme;
        private System.Windows.Forms.DataGridView dataGridViewMasini;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.TextBox txtNumeAngajat;
        private System.Windows.Forms.TextBox txtPrenumeAngajat;
        private System.Windows.Forms.TextBox txtParolaAngajat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAngajat;
        private System.Windows.Forms.ComboBox comboBoxFirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNum_Firma;
        private System.Windows.Forms.Button buttonAdaugare_Firma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNum_Client;
        private System.Windows.Forms.TextBox textBoxPrenume_Client;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.TextBox textBoxParolaC;
        private System.Windows.Forms.Button buttonAdaugaClient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxCuloare;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptiuni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxFirma_M;
    }
}