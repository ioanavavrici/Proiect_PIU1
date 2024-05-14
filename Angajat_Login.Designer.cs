namespace Proiect_PIU
{
    partial class Angajat_Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParolaAngajat = new System.Windows.Forms.TextBox();
            this.txtPrenumeAngajat = new System.Windows.Forms.TextBox();
            this.txtNumeAngajat = new System.Windows.Forms.TextBox();
            this.buttonSign = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.textBoxMesajEroare = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Parola";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prenume Angajat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nume angajat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtParolaAngajat
            // 
            this.txtParolaAngajat.Location = new System.Drawing.Point(376, 167);
            this.txtParolaAngajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParolaAngajat.Name = "txtParolaAngajat";
            this.txtParolaAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtParolaAngajat.TabIndex = 13;
            this.txtParolaAngajat.TextChanged += new System.EventHandler(this.txtParolaAngajat_TextChanged);
            // 
            // txtPrenumeAngajat
            // 
            this.txtPrenumeAngajat.Location = new System.Drawing.Point(376, 120);
            this.txtPrenumeAngajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrenumeAngajat.Name = "txtPrenumeAngajat";
            this.txtPrenumeAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtPrenumeAngajat.TabIndex = 12;
            this.txtPrenumeAngajat.TextChanged += new System.EventHandler(this.txtPrenumeAngajat_TextChanged);
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(376, 76);
            this.txtNumeAngajat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(100, 22);
            this.txtNumeAngajat.TabIndex = 11;
            this.txtNumeAngajat.TextChanged += new System.EventHandler(this.txtNumeAngajat_TextChanged);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(376, 212);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(100, 30);
            this.buttonSign.TabIndex = 17;
            this.buttonSign.Text = "Sign up";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(246, 212);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(107, 30);
            this.Login.TabIndex = 18;
            this.Login.Text = "Log in";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBoxMesajEroare
            // 
            this.textBoxMesajEroare.Location = new System.Drawing.Point(220, 259);
            this.textBoxMesajEroare.Name = "textBoxMesajEroare";
            this.textBoxMesajEroare.Size = new System.Drawing.Size(283, 22);
            this.textBoxMesajEroare.TabIndex = 19;
            // 
            // Angajat_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMesajEroare);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParolaAngajat);
            this.Controls.Add(this.txtPrenumeAngajat);
            this.Controls.Add(this.txtNumeAngajat);
            this.Name = "Angajat_Login";
            this.Text = "Angajat_Login";
            this.Load += new System.EventHandler(this.Angajat_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParolaAngajat;
        private System.Windows.Forms.TextBox txtPrenumeAngajat;
        private System.Windows.Forms.TextBox txtNumeAngajat;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox textBoxMesajEroare;
    }
}