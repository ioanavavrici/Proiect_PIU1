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
            this.dataGridViewAngajati.Name = "dataGridViewAngajati";
            this.dataGridViewAngajati.RowHeadersWidth = 51;
            this.dataGridViewAngajati.RowTemplate.Height = 24;
            this.dataGridViewAngajati.Size = new System.Drawing.Size(617, 218);
            this.dataGridViewAngajati.TabIndex = 0;
            // 
            // dataGridViewFirme
            // 
            this.dataGridViewFirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirme.Location = new System.Drawing.Point(666, 52);
            this.dataGridViewFirme.Name = "dataGridViewFirme";
            this.dataGridViewFirme.RowHeadersWidth = 51;
            this.dataGridViewFirme.RowTemplate.Height = 24;
            this.dataGridViewFirme.Size = new System.Drawing.Size(441, 218);
            this.dataGridViewFirme.TabIndex = 1;
            // 
            // dataGridViewMasini
            // 
            this.dataGridViewMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasini.Location = new System.Drawing.Point(12, 413);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.RowHeadersWidth = 51;
            this.dataGridViewMasini.RowTemplate.Height = 24;
            this.dataGridViewMasini.Size = new System.Drawing.Size(617, 290);
            this.dataGridViewMasini.TabIndex = 2;
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(666, 413);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.Size = new System.Drawing.Size(441, 263);
            this.dataGridViewClienti.TabIndex = 3;
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(13, 296);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtNumeAngajat.TabIndex = 4;
            this.txtNumeAngajat.TextChanged += new System.EventHandler(this.txtNumeAngajat_TextChanged);
            // 
            // txtPrenumeAngajat
            // 
            this.txtPrenumeAngajat.Location = new System.Drawing.Point(146, 295);
            this.txtPrenumeAngajat.Name = "txtPrenumeAngajat";
            this.txtPrenumeAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtPrenumeAngajat.TabIndex = 5;
            // 
            // txtParolaAngajat
            // 
            this.txtParolaAngajat.Location = new System.Drawing.Point(282, 296);
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
            this.label2.Location = new System.Drawing.Point(146, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prenume Angajat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parola";
            // 
            // btnAddAngajat
            // 
            this.btnAddAngajat.Location = new System.Drawing.Point(389, 295);
            this.btnAddAngajat.Name = "btnAddAngajat";
            this.btnAddAngajat.Size = new System.Drawing.Size(141, 23);
            this.btnAddAngajat.TabIndex = 10;
            this.btnAddAngajat.Text = "Adauga Angajat";
            this.btnAddAngajat.UseVisualStyleBackColor = true;
            this.btnAddAngajat.Click += new System.EventHandler(this.btnAddAngajat_Click);
            // 
            // comboBoxFirma
            // 
            this.comboBoxFirma.FormattingEnabled = true;
            this.comboBoxFirma.Location = new System.Drawing.Point(28, 325);
            this.comboBoxFirma.Name = "comboBoxFirma";
            this.comboBoxFirma.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFirma.TabIndex = 11;
            this.comboBoxFirma.SelectedIndexChanged += new System.EventHandler(this.comboBoxFirma_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 625);
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
    }
}