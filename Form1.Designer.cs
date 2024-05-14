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
            this.dataGridViewMasini = new System.Windows.Forms.DataGridView();
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxCuloare = new System.Windows.Forms.ComboBox();
            this.checkedListBoxOptiuni = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBoxPret = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.grupBoxMasina = new System.Windows.Forms.GroupBox();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.buttonStergereMasina = new System.Windows.Forms.Button();
            this.buttonActualizareMasina = new System.Windows.Forms.Button();
            this.buttonStergeClient = new System.Windows.Forms.Button();
            this.buttonActualizareClient = new System.Windows.Forms.Button();
            this.buttonAddMasina = new System.Windows.Forms.Button();
            this.Add_Client = new System.Windows.Forms.Button();
            this.labelMesajEroare1 = new System.Windows.Forms.Label();
            this.labelMesajEroare2 = new System.Windows.Forms.Label();
            this.labelMesajEroare3 = new System.Windows.Forms.Label();
            this.labelMesajEroare4 = new System.Windows.Forms.Label();
            this.buttonActualizareDateM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.grupBoxMasina.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMasini
            // 
            this.dataGridViewMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasini.Location = new System.Drawing.Point(44, 133);
            this.dataGridViewMasini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewMasini.RowHeadersWidth = 51;
            this.dataGridViewMasini.RowTemplate.Height = 24;
            this.dataGridViewMasini.Size = new System.Drawing.Size(617, 300);
            this.dataGridViewMasini.TabIndex = 2;
            this.dataGridViewMasini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMasini_CellContentClick);
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(738, 133);
            this.dataGridViewClienti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.Size = new System.Drawing.Size(617, 300);
            this.dataGridViewClienti.TabIndex = 3;
            this.dataGridViewClienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClienti_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tabel masini";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tabel Clienti";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 20);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nume client";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 18);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Prenume client";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 74);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "CNP";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 72);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Parola";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBoxNum_Client
            // 
            this.textBoxNum_Client.Location = new System.Drawing.Point(32, 43);
            this.textBoxNum_Client.Name = "textBoxNum_Client";
            this.textBoxNum_Client.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxNum_Client.Size = new System.Drawing.Size(226, 22);
            this.textBoxNum_Client.TabIndex = 24;
            this.textBoxNum_Client.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPrenume_Client
            // 
            this.textBoxPrenume_Client.Location = new System.Drawing.Point(367, 43);
            this.textBoxPrenume_Client.Name = "textBoxPrenume_Client";
            this.textBoxPrenume_Client.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPrenume_Client.Size = new System.Drawing.Size(226, 22);
            this.textBoxPrenume_Client.TabIndex = 25;
            this.textBoxPrenume_Client.TextChanged += new System.EventHandler(this.textBoxPrenume_Client_TextChanged);
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(32, 91);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCNP.Size = new System.Drawing.Size(226, 22);
            this.textBoxCNP.TabIndex = 26;
            this.textBoxCNP.TextChanged += new System.EventHandler(this.textBoxCNP_TextChanged);
            // 
            // textBoxParolaC
            // 
            this.textBoxParolaC.Location = new System.Drawing.Point(367, 91);
            this.textBoxParolaC.Name = "textBoxParolaC";
            this.textBoxParolaC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxParolaC.Size = new System.Drawing.Size(226, 22);
            this.textBoxParolaC.TabIndex = 27;
            this.textBoxParolaC.TextChanged += new System.EventHandler(this.textBoxParolaC_TextChanged);
            // 
            // buttonAdaugaClient
            // 
            this.buttonAdaugaClient.Location = new System.Drawing.Point(367, 154);
            this.buttonAdaugaClient.Name = "buttonAdaugaClient";
            this.buttonAdaugaClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonAdaugaClient.Size = new System.Drawing.Size(226, 30);
            this.buttonAdaugaClient.TabIndex = 28;
            this.buttonAdaugaClient.Text = "Adauga Client";
            this.buttonAdaugaClient.UseVisualStyleBackColor = true;
            this.buttonAdaugaClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 18);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Model";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 142);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(101, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Culoare Masina";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(310, 20);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Optiuni Masina";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(19, 45);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxModel.Size = new System.Drawing.Size(252, 22);
            this.textBoxModel.TabIndex = 34;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // comboBoxCuloare
            // 
            this.comboBoxCuloare.FormattingEnabled = true;
            this.comboBoxCuloare.Location = new System.Drawing.Point(21, 173);
            this.comboBoxCuloare.Name = "comboBoxCuloare";
            this.comboBoxCuloare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCuloare.Size = new System.Drawing.Size(252, 24);
            this.comboBoxCuloare.TabIndex = 35;
            this.comboBoxCuloare.SelectedIndexChanged += new System.EventHandler(this.comboBoxCuloare_SelectedIndexChanged);
            // 
            // checkedListBoxOptiuni
            // 
            this.checkedListBoxOptiuni.FormattingEnabled = true;
            this.checkedListBoxOptiuni.Location = new System.Drawing.Point(313, 45);
            this.checkedListBoxOptiuni.Name = "checkedListBoxOptiuni";
            this.checkedListBoxOptiuni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBoxOptiuni.Size = new System.Drawing.Size(279, 106);
            this.checkedListBoxOptiuni.TabIndex = 36;
            this.checkedListBoxOptiuni.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 164);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(279, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Adauga Masina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 74);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label18.Size = new System.Drawing.Size(31, 16);
            this.label18.TabIndex = 41;
            this.label18.Text = "Pret";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtBoxPret
            // 
            this.txtBoxPret.Location = new System.Drawing.Point(21, 101);
            this.txtBoxPret.Name = "txtBoxPret";
            this.txtBoxPret.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxPret.Size = new System.Drawing.Size(250, 22);
            this.txtBoxPret.TabIndex = 42;
            this.txtBoxPret.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 142);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(39, 16);
            this.label20.TabIndex = 46;
            this.label20.Text = "Data ";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // grupBoxMasina
            // 
            this.grupBoxMasina.Controls.Add(this.buttonActualizareDateM);
            this.grupBoxMasina.Controls.Add(this.txtBoxPret);
            this.grupBoxMasina.Controls.Add(this.textBoxModel);
            this.grupBoxMasina.Controls.Add(this.label13);
            this.grupBoxMasina.Controls.Add(this.label18);
            this.grupBoxMasina.Controls.Add(this.label14);
            this.grupBoxMasina.Controls.Add(this.label15);
            this.grupBoxMasina.Controls.Add(this.checkedListBoxOptiuni);
            this.grupBoxMasina.Controls.Add(this.comboBoxCuloare);
            this.grupBoxMasina.Controls.Add(this.button1);
            this.grupBoxMasina.Location = new System.Drawing.Point(44, 454);
            this.grupBoxMasina.Name = "grupBoxMasina";
            this.grupBoxMasina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grupBoxMasina.Size = new System.Drawing.Size(617, 223);
            this.grupBoxMasina.TabIndex = 47;
            this.grupBoxMasina.TabStop = false;
            this.grupBoxMasina.Enter += new System.EventHandler(this.grupBoxMasina_Enter);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.label9);
            this.groupBoxClient.Controls.Add(this.label10);
            this.groupBoxClient.Controls.Add(this.label11);
            this.groupBoxClient.Controls.Add(this.label20);
            this.groupBoxClient.Controls.Add(this.label12);
            this.groupBoxClient.Controls.Add(this.dateTimePicker1);
            this.groupBoxClient.Controls.Add(this.textBoxNum_Client);
            this.groupBoxClient.Controls.Add(this.buttonAdaugaClient);
            this.groupBoxClient.Controls.Add(this.textBoxPrenume_Client);
            this.groupBoxClient.Controls.Add(this.textBoxParolaC);
            this.groupBoxClient.Controls.Add(this.textBoxCNP);
            this.groupBoxClient.Location = new System.Drawing.Point(737, 454);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxClient.Size = new System.Drawing.Size(618, 209);
            this.groupBoxClient.TabIndex = 48;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Enter += new System.EventHandler(this.groupBoxClient_Enter);
            // 
            // buttonStergereMasina
            // 
            this.buttonStergereMasina.Location = new System.Drawing.Point(257, 47);
            this.buttonStergereMasina.Name = "buttonStergereMasina";
            this.buttonStergereMasina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStergereMasina.Size = new System.Drawing.Size(192, 33);
            this.buttonStergereMasina.TabIndex = 49;
            this.buttonStergereMasina.Text = "Sterge Masina";
            this.buttonStergereMasina.UseVisualStyleBackColor = true;
            this.buttonStergereMasina.Click += new System.EventHandler(this.buttonStergereMasina_Click);
            // 
            // buttonActualizareMasina
            // 
            this.buttonActualizareMasina.Location = new System.Drawing.Point(469, 47);
            this.buttonActualizareMasina.Name = "buttonActualizareMasina";
            this.buttonActualizareMasina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonActualizareMasina.Size = new System.Drawing.Size(192, 33);
            this.buttonActualizareMasina.TabIndex = 50;
            this.buttonActualizareMasina.Text = "Actualizare Date Masina";
            this.buttonActualizareMasina.UseVisualStyleBackColor = true;
            this.buttonActualizareMasina.Click += new System.EventHandler(this.buttonActualizareMasina_Click);
            // 
            // buttonStergeClient
            // 
            this.buttonStergeClient.Location = new System.Drawing.Point(950, 47);
            this.buttonStergeClient.Name = "buttonStergeClient";
            this.buttonStergeClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStergeClient.Size = new System.Drawing.Size(192, 30);
            this.buttonStergeClient.TabIndex = 52;
            this.buttonStergeClient.Text = "Sterge Client";
            this.buttonStergeClient.UseVisualStyleBackColor = true;
            this.buttonStergeClient.Click += new System.EventHandler(this.buttonStergeClient_Click);
            // 
            // buttonActualizareClient
            // 
            this.buttonActualizareClient.Location = new System.Drawing.Point(1160, 47);
            this.buttonActualizareClient.Name = "buttonActualizareClient";
            this.buttonActualizareClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonActualizareClient.Size = new System.Drawing.Size(192, 30);
            this.buttonActualizareClient.TabIndex = 53;
            this.buttonActualizareClient.Text = "Actualizare Date Client";
            this.buttonActualizareClient.UseVisualStyleBackColor = true;
            this.buttonActualizareClient.Click += new System.EventHandler(this.buttonActualizareClient_Click);
            // 
            // buttonAddMasina
            // 
            this.buttonAddMasina.Location = new System.Drawing.Point(44, 47);
            this.buttonAddMasina.Name = "buttonAddMasina";
            this.buttonAddMasina.Size = new System.Drawing.Size(192, 30);
            this.buttonAddMasina.TabIndex = 55;
            this.buttonAddMasina.Text = "Adauga Masina";
            this.buttonAddMasina.UseVisualStyleBackColor = true;
            this.buttonAddMasina.Click += new System.EventHandler(this.buttonAddMasina_Click);
            // 
            // Add_Client
            // 
            this.Add_Client.Location = new System.Drawing.Point(737, 47);
            this.Add_Client.Name = "Add_Client";
            this.Add_Client.Size = new System.Drawing.Size(192, 30);
            this.Add_Client.TabIndex = 56;
            this.Add_Client.Text = "Adauga Client";
            this.Add_Client.UseVisualStyleBackColor = true;
            this.Add_Client.Click += new System.EventHandler(this.Add_Client_Click);
            // 
            // labelMesajEroare1
            // 
            this.labelMesajEroare1.AutoSize = true;
            this.labelMesajEroare1.Location = new System.Drawing.Point(62, 680);
            this.labelMesajEroare1.Name = "labelMesajEroare1";
            this.labelMesajEroare1.Size = new System.Drawing.Size(44, 16);
            this.labelMesajEroare1.TabIndex = 57;
            this.labelMesajEroare1.Text = "label1";
            // 
            // labelMesajEroare2
            // 
            this.labelMesajEroare2.AutoSize = true;
            this.labelMesajEroare2.Location = new System.Drawing.Point(766, 680);
            this.labelMesajEroare2.Name = "labelMesajEroare2";
            this.labelMesajEroare2.Size = new System.Drawing.Size(44, 16);
            this.labelMesajEroare2.TabIndex = 58;
            this.labelMesajEroare2.Text = "label2";
            // 
            // labelMesajEroare3
            // 
            this.labelMesajEroare3.AutoSize = true;
            this.labelMesajEroare3.Location = new System.Drawing.Point(44, 94);
            this.labelMesajEroare3.Name = "labelMesajEroare3";
            this.labelMesajEroare3.Size = new System.Drawing.Size(44, 16);
            this.labelMesajEroare3.TabIndex = 59;
            this.labelMesajEroare3.Text = "label1";
            // 
            // labelMesajEroare4
            // 
            this.labelMesajEroare4.AutoSize = true;
            this.labelMesajEroare4.Location = new System.Drawing.Point(737, 94);
            this.labelMesajEroare4.Name = "labelMesajEroare4";
            this.labelMesajEroare4.Size = new System.Drawing.Size(44, 16);
            this.labelMesajEroare4.TabIndex = 60;
            this.labelMesajEroare4.Text = "label2";
            // 
            // buttonActualizareDateM
            // 
            this.buttonActualizareDateM.Location = new System.Drawing.Point(313, 165);
            this.buttonActualizareDateM.Name = "buttonActualizareDateM";
            this.buttonActualizareDateM.Size = new System.Drawing.Size(279, 32);
            this.buttonActualizareDateM.TabIndex = 43;
            this.buttonActualizareDateM.Text = "Actualizeaza Datele";
            this.buttonActualizareDateM.UseVisualStyleBackColor = true;
            this.buttonActualizareDateM.Click += new System.EventHandler(this.buttonActualizareDateM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.labelMesajEroare4);
            this.Controls.Add(this.labelMesajEroare3);
            this.Controls.Add(this.labelMesajEroare2);
            this.Controls.Add(this.labelMesajEroare1);
            this.Controls.Add(this.Add_Client);
            this.Controls.Add(this.buttonAddMasina);
            this.Controls.Add(this.buttonActualizareClient);
            this.Controls.Add(this.buttonStergeClient);
            this.Controls.Add(this.buttonActualizareMasina);
            this.Controls.Add(this.buttonStergereMasina);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.grupBoxMasina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewClienti);
            this.Controls.Add(this.dataGridViewMasini);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            this.grupBoxMasina.ResumeLayout(false);
            this.grupBoxMasina.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewMasini;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxCuloare;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptiuni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBoxPret;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grupBoxMasina;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button buttonStergereMasina;
        private System.Windows.Forms.Button buttonActualizareMasina;
        private System.Windows.Forms.Button buttonStergeClient;
        private System.Windows.Forms.Button buttonActualizareClient;
        private System.Windows.Forms.Button buttonAddMasina;
        private System.Windows.Forms.Button Add_Client;
        private System.Windows.Forms.Label labelMesajEroare1;
        private System.Windows.Forms.Label labelMesajEroare2;
        private System.Windows.Forms.Label labelMesajEroare3;
        private System.Windows.Forms.Label labelMesajEroare4;
        private System.Windows.Forms.Button buttonActualizareDateM;
    }
}