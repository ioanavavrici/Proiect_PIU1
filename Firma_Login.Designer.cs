namespace Proiect_PIU
{
    partial class Firma_Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxN_Firma = new System.Windows.Forms.TextBox();
            this.textBoxParolaFirma = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMesajEroare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxN_Firma
            // 
            this.textBoxN_Firma.Location = new System.Drawing.Point(361, 98);
            this.textBoxN_Firma.Name = "textBoxN_Firma";
            this.textBoxN_Firma.Size = new System.Drawing.Size(99, 22);
            this.textBoxN_Firma.TabIndex = 2;
            // 
            // textBoxParolaFirma
            // 
            this.textBoxParolaFirma.Location = new System.Drawing.Point(361, 135);
            this.textBoxParolaFirma.Name = "textBoxParolaFirma";
            this.textBoxParolaFirma.Size = new System.Drawing.Size(100, 22);
            this.textBoxParolaFirma.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(392, 182);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMesajEroare
            // 
            this.txtMesajEroare.Location = new System.Drawing.Point(225, 227);
            this.txtMesajEroare.Name = "txtMesajEroare";
            this.txtMesajEroare.Size = new System.Drawing.Size(300, 22);
            this.txtMesajEroare.TabIndex = 6;
            this.txtMesajEroare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesajEroare.TextChanged += new System.EventHandler(this.txtMesajEroare_TextChanged);
            // 
            // Firma_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 424);
            this.Controls.Add(this.txtMesajEroare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxParolaFirma);
            this.Controls.Add(this.textBoxN_Firma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Firma_Login";
            this.Text = "Firma_Login";
            this.Load += new System.EventHandler(this.Firma_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxN_Firma;
        private System.Windows.Forms.TextBox textBoxParolaFirma;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMesajEroare;
    }
}