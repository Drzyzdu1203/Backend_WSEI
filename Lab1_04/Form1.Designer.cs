namespace Lab1_04
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1Imie = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label1Nazwisko = new System.Windows.Forms.Label();
            this.textBox1Nazwisko = new System.Windows.Forms.TextBox();
            this.label2Wiek = new System.Windows.Forms.Label();
            this.textBox2Wiek = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.label1komunikat1 = new System.Windows.Forms.Label();
            this.label2komunikat2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1Imie
            // 
            this.label1Imie.AutoSize = true;
            this.label1Imie.Location = new System.Drawing.Point(13, 13);
            this.label1Imie.Name = "label1Imie";
            this.label1Imie.Size = new System.Drawing.Size(26, 13);
            this.label1Imie.TabIndex = 0;
            this.label1Imie.Text = "Imie";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(16, 30);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 1;
            // 
            // label1Nazwisko
            // 
            this.label1Nazwisko.AutoSize = true;
            this.label1Nazwisko.Location = new System.Drawing.Point(13, 57);
            this.label1Nazwisko.Name = "label1Nazwisko";
            this.label1Nazwisko.Size = new System.Drawing.Size(53, 13);
            this.label1Nazwisko.TabIndex = 2;
            this.label1Nazwisko.Text = "Nazwisko";
            // 
            // textBox1Nazwisko
            // 
            this.textBox1Nazwisko.Location = new System.Drawing.Point(16, 73);
            this.textBox1Nazwisko.Name = "textBox1Nazwisko";
            this.textBox1Nazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBox1Nazwisko.TabIndex = 3;
            // 
            // label2Wiek
            // 
            this.label2Wiek.AutoSize = true;
            this.label2Wiek.Location = new System.Drawing.Point(13, 114);
            this.label2Wiek.Name = "label2Wiek";
            this.label2Wiek.Size = new System.Drawing.Size(32, 13);
            this.label2Wiek.TabIndex = 4;
            this.label2Wiek.Text = "Wiek";
            // 
            // textBox2Wiek
            // 
            this.textBox2Wiek.Location = new System.Drawing.Point(16, 130);
            this.textBox2Wiek.Name = "textBox2Wiek";
            this.textBox2Wiek.Size = new System.Drawing.Size(100, 20);
            this.textBox2Wiek.TabIndex = 5;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(16, 203);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "Ok";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // label1komunikat1
            // 
            this.label1komunikat1.AutoSize = true;
            this.label1komunikat1.Location = new System.Drawing.Point(55, 272);
            this.label1komunikat1.Name = "label1komunikat1";
            this.label1komunikat1.Size = new System.Drawing.Size(66, 13);
            this.label1komunikat1.TabIndex = 7;
            this.label1komunikat1.Text = "Komunikat 1";
            // 
            // label2komunikat2
            // 
            this.label2komunikat2.AutoSize = true;
            this.label2komunikat2.Location = new System.Drawing.Point(54, 289);
            this.label2komunikat2.Name = "label2komunikat2";
            this.label2komunikat2.Size = new System.Drawing.Size(66, 13);
            this.label2komunikat2.TabIndex = 8;
            this.label2komunikat2.Text = "Komunikat 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2komunikat2);
            this.Controls.Add(this.label1komunikat1);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.textBox2Wiek);
            this.Controls.Add(this.label2Wiek);
            this.Controls.Add(this.textBox1Nazwisko);
            this.Controls.Add(this.label1Nazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label1Imie);
            this.Name = "Form1";
            this.Text = "Aplikacja Witaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Imie;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label1Nazwisko;
        private System.Windows.Forms.TextBox textBox1Nazwisko;
        private System.Windows.Forms.Label label2Wiek;
        private System.Windows.Forms.TextBox textBox2Wiek;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label label1komunikat1;
        private System.Windows.Forms.Label label2komunikat2;
    }
}

