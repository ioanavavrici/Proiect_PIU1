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
            this.label3.Location = new System.Drawing.Point(609, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Parola";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prenume Angajat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nume angajat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtParolaAngajat
            // 
            this.txtParolaAngajat.Location = new System.Drawing.Point(713, 269);
            this.txtParolaAngajat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtParolaAngajat.Name = "txtParolaAngajat";
            this.txtParolaAngajat.Size = new System.Drawing.Size(148, 30);
            this.txtParolaAngajat.TabIndex = 13;
            this.txtParolaAngajat.TextChanged += new System.EventHandler(this.txtParolaAngajat_TextChanged);
            // 
            // txtPrenumeAngajat
            // 
            this.txtPrenumeAngajat.Location = new System.Drawing.Point(713, 196);
            this.txtPrenumeAngajat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrenumeAngajat.Name = "txtPrenumeAngajat";
            this.txtPrenumeAngajat.Size = new System.Drawing.Size(148, 30);
            this.txtPrenumeAngajat.TabIndex = 12;
            this.txtPrenumeAngajat.TextChanged += new System.EventHandler(this.txtPrenumeAngajat_TextChanged);
            // 
            // txtNumeAngajat
            // 
            this.txtNumeAngajat.Location = new System.Drawing.Point(713, 127);
            this.txtNumeAngajat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeAngajat.Name = "txtNumeAngajat";
            this.txtNumeAngajat.Size = new System.Drawing.Size(148, 30);
            this.txtNumeAngajat.TabIndex = 11;
            this.txtNumeAngajat.TextChanged += new System.EventHandler(this.txtNumeAngajat_TextChanged);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(713, 339);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(150, 47);
            this.buttonSign.TabIndex = 17;
            this.buttonSign.Text = "Sign up";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(528, 339);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(160, 47);
            this.Login.TabIndex = 18;
            this.Login.Text = "Log in";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBoxMesajEroare
            // 
            this.textBoxMesajEroare.Location = new System.Drawing.Point(479, 413);
            this.textBoxMesajEroare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMesajEroare.Name = "textBoxMesajEroare";
            this.textBoxMesajEroare.Size = new System.Drawing.Size(487, 30);
            this.textBoxMesajEroare.TabIndex = 19;
            // 
            // Angajat_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proiect_PIU.Properties.Resources._360_F_715180795_1uPdH9Dvq6diEr6osK2MFIcuuNkxbDXJ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.textBoxMesajEroare);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.buttonSign);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParolaAngajat);
            this.Controls.Add(this.txtPrenumeAngajat);
            this.Controls.Add(this.txtNumeAngajat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Angajat_Login";
            this.Text = "Angajat_Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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