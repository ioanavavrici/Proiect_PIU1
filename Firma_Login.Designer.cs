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
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxN_Firma
            // 
            this.textBoxN_Firma.Location = new System.Drawing.Point(506, 228);
            this.textBoxN_Firma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxN_Firma.Name = "textBoxN_Firma";
            this.textBoxN_Firma.Size = new System.Drawing.Size(146, 30);
            this.textBoxN_Firma.TabIndex = 2;
            // 
            // textBoxParolaFirma
            // 
            this.textBoxParolaFirma.Location = new System.Drawing.Point(506, 286);
            this.textBoxParolaFirma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxParolaFirma.Name = "textBoxParolaFirma";
            this.textBoxParolaFirma.Size = new System.Drawing.Size(148, 30);
            this.textBoxParolaFirma.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 356);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Proiect_PIU.Properties.Resources._360_F_715180795_1uPdH9Dvq6diEr6osK2MFIcuuNkxbDXJ;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(540, 362);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(112, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sign up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtMesajEroare
            // 
            this.txtMesajEroare.Location = new System.Drawing.Point(330, 433);
            this.txtMesajEroare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMesajEroare.Name = "txtMesajEroare";
            this.txtMesajEroare.Size = new System.Drawing.Size(448, 30);
            this.txtMesajEroare.TabIndex = 6;
            this.txtMesajEroare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesajEroare.TextChanged += new System.EventHandler(this.txtMesajEroare_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inregistrare firma";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Firma_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Proiect_PIU.Properties.Resources._360_F_715180795_1uPdH9Dvq6diEr6osK2MFIcuuNkxbDXJ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMesajEroare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxParolaFirma);
            this.Controls.Add(this.textBoxN_Firma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Firma_Login";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Firma_Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label3;
    }
}