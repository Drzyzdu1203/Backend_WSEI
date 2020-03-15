using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            label1komunikat1.Text = "Witaj, " + textBoxImie.Text + " " + textBox1Nazwisko.Text;

            int wiek = Convert.ToInt32(textBox2Wiek.Text);
            if(wiek <67)
            {
                label2komunikat2.Text = string.Format(" do emerytury zostało ci {0} lat", 67 - wiek);
            }
            else
            {
                label2komunikat2.Text = "Jesteś emerytem!";
            }
               
                  
            
        }
    }
}
