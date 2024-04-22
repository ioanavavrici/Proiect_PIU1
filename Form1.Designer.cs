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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAngajati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAngajati
            // 
            this.dataGridViewAngajati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAngajati.Location = new System.Drawing.Point(9, 42);
            this.dataGridViewAngajati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAngajati.Name = "dataGridViewAngajati";
            this.dataGridViewAngajati.RowHeadersWidth = 51;
            this.dataGridViewAngajati.RowTemplate.Height = 24;
            this.dataGridViewAngajati.Size = new System.Drawing.Size(463, 177);
            this.dataGridViewAngajati.TabIndex = 0;
            // 
            // dataGridViewFirme
            // 
            this.dataGridViewFirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirme.Location = new System.Drawing.Point(500, 42);
            this.dataGridViewFirme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFirme.Name = "dataGridViewFirme";
            this.dataGridViewFirme.RowHeadersWidth = 51;
            this.dataGridViewFirme.RowTemplate.Height = 24;
            this.dataGridViewFirme.Size = new System.Drawing.Size(331, 177);
            this.dataGridViewFirme.TabIndex = 1;
            // 
            // dataGridViewMasini
            // 
            this.dataGridViewMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasini.Location = new System.Drawing.Point(9, 336);
            this.dataGridViewMasini.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.RowHeadersWidth = 51;
            this.dataGridViewMasini.RowTemplate.Height = 24;
            this.dataGridViewMasini.Size = new System.Drawing.Size(463, 236);
            this.dataGridViewMasini.TabIndex = 2;
            this.dataGridViewMasini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMasini_CellContentClick);
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(500, 336);
            this.dataGridViewClienti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.Size = new System.Drawing.Size(331, 236);
            this.dataGridViewClienti.TabIndex = 3;
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(10, 240);
            this.txtNumeAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(76, 20);
            this.txtNumeAngajat.TabIndex = 4;
            this.txtNumeAngajat.TextChanged += new System.EventHandler(this.txtNumeAngajat_TextChanged);
            // 
            // txtPrenumeAngajat
            // 
            this.txtPrenumeAngajat.Location = new System.Drawing.Point(110, 240);
            this.txtPrenumeAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrenumeAngajat.Name = "txtPrenumeAngajat";
            this.txtPrenumeAngajat.Size = new System.Drawing.Size(76, 20);
            this.txtPrenumeAngajat.TabIndex = 5;
            // 
            // txtParolaAngajat
            // 
            this.txtParolaAngajat.Location = new System.Drawing.Point(212, 240);
            this.txtParolaAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParolaAngajat.Name = "txtParolaAngajat";
            this.txtParolaAngajat.Size = new System.Drawing.Size(76, 20);
            this.txtParolaAngajat.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nume angajat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume Angajat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parola";
            // 
            // btnAddAngajat
            // 
            this.btnAddAngajat.Location = new System.Drawing.Point(292, 240);
            this.btnAddAngajat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAngajat.Name = "btnAddAngajat";
            this.btnAddAngajat.Size = new System.Drawing.Size(106, 19);
            this.btnAddAngajat.TabIndex = 10;
            this.btnAddAngajat.Text = "Adauga Angajat";
            this.btnAddAngajat.UseVisualStyleBackColor = true;
            this.btnAddAngajat.Click += new System.EventHandler(this.btnAddAngajat_Click);
            // 
            // comboBoxFirma
            // 
            this.comboBoxFirma.FormattingEnabled = true;
            this.comboBoxFirma.Location = new System.Drawing.Point(10, 264);
            this.comboBoxFirma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxFirma.Name = "comboBoxFirma";
            this.comboBoxFirma.Size = new System.Drawing.Size(176, 21);
            this.comboBoxFirma.TabIndex = 11;
            this.comboBoxFirma.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirma_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tabel angajati";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tabel firme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tabel masini";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tabel Clienti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 601);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}