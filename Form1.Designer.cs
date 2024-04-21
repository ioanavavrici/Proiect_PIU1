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
            this.dataGridViewMasini.Location = new System.Drawing.Point(12, 296);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.RowHeadersWidth = 51;
            this.dataGridViewMasini.RowTemplate.Height = 24;
            this.dataGridViewMasini.Size = new System.Drawing.Size(617, 290);
            this.dataGridViewMasini.TabIndex = 2;
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(666, 296);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowHeadersWidth = 51;
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.Size = new System.Drawing.Size(441, 263);
            this.dataGridViewClienti.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 625);
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

        }

       

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAngajati;
        private System.Windows.Forms.DataGridView dataGridViewFirme;
        private System.Windows.Forms.DataGridView dataGridViewMasini;
        private System.Windows.Forms.DataGridView dataGridViewClienti;
    }
}